using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deliverable_Two
{
    class Program
    {
        static void Main(string[] args)
        {
            String againResponse;
            int activity, human;
            Random rando = new Random();
            bool again = true;

            while (again)
            {

                Console.WriteLine("Welcome to the What-to-Do App");
                Console.WriteLine("Hello User, What Are you in the mood for?");
                Console.WriteLine("1) Action");
                Console.WriteLine("2) Chilling");
                Console.WriteLine("3) Danger");
                Console.WriteLine("4) Good Food");
                Console.WriteLine("");
                activity = Int32.Parse(Console.ReadLine());
                if (activity == 6)
                {
                    activity = rando.Next(1, 6);
                    Console.WriteLine("You chose random. Let me assist you!");
                }

                Console.WriteLine("How many will join you?");
                human = Int32.Parse(Console.ReadLine());

                switch (activity)
                {
                    case 1:
                        Console.Write("If you want action, lets go stock car racing and");
                        break;
                    case 2:
                        Console.Write("If you want to chill, then you should go hicking and");
                        break;
                    case 3:
                        Console.Write("If you’re in the mood for danger, then you should go sky diving and");
                        break;
                    case 4:
                        Console.Write("If you want good food, then you should go to Taco Bell and");
                        break;
                }

                if (human == 0)
                {
                    Console.WriteLine(" travel by sneakers.");
                }
                else if (human > 0 && human < 5)
                {
                    Console.WriteLine(" travel by sedan.");
                }
                else if (human > 4 && human < 11)
                {
                    Console.WriteLine(" travel by VW Buss.");
                }
                else
                {
                    Console.WriteLine(" travel by charter buss.");
                }

                Console.WriteLine("Would you like to try again?");
                Console.WriteLine("Type 'y' for Yes and 'n' for No");
                againResponse = Console.ReadLine();

                if (againResponse.Equals("y") || againResponse.Equals("Y"))
                {
                    again = true;
                }
                else
                {
                    again = false;
                }
            }
            Console.WriteLine("Thank you, Goodbye!");
            Console.ReadLine();
        }
    }
}
