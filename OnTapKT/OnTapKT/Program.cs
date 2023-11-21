using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTapKT
{
    class Program
    {
        static void Main(string[] args)
        {
            QLSV ds = new QLSV();
            do
            {
                Console.WriteLine("=======MENU======");
                 Console.WriteLine("1.Nhap danh sach sinh vien");
                Console.WriteLine("2.Xuat danh sach");
                Console.WriteLine("3.Tim sinh vien");
                Console.WriteLine("4.Xoa sinh vien");
                Console.WriteLine("0.Thoat");
                Console.WriteLine("Nhap lua chon: ");
                int chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 0:
                        return;
                    case 1:
                        ds.nhapDSSV();
                        break;
                    case 2:
                        ds.xuat();
                        break;
                    case 3:
                        Console.WriteLine("Ma dau la: ");
                        int ma1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ma cuoi la: ");
                        int ma2 = int.Parse(Console.ReadLine());
                        ds.timDSSV(ma1, ma2);
                        break;
                    case 4:
                        Console.WriteLine("Nhap ma sinh vien: ");
                        int ma = int.Parse(Console.ReadLine());
                        ds.xoaSV(ma);
                        break;
                    default:
                        Console.WriteLine("Ban nhap sai");
                        break;
                }
            } while (true) ;
        }
    }
}
