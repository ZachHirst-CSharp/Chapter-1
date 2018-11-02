using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eggs
{
    class Program
    {
        static void Main(string[] args)
        {
            int Chicken1;
            int Chicken2;
            int Chicken3;
            int Chicken4;

            Console.WriteLine("Please enter the number of egs produced by each of the four chickens in the chicken coupe.");
            Console.WriteLine("Chicken 1 ?");
            Chicken1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Chicken 2 ?");
            Chicken2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Chicken 3 ? ");
            Chicken3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Chicken 4 ?");
            Chicken4 = int.Parse(Console.ReadLine());

            int TotalDozen = (Chicken1 + Chicken2 + Chicken3 + Chicken4) / 12;
            int Remainderdozen = (Chicken1 + Chicken2 + Chicken3 + Chicken4) % 12;

            Console.WriteLine("Total dozens of eggs are {0} dozen and {1} eggs", TotalDozen, Remainderdozen);
            Console.ReadLine();
        }
    }
}
