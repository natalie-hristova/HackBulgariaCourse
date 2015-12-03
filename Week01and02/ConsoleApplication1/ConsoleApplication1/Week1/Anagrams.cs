using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Week1
{
    class Anagrams
    {
        public static bool IsAnagram(string A, string B)
        {
            bool isAnagram = true;
            int x = 0;
            if (A.Length == B.Length)
            {
                foreach (var item in A)
                {
                    for (int i = 0; i < B.Length; i++)
                    {
                        if (item == B[i])
                        {
                            x++;
                            break;
                        }
                    }
                }

            }
            else
                isAnagram = false;
            if (x < A.Length)
                isAnagram = false;
            return isAnagram;
        }

      public static bool  HasAnagramOf(string A, string B)
        {
            int x = 0;
            bool has = true;
            if (A.Length <= B.Length)
            {
                foreach (var item in A)
                {
                    for (int i = 0; i < B.Length; i++)
                    {
                        if (item == B[i])
                        {
                            x++;
                            break;
                        }
                    }
                }

            }
            else
                has = false;
            if (x < A.Length)
                has = false;
            return has;
        }
    }
}
