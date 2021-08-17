using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // asks the user to enter a number and assigns input to a variable
            Console.WriteLine("Please enter a number to perform math operations on:");
            int userInput = Convert.ToInt32(Console.ReadLine());

            // instantiates the class and assigns the instance to a variable
            Math math = new Math();
            int result = 0;
            int result2 = 0;
            int result3 = 0;

            // creates a variable for each math operation
            result = math.Add(userInput,10);
            result2 = math.Multiply(userInput, 10);
            result3 = math.Subtract(userInput, 10);

            // prints results of the calculations to screen
            Console.WriteLine(userInput + " plus ten equals " + result);
            Console.WriteLine(userInput + " times ten equals " + result2);
            Console.WriteLine(userInput + " minus ten equals " + result3);

            Console.ReadLine();
        }
        
    }
}
