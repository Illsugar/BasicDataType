using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введеите свой рост:");
            var height = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите ваш вес:");
            var weight = double.Parse(Console.ReadLine());

            var i = weight / (height * height);

            Console.WriteLine("Ваш индекс массы тела{0:f4}", i);
            Console.ReadLine();
        }
    }
}
