using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OT1
{
    class Program
    {
        static void Main(string[] args)
        {
            QLSV ds = new QLSV();
            do
            {
                Console.WriteLine("===========MENU=======");
                Console.WriteLine("1.Nhap danh sach sinh vien");
                Console.WriteLine("2.Xuat danh sach");
                Console.WriteLine("3.Tim sinh vien");
                Console.WriteLine("4.Xoa sinh vien");
                Console.WriteLine("0.Thoat");
                Console.WriteLine("Nhap lua chon: ");
                int chon = int.Parse(Console.ReadLine());
            switch (chon)
            {
                case 1:
                        ds.nhapdssv();
                    break;
                case 2:
                        ds.xuatdssv();
                    break;
                case 3:
                        ds.timSV();
                    break;
                case 4:
                        ds.xoaSV();
                    break;
                case 0:
                    return;
                default :
                    Console.WriteLine("Nhap lai!");
                    break;
            }
            } while (true);
        }
    }
}
