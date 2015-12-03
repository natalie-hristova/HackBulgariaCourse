using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class FactGenerator
    {
     public static  IEnumerable<int> GenerateFactorials(int n)
        {
            var fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
               Console.Write(fact+ " ");
              
            }
            yield return fact;
        }
    }
}
