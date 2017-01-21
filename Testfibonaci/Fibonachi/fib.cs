using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonachi
{
    public class fib
    {

        /*
        private int last = 0;
        private int next = 1;
        */
        /*
        private  int next = 0;
	    private  int last = 1;


        /*
        private int fib1(int k)
        {
            int fib1 = 0;
            for (int i = 1; i <= k; i++)
            {
                fib1 = last + next;
                last = next;
                next = fib1;

            }
            return fib1;
        }
        */


        public int fib1(int n)
        {
            int firstnumber = 0, secondnumber = 1, result = 0;  
   
            if (n == 0) return 0;   
            if (n == 1) return 1;  
   
   
            for (int i = 2; i <= n; i++)  
            {  
                result = firstnumber + secondnumber;  
                firstnumber = secondnumber;  
                secondnumber = result;  
            }  
   
            return result;  
        }



        public int this[int index]
        {
            set
            {
                value = (fib1(index));

            }

            get
            {

                return fib1(index);
            }

        }






    }
}





