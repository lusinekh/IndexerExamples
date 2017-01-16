using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using rectangle;
using Point;

namespace tectrectangl
{
    class Program
    {
        static void Main(string[] args)
        {
         //   Console.SetCursorPosition(Console.WindowHeight / 2, Console.WindowWidth / 2);
           // point b = new point ( 7, 9 );
       //     Console.WriteLine(b.X+"\t"+b.Y);
            rectangle1 h = new rectangle1(new point(8, 9), new point(5, 4),ConsoleColor.DarkGreen,'e');
         //   Console.WriteLine(h.X.X + "\t" + h.X.Y);
           // h.Drowrect(true);
            h.Drowrect(true);
          //  h.goleft();

            Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowTop / 2);
            Console.WriteLine("hello my name is Lusine");
            Console.WriteLine("hello my name is Roza");

        }
    }
}
