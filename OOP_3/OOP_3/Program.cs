using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<NhanVien> ds = new List<NhanVien>();
            do
            {
                Console.WriteLine("===========MENU===========");
                Console.WriteLine("1. Them");
                Console.WriteLine("2. Hien thi danh sach");
                Console.WriteLine("3. Sap xep");
                Console.WriteLine("Nhap vao luac chon: ");
                int chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        NhanVien nv = new NhanVien();
                        nv.nhapThongTin();
                        foreach (NhanVien i in ds)
                        {
                            if (i.maNV == nv.maNV)
                            {
                                Console.WriteLine("Khong duoc trung ma nv");
                                break;
                            }
                        }
                        ds.Add(nv);
                        break;
                    case 2:
                        Console.WriteLine($"{"MaNV", 20}{"HoTen",20}{"DiaChi",20}{"ChucVu",20}{"LuongCB",20}");
                        foreach(NhanVien s in ds)
                        {

                            Console.WriteLine("{0,20}{1,20}{2,20}{3,20}{4,20}{5, 20}", s.maNV, s.hoTen, s.diaChi, s.chucVu, s.luongCB, s.tinhHSL());
                        }
                        break;
                    case 3:
                        //ds = ds.OrderBy(s => s.tinhHSL()).ToList();
                        for (int i = 0; i<ds.Count-1; i++)
                            for (int j = i+1; j<ds.Count; j++)
                            {
                                if (ds[i].tinhHSL() > ds[i].tinhHSL())
                                {
                                    NhanVien v = ds[i];
                                    ds[i] = ds[j];
                                    ds[j] = v;
                                }
                                if (ds[i].tinhHSL() == ds[i].tinhHSL())
                                {
                                    if (ds[i].luongCB > ds[j].luongCB)
                                    {
                                        NhanVien v = ds[i];
                                        ds[i] = ds[j];
                                        ds[j] = v;
                                    }
                                }
                            }
                                
                        break;
                }
            } while (true);
        }
    }
}
