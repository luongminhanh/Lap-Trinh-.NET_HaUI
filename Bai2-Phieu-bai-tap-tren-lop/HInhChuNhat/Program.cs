using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HInhChuNhat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap chieu dai: ");
            Double Dai = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhap chieu rong: ");
            Double Rong = Convert.ToDouble(Console.ReadLine());
            Double C = (Dai + Rong) * 2;
            Double S = Dai * Rong;
            Console.WriteLine($"Chu vi HCN la: {C}");
            Console.WriteLine($"Dien tich HCN la: {S}");
            Console.ReadLine();
        }
    }
}
