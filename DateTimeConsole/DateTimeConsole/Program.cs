using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DateTimeConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The current date and time is:");

            //prints the current date and time to the console
            DateTime now = DateTime.Now;  
            Console.WriteLine(now);

            //asks the user for a number
            Console.WriteLine("\n" + "Please enter a number");

            //assigns user input to an int type variable
            int userInput = Convert.ToInt32(Console.ReadLine());

            //adds the users number to the current time
            DateTime futureTime = DateTime.Now.AddHours(userInput);

            //prints future time to the console
            Console.WriteLine("\n" + "In " + userInput + " hours" + " it will be: " + "\n" + futureTime);

            Console.ReadLine();
        }
    }
}
