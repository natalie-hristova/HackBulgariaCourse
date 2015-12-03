using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class MaxScProduct
    {
       //static  int sum = 0;
       //static  int mult = 1;
        public static int MaxScalarProduct(List<int> v1, List<int> v2)
        {
            int sum = 0;
              int mult = 1;
            int[] a1 = v1.ToArray();
            int[] a2 = v2.ToArray();
            if (a1.Length != a2.Length)
                return 0;
            else
            {
                for (int i = 0; i < a1.Length; i++)
                {
                    mult = a2[i] * a1[i];
                    sum += mult;
                }
            }
            return sum;
        }


        public static int MaxScalarProduct2(List<int> v1, List<int> v2)
        {
            int sum = 0;
          int mult = 1;
            int[] a1 = v1.ToArray();
            int[] a2 = v2.ToArray();
            int mina1;
            int mina2 ;
            for (int i = 1; i < a1.Length; i++)
            {
                for (int j = 0; i < a1.Length; i++) { 
                if (a1[i] > a1[i - 1])
                    {
                        mina1 = a1[i - 1];
                        a1[i - 1] = a1[i];
                        a1[i] = mina1;
                    }
                    if (a2[i] > a2[i - 1])
                    {
                        mina2 = a2[i - 1];
                        a2[i - 1] = a2[i];
                        a2[i] = mina2;
                    }
                }
            }
   for (int i = 0; i < a1.Length; i++)
                {
                    mult = a2[i] * a1[i];
                    sum += mult;
                
                }
            
            return sum;
        }
    }
    }
