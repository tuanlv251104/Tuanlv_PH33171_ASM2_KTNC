namespace Asm
{
    public class Class1
    {
        #region Tổng 2 số 
        public static int Tong2So(object number1, object number2)
        {
            if (!IsInteger(number1) || !IsInteger(number2))
            {
                throw new ArgumentException("Both inputs must be integers.");
            }

            return (int)number1 + (int)number2;
        }

        public static bool IsInteger(object number)
        {
            return number is int;
        }
        #endregion
        
    }
}