// Written by Chloe Jensrud
// 2/24/2025

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSpecializations
{
    //manager subclass
    public class Manager : Employee
    { // class variables
        private int numberOfEmployeesManaged = 10;

        // gets and sets
        public int NumberOfEmployees
        {
            get { return this.numberOfEmployeesManaged; }
            set { this.numberOfEmployeesManaged = value; }
        }
        // constructor calling base
        public Manager(string name, int salary, int numberOfEmployeesManaged) : base(name, salary)
        {
            this.numberOfEmployeesManaged = numberOfEmployeesManaged;
        }
        //ToString Override
        public override string ToString()
        {
            string msg = "";
            msg += $"{Name} manages {NumberOfEmployees} employees.";
            return msg;
        }
    }
    // engineer subclass
    public class Engineer : Employee
    { // class variables
        private string specialization = "n/a";

        // gets and sets
        public string Specialization
        {
            get { return this.specialization; }
            set { this.specialization = value; }
        }
        // constructor calling base class
        public Engineer(string name, int salary, string specialization) : base(name, salary)
        {
            this.specialization = specialization;
        }
        // ToString
        public override string ToString()
        {
            string msg = "";
            msg += $"{Name} has a specialization of: {specialization}";
            return msg ;
        }
    }
}
