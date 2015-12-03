using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Fibunaci
    {
      
       public static void FibNumber(int number)
        {
            Console.Write("1 1 ");
            int fib1 = 1;
            int fib2 = 1;
            int fib;
            for (int i=0;i< number-2; i++)
            {
                fib = fib1 + fib2;
                fib1 = fib2;
                fib2 = fib;
                Console.Write(fib+ " ");
            }
        }
    }
}
