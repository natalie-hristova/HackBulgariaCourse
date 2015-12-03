using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Palindromes
    {
        public static int pl = 1;
        public static int PScore(int n)
        {
            int pol = 1;
            string b = n.ToString();
            for (int i = 0; i < b.Length / 2; i++)
            {
                if (!b[i].Equals(b[b.Length - 1 - i]))
                {
                    pol = 0;
                    break;
                }
            }
            if (pol == 1)
                return pl;
            else
            {
                pl++;
                Palindromes.PScore2(n);
            }
            return pl;
        }

        public static void PScore2(int n)
        {
            string b = n.ToString();
            string reversen = new string(b.Reverse().ToArray());
            int reversex = int.Parse(reversen);
            int x = int.Parse(b);
            int sum = x + reversex;
            Palindromes.PScore(sum);
        }
    }
}
