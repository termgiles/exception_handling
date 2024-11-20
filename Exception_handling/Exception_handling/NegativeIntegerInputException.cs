using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_handling
{
     class NegativeIntegerInputException : Exception
    {

        public NegativeIntegerInputException() : base("You used a negative number.")
        {
        }
    }
}
