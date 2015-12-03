using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class WordsInString
    {
        public static int CountVowels(String str)
        {
            int br = 0;
            String vowels;
            vowels = "aeiouyAEIOUY";
            for (int i = 0; i < str.Length ; i++)
            {
                for (int j = 0; j < vowels.Length; j++)
                {
                    if (vowels[j].Equals(str[i]))
                        br++;
                }
            }
            return br;
        }

        public static int CountConsonants(String str)
        {
            int br = 0;
            String vowels;
            vowels = "bcdfghjklmnpqrstvwxzBCDFGHJKLMNPQRSTVWXZ";
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j < vowels.Length; j++)
                {
                    if (vowels[j].Equals(str[i]))
                        br++;
                }
            }
            return br;
        }
    }
}
