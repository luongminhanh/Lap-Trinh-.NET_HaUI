using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaiThua
{
    class Program
    {
        static long giaithua(int m)
        {
            if (m == 0) return 1;
            else return giaithua(m - 1) * m;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so nguyen duong: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"{n}! = {giaithua(n)}");
            Console.ReadLine();
        }
    }
}
