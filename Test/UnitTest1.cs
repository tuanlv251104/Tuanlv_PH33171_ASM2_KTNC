using Asm;
using System.Runtime.Intrinsics.X86;

namespace Test
{
    public class Tests
    {
        Class1 _TinhTong;
        [SetUp]
        public void Setup()
        {
            _TinhTong = new Class1();
        }
        #region Tổng 2 số
        [Test]
        public void Tong2SoDuong()
        {
            object number1 = 10;
            object number2 = 5;
            int result = Class1.Tong2So(number1, number2);
            Assert.AreEqual(15, result);
        }

        [Test]
        public void Tong_2_SoAm()
        {
            object number1 = -10;
            object number2 = -5;
            int result = Class1.Tong2So(number1, number2);
            Assert.AreEqual(-15, result);
        }

        [Test]
        public void Tong2So_DuongVaAm()
        {
            object number1 = 10;
            object number2 = -5;
            int result = Class1.Tong2So(number1, number2);
            Assert.AreEqual(5, result);
        }

        [Test]
        public void Tong2So_AmVaDuong()
        {
            object number1 = -10;
            object number2 = 5;
            int result = Class1.Tong2So(number1, number2);
            Assert.AreEqual(-5, result);
        }

        [Test]
        public void Tong2So_GiongNhau()
        {
            object number1 = 5;
            object number2 = 5;
            int result = Class1.Tong2So(number1, number2);
            Assert.AreEqual(10, result);
        }

        [Test]
        public void Tong0_VoiSoduong()
        {
            object number1 = 0;
            object number2 = 5;
            int result = Class1.Tong2So(number1, number2);
            Assert.AreEqual(5, result);
        }


        [Test]
        public void Tong2So_SoAmNho()
        {
            object number1 = -1;
            object number2 = -2;
            int result = Class1.Tong2So(number1, number2);
            Assert.AreEqual(-3, result);
        }

        [Test]
        public void CalculateDifference_WithNonIntegerInput_ThrowsArgumentException()
        {
            object number1 = 5;
            object number2 = "5";
            Assert.Throws<ArgumentException>(() => Class1.Tong2So(number1, number2), "Both inputs must be integers.");
        }

        [Test]
        public void KiemTraDungSoNguyen()
        {
            object number = 5;
            bool result = Class1.IsInteger(number);
            Assert.IsTrue(result);
        }

        [Test]
        public void KiemTrakhongDungSoNguyen()
        {
            object number = "5";
            bool result = Class1.IsInteger(number);
            Assert.IsFalse(result);
        }
        #endregion
        #region Tích 2 số
        [Test]
        public void Test_Tich2_SoDuong()
        {
            Assert.AreEqual(6, Tich2Socs.Tich2So(2, 3));
        }

        [Test]
        public void Test_Tich2_SoAm()
        {
            Assert.AreEqual(6, Tich2Socs.Tich2So(-2, -3));
        }

        [Test]
        public void TestOnePositiveOneNegative()
        {
            Assert.AreEqual(-6, Tich2Socs.Tich2So(2, -3));
        }

        [Test]
        public void TestOneNegativeOnePositive()
        {
            Assert.AreEqual(-6, Tich2Socs.Tich2So(-2, 3));
        }

        [Test]
        public void TestZeroAndPositive()
        {
            Assert.AreEqual(0, Tich2Socs.Tich2So(0, 3));
        }

        [Test]
        public void TestZeroAndNegative()
        {
            Assert.AreEqual(0, Tich2Socs.Tich2So(0, -3));
        }

        [Test]
        public void TestBothZero()
        {
            Assert.AreEqual(0, Tich2Socs.Tich2So(0, 0));
        }

        [Test]
        public void Test_TichsSo_Khac()
        {
            Assert.AreEqual(2.5, Tich2Socs.Tich2So(2.5, 1));
        }

