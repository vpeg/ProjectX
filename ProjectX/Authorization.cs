using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Security.Cryptography;

namespace ProjectX
{
    public class Authorization
    {
        protected static int CursorPositionRow;
        protected static int CursorPositionCol;
        protected static string usr_name;
        protected static string usr_pass;
        protected static int usr_ath_result;

        string path;
        XmlNode root;
        XmlDocument doc;

        public Authorization()
        {
            path = @"..\..\accounts.xml";
            doc = new XmlDocument();
            doc.Load(path);
            root = doc.DocumentElement;
        }

        static string GetMd5Hash(MD5 md5Hash, string input)
        {

            // Преобразует входную строку в массив байтов и вычисляет хэш
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            StringBuilder sBuilder = new StringBuilder();

            // Обработка циклом каждого байта хешированных данных
            // и формирование каждого в виде шестнадцатеричной строки
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            return sBuilder.ToString();
        }

        // Сравнение хэша и строки
        static bool VerifyMd5Hash(MD5 md5Hash, string input, string hash)
        {
            // Создание StringComparer для сравнения хэшей
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;

            if (0 == comparer.Compare(input, hash))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        protected void CheckAuthorizationData(string usr_log_name, string usr_pass)
        {
            doc.Load(path);
            root = doc.DocumentElement;

            using (MD5 md5Hash = MD5.Create())
            {
                string hash = GetMd5Hash(md5Hash, usr_pass);

                foreach (XmlNode x in root.ChildNodes)
                {
                    if (usr_log_name == x.Attributes["login"].Value &&
                        x.Attributes["login"].Value == "admin" &&
                        VerifyMd5Hash(md5Hash, x.Attributes["passw"].Value, hash))
                        usr_ath_result = 1;

                    if (usr_log_name == x.Attributes["login"].Value &&
                        x.Attributes["login"].Value == "teacher" &&
                        VerifyMd5Hash(md5Hash, x.Attributes["passw"].Value, hash))
                        usr_ath_result = 2;

                    if (usr_log_name == x.Attributes["login"].Value &&
                        x.Attributes["login"].Value == "student" &&
                        VerifyMd5Hash(md5Hash, x.Attributes["passw"].Value, hash))
                        usr_ath_result = 3;
                }
            } 
        }

        protected static void WriteAt(string s, int x, int y)
        {
            try
            {
                Console.SetCursorPosition(CursorPositionCol + x, CursorPositionRow + y);
                Console.Write(s);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.Clear();
                Console.WriteLine(e.Message);
            }
        }

        public void Display()
        {
            Console.Clear();
            CursorPositionRow = Console.CursorTop;
            CursorPositionCol = Console.CursorLeft;

            WriteAt("ТРЕБУЕТСЯ АВТОРИЗАЦИЯ В СИСТЕМЕ ТЕСТИРОВАНИЯ!", 18, 8);
            WriteAt("ВВЕДИТЕ ИМЯ ПОЛЬЗОВАТЕЛЯ: ", 18, 10);
            usr_name = Console.ReadLine();

            WriteAt("ВВЕДИТЕ ПАРОЛЬ: ", 18, 12);
            usr_pass = Console.ReadLine();

            CheckAuthorizationData(usr_name, usr_pass);
        }

        public int GetUsrAuthorizationResult()
        {
            switch (usr_ath_result)
            {
                case 1:
                    return 1;

                case 2:
                    return 2;

                case 3:
                    return 3;
            }

            return -1;
        }
    }
}
