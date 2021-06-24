using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceXY
{
    class Program
    {
        static void Main(string[] args)
        {
              Console.Write("Введите значение х первой координаты: ");
              var x1 = double.Parse(Console.ReadLine());
              Console.Write("Введите значение y первой координаты: ");
              var x2 = double.Parse(Console.ReadLine());
              Console.Write("Введите значение x второй координаты: ");
              var y1 = double.Parse(Console.ReadLine());
              Console.Write("Введите значение y второй координыты: ");
              var y2 = double.Parse(Console.ReadLine());

              var r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));


              Console.WriteLine("Растояние между координами: {0:f2}",r);
              Console.ReadLine();
            
            //Задание со звёздочкой 
            //Distance(x1, y1, x2, y2); // Вызов метода

        }

        //Метод вычисления расстояния между точками в виде метода
        /*
        private static void Distance(double x1, double y1, double x2, double y2)
        {
            var r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("Растояние между координами: {0:f2}", r);
            Console.ReadLine();
        }*/
    }
}
