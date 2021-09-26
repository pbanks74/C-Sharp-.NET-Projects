using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadConsoleApp
{
    // created Employee class and assigned it a property
    public class Employee
    {
        // assigns an Id property
        public int Id { get; set; }
        
        // overloads the comparison operator == and passes in parameters
        public static bool operator ==(Employee employee1, Employee employee2)
        {
            // if statement compares the two parameters
            if (employee1.Id.Equals(employee2.Id))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        // overloads the comparison operator != and passes in parameters
        public static bool operator !=(Employee employee3, Employee employee4)
        {
            // if statement compares the two parameters
            if (employee3.Id.Equals(employee4.Id))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}