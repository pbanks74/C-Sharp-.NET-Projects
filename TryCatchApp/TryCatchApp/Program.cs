using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // asks the user to input their age
            Console.WriteLine("Please enter your age.");

            // converts user input to int type and saves as a variable
            int userAge = Convert.ToInt32(Console.ReadLine());

            try
            {
                int yearBorn = 2021 - userAge;
                Console.WriteLine("You were born in " + yearBorn);
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter only digits");
            }

            Console.ReadLine();
        }
    }
}
