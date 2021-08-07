using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // creates 3 basic strings
            string name ="Paul";
            string hobby = "kayaking";
            string animal = "dog";

            // concatenates strings and converts to upper case
            string concatenate = name + " loves " + hobby + " and has a " + animal;
            Console.WriteLine(concatenate.ToUpper());

            //creates a StringBuilder object and appends to create a paragraph
            StringBuilder sb = new StringBuilder();
            sb.Append("\nMy name is Paul ");
            sb.Append("and this is my paragraph built one sentence at a time ");
            sb.Append("utilizing StringBuilder.");
            
            Console.WriteLine(sb);


            Console.ReadLine();
        }
    }
}
