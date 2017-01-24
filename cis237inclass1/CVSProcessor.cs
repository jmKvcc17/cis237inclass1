using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace cis237inclass1
{
    class CVSProcessor
    {
        public bool ImportCSV(string pathToCSVFile, Employee[] employees)
        {
            // Declare the streamReader
            StreamReader inputFile = null;

            try
            {
                // declare a string for the line
                string line;

                //Instantiate the stream reader
                inputFile = new StreamReader(pathToCSVFile);

                int counter = 0;

                while(!inputFile.EndOfStream)
                {
                    line = inputFile.ReadLine();
                    processLine(line, employees, counter++); // increments after used
                }
                //inputFile.Close();

                return true;
            }
            catch (Exception ex)
            {
                // Output the exception and the stacktrace for the exception
                Console.WriteLine(ex.ToString());
                Console.WriteLine();
                Console.WriteLine(ex.StackTrace);

                // return false becuase it didn't work
                return false;
            }
            finally
            {
                // if the stream reader was instanciated, make sure it is 
                // closed before exiting the reader
                if (inputFile != null)
                    inputFile.Close();
            }

            

        }

        private void processLine(string line, Employee[] employeeArray, int index)
        {
            // declare array of parts that will contain the results of splitting 
            // the read in string
            string[] parts = line.Split(',');

            // Assign each part to a variable
            string firstName = parts[0];
            string lastName = parts[1];
            decimal salary = decimal.Parse(parts[2]);

            // Add a new employee into the array that was passed
            employeeArray[index] = new Employee(firstName, lastName, salary);
        }
    }
}
