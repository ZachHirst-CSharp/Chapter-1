using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum;
            int difference;
            int product;
            int quotient;
            int value1;
            int value2;
            int remainder;

            Console.WriteLine("Please enter your first number. ");
            value1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your second number. ");
            value2 = int.Parse(Console.ReadLine());

            sum = value1 + value2;
            difference = value1 - value2;
            product = value1 * value2;
            quotient = value1 / value2;
            remainder = value1 % value2;

            Console.WriteLine("The sum of {0} and {1} is {2}. ", value1 , value2, sum);
            Console.WriteLine("The difference of {0} and {1} is {2}. ", value1, value2, difference);
            Console.WriteLine("The product of {0} and {1} is {2}. ", value1, value2, product);
            Console.WriteLine("The quotient of {0} and {1} is {2}. ", value1, value2, quotient);
            Console.WriteLine("The remainder of {0} and {1} is {2}. ", value1, value2, remainder);
            Console.ReadLine();

        }
    }
}
