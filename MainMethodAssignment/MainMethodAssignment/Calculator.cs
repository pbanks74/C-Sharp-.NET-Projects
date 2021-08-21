using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    public class Calculator
    {
        public Calculator()
        {
        }
        // method to add integers
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        // method to add decimals
        public decimal Add(decimal d1, decimal d2)
        {
            return Convert.ToInt32(d1 + d2);
        }
        // method to add 2 strings and convert to integers and return the result
        public int Add(string a, string b)
        {
            int number1 = Convert.ToInt32(a);
            int number2 = Convert.ToInt32(b);
            int result = number1 + number2;
            return result;

        }

    }
}
