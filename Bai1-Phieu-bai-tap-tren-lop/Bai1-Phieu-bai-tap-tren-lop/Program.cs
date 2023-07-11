using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1_Phieu_bai_tap_tren_lop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap n: ");
            int n = int.Parse(Console.ReadLine());
            if (n % 2 == 0) Console.WriteLine("n la so chan");
            else Console.WriteLine("n la so le");
            if (n < 0) Console.WriteLine("n la so am");
            else Console.WriteLine("n la so duong");
            Console.ReadLine();
        }
    }
}
