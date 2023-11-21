using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CauTruc
{
    struct HocSinh
    {
        public string HoTen;
        public int Tuoi;
        public bool GioiTinh;
    }

    class Program
    {
        static void Main(string[] args)
        {
            HocSinh[] hs = new HocSinh[5];
            for (int i = 0; i<5; i++)
            {
                Console.WriteLine($"Nhap thong tin hoc sinh thu {i + 1}");
                Console.Write("Ho ten: ");
                hs[i].HoTen = Console.ReadLine();
                Console.Write("Tuoi: ");
                hs[i].Tuoi = int.Parse(Console.ReadLine());
                Console.Write("Gioi tinh: ");
                hs[i].GioiTinh = bool.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Hoc sinh thu {i}: ");
                Console.WriteLine($"Ho ten: {hs[i].HoTen}");
                Console.WriteLine($"Tuoi: {hs[i].Tuoi}");
                Console.WriteLine($"Gioi tinh: {(hs[i].GioiTinh == true ? "Nam" : "Nu")}");
            }
            int tong = 0;
            for (int i = 0; i<5; i++)
            {
                tong += hs[i].Tuoi;
            }
            Console.WriteLine($"Tong so tuoi cua 5 hoc sinh la: {tong}");
            Console.ReadLine();
        }
    }
}
