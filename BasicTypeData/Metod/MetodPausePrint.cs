using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metod
{
    class MetodPausePrint
    {
        public static void Pause()                    
        {
            Console.ReadKey();
        }

        public static void Print(string text, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(text);
        }
    }
}
