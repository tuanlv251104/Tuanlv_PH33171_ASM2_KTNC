using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asm
{
    public class HIeu2Sos
    {
        public static int Hieu2So(object number1, object number2)
        {
            if (!IsInteger(number1) || !IsInteger(number2))
            {
                throw new ArgumentException("Both inputs must be integers.");
            }

            return (int)number1 - (int)number2;
        }

        public static bool IsInteger(object number)
        {
            return number is int;
        }
    }
}
