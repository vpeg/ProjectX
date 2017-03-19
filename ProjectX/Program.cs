using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectX
{
    class Program
    {
        static void Main(string[] args)
        {
            AdminMenu am = new AdminMenu();
            //am.Start();

            BaseMenu bm = new BaseMenu();
            //bm.Start();

            UserMenu um = new UserMenu();

            do
            {
                try
                {
                    um.Start();

                    switch (um.GetChoice())
                    {
                        case 1:
                            Console.WriteLine("Тестирование:");
                            Console.WriteLine();
                            break;

                        case 2:
                            Console.WriteLine("Результаты тестирования:");
                            Console.WriteLine();
                            break;

                        case 3:
                            Console.WriteLine("Лучшие результаты:");
                            Console.WriteLine();
                            break;

                        case 4:
                            Console.WriteLine("Выход из системы...");
                            Console.WriteLine();
                            break;

                        default:
                            throw new Exception("Ошибка! Недопустимый вариант выбора");
                    }
                }

                catch (Exception err)
                {
                    Console.WriteLine(err.Message);
                }
            } while (um.AllowContinue());

            um.Finish();
        }
    }
 
}
