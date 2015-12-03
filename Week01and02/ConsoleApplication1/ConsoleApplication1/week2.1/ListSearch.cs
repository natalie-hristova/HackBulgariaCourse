using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class ListSearch
    {
        public static bool TryFindSubstring(List<string> list, string searched, out int foundIndex)
        {
            bool has = false;
            foundIndex = -1;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Contains(searched))
                {
                    foundIndex = i;
                    has = true;
                    break;
                }
            }
            Console.WriteLine(has + " " + foundIndex);
            return has;
        }
        public static string JoinStrings(string separator, params string[] strings)
        {
            return string.Join(separator, strings);
        }
    }
}
