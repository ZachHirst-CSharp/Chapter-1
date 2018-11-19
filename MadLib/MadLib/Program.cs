using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadLib
{
    class Program
    {
        static void Main(string[] args)
        {
            string color;
            string est;
            string bodypartplural;
            string animal;
            string noun;
            string pluralnoun;

            int a;
            int b;
            int c;



            Console.WriteLine("Please enter a color of your choice. ");
            color = Console.ReadLine();
            Console.WriteLine("Please enter a word of your choice ending in 'est'.");
            est = Console.ReadLine();
            Console.WriteLine("Please enter a plural body part. ");
            bodypartplural = Console.ReadLine();
            Console.WriteLine("Please enter an animal of your choice. ");
            animal = Console.ReadLine();
            Console.WriteLine("Please enter a noun. ");
            noun = Console.ReadLine();
            Console.WriteLine("Please enter a plural noun. ");
            pluralnoun = Console.ReadLine();
            Console.WriteLine("Please enter a integer of your choice. ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter another integer. ");
            b = int.Parse(Console.ReadLine());
              
            c = b - a;

            Console.WriteLine(" The {0} {1} was eating {2} {3} when you found it. It was the {4} {5}", color, animal, a, bodypartplural, est, animal);
            Console.WriteLine(" you have ever seen. {0} was the {1}'s next victim... ", noun, animal);
            Console.WriteLine("However only {0} miles from the {1} there are {2} just ", b, animal, pluralnoun);
            Console.WriteLine("waiting to die..");
            Console.ReadLine();
        }
    }
}
