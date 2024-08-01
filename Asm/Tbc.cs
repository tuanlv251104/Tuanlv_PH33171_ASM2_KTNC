using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asm
{
    public class Tbc
    {
        public static double TrungBC(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                throw new ArgumentException("Không được để trống và chia cho 0");
            }
            return numbers.Average();
        }
    }
}
