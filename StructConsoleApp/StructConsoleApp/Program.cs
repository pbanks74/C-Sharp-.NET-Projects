using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // creates instance and assigns its property
            Number num1;
            num1.Amount = 100.5m;

            //prints to console
            Console.WriteLine(num1.Amount);

            Console.ReadLine();
        }
        // creates a struct and assigns it a property
        struct Number
        {
            public decimal Amount;
        }
    }
}
