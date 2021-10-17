using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorApp
{
    public class Employee
    {
        // constructer chaining or re-using the code  
        // if no last name is entered "Granks Banks" the company name will be assigned :-)
        public Employee(string firstName) : this (firstName, "Grand Banks")
        {
        }

        public Employee (string firstName, string lastName)
        {
            string First = firstName;
            string Last = lastName;
        }
    }
}
