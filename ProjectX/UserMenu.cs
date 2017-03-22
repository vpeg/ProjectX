using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectX
{
    class UserMenu
    {
        public void Start()
        {
            Console.Title = "Экзаменационный проект: \"CISCO Tests Analyzer\"";
            Console.Clear();
            Console.WriteLine("Тестирование по курсам CISCO CCNA:");
            Console.WriteLine("======================================");
            Console.WriteLine(" 1) Приступить к тестированию         ");
            Console.WriteLine(" 2) Просмотреть результат тестирования");
            Console.WriteLine(" 3) Топ тестирования                  ");
            Console.WriteLine(" 4) Выход из системы                  ");
            Console.WriteLine("======================================");
            Console.WriteLine();
        }
        public int GetChoice()
        {
            Console.Write("Ваш выбор\n ->");
            int choice = Convert.ToInt32(Console.ReadLine());
            return choice;
        }

        public bool AllowContinue()
        {
            Console.Write("Продолжать? \nВаш выбор (y/n)\n ->");
            string s = Console.ReadLine();
            return (s == "y");
        }

        public void Finish()
        {
            Console.WriteLine("Завершение приложения...");
        }
    }
}
