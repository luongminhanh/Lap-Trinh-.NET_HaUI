using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Minh Anh 6h 11/7/2023
namespace PSRutGon
{
    class Program
    {
        static int UCLN(int a, int b)
        {
            if (b == 0) return a;
            return UCLN(b, a % b);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap 2 so m va n: ");
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            if (m % n == 0) Console.WriteLine($"Phan so rut gon {m}/{n} = {m / n}");
            else Console.WriteLine($"Phan so rut gon {m}/{n} = {m / UCLN(m, n)}/{n / UCLN(m, n)}");
            Console.ReadLine();
        }
    }
}
