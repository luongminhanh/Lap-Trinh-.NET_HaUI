using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao bac luong, ngay cong, phu cap: ");
            int BacLuong = int.Parse(Console.ReadLine());
            int NgayCong = int.Parse(Console.ReadLine());
            float PhuCap = float.Parse(Console.ReadLine());
            int NCTL = NgayCong < 25 ? NgayCong : (25 + (NgayCong - 25) * 2);
            float TienLinh = BacLuong * 1490000 * NCTL + PhuCap;
            Console.WriteLine($"Tien luong thuc linh la {TienLinh:F3}");
            Console.ReadLine();
        }
    }
}
