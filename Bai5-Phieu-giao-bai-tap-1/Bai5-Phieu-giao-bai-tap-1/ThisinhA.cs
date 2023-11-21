using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5_Phieu_giao_bai_tap_1
{
    class ThisinhA
    {
        public int sbd { get; set; }
        public string hoTen { get; set; }
        public string diaChi { get; set; }
        public double toan { get; set; }
        public double ly { get; set; }
        public double hoa { get; set; }
        public double diemUuTien { get; set; }
        public double sum { 
            get 
            { 
                return toan + ly + hoa + diemUuTien; 
            } 
        }

        public void inThongTin()
        {
            Console.WriteLine($"SBD: {sbd}, Ho Ten: {hoTen}, Dia chi: {diaChi}, Toan: {toan}, Ly: {ly}, Hoa: {hoa}, Diem uu tien: {diemUuTien}, TongDiem: {sum}");
        }
        public void Input()
        {
            Console.WriteLine("Nhap sbd: ");
            sbd = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap ho ten: ");
            hoTen =Console.ReadLine();
            Console.WriteLine("Nhap dia chi: ");
            diaChi = Console.ReadLine();
            Console.WriteLine("Nhap diem toan, ly, hoa, diem uu tien: ");
            toan = double.Parse(Console.ReadLine());
            ly = double.Parse(Console.ReadLine());
            hoa = double.Parse(Console.ReadLine());
            diemUuTien = double.Parse(Console.ReadLine());
        }
      
    }
}
