using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asm
{
    public class TimPT
    {
        public static T[] GetElementAtIndex<T>(T[] array, int PhanTu1, int PhanTu2)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            if (PhanTu1 < 0 || PhanTu1 >= array.Length || PhanTu2 < 0 || PhanTu2 >= array.Length)
            {
                throw new IndexOutOfRangeException("Phần tử không có trong mảng");
            }

            return new T[] { array[PhanTu1], array[PhanTu2] };
        }
    }
}
