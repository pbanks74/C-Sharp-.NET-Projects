using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    // creates an abstact class with 2 properties
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // assigns method name
        public void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
    
}
