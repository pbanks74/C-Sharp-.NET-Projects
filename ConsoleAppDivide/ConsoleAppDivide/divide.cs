using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDivide
{
    
    public class divide
    {
        public divide()
        {

        }
        // Void method that outputs an integer
        // divides the data passed to it by 2
        public int Divide(int a1, int a2 = 2)
        {
            return a1 / a2;
        }
        // method with output parameters
        public int Divide(int b1, out int outParameter, int b2 = 4)
        {
            outParameter = 10;
            return b1 / b2;
        }
        
    }
}
