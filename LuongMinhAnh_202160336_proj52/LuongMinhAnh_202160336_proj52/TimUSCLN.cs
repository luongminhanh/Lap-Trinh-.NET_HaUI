using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuongMinhAnh_202160336_proj52
{
    class TimUSCLN
    {
        public int sothu1 { get; set; }
        public int sothu2 { get; set; }
        public void Input()
        {
            Console.WriteLine("Nhap 2 so: ");
            sothu1 = int.Parse(Console.ReadLine());
            sothu2 = int.Parse(Console.ReadLine());
        }
        public int ucln(int sothu1, int sothu2)
        {
            if (sothu2 == 0) return sothu1;
            else return ucln(sothu2, sothu1 % sothu2);
        }
        public void output()
        {
            Console.WriteLine($"s1: {sothu1}, s2: {sothu2}, gcd: {ucln(sothu1, sothu2)}");
        }
    }
}
