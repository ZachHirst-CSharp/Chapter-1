using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilesToKilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            double KiloPerMile = 1.6;
            double Distance;
            double Conversion;

            Console.WriteLine("What is the distance in mile that you would like to convert?");
            Distance = double.Parse(Console.ReadLine());
            Conversion = Distance * KiloPerMile;
            Console.WriteLine("The Distance in miles is {0} , and the distance in kilometers is {1} ", Distance, Conversion);
            Console.ReadLine();
        }
    }
}
