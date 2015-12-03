using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Copies
    {
        public static string CopyEveryChar(string input, int k)
        {
            List<char> copied = new List<char>();
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    copied.Add(input[i]);
                }
            }
            foreach (var item in copied)
            {
                Console.Write(item);
            }
            Console.WriteLine();
            return copied.ToString();
        }
    }
}
