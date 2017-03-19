using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectX
{
    class BaseMenu
    {
        public void Start()
        {
            Console.Clear();
            Console.WriteLine("=======================");
            Console.WriteLine("Проект <<<Тестирование в массы!!!>>>");
            Console.WriteLine("=======================");
            Console.WriteLine("1) Авторизация");
            Console.WriteLine("2) Предварительный просмотр самых популярных вопросов");
            Console.WriteLine("3) Список кто проходил тестирование");
            Console.WriteLine("4) Информация о продукте");
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
