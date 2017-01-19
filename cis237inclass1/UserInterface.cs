using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass1
{
    class UserInterface
    {
        // No Variables
        // No properties
        // No constructors (but we could if we needed to)

        //*****************************
        // Methods
        public int GetUserInput()
        {
            //Print out a menu
            PrintMenu();

            // Get the input from the user
            String input = Console.ReadLine();

            // While the input is not valid re-get the input
            while (input != "1" && input != "2")
            {
                this.PrintErrorMessage();

                // Re-print the menu
                this.PrintMenu();

                // Get the input from the console again
                input = Console.ReadLine();

            }

            return Int32.Parse(input) ;
        }

        private void PrintMenu()
        {
            Console.WriteLine("What would you like to do?: ");
            Console.WriteLine("1. Print List");
            Console.WriteLine("2. Exit");
        }

        private void PrintErrorMessage()
        {
            Console.WriteLine("ERROR: INPROPER INPUT");
            Console.WriteLine("Please re-enter input: ");
            Console.WriteLine();
        }

        public void Output(string userInfo)
        {
            Console.WriteLine(userInfo);
        }

    }
}
