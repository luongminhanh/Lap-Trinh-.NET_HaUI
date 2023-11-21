using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OT1
{ 
    class QLSV
    {
        List<SinhVienFPOLY> dssv = new List<SinhVienFPOLY>(10);
        public void nhapdssv()
        {
            string chon;
            do
            {
                //Console.WriteLine("Nhap ma sv: ");
                //int maSV = int.Parse(Console.ReadLine());
                int maSV = layMa();
                Console.WriteLine("Nhap ho ten: ");
                string hoTen = Console.ReadLine();
                Console.WriteLine("Nhap chuyen nganh: ");
                int chuyenNganh = int.Parse(Console.ReadLine());
                SinhVienFPOLY sv = new SinhVienFPOLY(maSV, hoTen, chuyenNganh);
                dssv.Add(sv);
                Console.WriteLine("Ban muon nhap tiep: (y/n)");
                chon = Console.ReadLine();
            } while (chon == "y");
        }
        public void xuatdssv()
        {
            foreach (SinhVienFPOLY sv in dssv)
            {
                sv.inThongTin();
            }
        }
        public void timSV()
        {
            Console.WriteLine("Nhap ma bat dau: ");
            int maDau = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap ma cuoi: ");
            int maCuoi = int.Parse(Console.ReadLine());
            foreach (SinhVienFPOLY sv in dssv)
            {
                if (sv.maSV <= maCuoi && sv.maSV >= maDau)
                    sv.inThongTin();
            }
        }
        public void xoaSV()
        {
            Console.WriteLine("Nhap ma sv muon xoa: ");
            int ma = int.Parse(Console.ReadLine());
            for (int i = 0; i < dssv.Count; i++)
                if (dssv[i].maSV == ma)
                    dssv.RemoveAt(i);
        }
        public int layMa()
        {
            if (dssv.Count == 0) return 1;
            else return dssv.Count + 1;
        }
    }
}
