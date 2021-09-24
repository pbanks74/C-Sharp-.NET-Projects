using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    
    // created a class that inherits from the Person class AS WELL AS the interface
    public class Employee : Person, IQuittable
    {
        public override void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
        // provides implementation to the interface method
        public void Quit()
        {
            {
                throw new NotImplementedException();
            }
        }
    }
    
}
 