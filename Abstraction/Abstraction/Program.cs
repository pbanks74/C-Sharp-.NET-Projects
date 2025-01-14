﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public class Program
    {
        static void Main(string[] args)
        {
            // instantiates an object and calls the method
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student" };
            employee.SayName();
            Console.ReadLine();
        }
        // creates an object of type IQuittable from the interface and calls the method on it
        interface IQuittable
        {
            void Quit();
        }
    }
}
