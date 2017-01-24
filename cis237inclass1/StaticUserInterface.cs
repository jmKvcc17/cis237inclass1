using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass1
{
    static class StaticUserInterface
    {
        
        public static int GetUserInput()
        {
            //Print out a menu
            PrintMenu();

            // Get the input from the user
            String input = Console.ReadLine();

            // While the input is not valid re-get the input
            while (input != "1" && input != "2")
            {
                PrintErrorMessage();

                // Re-print the menu
                PrintMenu();

                // Get the input from the console again
                input = Console.ReadLine();

            }

            return Int32.Parse(input);
        }
        

        private static void PrintMenu()
        {
            Console.WriteLine("What would you like to do?: ");
            Console.WriteLine("1. Print List");
            Console.WriteLine("2. Exit");
        }

        private static void PrintErrorMessage()
        {
            Console.WriteLine("ERROR: INPROPER INPUT");
            Console.WriteLine("Please re-enter input: ");
            Console.WriteLine();
        }

        public static void Output(string userInfo)
        {
            Console.WriteLine(userInfo);
        }
    }
}
