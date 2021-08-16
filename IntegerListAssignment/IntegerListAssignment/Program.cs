using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerListAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
           try
            {
                // Creates list of integers
                List<int> myIntegers = new List<int>() { 2, 4, 6, 8, 10, 16, 20, 50, 100, 200, 500, 1000 };

                //asks the user for a number
                Console.WriteLine("Please enter a number that we will use in our list to divide by:");
                int userInput = Convert.ToInt32(Console.ReadLine());

                // foreach loop divides each integer in the string by the user input and displays quotient
                foreach (int integer in myIntegers)
                {
                    Console.WriteLine(integer + " divided by " + userInput + " equals " + integer / userInput);
                }
                Console.ReadLine();
            }
            // catches a user error and displays a message
            catch (DivideByZeroException)
            {
                Console.WriteLine("Please do not divide by zero.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Please type a whole number.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
            Console.ReadLine();
        }
    }
}
