using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethod_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiates the class
            Math math = new Math();

            // asks the user to input a number and saves as a variable
            Console.WriteLine("Please enter a number:");
            int userInput = Convert.ToInt32(Console.ReadLine());

            //asks the user to enter a second number and saves as a variable
            Console.WriteLine("Please enter a second number:");
            int userInput2 = Convert.ToInt32(Console.ReadLine());

            // calls the method and passes in the variables
            int result1 = math.Add(userInput, userInput2);

            // displays the results of the math operation
            Console.WriteLine("The first number plus one equals " + result1);
            // displays the second integer to the screen
            Console.WriteLine("The second number is " + userInput2);

            Console.ReadLine();

        }
    }
}
