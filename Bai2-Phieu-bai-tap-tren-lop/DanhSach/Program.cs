using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanhSach
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
            List<int> list = new List<int>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
                list.Add(int.Parse(Console.ReadLine()));
            Console.WriteLine("Cac so chan trong day la: ");
            for (int i = 0; i < n; i++)
                if (list[i] % 2 == 0) Console.Write(list[i] + " ");
            Console.WriteLine("\nCac so le trong day la: ");
            for (int i = 0; i < n; i++)
                if (list[i] % 2 != 0) Console.Write(list[i] + " ");
            Console.WriteLine("\nCac so nguyen to trong day la: ");
            for (int i = 0; i < n; i++)
                if (SNT(list[i]) == 1) Console.Write(list[i] + " ");
            Console.ReadLine();
        }
    }
}
