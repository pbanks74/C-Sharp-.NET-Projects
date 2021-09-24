using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperClassConsole
{
    // creates a class that inherits from the Person class and adds an aditional property called Id
    public class Employee : Person
    {
        public int Id { get; set; }
    }

}
