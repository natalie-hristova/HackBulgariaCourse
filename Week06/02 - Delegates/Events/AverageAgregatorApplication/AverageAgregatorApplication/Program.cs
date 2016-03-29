using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageAgregatorApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            AverageAgragator avgAggregator = new AverageAgragator();
            avgAggregator.AverageChanged += AvgAggregator_AverageChanged;

            avgAggregator.AddNumber(4);
            avgAggregator.AddNumber(4);
            avgAggregator.AddNumber(5);
        }

        private static void AvgAggregator_AverageChanged(object sender, EventArgs e)
        {
            // Console.WriteLine("Average changed!");

            AverageAgragator avg = (AverageAgragator)sender;
            Console.WriteLine("New average: " + avg.Average);
        }
    }
}
