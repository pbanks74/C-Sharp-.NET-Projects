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
        public int Id { get; set; }

        public static Employee operator== (Employee employee)
        {
            employee.Id.Equals(employee.Id);
            return employee;
        }
    }
}