        [Test]
        public void TestLargeAndSmallNumber()
        {
            Assert.AreEqual(100000, Tich2Socs.Tich2So(100000, 1));
        }

        [Test]
        public void TestNonIntegerInput()
        {
            Assert.False(Tich2Socs.IsInteger(2.5));
            Assert.False(Tich2Socs.IsInteger("5"));
            Assert.False(Tich2Socs.IsInteger('c'));
        }
        #endregion
        #region Hiệu 2 số
        [Test]
        public void Hieu2SoDuong()
        {
            object number1 = 10;
            object number2 = 5;
            int result = HIeu2Sos.Hieu2So(number1, number2);
            Assert.AreEqual(5, result);
        }

        [Test]
        public void Hieu_2_SoAm()
        {
            object number1 = -10;
            object number2 = -5;
            int result = HIeu2Sos.Hieu2So(number1, number2);
            Assert.AreEqual(-5, result);
        }

        [Test]
        public void Hieu2So_DuongVaAm()
        {
            object number1 = 10;
            object number2 = -5;
            int result = HIeu2Sos.Hieu2So(number1, number2);
            Assert.AreEqual(15, result);
        }

        [Test]
        public void Hieu2So_AmVaDuong()
        {
            object number1 = -10;
            object number2 = 5;
            int result = HIeu2Sos.Hieu2So(number1, number2);
            Assert.AreEqual(-15, result);
        }

        [Test]
        public void Hieu2So_GiongNhau()
        {
            object number1 = 5;
            object number2 = 5;
            int result = HIeu2Sos.Hieu2So(number1, number2);
            Assert.AreEqual(0, result);
        }

        [Test]
        public void Hieu0_VoiSoduong()
        {
            object number1 = 0;
            object number2 = 5;
            int result = HIeu2Sos.Hieu2So(number1, number2);
            Assert.AreEqual(-5, result);
        }


        [Test]
        public void Hieu2So_SoAmNho()
        {
            object number1 = -1;
            object number2 = -2;
            int result = HIeu2Sos.Hieu2So(number1, number2);
            Assert.AreEqual(1, result);
        }

        [Test]
        public void Hieu_WithNonIntegerInput_ThrowsArgumentException()
        {
            object number1 = 5;
            object number2 = "5";
            Assert.Throws<ArgumentException>(() => HIeu2Sos.Hieu2So(number1, number2), "Both inputs must be integers.");
        }

        [Test]
        public void KiemTraSoNguyen()
        {
            object number = 5;
            bool result = HIeu2Sos.IsInteger(number);
            Assert.IsTrue(result);
        }

        [Test]
        public void KiemTrakhongSoNguyen()
        {
            object number = "5";
            bool result = HIeu2Sos.IsInteger(number);
            Assert.IsFalse(result);
        }
        #endregion
        #region Trung bình cộng
        [Test]
        public void MangSoNguyen()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            double result = Tbc.TrungBC(numbers);
            Assert.AreEqual(3.0, result);
        }

        [Test]
        public void CalculateAverage_WithNegativeNumbers_ReturnsCorrectAverage()
        {
            int[] numbers = { -1, -2, -3, -4, -5 };
            double result = Tbc.TrungBC(numbers);
            Assert.AreEqual(-3.0, result);
        }

        [Test]
        public void MangSoAm()
        {
            int[] numbers = { -1, 2, -3, 4, -5 };
            double result = Tbc.TrungBC(numbers);
            Assert.AreEqual(-0.6, result);
        }

        [Test]
        public void MangAm_Duong()
        {
            int[] numbers = { 5, 5, 5, 5, 5 };
            double result = Tbc.TrungBC(numbers);
            Assert.AreEqual(5.0, result);
        }

        [Test]
        public void MangCoSoLon()
        {
            int[] numbers = { 1000000, 2000000, 3000000, 4000000, 5000000 };
            double result = Tbc.TrungBC(numbers);
            Assert.AreEqual(3000000.0, result);
        }

