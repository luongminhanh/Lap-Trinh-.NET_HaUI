using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.WriteLine("Nhap vao so nguyen duong: ");
                n = int.Parse(Console.ReadLine());
            } while (n <= 0);
            Console.ReadLine();
        }
    }
}
