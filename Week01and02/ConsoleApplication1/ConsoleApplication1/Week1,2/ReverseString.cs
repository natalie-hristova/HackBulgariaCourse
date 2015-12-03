using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class ReverseString
    {
        public static String ReverseMe(string original)
        {
            char[] cArray = original.ToCharArray();
            string reverse = "";
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reverse += cArray[i];
            }
            return reverse;

            //var s = "dhd ff  ff".Split(new char[] { ' ' }, StringSplitOptions.None);
            //string.Join(", ", s);
        }

        public static string ReverseEveryWord(string sentence)
        {
            string[] s = sentence.Split(' ');
            Array.Reverse(s);
            return (string.Join(" ", s));
        }
    }
}


