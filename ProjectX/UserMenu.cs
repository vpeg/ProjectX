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
            Console.Clear();
            Console.WriteLine("=======================");
            Console.WriteLine("Проект <<<Тестирование в массы!!!>>>");
            Console.WriteLine("=======================");
            Console.WriteLine("1) Приступить к тестированию");
            Console.WriteLine("2) Просмотреть результат тестирования");
            Console.WriteLine("3) Топ тестирования");
            Console.WriteLine("4) Выход из системы");
            Console.WriteLine("=======================");
        }
        public int GetChoice()
        {
            Console.Write("Введите ваш выбор\n ->");
            int choice = Convert.ToInt32(Console.ReadLine());
            return choice;
        }

        public bool AllowContinue()
        {
            Console.Write("Продолжать? \nВведите ваш выбор (y/n)\n ->");
            string s = Console.ReadLine();
            return (s == "y");
        }

        public void Finish()
        {
            Console.WriteLine("До встречи на следующем запуске !!!");
        }
    }
}
