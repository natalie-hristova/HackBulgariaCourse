using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    public delegate bool DelegationFunction<T>(T number1,T number2);
    class Program
    {
       static  bool function(int x,int y) {
            return (x > y);
        }

        static void Main(string[] args)
        {
        }
    }
}
