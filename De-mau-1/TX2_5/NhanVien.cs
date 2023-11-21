using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TX2_5
{
    public class NhanVien
    {
        public string MaNV { get; set; }
        public string HoTen { get; set; }
        public string GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public int LuongNgay { get; set; }
        public int SoNgay { get; set; }
        public NhanVien(string ma, string ten, string gt, DateTime date, int luong, int ngay)
        {
            this.MaNV = ma;
            this.HoTen = ten;
            this.GioiTinh = gt;
            this.NgaySinh = date;
            this.LuongNgay = luong;
            this.SoNgay = ngay;
        }
        public int TinhLuong()
        {
            if (SoNgay <= 24) return LuongNgay * SoNgay;
            else return (24 + (SoNgay - 24) * 2) * LuongNgay;
        }
    }
}
