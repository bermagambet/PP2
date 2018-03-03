using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Food


    {
        public int a, b;
        public Food()
        {
            Random rnd2 = new Random();
            Random rnd1 = new Random();
            a = rnd1.Next(0, 40);
            b = rnd2.Next(0, 15);
        }
            public void DrawF()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.SetCursorPosition(a, b);
            Console.Write("z");
        }
    }
}
