using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Points;
using Vector;

namespace Testvectors
{
    class Program
    {
        static void Main(string[] args)
        {
          Vectors i = new Vectors(new Point(6, 8), new Point(9, 6));

            Vectors h = new Vectors(new Point(7, 4), new Point(2, 1));
           

            Vectors u = i + h;
            Console.WriteLine(u.X.X);
            Console.WriteLine(u.X.Y);
            Console.WriteLine(u.GetVectorlength());

        }
    }
}
