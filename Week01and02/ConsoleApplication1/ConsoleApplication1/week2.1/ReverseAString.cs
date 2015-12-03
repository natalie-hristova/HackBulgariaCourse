using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class ReverseAString
    {
     public static  void ReverseList(ref List<int> list)
        {
            int x = list.Count;
            int st;
            for (int i = 0; i < x/2; i++)
            {
                st = list[i];
                list[i] = list[x - 1 - i];
                list[x - 1 - i] = st;
            }
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
        }
    }
}
