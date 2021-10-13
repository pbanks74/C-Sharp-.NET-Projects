using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InputConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // asks the user for a number
            Console.WriteLine("Please enter a number");

            // saves user input to a variable
            string userInput = Console.ReadLine();

            // logs user input to a text file
            File.WriteAllText(@"C:\Basic_C#_Programs\Logs\log.txt", userInput);

            // prints the text file back to the user
            string text = File.ReadAllText("C:\\Basic_C#_Programs\\Logs\\log.txt");
            Console.WriteLine(text);

            Console.ReadLine();
        }
    }
}
