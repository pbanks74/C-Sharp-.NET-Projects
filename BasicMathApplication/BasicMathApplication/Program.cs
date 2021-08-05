using System;

namespace BasicMathApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // Title and greeting
            Console.WriteLine("Basic Math Application");
            Console.WriteLine("Created by: Paul Fairbanks");
            Console.WriteLine("--------------------------");
            Console.WriteLine("\nHello!");

            // Takes user input, multiples by 50 and prints result / Must convert string to Int
            Console.WriteLine("\nPlease enter a random number");
            string number = Console.ReadLine();
            int num1 = Convert.ToInt32(number);
            int product = num1 * 50;
            Console.WriteLine(num1 + " times 50 equals " + product);

            // Takes user input, adds 50 and prints result / Must convert string to Int
            Console.WriteLine("\nPlease enter another number");
            string number2 = Console.ReadLine();
            int num2 = Convert.ToInt32(number2);
            int sum = num2 + 50;
            Console.WriteLine(num2 + " plus fifty equals " + sum);
           
             // Takes user input, divides it by 12.5 and prints result / Must convert string to Int
            Console.WriteLine("\nPlease enter another number");
            string number3 = Console.ReadLine();
            int num3 = Convert.ToInt32(number3);
            double quotient = num3 / 12.5;
            Console.WriteLine(num3 + " divided by 12.5 equals " + quotient);

            // Takes user input, checks if it is greater than 50 and prints true or false / Must convert string to Int
            Console.WriteLine("\nPlease enter another number");
            string number4 = Console.ReadLine();
            int num4 = Convert.ToInt32(number4);
            bool TrueorFalse = num4 > 50;
            Console.WriteLine("Is your number greater than 50? ---- " + TrueorFalse.ToString());

            // Takes user input, divides by 7 and prints remainder
            Console.WriteLine("\nPlease enter another number");
            string number5 = Console.ReadLine();
            int num5 = Convert.ToInt32(number5);
            int remainder = num5 % 7;
            Console.WriteLine(num5 + " divided by 7 has a remainder of " + remainder);
            Console.WriteLine("\nTHE END");
            Console.ReadLine();


        }
    }
}
