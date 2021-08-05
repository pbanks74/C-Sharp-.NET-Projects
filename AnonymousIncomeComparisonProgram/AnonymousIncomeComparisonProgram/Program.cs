using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousIncomeComparisonProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Program greeting
            Console.WriteLine("Anonymous Income Compensation Program");
            Console.WriteLine("======================================");

            // Person 1 info
            Console.WriteLine("\nPerson 1");
            Console.WriteLine("---------");
            Console.WriteLine("Hourly rate?");
            string hourlyRate = Console.ReadLine();
            int hourly_rate = Convert.ToInt32(hourlyRate);
            Console.WriteLine("Hours worked per week?");
            string hoursWkd = Console.ReadLine();
            int hours_wkd = Convert.ToInt32(hoursWkd);

            // Person 2 info
            Console.WriteLine("\nPerson 2");
            Console.WriteLine("---------");
            Console.WriteLine("Hourly rate?");
            string hourlyRate2 = Console.ReadLine();
            int hourly_rate2 = Convert.ToInt32(hourlyRate2);
            Console.WriteLine("Hours worked per week?");
            string hoursWkd2 = Console.ReadLine();
            int hours_wkd2 = Convert.ToInt32(hoursWkd2);

            // uses hourly wage and hours worked to figure annual salary for person1
            int hours_Peryear = 52 * hours_wkd;
            int annual_Salary = hours_Peryear * hourly_rate;
            Console.WriteLine("\n---------");
            Console.WriteLine("Annual salary of Person 1:");
            Console.WriteLine("$" + annual_Salary);

            // uses hourly wage and hours worked to figure annual salary for person2
            int hours_Peryear2 = 52 * hours_wkd2;
            int annual_Salary2 = hours_Peryear2 * hourly_rate2;
            Console.WriteLine("\nAnnual salary of Person 2:");
            Console.WriteLine("$" + annual_Salary2);

            // compares annual salaries
            Console.WriteLine("\nDoes Person 1 make more money than Person 2?");
            bool trueorFalse = annual_Salary > annual_Salary2;
            Console.WriteLine(trueorFalse.ToString());
            Console.ReadLine();
        }
    }
}
