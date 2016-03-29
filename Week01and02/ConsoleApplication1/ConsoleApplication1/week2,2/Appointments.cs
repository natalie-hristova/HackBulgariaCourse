using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Appointments
    {
        public static void FindIntersectingAppointments(DateTime[] startDates, TimeSpan[] durations)
        {
            if (startDates.Length == durations.Length)
            {
                DateTime temp = new DateTime();
                TimeSpan tsp = new TimeSpan();
                for (int j = 0; j < startDates.Length - 1; j++)
                {
                    for (int i = 0; i < startDates.Length - 1; i++)
                    {
                        if (startDates[i] > startDates[i + 1])
                        {
                            temp = startDates[i];
                            startDates[i] = startDates[i + 1];
                            startDates[i + 1] = temp;
                            tsp = durations[i];
                            durations[i] = durations[i + 1];
                            durations[i + 1] = tsp;
                        }
                    }
                }
                for (int i = 0; i < startDates.Length - 1; i++)
                {
                    if (startDates[i] + durations[i] > startDates[i + 1])
                    {
                        tsp = (startDates[i] + durations[i]) - startDates[i + 1];
                        Console.WriteLine("This meeting {0} is going to be interrupted with {1} time!", i, tsp);
                    }
                }
            }
            else
                Console.WriteLine("Error!");
        }
    }
}
