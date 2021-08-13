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



        //============== PART 2 =========================================================

        // created indefinate loop 
        int z = 0;
        while (true)
        {
            Console.WriteLine("z = {0}", z);

            z++;

            // created break to stop the loop at i = 10
            if (z > 10)
                break;
        }



        //============== PART 3 =========================================================

        // created loop that uses "<"
        int i = 0;
        while (true)
        {
            Console.WriteLine("i = {0}", i);

            i++;

            // created break to stop the loop at i = 10
            if (i > 10)
                break;
        }

        // created loop that uses "<="
        int x = 1;

        // Exit when x becomes greater than 6
        while (x <= 6)
        {
            Console.WriteLine("This is my loop using less than or equal to operator");
            
                x++;
        }



        //============== PART 4 =========================================================
        
        List<string> ColorList = new List<string>();
        ColorList.Add("green");
        ColorList.Add("blue");
        ColorList.Add("yellow");
        ColorList.Add("orange");
        ColorList.Add("brown");
        ColorList.Add("black");
        ColorList.Add("red");
        ColorList.Add("pink");
        ColorList.Add("white");

        Console.WriteLine("\nPlease enter a color to see if there is a match on the list:");
        string input = Console.ReadLine();

        for (int z = 0; z < ColorList.Count; z++)
        {
            if (input == color)
            {
                Console.WriteLine("Yes " + color + " is on the list!");
            }
            else
            {
                Console.WriteLine("Sorry " + input + " is not on the list.");
            }
        }



        //============== PART 5 =========================================================

        

        //============== PART 6 =========================================================


        Console.ReadLine();
        }
    }

