using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class ExtrEl
    {
        public static int Min(int[] items)
        {
            int min = items[0];
            for (int i = 1; i < items.Length; i++)
            {
                if (items[i - 1] > items[i])
                    min = items[i];
            }
            return min;
        }
        public static int Max(int[] items)
        {
            int max = items[0];
            for (int i = 1; i < items.Length; i++)
            {
                if (items[i - 1] < items[i])
                    max = items[i];
            }
            return max;
        }



        public static int NthMin(int n, int[] items)
        {
            if (n >= items.Length)
                return 0;
            else
            {
                int c;
                for (int i = 0; i < items.Length; i++)
                {
                    for (int j = 0; j < items.Length - 1; j++)
                    {
                        if (items[j] > items[j + 1])
                        {
                            c = items[j];
                            items[j] = items[j + 1];
                            items[j + 1] = c;
                        }
                    }
                }
                return items[n - 1];
            }
        }
        public static int NthMax(int n, int[] items)
        {
            if (n >= items.Length)
                return 0;
            else
            {
                int c;
                for (int i = 0; i < items.Length; i++)
                {
                    for (int j = 0; j < items.Length - 1; j++)
                    {
                        if (items[j] < items[j + 1])
                        {
                            c = items[j];
                            items[j] = items[j + 1];
                            items[j + 1] = c;
                        }
                    }
                }
                return items[n - 1];
            }
        }
    }
}
