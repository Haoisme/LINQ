using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class Manager : Staff
    {
        private double Allowance { get; set; }

        public Manager()
        {
            // Default constructor
        }

        public Manager(string name, double salary, double allowance)
            : base(name, salary)
        {
            // Constructor with name, salary and allowance parameters
            Allowance = allowance;
        }

        public override double GetPaid()
        {
            // Method to calculate manager payment, including allowance
            return Salary + Allowance;
        }

        public override string ToString()
        {
            // Method to return string representation of manager object
            return $"Name: {Name}, Salary: {Salary}, Allowance: {Allowance}";
        }
    }
}
