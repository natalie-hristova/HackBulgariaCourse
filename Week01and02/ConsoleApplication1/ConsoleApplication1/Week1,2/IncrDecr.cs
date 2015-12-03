using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class IncrDecr
    {
        public static bool IsIncreasing(int[] sequence)
        {
            bool isIncr = true;
            for(int i = 0; i < sequence.Length-1; i++)
            {
                if (sequence[i] >= sequence[i + 1])
                    isIncr = false;
            }
            return isIncr;
        }

        public static bool IsDecreasing(int[] sequence)
        {
            bool isDecr = true;
            for (int i = 0; i < sequence.Length - 1; i++)
            {
                if (sequence[i] <= sequence[i + 1])
                    isDecr = false;
            }
            return isDecr;
        }
    }
}
