// Written by Chloe Jensrud
// 2/24/2025

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSpecializations
{
    public class Employee
    { //class variables
        private string name = "n/a";
        private int salary = 0;

        //gets and sets
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public int Salary
        {
            get { return this.salary; }
            set { this.salary = value; }
        }

        public Employee() : this("n/a", 0)
        {
            //empty constructor
        }
        //full constructor
        public Employee(string aName, int aSalary)
        {
            this.Name = aName;
            this.Salary = aSalary; 
        }

        //ToSTring
        public override string ToString()
        {
            string msg = "";
            msg += $"Employee:  {Name} Salary: ${Salary}.";
            return msg;
        }
    }
}
