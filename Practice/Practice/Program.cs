using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            String name = "Zach Hirst";
            String YourAge;
            String YourName;
            int age = 17;
            int Addage = 11;

            Console.WriteLine("Hello, my name is {0} and I am {1} years old. " , name, age);
            Console.WriteLine("What's your name?");
            YourName = Console.ReadLine();
            Console.WriteLine("And your age?");
            YourAge = Console.ReadLine();
            Console.WriteLine("Gosh, you're only {0}!!?? Well, {1} it's nice to meet you.", YourAge, YourName);
            Console.ReadLine();
        }
    }
}
