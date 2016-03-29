using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassesAndMethods
{
    public class ArrayExtension<T>
    {
     
        static List<T> Intersect(List<T> firstList, List<T> secondList)
        {

            List<T> newList = new List<T>();
            for (int i = 0; i < firstList.Count; i++)
            {
                for (int j = 0; j < secondList.Count; j++)
                {
                    if (firstList[i].Equals(secondList[j]))
                    {
                        newList.Add(firstList[i]);
                    }
                }
            }
            return newList;
        }


        static List<T> UnionAll(List<T> firstList, List<T> secondList)
        {
            for (int i = 0; i < secondList.Count; i++)
            {
                firstList.Add(secondList[i]);
            }
            return firstList;
        }

        static List<T> Union(List<T> firstList, List<T> secondList)
        {
            List<T> newList = new List<T>();
            newList = UnionAll(firstList, secondList);
            for (int i = 0; i < newList.Count; i++)
            {
                for (int j = 0; j < Intersect(firstList, secondList).Count; j++)
                {
                    if (newList[i].Equals(Intersect(firstList, secondList)[j]))
                        newList.Remove(newList[i]);
                }
            }
            return newList;
        }
        string Join(List<string> list) {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < list.Count; i++)
            {
                sb.Append(list[i]);
                sb.Append(Configuration.GetReplacingValue());
            }

            return sb.ToString();
        }
    }
}
