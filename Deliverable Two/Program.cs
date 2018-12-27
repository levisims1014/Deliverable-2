using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Deliverable_Two
{
    class Program
    {
        static void Main(string[] args)
        {
            string repeat;
            bool mary = true;
            do
            {
                Console.WriteLine("Hello User! What are you in the mood for?");
                Console.WriteLine("Here are your options!");
                Console.WriteLine("1.) Action");
                Console.WriteLine("2.) Chill Times");
                Console.WriteLine("3.) Danger");
                Console.WriteLine("4.) Good food");
                Console.WriteLine("/n");
                Console.WriteLine("What do you want to do?");
                int fun = int.Parse(Console.ReadLine());

                Console.WriteLine("Great! How many people are you bringing with you?");
                int size = int.Parse(Console.ReadLine());

                switch (fun)
                {
                    case 1:
                        Console.Write("Okay if you’re in the mood for action, then you should go stock car racing and");
                        break;
                    case 2:
                        Console.Write("Okay if you’re in the mood for chilling, then you should go hicking and");
                        break;
                    case 3:
                        Console.Write("Okay if you’re in the mood for danger, then you should go sky diving and");
                        break;
                    case 4:
                        Console.Write("Okay if you’re in the mood for good food, then you should go to Taco Bell and");
                        break;
                }
                if (size == 0)
                {
                    Console.WriteLine("travel in comfortable sneakers!");
                }
                else if (size > 0 && size < 5)
                {
                    Console.WriteLine("travel in a nice sedan!");
                }
                else if (size > 4 && size < 11)
                {
                    Console.WriteLine("travel in a Volkswagen Bus!");
                }
                else if (size > 11)
                {
                    Console.WriteLine("travel in a luxury airplaine!");
                }
                Console.WriteLine("Would you like to try something different? y or n?");
                repeat = Console.ReadLine().ToLower();
                if (repeat == "y")
                {
                    mary = true;
                }
                else if (repeat == "n")
                {
                    Console.WriteLine("Goodbye!");
                    Console.ReadLine();
                    mary = false;
                }
                else
                {
                    Console.WriteLine("Invalid Input, Please try again!");
                }
            }
            while (mary);
        }
    }
}