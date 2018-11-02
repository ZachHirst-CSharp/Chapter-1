using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental
{
    class Program
    {
        static void Main(string[] args)
        {
            double ChargePerMile = .25;
            double DayCharge = 20;
            double DaysDriven;
            double MilesDriven;

            Console.WriteLine("Please enter the number of days you would like to rent the driver for?? ");
            DaysDriven = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the total number of miles driven. ");
            MilesDriven = double.Parse(Console.ReadLine());
            double TotalCost = (DaysDriven * DayCharge) + (ChargePerMile * MilesDriven);
            Console.WriteLine("The total cost for your adventure with us is {0} ", TotalCost.ToString("C"));
            Console.ReadLine();
        }
    }
}
