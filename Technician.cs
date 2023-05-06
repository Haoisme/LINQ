using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class Technician : Staff
    {
        private double OvertimePay { get; set; }

        public Technician()
        {
            // Default constructor
        }

        public Technician(string name, double salary, double overtimePay)
            : base(name, salary)
        {
            // Constructor with name, salary and overtimePay parameters
            OvertimePay = overtimePay;
        }

        public override double GetPaid()
        {
            // Method to calculate technician payment, including overtime pay
            return Salary + OvertimePay;
        }

        public override string ToString()
        {
            // Method to return string representation of technician object
            return $"Name: {Name}, Salary: {Salary}, Overtime Pay: {OvertimePay}";
        }
    }
}
