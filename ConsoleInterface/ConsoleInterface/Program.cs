using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleInterface
{
    public class Program
    {
        static void Main(string[] args)
        {
            // instantiates an Employee object 
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student" };
            
            // calls method
            employee.SayName();

            // uses polymorphism to create an object of IQuittable
            IQuittable employee1 = new Employee();

            // calls method
            employee1.Quit();
   
            Console.ReadLine();
        }
    }
}
