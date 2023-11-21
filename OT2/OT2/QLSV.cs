using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OT2
{
    class QLSV
    {
        List<SinhVienFPOLY> dssv = new List<SinhVienFPOLY>();

        public void nhap()
        {
            string chon;
            do
            {
                //Console.WriteLine("Nhap vao ma sinh vien: ");
                //int ma = int.Parse(Console.ReadLine());
                int ma = layMa();
                Console.WriteLine("Nhap vao ho ten sinh vien: ");
                string ten = Console.ReadLine();
                Console.WriteLine("Nhap vao chuyen nganh: ");
                int cn = int.Parse(Console.ReadLine());
                SinhVienFPOLY sv = new SinhVienFPOLY(ma, ten, cn);
                dssv.Add(sv);
                Console.WriteLine("Ban co muon nhap tiep không (y/n): ");
                chon = Console.ReadLine();
            } while (chon == "y");
        }

        public void xuat()
        {
            foreach(SinhVienFPOLY s in dssv)
            {
                s.inThongTin();
            }
        }

        public void tim()
        {
            Console.WriteLine("Nhap ma dau va ma cuoi: ");
            int dau = int.Parse(Console.ReadLine());
            int cuoi = int.Parse(Console.ReadLine());
            int dem = 0;
            foreach (SinhVienFPOLY s in dssv)
            {
                if (s.maSV >= dau && s.maSV <= cuoi)
                {
                    s.inThongTin();
                    dem++;
                }   
            }
            if (dem == 0) Console.WriteLine("Khong co sinh vien nao trong khoang ma nay");
        }

        public void xoa()
        {
            bool thay = false;
            Console.WriteLine("Nhap ma sv muon xoa: ");
            int ma = int.Parse(Console.ReadLine());
            for (int i = 0; i<dssv.Count; i++)
                if (dssv[i].maSV == ma)
                {
                    thay = true;
                    dssv.RemoveAt(i);
                }
            if (thay == false)
                Console.WriteLine("Khong co sinh vien nay");
            else Console.WriteLine("Xoa thanh cong");
        }

        public int layMa()
        {
            if (dssv.Count == 0) return 1;
            else return dssv.Count + 1;
        }
    }
}
