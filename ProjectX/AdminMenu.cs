using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectX
{
    class AdminMenu
    {
        public void Start()
        {
            Console.Clear();
            Console.WriteLine("=======================");
            Console.WriteLine("Проект <<<Тестирование в массы!!!>>>");
            Console.WriteLine("=======================");
            Console.WriteLine("1) Добавление нового теста");
            Console.WriteLine("2) Добавление вопросов в тест");
            Console.WriteLine("3) Удаление старых вопросов");
            Console.WriteLine("4) Удаление устаревших тестов");
            Console.WriteLine("5) Выход");
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
