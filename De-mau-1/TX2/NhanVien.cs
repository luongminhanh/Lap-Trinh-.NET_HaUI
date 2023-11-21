using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TX2
{
    public class NhanVien
    {
        public string MaNV { get; set; }
        public string HoTen { get; set; }
        public string GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public int LuongNgay { get; set; }
        public int SoNgayLamViec { get; set; }

        public NhanVien(string maNV, string hoTen, string gioiTinh, DateTime ngaySinh, int luongNgay, int soNgayLamViec)
        {
            MaNV = maNV;
            HoTen = hoTen;
            GioiTinh = gioiTinh;
            NgaySinh = ngaySinh;
            LuongNgay = luongNgay;
            SoNgayLamViec = soNgayLamViec;
        }

        public double TinhLuong()
        {
            if (SoNgayLamViec <= 24)
                return SoNgayLamViec * LuongNgay;
            else
                return (24 + (SoNgayLamViec - 24) * 2) * LuongNgay;
        }
    }
}
