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
            Console.WriteLine("Please enter a pluar body part. ");
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

            Console.WriteLine(" The {0} {1} ");
        }
    }
}
