using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Week1
{
    public static class Factorial
    {
        public static void GetNth(int n)
        {
            int x = 1;
            for (int i = 1; i <= n; i++)
            {
                x = x * i;
            }
            Console.WriteLine("Factoriel loop:" + x);
        }
        public static int GetNthWithRecursion(int n)
        {
            int x = 1;
            if (n == 1)
            {

                return 1;
            }
            else
            {
                x = n * GetNthWithRecursion(n - 1);
                return x;
            }

        }
    }
}
