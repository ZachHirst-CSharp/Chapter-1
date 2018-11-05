using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectedRaises
{
    class Program
    {
        static void Main(string[] args)
        {
           
            double YearlyRaise = 1.04;

            String EmployeeChoice;

            Console.WriteLine("Please Select and employee.");
            Console.WriteLine("Kane");
            Console.WriteLine("Crhis");
            Console.WriteLine("Zach");
            Console.WriteLine("Sal");
           
            EmployeeChoice = Console.ReadLine();
          
            if(EmployeeChoice =="Kane")
            {
                double KaneSalary;
                
                Console.WriteLine("Please Enter His salary");
                KaneSalary = double.Parse(Console.ReadLine());
                double Kconversion = (KaneSalary*YearlyRaise); 
                Console.WriteLine("Kane's projected growth of salary for the next year is {0}" , Kconversion.ToString("C"));
                Console.ReadLine();
            }
            else if(EmployeeChoice == "Chris")
            {
                double ChrisSalary;

                Console.WriteLine("Please Enter His salary");
                ChrisSalary = double.Parse(Console.ReadLine());
                double Cconversion = (ChrisSalary * YearlyRaise);
                Console.WriteLine("Chris' projected growth of salary for the next year is {0}", Cconversion.ToString("C"));
                Console.ReadLine();
            }
            else if(EmployeeChoice == "Zach")
            {
                double ZachSalary;

                Console.WriteLine("Please Enter His salary");
                ZachSalary = double.Parse(Console.ReadLine());
                double Zconversion = (ZachSalary * YearlyRaise);
                Console.WriteLine("Zach's projected growth of salary for the next year is {0}", Zconversion.ToString("C"));
                Console.ReadLine();
            }
            else if (EmployeeChoice == "Sal")
            {
                double SalSalary;

                Console.WriteLine("Please Enter His salary");
                SalSalary = double.Parse(Console.ReadLine());
                double Sconversion = (SalSalary * YearlyRaise);
                Console.WriteLine("Sal's projected growth of salary for the next year is {0}", Sconversion.ToString("C"));
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("User not available, sorry. ");
                Console.ReadLine(); 
            }
        }
    }
}
