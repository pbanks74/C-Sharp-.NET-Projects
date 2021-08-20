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
            return Decimal.ToInt32(d1 + d2);
        }
        
    }
}
