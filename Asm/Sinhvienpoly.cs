using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Asm
{
    public class Sinhvienpoly
    {
        private List<Sinhvien> sinhviens;

        public Sinhvienpoly()
        {
            sinhviens = new List<Sinhvien>();
        }

        public void ThemSinhVien(Sinhvien sv)
        {
            // Kiểm tra tenlop không chứa ký tự đặc biệt
            if (!Regex.IsMatch(sv.TenLop, @"^[a-zA-Z0-9 ]*$"))
            {
                throw new IndexOutOfRangeException("TenLop không được chứa ký tự đặc biệt.");
            }

            sinhviens.Add(sv);
        }

        public List<Sinhvien> TimTheoTen(string ten)
        {
            return sinhviens.Where(sv => sv.HoTen.ToLower().Contains(ten.ToLower())).ToList();
        }

        public List<Sinhvien> TimTheoMaLop(string maLop)
        {
            return sinhviens.Where(sv => sv.MaLop.ToLower() == maLop.ToLower()).ToList();
        }

        public Sinhvien TimTheoMaSv(string maSv)
        {
            return sinhviens.FirstOrDefault(sv => sv.MaSv.ToLower() == maSv.ToLower());
        }
    }
}
