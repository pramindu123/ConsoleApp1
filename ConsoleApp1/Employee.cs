using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double BasicSalary { get; set; }

        public Employee(string afirstName, string aLastName, double aBasicSalary)
        {
            FirstName = afirstName;
            LastName = aLastName;
            BasicSalary = aBasicSalary;
        }
        public void print(string afirstName, string aLastName, double aBasicSalary)
        {
            Console.WriteLine($"Name: {afirstName} {aLastName} , Salary :{aBasicSalary}");
        }


    }
}



