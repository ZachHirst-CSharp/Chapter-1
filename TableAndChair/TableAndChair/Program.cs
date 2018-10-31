using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableAndChair
{
    class Program
    {
        static void Main(string[] args)
        {
            String choice; 
            Console.WriteLine("Would you like to see my Table, Chairs, and Flower? ");
            choice = Console.ReadLine();

            if(choice.Equals("Yes"))
            {
                TableAndChairs(); 
            }
            else if (choice.Equals("No"))
            {
                Console.WriteLine(" Haha.. Loser ");
                Console.ReadLine();
            }
        }
        static void TableAndChairs()
        {
            Console.WriteLine("                                                                  ");
            Console.WriteLine("                                                                  ");
            Console.WriteLine("                                                                  ");
            Console.WriteLine("                             F                                    ");
            Console.WriteLine("                            L                                     ");
            Console.WriteLine("                         | O |                                    ");
            Console.WriteLine("                         | W |                                    ");
            Console.WriteLine("   |                     | E |                               |    ");
            Console.WriteLine("   |            _________|_R_|________________________       |    ");
            Console.WriteLine("   |                  |                    |                 |    ");
            Console.WriteLine("   |_______           |                    |          _______|    ");
            Console.WriteLine("   |      |           |                    |          |      |    ");
            Console.WriteLine("   |      |           |                    |          |      |    ");
            Console.WriteLine("   |      |           |                    |          |      |    ");
            Console.ReadLine();
        }
    }
}
