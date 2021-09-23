using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDivide
{
    // declared class as static *prevents the class from being instantiated*
    static class Program
    {
        static void Main(string[] args)
        {
            // instantiates the class
            divide divide = new divide();

            // asks the user to input a number and saves as a variable
            Console.WriteLine("Please enter a number:");
            int userInput = Convert.ToInt32(Console.ReadLine());

            // calls the method and passes in the variable
            int result1 = divide.Divide(userInput);

            // displays the results of the math operation
            Console.WriteLine(userInput + " divided by two equals " + result1);

            Console.ReadLine();
        }
    }
}
