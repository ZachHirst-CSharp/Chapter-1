using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoursAndMinutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int Hours;
            int MinutesRemaining;
            Console.WriteLine("Pleae enter the number of minutes worked on the job. ");
            int MinutesWorked = int.Parse(Console.ReadLine());
            Hours = (MinutesWorked / 60);
            MinutesRemaining = MinutesWorked % 60;
            Console.WriteLine("The total number of time worked is {0} hours and {1} minutes", Hours , MinutesRemaining);
            Console.ReadLine();
        }
    }
}
