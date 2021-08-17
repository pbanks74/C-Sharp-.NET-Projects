using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsConsoleApp
{
    // created new class and made public
    public class Math
    {
        public Math()
        {

        }
        // method to add
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        // method to multiply
        public int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }
        // method to subtract
        public int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }
    }
}
