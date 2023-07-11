using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Minh Anh 17h30 11/7/2023
namespace TamGiac_1
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, c;
            do
            {
                Console.WriteLine("Nhap do dai 3 canh tam giac");
                a = Convert.ToSingle(Console.ReadLine());
                b = Convert.ToSingle(Console.ReadLine());
                c = Convert.ToSingle(Console.ReadLine());
            }
            while (a + b < c || a + c < b || b + c < a);
            Double C = (a + b + c);
            Double p = C / 2;
            Double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine($"Chu vi cua tam giac la: {C}\nDien tich cua tam giac la: {S}");
            Console.ReadLine();
        }
    }
}
