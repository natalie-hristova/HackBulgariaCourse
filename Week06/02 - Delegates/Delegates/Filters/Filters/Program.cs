using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Filters
{
    public delegate bool DelegateMethod<T>(T number);
    public class Program
    {
        public static bool IsNotZero(int number) {
            return (number != 0);
        }

        public static bool PositiveNumber(int number)
        {
            return number >= 0;
        }
        public static List<T> FilterCollection<T>(List<T> original, DelegateMethod<T> filter)
        {
            List<T> newList = new List<T>();

            foreach (var item in original)
            {
                if (filter(item))
                    newList.Add(item);

            }
            return newList;
        }
    
        static void Main(string[] args)
        {

            List<int> list = new List<int>() { 3, 6, 1, -2, -6, 34,0,0,0 };
            List<int> filteredList = FilterCollection<int>(list, IsNotZero);

            Console.Write("Original list: ");
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }

            Console.Write("\nPositive numbers: ");
            foreach (var item in filteredList)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

        }
    }
}
