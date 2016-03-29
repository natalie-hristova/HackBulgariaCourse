using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SortAndSearch;


namespace SortAndSearchApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> a = new List<int>() { 1, 4, 2, 4, 6, 8 };


            a.BubbleSort( new MyIntComparer());
            a.SelectionSort(new MyIntComparer());

            OddEvenComparer comparer = new OddEvenComparer();
            ReverseComparer<int?> reverseComparer = new ReverseComparer<int?>(comparer);

            int? x = 5;
            int? y = 7;

            Console.WriteLine(comparer.Compare(x, y));
            Console.WriteLine(reverseComparer.Compare(x, y));

        }
    }
}

class MyIntComparer : IComparer<int>
{
    public int Compare(int x, int y)
    {
        return x - y;
    }

}
class LastDigitComparer : IComparer<int>
{
    public int Compare(int x, int y)
    {
        int xa = x % 10;
        int ya = y % 10;
        if (ya == xa) return 0;
        else if (xa > ya) return 1;
        else return -1;
    }
}
// ReverseComparer<T> that reverses the comparison of a given IComparer<T>
public class ReverseComparer<T> : IComparer<T>
{
    private IComparer<T> comparer;
    public ReverseComparer(IComparer<T> comparer)
    {
        this.comparer = comparer;
    }

    public int Compare(T x, T y)
    {
        return this.comparer.Compare(y, x);
    }
}
class StringLengthComparer : IComparer<string>
{
    public int Compare(string a, string b)
    {
        int lenghtA;
        int lengthB;
        if (a == null) lenghtA = 0;
        else lenghtA = a.Length;
        if (b == null) lengthB = 0;
        else lengthB = b.Length;
        return lenghtA - lengthB;
    }
}
class OddEvenComparer : IComparer<int?>
{
    public int Compare(int? x, int? y)
    {

        if (x != null && y != null)
        {
            if (x % 2 == 0 && y % 2 == 0) return (int)x - (int)y;
            else if (x % 2 == 1 && y % 2 == 1) return (int)y - (int)x;
            else if (x % 2 == 0 && y % 2 == 1) return (int)y;
            else return (int)x;

        }
        else
        {
            if (x == null && y != null) return (int)y;
            else if (x != null && y == null) return (int)x;
            else return 0;
        }

    }
}
 

