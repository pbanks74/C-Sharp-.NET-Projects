using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            // creates 4 enployee objects
            Employee employee1 = new Employee();
            Employee employee2 = new Employee();
            Employee employee3 = new Employee();
            Employee employee4 = new Employee();

            //assigns Id values
            employee1.Id = 1;
            employee2.Id = 2;
            employee3.Id = 3;
            employee4.Id = 4;

            // prints results of comparison to the screen
            Console.WriteLine(employee1 == employee2);
            Console.WriteLine(employee3 != employee4);

            Console.ReadLine();
        }
    }
}
