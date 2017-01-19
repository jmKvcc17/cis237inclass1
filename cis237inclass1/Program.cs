using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create user interface class object
            UserInterface ui = new UserInterface();

            // Create an array of employee objects
            Employee[] employeeArray = new Employee[10];

            // Let's add some employees to our array
            employeeArray[0] = new Employee("Jesse", "Meachum", 34.34m);
            employeeArray[1] = new Employee("Jimbo", "Bobby", .02m);
            employeeArray[2] = new Employee("Guy", "Person", 1002m);
            employeeArray[3] = new Employee("uy", "Pefrson", 100.2m);
            employeeArray[4] = new Employee("Gu", "Pedrson", 10.02m);
            employeeArray[5] = new Employee("Gy", "Perfson", 102m);

            // Get some input from the user
            int choice = ui.GetUserInput();

            // while the choice they select is not 2, continue to do work
            while(choice != 2)
            {
                // See if the input they sent is equal to 1
                if (choice == 1)
                {
                    string outputString = "";

                    // print the array
                    foreach (Employee employee in employeeArray)
                    {
                        if (employee != null)
                        {
                            // Concat to the outputString
                            outputString += employee.ToString() +
                                Environment.NewLine;
                        }
                    }

                    // Use the UI class to print the string
                    ui.Output(outputString);
                }

                // re-prompt the user for input
                choice = ui.GetUserInput();

            }

            Console.ReadLine();
        }
    }
}
