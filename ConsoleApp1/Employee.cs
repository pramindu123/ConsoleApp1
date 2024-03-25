using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Employee
    {
        string FirstName {  get; set; }
        string LastName { get; set; }
        double BasicSalary {  get; set; }

        public Employee(string afirstName, string aLastName, double aBasicSalary) {
            FirstName = afirstName;
            LastName=aLastName; 
            BasicSalary = aBasicSalary;
        }
        public void print()
        {
            Console.WriteLine($"Name: {FirstName} {LastName} , Salary :{BasicSalary}");
        }

        
    }
}


