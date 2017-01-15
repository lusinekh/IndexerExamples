using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pointstract;

namespace vector
{
    public class vec1
    {
        public Point X;
        public Point Y;
      public vec1(Point x,Point y)
        {
            X = x;
            Y = y;

        }
        
        public int GetVectorlength()
    {
      
        return (int)(Math.Sqrt((Math.Pow(X.X - Y.X, 2)+(Math.Pow(X.Y - Y.Y, 2)))));
        
    }

        

        public static vec1 operator +(vec1 a,vec1  b)

        {
           
            return new vec1(new Point(a.X.X + b.X.X, a.X.Y + b.X.Y), new Point(a.Y.X + b.Y.X, a.Y.Y + b.Y.Y));
            
        }


        public static vec1 operator -(vec1 a, vec1 b)
        {
            
            return new vec1(new Point(a.X.X - b.X.X, a.X.Y - b.X.Y), new Point(a.Y.X - b.Y.X, a.Y.Y - b.Y.Y));

        }



    }
}
