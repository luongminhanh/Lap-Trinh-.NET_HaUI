using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap n: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i<=n; i++)
            {
                if (i % 5 == 0) continue;
                Console.Write(i + " ");
            }
            Console.ReadLine();
        }
    }
}
