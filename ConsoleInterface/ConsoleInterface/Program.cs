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
            // instantiates an object and calls the method
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student" };
            employee.SayName();
            employee.Quit();
            Console.ReadLine();
        }
    }
}