        [Test]
        public void MangCoSoPhanTuChan()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6 };
            double result = Tbc.TrungBC(numbers);
            Assert.AreEqual(3.5, result);
        }

        [Test]
        public void MangCo1PhanTu()
        {
            int[] numbers = { 10 };
            double result = Tbc.TrungBC(numbers);
            Assert.AreEqual(10.0, result);
        }

        [Test]
        public void MangCoCacPhanTuLa_0()
        {
            int[] numbers = { 0, 0, 0, 0, 0 };
            double result = Tbc.TrungBC(numbers);
            Assert.AreEqual(0.0, result);
        }

        [Test]
        public void MangCoSoThapPhan()
        {
            int[] numbers = { 1, 2, 3, 4, 6 };  // Average should be 3.2
            double result = Tbc.TrungBC(numbers);
            Assert.AreEqual(3.2, result);
        }

        [Test]
        public void Mang_Rong()
        {
            int[] numbers = { };
            double result = Tbc.TrungBC(numbers);
            Assert.AreEqual(3.2, result);
        }
        #endregion
        #region Tìm phần tử trong mảng
        [Test]
        public void Tim_2So_TrongMang()
        {
            int[] array = { 1, 2, 3, 4, 5 };
            int[] result = TimPT.GetElementAtIndex(array, 1, 3);
            Assert.AreEqual(new int[] { 2, 4 }, result);
        }
        [Test]
        public void Tim_2Chu_TrongMang()
        {
            string[] array = { "a", "b", "c", "d", "e" };
            string[] result = TimPT.GetElementAtIndex(array, 0, 4);
            Assert.AreEqual(new string[] { "a", "e" }, result);
        }
        [Test]
        public void Tim_2PhanTu_GiongNhau_TrongMang()
        {
            string[] array = { "x", "y", "z", "w" };
            string[] result = TimPT.GetElementAtIndex(array, 2, 2);
            Assert.AreEqual(new string[] { "z", "z" }, result);
        }
        [Test]
        public void Test_GetElementAtIndex_IndexOutOfRange()
        {
            int[] array = { 1, 2, 3, 7, 9, 11 };
            int[] result = TimPT.GetElementAtIndex(array, 2, 2);
            Assert.AreEqual(new int[] { 3, 3 }, result);
        }

        [Test]
        public void Test_MangRong()
        {
            int[] array = { };
            int[] result = TimPT.GetElementAtIndex(array, 2, 2);
            Assert.AreEqual(new int[] { 3, 3 }, result);
        }

        [Test]
        public void Test_PhanTuKhong_CoTrongMang()
        {
            int[] array = { 1, 2, 3 };
            int[] result = TimPT.GetElementAtIndex(array, 4, 5);
            Assert.AreEqual(new int[] { 3, 3 }, result); ;
        }

        [Test]
        public void Test_GetElementAtIndex_LargeIndices()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] result = TimPT.GetElementAtIndex(array, 8, 9);
            Assert.AreEqual(new int[] { 9, 10 }, result);
        }

        [Test]
        public void Test_MangCoChu()
        {
            string[] array = { "hello", "world" };
            string[] result = TimPT.GetElementAtIndex(array, 0, 0);
            Assert.AreEqual(new string[] { "hello", "hello" }, result);
        }

        [Test]
        public void Test_GetElementAtIndex_ReversedIndices()
        {
            int[] array = { 1, 2, 3, 4, 5 };
            int[] result = TimPT.GetElementAtIndex(array, 3, 1);
            Assert.AreEqual(new int[] { 4, 2 }, result);
        }

        [Test]
        public void Test_Mang_CoSoThapPhan()
        {
            double[] array = { 1.1, 2.2, 3.3, 4.4 };
            double[] result = TimPT.GetElementAtIndex(array, 1, 2);
            Assert.AreEqual(new double[] { 2.2, 3.3 }, result);
        }
        #endregion
    }
}