using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Info
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя: ");
            string name = Console.ReadLine();
            Console.WriteLine("Введите фамилию: ");
            string lastname = Console.ReadLine();
            Console.WriteLine("Введите свой город: ");
            string city = Console.ReadLine();

            //a) просто вывод данных
            Console.WriteLine($"\n\n{name} {lastname}, {city}");
            Console.ReadLine();

            //б)* вывод в чентре экрана
            //Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);
            //Console.WriteLine($"{name} {lastname}, {city}");
            //Console.ReadLine();
           
            //в)** сделать задание с использованием метода
            
            //Print(name, lastname, city); //метода

        }
        //метод вывода 
        /*private static void Print(string name, string lastname, string city)
        {
            Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);
            Console.WriteLine($"{name} {lastname}, {city}");
            Console.ReadLine();
        }*/
    }
}
