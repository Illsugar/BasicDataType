using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите что-нибудь: ");
            string text = Console.ReadLine();

            Random ran = new Random();
            int x = ran.Next(10, Console.WindowHeight);
            int y = ran.Next(10, Console.WindowWidth);

            MetodPausePrint.Print(text, x, y);
            MetodPausePrint.Pause();
        }
    }
}
