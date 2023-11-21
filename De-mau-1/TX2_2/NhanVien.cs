using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TX2_2
{
    public class NhanVien
    {
        public string MaNV { get; set; }
        public string HoTen { get; set; }
        public string GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public int LuongNgay { get; set; }
        public int SoNgay { get; set; }
        public NhanVien(string ma, string ten, string gt, DateTime ngay, int luong, int songay)
        {
            this.MaNV = ma;
            this.HoTen = ten;
            this.GioiTinh = gt;
            this.NgaySinh = ngay;
            this.LuongNgay = luong;
            this.SoNgay = songay;
        }
        public int TinhLuong()
        {
            if (SoNgay <= 24) return LuongNgay * SoNgay;
            else return (24 + (SoNgay - 24) * 2) * LuongNgay;
        }
    }
}
