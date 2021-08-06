using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLoopApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Greeting
            Console.WriteLine("Paul's While Loop");
            Console.WriteLine("==============================");
            Console.WriteLine("\nGuess a number between 1 and 9:");
            int number = Convert.ToInt32(Console.ReadLine());
            bool correctNum = number == 7; //sets value of bool

            do // Do below loop while bool is not true 
            {
                switch (number)
                {
                    case 2:
                        Console.WriteLine("You guessed 2, try again.");
                        Console.WriteLine("Guess a number between 1 and 9:");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 4:
                        Console.WriteLine("You guessed 4, try again.");
                        Console.WriteLine("Guess a number between 1 and 9:");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 6:
                        Console.WriteLine("You guessed 6, try again.");
                        Console.WriteLine("Guess a number between 1 and 9:");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 7:
                        Console.WriteLine("You guessed right, the number was 7, Yay!");
                        correctNum = true;
                        break;
                    default: // default message if bool is not true and above cases do not apply
                        Console.WriteLine("You have guessed incorrectly.");
                        Console.WriteLine("Guess a number between 1 and 9:");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!correctNum); // Do the above loop while the bool variable is not true

            

            // very basic while loop. sets variable at 0
            // iterates through and breaks when greater than 10
            int i = 0;
            while (true)
            {
                Console.WriteLine("i = {0}", i);

                i++;

                if (i > 10)
                    break;
            }

            Console.ReadLine();
        }
    }
}
