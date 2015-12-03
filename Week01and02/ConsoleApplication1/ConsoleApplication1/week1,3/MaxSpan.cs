using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class MaxSpan
    {
        public static int MaxiSpan(List<int> numbers)
        {
            int br, x = 0;
            int[] array = new int[numbers.Count];
            for (int i = 0; i < numbers.Count; i++)
            {
                for (int j = numbers.Count - 1; j >= 0; j--)
                {
                    if (numbers[i] == numbers[j])
                    {
                        br = j - i + 1;
                        array[x] = br;
                        x++;
                        break;
                    }
                    else
                        br = 1;
                }
            }
            int max = 1;
            for (int i = 0; i < array.Length; i++)
            {
                if (max < array[i])
                    max = array[i];
            }
            return max;
        }

    }
}
