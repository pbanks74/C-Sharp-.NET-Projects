using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperClassConsole
{
    public class Program
    {
        static void Main(string[] args)
        {
            // instantiates and initializes an Employee object
            // Employee inherits from Person class and adds Id parameter
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student", Id = 001 };
            Console.ReadLine();
        }

        private static void SayName()
        {
            throw new NotImplementedException();
        }
    }
}
