using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Week1
{
    public static class Lucas
    {

        public static int NthLucas(int n)
        {

            int n_2 = 2;
            int n_1 = 1;
            int ln = 0;
            for (int i = 3; i <= n; i++)
            {

                ln = n_1 + n_2;
                n_2 = n_1;
                n_1 = ln;
            }
            return ln;
        }
        public static void FirstNLucas(int n)
        {
            int n_2 = 2;
            int n_1 = 1;
            int ln = 0;
            if (n == 1)
            {
                Console.Write(2);
            }
            else if (n == 2)
            {
                Console.Write("2 1");
            }
            else
            {
                Console.Write("2 1");
                for (int i = 3; i <= n; i++)
                {
                    ln = n_1 + n_2;
                    n_2 = n_1;
                    n_1 = ln;
                    Console.Write(" " + ln);
                }
            }
            Console.WriteLine();
        }
    }
}

