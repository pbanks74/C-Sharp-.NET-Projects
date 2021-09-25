using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleInterface
{
    // allows Employee to inherit from Person & IQuittable
    public class Employee : Person, IQuittable
    {
        // overrides method
        public override void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
        // adds functionality to interface method
        public void Quit()
        {
            Console.WriteLine("The employee has quit");
        }
    }
}
