using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAndSearch
{
    public static class ClasSortAndSearchExtensions
    {
        public static IList<T> BubbleSort<T>(this IList<T> list,IComparer<T> comparer)
        {
            T temp;
            for (int i = 0; i < list.Count - 1; i++)
            {
                for (int j = 0; j < list.Count - 1; j++)
                {
                    if (comparer.Compare(list[j], list[j + 1]) > 0)
                    {
                        temp = list[j + 1];
                        list[j + 1] = list[j];
                        list[j] = temp;
                    }
                }
            }
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            return list;

        }
        public static IList<T> SelectionSort<T>(this IList<T> list, IComparer<T> comparer)
        {

            for (int i = 0; i < list.Count - 1; i++)
            {
                T min = list[i];
                int imin = i;
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (comparer.Compare(min, list[j]) > 0)
                    {
                        min = list[j];
                        imin = j;
                    }
                }
                list[imin] = list[i];
                list[i] = min;
            }
            foreach (var item in list)
            {
                Console.Write(item);
            }
            return list;
        }
    }
}

