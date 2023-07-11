using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap do dai 2 canh cua HCN");
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine($"Chu vi cua HCN la {(a + b) * 2}");
            Console.WriteLine($"Dien tich cua HCN la {a * b}");
            Console.ReadLine();
        }
    }
}
