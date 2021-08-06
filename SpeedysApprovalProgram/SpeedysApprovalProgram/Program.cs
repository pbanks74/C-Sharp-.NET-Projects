using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedysApprovalProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Greeting
            Console.WriteLine("Speedys Approval Program");
            Console.WriteLine("==========================");
            Console.WriteLine("\nDo you qualify for car insurance?");
            Console.WriteLine("Answer just a few questions to find out...");
            Console.WriteLine("-------------------");

            // Asks user age and saves input in a variable
            Console.WriteLine("\nWhat is your age?");
            string years = Console.ReadLine();
            int _age = Convert.ToInt32(years);

            // Asks user and saves input in a variable
            Console.WriteLine("\nHave you ever had a DUI? Please answer true or false.");
            string party = Console.ReadLine();
            bool _dui = Convert.ToBoolean(party);

            // Asks user and saves input in a variable
            Console.WriteLine("\nHow many speeding tickets have you had in the last 5 years?");
            string fast = Console.ReadLine();
            int _tickets = Convert.ToInt32(fast);

            // Calculates if user qualifies for car insurance
            // Must be over 15 years old, no DUI's and no more than 3 speeding tickets
            bool result = (_age > 15 && _dui == false && _tickets < 4);
            Console.WriteLine("-------------------");
            Console.WriteLine("\nAre you qualified?");
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
