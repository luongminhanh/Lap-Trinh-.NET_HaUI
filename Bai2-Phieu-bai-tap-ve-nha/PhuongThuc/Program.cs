using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhuongThuc
{
    class Program
    {
        static int SNT(int m)
        {
            if (m < 2) return 0;
            for (int i = 2; i <= Math.Sqrt(m); i++)
                    if (m % i == 0) return 0;
            return 1;
        }
        static void Main(string[] args)
        {
            int[] arr = new int[10000];
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
                arr[i] = int.Parse(Console.ReadLine());
            Console.WriteLine("\nCac so nguyen to trong day la: ");
            for (int i = 0; i < n; i++)
                if (SNT(arr[i]) == 1) Console.Write(arr[i] + " ");
            Console.ReadLine();
        }
    }
}
