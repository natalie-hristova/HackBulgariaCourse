using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aggregates
{
    public delegate T AggregationDelegate<T>(T number1, T number2);

    class Program
    {
        public static int Max(int number1, int number2)
        {
            if (number2 > number1)
            {
                return number2;
            }
            else
                return number1;
        }

        public static int Min(int number1, int number2)
        {
            if (number2 < number1)
            {
                return number2;
            }
            else
                return number1;
        }
        public static int Sum(int number1, int number2)
        {
            return number1 + number2;
        }
        public static int Product(int number1, int number2)
        {
            return number1 * number2;
        }
        public static int Average(int number1, int number2)
        {
            return (number1 + number2) / 2;
        }


        static T AggregateCollection<T>(List<T> original, AggregationDelegate<T> aggregate)
        {
            T x = original[0];
            for (int i = 1; i < original.Count; i++)
            {
                x = (aggregate(original[i], x));
            }
            return x;
        }

        static void Main(string[] args)
        {
            List<int> list = new List<int> { 1, 2, 3, 4 };
            Console.WriteLine("The max element is :{0}", AggregateCollection(list, Max));
            Console.WriteLine("The min element is :{0}", AggregateCollection(list, Min));
            Console.WriteLine("The sum element is :{0}", AggregateCollection(list, Sum));
            Console.WriteLine("The product element is :{0}", AggregateCollection(list, Product));
            Console.WriteLine("The average element is :{0}", AggregateCollection(list, Average));
        }
    }
}
