using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameters
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


            Console.WriteLine("Optional, enter a second number:");

            // trys the second user input, catches if unsucessaful and uses default parameter.
            try
            {
                int userInput2 = Convert.ToInt32(Console.ReadLine());

                // calls the method and passes in the variables
                int result1 = math.Add(userInput, userInput2);

                // displays the results 
                Console.WriteLine(result1);
            }
            catch (FormatException)
            {
                int result1 = math.Add(userInput);
                Console.WriteLine(userInput + " plus ten equals " + result1);
            }
            finally
            {
                Console.ReadLine();
            }
            
        }
    }
}
