using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnums
{
    class Program
    {
        static void Main(string[] args)
        {
            // prompts user to enter the current day of the week
            Console.WriteLine("Please enter the current day of the week:");

            // assigns user input to a string type variable
            string UserInput = Console.ReadLine();

            // try to parse the enum, if sucessful prints a message to user
            try
            {
                Enum.Parse(typeof(DaysOfTheWeek), UserInput);
                Console.WriteLine("Happy " + UserInput + " !");
            }
            // if unsucessful prints error message to user
            catch
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }
            finally
            {
                Console.ReadLine();
            }

        }

        




        // created enum for the days of the week
        public enum DaysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}
