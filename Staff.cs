using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class Staff
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public Staff()
        {
            // Default constructor
        }

        public Staff(string name, double salary)
        {
            // Constructor with name and salary parameters
            Name = name;
            Salary = salary;
        }

        public string GetName()
        {
            // Method to get staff name
            return Name;
        }

        public double GetSalary()
        {
            // Method to get staff salary
            return Salary;
        }

        public virtual double GetPaid()
        {
            // Method to calculate staff payment
            return Salary;
        }

        public override string ToString()
        {
            // Method to return string representation of staff object
            return $"Name: {Name}, Salary: {Salary}";
        }
    }
}
