using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class RandomNumbers
    {
        public static void GenerateRandomMatrix(int rows, int columns, string fileName)
        {
            Random rnd = new Random();
            StringBuilder sb = new StringBuilder();
            sb.Append(rows + "x" + columns);
            sb.Append(Environment.NewLine);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    double number = rnd.NextDouble() * (1001.00);
                    sb.AppendFormat(("{0:#,###.##}"), number.ToString("#,##0.00").PadLeft(8));
                }
                sb.Append(Environment.NewLine);
            }
            Console.WriteLine(sb);
            File.WriteAllText(fileName, sb.ToString());
        }

    }
}
