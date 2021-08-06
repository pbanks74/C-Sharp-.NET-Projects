using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            // Greeting
            Console.WriteLine("Welcome to Package Express.");
            Console.WriteLine("\nPlease follow the instructions below.");
            Console.WriteLine("========================================");
            Console.WriteLine("\nPlease enter the package weight:");
            int pkgWeight = Convert.ToInt32(Console.ReadLine());
            // gives user error message if weight is greater than 50
            if (pkgWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
            }
            // saves user input for width, height and length
            Console.WriteLine("\nPlease enter the package width:");
            int pkgWidth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nPlease enter the package height:");
            int pkgHeight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nPlease enter the package length:");
            int pkgLength = Convert.ToInt32(Console.ReadLine());

            // if dimensions total greater than 50, the error message is displayed
            if (pkgWidth + pkgHeight + pkgLength > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
            }

            // Calculates estimated shipping total
            int product = pkgHeight * pkgWidth * pkgLength;
            int quote = product * pkgWeight / 100;

            // Displays estimated shipping total
            Console.WriteLine("\nYour estimated total for shipping this package is: $" + quote);
            Console.WriteLine("\nThank you!");

            Console.ReadLine();
        }
    }
}
