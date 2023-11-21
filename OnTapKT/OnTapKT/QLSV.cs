using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTapKT
{
    class QLSV
    {
        List<SinhVienFPOLY> dssv = new List<SinhVienFPOLY>();
        public void nhapDSSV()
        {
            string chon;
            do
            {
                // Console.WriteLine("Ma SV: ");
                // int ma = int.Parse(Console.ReadLine());
                int ma = layMa();
                Console.WriteLine("Ho ten: ");
                string hoTen = Console.ReadLine();
                Console.WriteLine("Chuyen nganh: ");
                int chuyenNganh = int.Parse(Console.ReadLine());
                SinhVienFPOLY sv = new SinhVienFPOLY(ma, hoTen, chuyenNganh);
                dssv.Add(sv);
                Console.WriteLine("Ban muon nhap tiep (y/n)");
                chon = Console.ReadLine();
            } while (chon =="y");
        }
        public void xuat()
        {
            Console.WriteLine("Danh sach sv vua nhap: ");
            foreach (SinhVienFPOLY s in dssv)
            {
                s.inThongTin();
            }    
        }
        public void timDSSV(int ma1, int ma2)
        {
            Console.WriteLine($"Danh sach sv co ma trong khoang {ma1} va {ma2} la: ");
            foreach (SinhVienFPOLY s in dssv)
            {
                if (s.maSV >= ma1 && s.maSV <= ma2) 
                    s.inThongTin();
            }    
        }
        public void xoaSV(int ma)
        {
            bool thay = false;
            for(int i = 0; i<dssv.Count; i++)
                if (dssv[i].maSV == ma)
                {
                    thay = true;
                    dssv.RemoveAt(i);
                }
            if (thay)
            {
                Console.WriteLine("Xoa sv thanh cong");
                xuat();
            }
            else Console.WriteLine("Khong tim thay");
        }
        public int layMa()
        {
            int ma = 0;
            if (dssv.Count == 0) ma = 1;
            else ma = dssv.Count + 1;
            return ma;
        }
    }
}
