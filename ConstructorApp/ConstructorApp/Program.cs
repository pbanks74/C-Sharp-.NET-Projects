using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // creates a constant field
            const string buisnessName = "Grand Banks Hotel";

            // creates an implicit type variable
            var taxCode = 0017395;

            // prints to the console
            Console.WriteLine("Employees of " + buisnessName);
            Console.WriteLine("Your Tax Code is: " + taxCode);

            // creates a new employee using the method made of 2 constructors
            Employee emp1 = new Employee("Paul");

        
            Console.ReadLine();
        }
    }
}
