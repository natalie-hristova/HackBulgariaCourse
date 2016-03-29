using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericType
{
    public class GenericDequeue<T>
    {
        List<T> double_Ended;

        public GenericDequeue()
        {
            this.double_Ended = new List<T>();
        }

        public void Clear()
        {
            if (double_Ended.Count == 0)
                Console.WriteLine("The double queue is alredy empty!");
            else
            {
                for (int i = 0; i < double_Ended.Count; i++)
                {
                    double_Ended.Clear();
                }
            }
        }

        public bool Contains(T element)
        {
            for (int i = 0; i < double_Ended.Count; i++)
            {
                if (element.Equals(double_Ended[i]))
                    return true;
            }
            return false;
        }

        public T RemoveFromFront()
        {
            T firstElement = double_Ended[0];
            double_Ended.RemoveAt(0);
            for (int i = 0; i < double_Ended.Count - 1; i++)
            {
                T x = double_Ended.ElementAt(i + 1);
                double_Ended[i] = x;
            }
            return firstElement;
        }

        public T RemoveFromEnd()
        {
            T lastElement = double_Ended[double_Ended.Count - 1];
            double_Ended.RemoveAt(double_Ended.Count - 1);
            return lastElement;
        }

        public void AddToFront(T element)
        {
            double_Ended.Insert(0, element);
        }

        public void AddToEnd(T element)
        {
            double_Ended.Add(element);
        }

        public T PeekFromFront()
        {
            return double_Ended.ElementAt(0);
        }

        public T PeekFromEnd()
        {
            return double_Ended[double_Ended.Count - 1];
        }

    }
}

