using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass1
{
    class Employee
    {
        // Backing fields
        private string _employeeFName;
        private string _employeeLName;
        private decimal _weeklySalary;

        

        public string EmployeeFirst
        {
            get { return _employeeFName; }
            set { _employeeFName = value; }
        }

        public string EmployeeLast
        {
            get { return _employeeLName; }
            set { _employeeLName = value; }
        }

        public decimal WeeklySalary
        {
            get { return _weeklySalary; }
            set { _weeklySalary = value; }
        }

        // *****************************
        // Public Methods
        public string FirstAndLastName()
        {
            return _employeeFName + " " + _employeeLName;
        }

        // ******************************
        // Constructors
        public Employee(string FName, string LName, decimal weeklySalary)
        {
            _employeeFName = FName;
            _employeeLName = LName;
            _weeklySalary = weeklySalary;
        }

        // Default constructor
        public Employee()
        {

        }

        public override string ToString()
        {
            return _employeeFName + " " + _employeeLName + " " + _weeklySalary.ToString("C");
        }
    }
}
