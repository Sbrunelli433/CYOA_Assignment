using System;

namespace CYOA_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please choose a place to go: Restaurant or Steve's Sandwiches");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "Restaurant":
                    Console.WriteLine("You chose to go to the Restaurant");
                    break;
                case "Steve's Sandwiches":
                    Console.WriteLine("You chose to go to Steve's Sandwiches");
                    break;
                default:
                    Console.WriteLine("Not an option today for lunch, please choose Restaurant or Market");
                    break;
            }



        }
    }
}
