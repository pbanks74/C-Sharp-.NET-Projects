using System;
using System.Collections.Generic;




    class Program
    {
        static void Main()
        {
        Console.WriteLine("Welcome to my Array of things");
        Console.WriteLine("=====================================");

        // Created an array of strings that allows user input to determine which string to display
        string[] Array = { "Paul", "Jen", "Tom", "Ron", "Isabella", "Porter", "Juliana" };
        Console.WriteLine("\nPlease choose a number between 0 and 6 to display a random string name from the array");
        int index = Convert.ToInt32(Console.ReadLine());

        //creates a message if user selects inex that does not exist
        if (index < 7)
        {
            Console.WriteLine(Array[index]);
        }
        else
        {
            Console.WriteLine("That index number does not exist");
        }
           
        // created basic array of integers that allows user input to determine which integer to display
        int[] numArray = { 3, 5, 7, 9, 12, 16, 21, 25, 36 };
        Console.WriteLine("\nPlease choose another number between 0 and 8 to display a random integer from the array");
        int index2 = Convert.ToInt32(Console.ReadLine());

        // creates a message if user selects index that does not exist
        if (index2 < 9)
        {
            Console.WriteLine(numArray[index2]);
        }
        else
        {
            Console.WriteLine("That index number does not exist");
        }

        //creates a list of strings and allows the user to choose the idex to display
        List<string> myList = new List<string>();
        myList.Add("Blue");
        myList.Add("Green");
        myList.Add("Yellow");
        myList.Add("Orange");
        myList.Add("Brown");
        myList.Add("Pink");
        myList.Add("Red");
        Console.WriteLine("\nPlease choose a number between 0 and 6 to display a random color from the list");
        int color = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(myList[color]);

        // Thanks
        Console.WriteLine("\n======================================");
        Console.WriteLine("\nThanks for Playing!");

        Console.ReadLine();
       
        }
    }
