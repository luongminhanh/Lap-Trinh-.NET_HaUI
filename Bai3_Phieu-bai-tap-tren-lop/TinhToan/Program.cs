using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhToan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap 2 so thuc a, b va phep toan");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            char pt = char.Parse(Console.ReadLine());
            switch (pt)
            {
                case '+':
                    {
                        Console.WriteLine($"{a} + {b} = {a + b}");
                        break;
                    }
                case '-':
                    {
                        Console.WriteLine($"{a} - {b} = {a - b}");
                        break;
                    }
                case '*':
                    {
                        Console.WriteLine($"{a} * {b} = {a * b}");
                        break;
                    }
                case '/':
                    {
                        Console.WriteLine($"{a} / {b} = {a / b}");
                        break;
                    }
            }
            Console.ReadLine();
        }
    }
}
