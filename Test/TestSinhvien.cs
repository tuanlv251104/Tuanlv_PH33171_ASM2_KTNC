using Asm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class TestSinhvien
    {
        private Sinhvienpoly _sinhvienpoly;
        [SetUp]
        public void Setup()
        {
            _sinhvienpoly = new Sinhvienpoly();
        }
        #region Thêm sinh viên
        [Test]
        public void ThemSinhVien_ThanhCong()
        {
            var sv = new Sinhvien("1", "Nguyen Van A", "CS101", "Cong nghe thong tin", "123456");
            Assert.DoesNotThrow(() => _sinhvienpoly.ThemSinhVien(sv));
        }

        [Test]
        public void ThemSinhVien_CoKyTu_DacBiet()
        {
            var sv = new Sinhvien("2", "Le Thi B", "CS102", "Cong nghe @ thong tin", "654321");
            Assert.Throws<ArgumentException>(() => _sinhvienpoly.ThemSinhVien(sv));
        }

        [Test]
        public void ThemSinhVien_DeTrong_Id()
        {
            var sv = new Sinhvien("", "Le Thi B", "CS102", "Cong nghe thong tin", "654321");
            Assert.Throws<ArgumentException>(() => _sinhvienpoly.ThemSinhVien(sv));
        }

        [Test]
        public void ThemSinhVien_DeTrong_Ten()
        {
            var sv = new Sinhvien("3", "", "CS102", "Cong nghe thong tin", "654321");
            Assert.Throws<ArgumentException>(() => _sinhvienpoly.ThemSinhVien(sv));
        }

        [Test]
        public void ThemSinhVien_DeTrong_MaLop()
        {
            var sv = new Sinhvien("4", "Le Thi B", "", "Cong nghe thong tin", "654321");
            Assert.Throws<ArgumentException>(() => _sinhvienpoly.ThemSinhVien(sv));
        }

        [Test]
        public void ThemSinhVien_DeTrong_TenLop()
        {
            var sv = new Sinhvien("5", "Le Thi B", "CS102", "", "654321");
            Assert.Throws<ArgumentException>(() => _sinhvienpoly.ThemSinhVien(sv));
        }

        [Test]
        public void ThemSinhVien_DeTrong_MaSV()
        {
            var sv = new Sinhvien("6", "Le Thi B", "CS102", "Cong nghe thong tin", "");
            Assert.Throws<ArgumentException>(() => _sinhvienpoly.ThemSinhVien(sv));
        }

        [Test]
        public void ThemSinhVien_ValidStudent_EmptyHoTen_ShouldFail()
        {
            var sv = new Sinhvien("7", "", "CS102", "Cong nghe thong tin", "123456");
            Assert.Throws<ArgumentException>(() => _sinhvienpoly.ThemSinhVien(sv));
        }

        [Test]
        public void ThemSinhVien_ValidStudent_EmptyId_ShouldFail()
        {
            var sv = new Sinhvien("", "Nguyen Van A", "CS101", "Cong nghe thong tin", "123456");
            Assert.Throws<ArgumentException>(() => _sinhvienpoly.ThemSinhVien(sv));
        }

        [Test]
        public void ThemSinhVien_ValidStudent_EmptyMaSv_ShouldFail()
        {
            var sv = new Sinhvien("9", "Nguyen Van A", "CS101", "Cong nghe thong tin", "");
            Assert.Throws<ArgumentException>(() => _sinhvienpoly.ThemSinhVien(sv));
        }

        [Test]
        public void ThemSinhVien_ValidStudent_EmptyTenLop_ShouldFail()
        {
            var sv = new Sinhvien("10", "Nguyen Van A", "CS101", "", "123456");
            Assert.Throws<ArgumentException>(() => _sinhvienpoly.ThemSinhVien(sv));
        }
        #endregion
        #region Tìm Kiếm
        [Test]
        public void TimTheoMaSv_StudentExists_ReturnsStudent()
        {
            var sv = new Sinhvien("1", "Nguyen Van A", "CS101", "Cong nghe thong tin", "123456");
            _sinhvienpoly.ThemSinhVien(sv);

            var result = _sinhvienpoly.TimTheoMaSv("123456");

            Assert.NotNull(result);
            Assert.AreEqual("Nguyen Van A", result.HoTen);
        }

        [Test]
        public void TimTheoMaSv_StudentDoesNotExist_ReturnsNull()
        {
            var result = _sinhvienpoly.TimTheoMaSv("999999");
            Assert.IsNull(result);
        }

        [Test]
        public void TimTheoMaSv_Khong_ThanhCong()
        {
            var result = _sinhvienpoly.TimTheoMaSv(null);
            Assert.IsNull(result);

            result = _sinhvienpoly.TimTheoMaSv(string.Empty);
            Assert.IsNull(result);
        }

        [Test]
        public void TimTheoMaSv_DifferentCase_ReturnsStudent()
        {
            var sv = new Sinhvien("2", "Le Thi B", "CS102", "Cong nghe thong tin", "654321");
            _sinhvienpoly.ThemSinhVien(sv);

            var result = _sinhvienpoly.TimTheoMaSv("654321");

            Assert.NotNull(result);
            Assert.AreEqual("Le Thi B", result.HoTen);
        }

        [Test]
        public void TimTheoMaSv_PartialMatch_ReturnsNull()
        {
            var sv = new Sinhvien("3", "Tran Van C", "CS103", "Cong nghe thong tin", "789012");
            _sinhvienpoly.ThemSinhVien(sv);

            var result = _sinhvienpoly.TimTheoMaSv("789");
            Assert.IsNull(result);
        }
        #endregion
    }
}
