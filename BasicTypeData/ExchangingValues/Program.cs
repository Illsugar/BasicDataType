using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangingValues
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            var a = double.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            var b = double.Parse(Console.ReadLine());
            var c = a;
            a = b;
            b = c;

           /* // Задание со звёздочкой
            b = b + a;
            a = b - a;
            b = b - a;*/

            Console.WriteLine($"Первое число: {a}, второе число: {b}");
            Console.ReadLine();
        }
    }
}
