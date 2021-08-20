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
            // asks the user to enter a number and assigns input to a integer variable
            Console.WriteLine("Please enter a number to perform math operations on:");
            int userInput = Convert.ToInt32(Console.ReadLine());

            // instantiates the class and assigns the instance to a variable
            Calculator calculator = new Calculator();
            int result1 = 0;
            
            // creates a variable for the math operation
            result1 = calculator.Add(userInput, 10);
            
            // displays answer to the screen
            Console.WriteLine(userInput + " plus ten equals: " + result1);

            // asks the user to enter a number and assigns input to a decimal variable
            Console.WriteLine("Please enter a number to perform math operations on:");
            decimal userInput2 = Convert.ToDecimal(Console.ReadLine());

            // creates a variable for the math operation
            decimal result2 = 0;
            result2 = (int)calculator.Add(userInput2, 10);

            // displays answer to the screen
            Console.WriteLine(userInput2 + " plus ten equals: " + result2);

            // asks the user to enter a number and assigns input to a string variable
            Console.WriteLine("Please enter a number to perform math operations on:");
            string userInput3 = Convert.ToString(Console.ReadLine());

            // creates a variable for the math operation
            int result3 = 0;
            result3 = calculator.Add(userInput3, fun);

            // displays answer to the screen
            Console.WriteLine(userInput3 + " plus ten equals " + result3);


            Console.ReadLine();
        }
    }
}
