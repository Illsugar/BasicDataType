using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ваше имя");
            string name = Console.ReadLine();
            Console.WriteLine("Ваша фамилия:");
            string lastname = Console.ReadLine();
            Console.WriteLine("Ваш возраст:");
            string age = Console.ReadLine();
            Console.WriteLine("Ваш рост (см):");
            string height = Console.ReadLine();
            Console.WriteLine("Ваш вес:");
            string weight = Console.ReadLine();

            //вывод информации разные способы
            //а) склеивание
            Console.WriteLine("Привет, " + name + " " + lastname + ". Возраст: " + age + ", рост: " + height + " см, вес: " + weight + " кг");
            Console.ReadLine();

            //б) форматирование
            Console.WriteLine("Привет, {0} {1}. Возраст: {2}, рост: {3:f2} см, вес: {4:f2} кг", name, lastname, age, height, weight);
            Console.ReadLine();

            //в) вывод со знаком доллар
            Console.WriteLine($"Привет, {name} {lastname}. Возраст: {age}, рост: {height} см, вес: {weight} кг");
            Console.ReadLine();
        }
    }
}
