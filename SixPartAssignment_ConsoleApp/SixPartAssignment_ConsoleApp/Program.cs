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


        // Checks to see if the user input matches a color in the list and displays it
        for (int w = 0; w < ColorList.Count; w++)
        {
            if (input == ColorList[w])
            {
                Console.WriteLine(input + " occurs at idex position: " + ColorList.IndexOf(input));
            }
        }



        //============== PART 5 =========================================================

        // A list of strings that has at least two identical strings in the list
        List<string> animalList = new List<string>();

        animalList.Add("dog");
        animalList.Add("cat");
        animalList.Add("bird");
        animalList.Add("dog");
        animalList.Add("rabbit");
        animalList.Add("snake");
        animalList.Add("deer");

        // asks user to enter an animal name
        Console.WriteLine("\nPlease enter an animal name to see if there is a match on the list:");
        string user_input = Console.ReadLine();
        

        // iterates through the animalList and displays if there is a match, if not displays message to user.
        foreach (string animal in animalList)
        {
            if (animalList.Contains(user_input))
            {
                int h = 0;
                while ((h = animalList.IndexOf(user_input, h)) != -1)
                { 
                    Console.WriteLine("index: " + h);
                    h++;
                }
            }
            else
            {
                Console.WriteLine(user_input + " is not on the list");
            }
            break;
        }

        //============== PART 6 =========================================================

        List<string> fruitList = new List<string>();
        List<string> duplicates = new List<string>();

        fruitList.Add("apple");
        fruitList.Add("pear");
        fruitList.Add("banana");
        fruitList.Add("strawberry");
        fruitList.Add("orange");
        fruitList.Add("grape");
        fruitList.Add("lemon");
        fruitList.Add("lime");
        fruitList.Add("pinnapple");
        fruitList.Add("apple");
        fruitList.Add("banana");

        // foreach loop that evaluates each item in the list and adds duplicates to new list
        foreach (var fruit in fruitList)
        {
            if (duplicates.Contains(fruit))
            {
                Console.WriteLine(fruit + " has already been seen");
            }     
            else
            {
                Console.WriteLine(fruit + " has not been seen");
            }
            duplicates.Add(fruit);
        }
        Console.ReadLine();
    }
           
}
