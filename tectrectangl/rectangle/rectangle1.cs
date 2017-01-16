using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Point;

namespace rectangle
{
    public class rectangle1
    {
        public point X { set; get; }
        public point Y { set; get; }
        public ConsoleColor K { set; get; }
        public char D { set; get; }
        public ConsoleColor E = ConsoleColor.DarkCyan;

        public rectangle1(point x, point y, ConsoleColor k, char d)
        {
            X = x;
            Y = y;
            K = k;
            D = d;
        }

        public void Drowrect(bool e)
        {
            if (e == true)
            {
               
                for (int i = 0; i < X.X - Y.X; i++)
                {
                 //   Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowTop / 2);
                    for (int j = 0; j < X.Y - Y.Y; j++)
                    {
                        if (0 < i && i < ((int)(X.X - Y.X) - 1) && 0 < j && j < (int)((X.Y - Y.Y) - 1))
                        {
                            Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowTop / 2);
                            Console.Write(" ");
                        }
                        else
                        {
                            Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowTop / 2);
                            Console.Write(D);
                        }
                    }

                    Console.WriteLine();
                   
                }


                Console.ResetColor();

            }
            else
            {
                Console.ForegroundColor = K;

                // Console.ResetColor();
            }
        }



        public void goleft()
        {
            
            Console.BackgroundColor = E;
           
          //  Console.CursorLeft = Console.WindowLeft / 2 - 1 + (X.Y - Y.Y);

            for (int i = 0; i < X.X - Y.X; i++)
            {
                for (int j = 0; j < X.Y - Y.Y; j++)
                {
                    if (0 < i && i < ((int)(X.X - Y.X) - 1) && 0 < j && j < (int)((X.Y - Y.Y) - 1))
                    {
                        
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write(D);
                        
                    }
                }

                Console.SetCursorPosition((X.Y - Y.Y) + 4, 0);
            }

        }
    }
}


 