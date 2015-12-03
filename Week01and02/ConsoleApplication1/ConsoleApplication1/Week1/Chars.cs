using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Chars
    {
        public static void CharHistogram(string str)
        {

            int br = 1;
            for (int i = 0; i < str.Length - 1; i++)
            {
                if (!str[i].Equals(str[i + 1]))
                {
                    br++;
                }
            }
                char[] words = new char[br];
                int[] numbers = new int[br];

                int br2 = 1;
                int x = 0;
            words[br - 1] = str[str.Length - 1];
                for (int j = 0; j < str.Length - 1; j++)
                {
                    if (str[j].Equals(str[j + 1]))
                        br2++;
                    else
                    {
                        words[x] = str[j];
                        numbers[x] = br2;
                        br2 = 1;
                        x++;
                    }
                numbers[br - 1] = br2;
                }
                for (int k = 0; k < br; k++)
                    Console.Write("'" + words[k] + "':" + numbers[k]+",");
            Console.WriteLine();
        }
       

        }
    }

