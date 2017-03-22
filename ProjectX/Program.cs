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
            Console.Title = "\"СИСТЕМА ТЕСТИРОВАНИЯ ПО КУРСАМ CCNA CISCO\"";
            Authorization athm = new Authorization();

            athm.Display();

            DataManager dm = new DataManager();

            switch (athm.GetUsrAuthorizationResult())
            {
                case 1:
                    AdminMenu am = new AdminMenu();
                    am.Start();

                    break;

                case 2:
                    BaseMenu bm = new BaseMenu();
                    bm.Start();

                    break;

                case 3:
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

                    break;

                 default:
                    break;
            }
        }      
    }
}
