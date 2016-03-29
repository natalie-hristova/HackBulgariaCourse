using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector a = new Vector(1, 2, 3);
            Vector b = new Vector(2, 3, 4);

            Console.WriteLine(a + 1);
            Console.WriteLine(a);

        }
    }
}
