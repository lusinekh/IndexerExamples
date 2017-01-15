using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pointstract;
using vector;
//using vectorssum;

namespace testvector
{
    class Testvectors
    {
        static void Main(string[] args)
        {
            vec1 i = new vec1(new Point(6,8),new Point(9,6));
            vec1 h=new vec1(new Point(7,4),new Point(2,1));
           // Console.WriteLine(i.X.X);
           //Console.WriteLine( i.GetVector());

            vec1 u = i + h;
            Console.WriteLine(u.X.X);
            Console.WriteLine(u.X.Y);
           Console.WriteLine( u.GetVectorlength());
        }
    }
}
