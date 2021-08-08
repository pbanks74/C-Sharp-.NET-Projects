using System;
using System.Collections.Generic;




    class Program
    {
        static void Main(string[] args)
        {
        //============== PART 1 =========================================================

        // Greeting
        Console.WriteLine("Six Part C# Tech Academy Assignment");
        Console.WriteLine("\nBy: Paul Fairbanks, 2021");
        Console.WriteLine("\n=======================================");


        // creates a  one-dimensional array of strings
        string[] namesArray = { "The kayak is ", "The boat is ", "The car is ", "The house is ", "The dog is "};

        // asks the user to input text and saves it as a variable
        Console.WriteLine("Please enter your favorite color:");
        string userColor = Console.ReadLine();

        // a loop that iterates through each string and adds user's input end of each
        for (int p = 0; p < namesArray.Length; p++)
        {
            namesArray[p] += userColor;
        }

        // a loop that prints off each string in the array on a seperate line
        foreach (string p in namesArray)
        {
            Console.WriteLine(p);
        }
        
        // prints namesArray[1] to test if for loop works
        //Console.WriteLine(namesArray[1]);



        Console.ReadLine();
        }
    }

