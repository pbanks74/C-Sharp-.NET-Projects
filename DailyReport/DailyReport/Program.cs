using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReport
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("The Tech Academy"); 
            Console.WriteLine("Student Daily Report");

            //asks student name and saves as a string variable
            Console.WriteLine("\nWhat is your name?");
            string yourName = Console.ReadLine();

            // greets student by name and asks current course while saving it as string variable
            Console.WriteLine("\nHello " + yourName + ", what course are you on?" );
            string currentCourse = Console.ReadLine();
            Console.WriteLine("\nCongrats on making it to " + currentCourse + "!");

            //asks student what page number, must first assign to a string 
            Console.WriteLine("\nWhat page number are you on?");
            string pageNumber = Console.ReadLine();
            Console.WriteLine("\nCongrats on making to page " + pageNumber + "!");
            Console.WriteLine("\nDo you need help with anything? Please answer \"true\" or \"false.\"");

            // converts string to bool
            string help = Console.ReadLine();
            bool needHelp = Convert.ToBoolean(help);
            Console.WriteLine("\nWere there any positive experiences you would like to share? Please give specifics.");
            string positiveExperiences = Console.ReadLine();
            Console.WriteLine("\nIs there any other feedback you would like to provide? Please be specific.");
            string feedback = Console.ReadLine();
            Console.WriteLine("\nHow many hours did you study today?");
            string hoursStudied = Console.ReadLine();
            Console.WriteLine("\nCongrats on studying " + hoursStudied + " hours today, you have completed the Daily Report!");
            Console.ReadLine();
        }
    }
}
