using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OT2
{
    class Program
    {
        static void Main(string[] args)
        {
            QLSV ds = new QLSV();
            int chon;           
            do
            {
                Console.WriteLine("=====MENU=====");
                Console.WriteLine("1.Nhap dssv");
                Console.WriteLine("2.Xuat dssv");
                Console.WriteLine("3.Tim sv");
                Console.WriteLine("4.Xoa sv");
                Console.WriteLine("0.Thoat");
                Console.WriteLine("Nhap vao lua chon: ");
                chon = int.Parse(Console.ReadLine());

                switch (chon)
                {
                    case 1:
                        ds.nhap();  
                        break;
                    case 2:
                        ds.xuat();
                        break;
                    case 3:
                        ds.tim();
                        break;
                    case 4:
                        ds.xoa();
                        break;                            ;
                    default:
                        Console.WriteLine("Nhap lai");
                        break;
                }
            } while (true);
        }
    }
}
