using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // asks the user to enter a number and assigns input to a variable
            Console.WriteLine("Please enter a number to perform math operations on:");
            int userInput = Convert.ToInt32(Console.ReadLine());

            // instantiates the class and assigns the instance to a variable
            Calculator calculator = new Calculator();
            int result1 = 0;
            
            // creates a variable for the math operation
            result1 = calculator.Add(userInput, 10);
            
            // displays anser to the screen
            Console.WriteLine(userInput + " plus ten equals: " + result1);

            Console.WriteLine("Please enter a decimal to perform math operations on:");
            decimal userInput2 = Convert.ToDecimal(Console.ReadLine());
            decimal result2 = 0;
            result2 = (int)calculator.Add(userInput2, .3m);
            Console.WriteLine(userInput2 + " plus three tenths equals: " + result2);

            Console.ReadLine();
        }
    }
}
