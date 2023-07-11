using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Minh Anh 17h30 11/7/2023
namespace CanBacHai
{
    class Program
    {
            static void Main(string[] args)
            {
                Console.WriteLine("Nhap so a va do chinh xac: ");
                double a = double.Parse(Console.ReadLine());
                double esp = double.Parse(Console.ReadLine());
                double x0 = 1.0;
                double xn = (a / x0 + x0) / 2.0;
                while (Math.Abs(xn - x0) > esp)
                {
                    x0 = xn;
                    xn = (a / xn + xn) / 2.0;
                }
                Console.WriteLine($"Can bac 2 cua a la {xn}");
                Console.ReadLine();
            }
        
    }
}
