using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class IntegerPolindromes
    {
       public static bool IsIntPalindrome(int n)
        {
            string myS = n.ToString();
            
            bool isPolindrom = true;
            for (int i=0;i< myS.Length/2;i++)
            {
                if (!myS[i].Equals(myS[myS.Length - 1 - i]))
                {
                    isPolindrom = false;
                    break;
                }
            }  
            return isPolindrom;
        }

       public static int GetLargestPalindrome(int N)
        {
            N=N-1;
            string myS = N.ToString();
            while (IntegerPolindromes.IsIntPalindrome(N)== false)
            {
                N--;
            }
            return N;
        }
    }
}
