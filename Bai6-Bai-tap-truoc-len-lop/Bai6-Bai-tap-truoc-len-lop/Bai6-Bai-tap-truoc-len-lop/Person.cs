using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6_Bai_tap_truoc_len_lop
{
    class Person
    {
        public int id { get; set; }
        public string name { get; set; }
        public string address { get; set; }

        public Person()
        {
            this.id = 0;
            this.name = "";
            this.address = "";
        }

        public Person(int id, string name, string address)
        {
            this.id = id;
            this.name = name;
            this.address = address;
        }
        public void Input()
        {
            Console.WriteLine("Nhap vao id: ");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vao ten: ");
            name = Console.ReadLine();
            Console.WriteLine("Nhap vao dia chi: ");
            address = Console.ReadLine();
        }
        public virtual void Output()
        {
            Console.WriteLine($"id: {id}\tname: {name}\taddress: {address}");
        }
    }
}
