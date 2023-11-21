using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class NhanVien
    {
        public string MaNV { get; set; }
        public string HoTen { get; set; }
        public string GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public int LuongNgay { get; set; }
        public int SoNgay { get; set; }
        public int TienLuong { get; set; }
        public NhanVien(string ma, string ten, string gt, DateTime date, int luong, int ngay, int tien)
        {
            this.MaNV = ma;
            this.HoTen = ten;
            this.GioiTinh = gt;
            this.NgaySinh = date;
            this.LuongNgay = luong;
            this.SoNgay = ngay;
            this.TienLuong = TinhLuong();
        }
        public int TinhLuong()
        {
            if (SoNgay <= 24) return SoNgay * LuongNgay;
            else return (24 + (SoNgay - 24) * 2) * LuongNgay;
        }
    }
}
