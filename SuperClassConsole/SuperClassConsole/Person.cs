using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperClassConsole
{
    
    // creates a class called Person and gives it two properties
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        // void method called Sayname() that simply writes the persons name to the console.
        public void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
    
}
