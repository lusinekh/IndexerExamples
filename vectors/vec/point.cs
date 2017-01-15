using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Pointstract
{
      

       public struct Point
    {
           public Point(float x, float y)
               : this()
           {
               this.X = x;
               this.Y = y;
           }

        public float X { get; set; }
        public float Y { get; set; }
       
    }
}



   
   
    