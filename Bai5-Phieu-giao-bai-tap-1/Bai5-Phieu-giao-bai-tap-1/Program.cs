using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5_Phieu_giao_bai_tap_1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            List<ThisinhA> ds = new List<ThisinhA>();
            do
            {
                Console.WriteLine("=====MENU=====");
                Console.WriteLine("1.Nhap tt 1 thi sinh");
                Console.WriteLine("2.Hien thi danh sach thi sinh");
                Console.WriteLine("3.Hien thi cac sinh vien theo tong diem");
                Console.WriteLine("4.Hien thi cac sinh vien theo dia chi");
                Console.WriteLine("5.Tim kiem theo so bao danh");
                Console.WriteLine("6.Ket thuc");
                Console.WriteLine("Nhap lua chon");
                int chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 6:
                        return;
                    case 1:
                        ThisinhA t = new ThisinhA();
                        t.Input();
                        t.inThongTin();
                        ds.Add(t);
                        break;
                    case 2:
                        foreach (ThisinhA m in ds)
                            m.inThongTin();
                        break;
                    case 3:
                        Console.WriteLine("Nhap tong diem: ");
                        double diem = double.Parse(Console.ReadLine());
                        foreach (ThisinhA ts in ds)
                            if (ts.sum >= diem) ts.inThongTin();
                        break;
                    case 4:
                        Console.WriteLine("Nhap dia chi: ");
                        string dc = Console.ReadLine();
                        foreach (ThisinhA ts in ds)
                            if (ts.diaChi == dc) ts.inThongTin();
                        break;
                    case 5:
                        Console.WriteLine("Nhap sbd: ");
                        int sbd = int.Parse(Console.ReadLine());
                        foreach (ThisinhA ts in ds)
                            if (ts.sbd == sbd) ts.inThongTin();
                        break;
                }
            } while (true);
        }
    }
}
