using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai7
{
    class Program
    {
        static int SNT(int m)
        {
            if (m < 2) return 0;
            else for (int i = 2; i<Math.Sqrt(m); i++)
            {
                if (m % i == 0) return 0;
            }
            return 1;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so n: ");
            int n = int.Parse(Console.ReadLine());
            if (SNT(n) == 1) Console.WriteLine("n co la so nguyen to");
            else Console.WriteLine("n khong la so nguyen to");
            Console.ReadLine();
        }
    }
}
