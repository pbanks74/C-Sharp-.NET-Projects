using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameters
{
    public class Math
    {
        public Math()
        {

        }
        // method that takes in optional parameters
        public int Add(int num1, int num2 = 10)
        {
            return num1 + num2;
        }
    }
}
