using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mang
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so phan tu cua mang va cac phan tu mang: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[1000];
            for (int i = 0; i < n; i++)
                a[i] = int.Parse(Console.ReadLine());
            int max = int.MinValue;
            int min = int.MaxValue;
            int tong = 0;
            for (int i = 0; i<n; i++)
            {
                if (min > a[i]) min = a[i];
                if (max < a[i]) max = a[i];
                tong += a[i];
            }
            Console.WriteLine($"Min: {min}\nMax: {max}\nTong: {tong}");
            Console.ReadLine();
        }
    }
}
