using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchApp
{
    public class IntException : Exception
    {
        public IntException()
            : base() { }

        public IntException(string message)
            : base(message) { }
    }

}
