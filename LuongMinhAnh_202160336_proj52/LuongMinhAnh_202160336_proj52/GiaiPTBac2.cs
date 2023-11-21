using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuongMinhAnh_202160336_proj52
{
    class GiaiPTBac2
    {
        private int _a;
        public int a
        {
            get { return _a; }
            set { _a = value; }
        }
        private int _b;
        public int b
        {
            get { return _b; }
            set { _b = value; }
        }
        private int _c;
        public int c
        {
            get { return _c; }
            set { _c = value; }
        }
        public void Input()
        {
            Console.WriteLine("Nhap cac he so cua pt bac 2: ");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
        }
        public void Output()
        {
            Console.WriteLine($"{a}x^2 + {b}x + {c} = 0");
        }
        public void giai()
        {
            double delta = b * b - 4 * a * c;

            if (delta > 0)
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine($"PT co 2 nghiem pb la x1 = {x1}, x2 = {x2}");
            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine($"PT co nghiem kep la x = {x}");
            }
            else
            {
                Console.WriteLine("PT vo nghiem");
            }
        }
    }
}
