using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asm
{
    public class Tich2Socs
    {
        #region Tích 2 số 
        public static int Tich2So(object number1, object number2)
        {
            if (!IsInteger(number1) || !IsInteger(number2))
            {
                throw new ArgumentException("Số không phải là số nguyên");
            }

            return (int)number1 * (int)number2;
        }

        public static bool IsInteger(object number)
        {
            return number is int;
        }
        #endregion
    }
}
