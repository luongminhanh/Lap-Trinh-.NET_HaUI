using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4_Bai_tap_tren_lop
{
    class Person
    {
        private string _id;
        public string id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public string email { get; set; }
        public string address { get; set; }

        public void checkAge()
        {
            if (age >= 18) Console.WriteLine("Bạn đủ tuổi bầu cử");
            else Console.WriteLine("Bạn chưa đủ tuổi bầu cử");
        }

        public void Input()
        {
            Console.WriteLine("Nhập id: ");
            id = Console.ReadLine();
            Console.WriteLine("Nhập tên: ");
            name = Console.ReadLine();
            Console.WriteLine("Nhập tuổi: ");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập email: ");
            email = Console.ReadLine();
            Console.WriteLine("Nhập địa chỉ: ");
            address = Console.ReadLine();
        }

        public void Output()
        {
            Console.WriteLine($"{id}\t{name}\t{age}\t{email}\t{address}");
        }
    }
}
