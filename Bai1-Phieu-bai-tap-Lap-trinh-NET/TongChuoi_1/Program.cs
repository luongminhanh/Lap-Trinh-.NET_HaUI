using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Minh Anh 17h30 11/7/2023
namespace TongChuoi_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so nguyen duong n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int s = 0;
            double s1 = 0.0;
            for (int i = 1; i <= n; i++)
            {
                s += i;
                s1 += (float)1 / (i * 1.0);
            }
            Console.WriteLine($"Tong 1 + 2 + 3 + ... + n =  {s}");
            Console.WriteLine($"Tong 1 + 1/2 + 1/3 +...+ 1/n = {s1}");
            Console.ReadLine();
        }
    }
}
