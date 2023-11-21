using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6_Bai_tap_ve_nha
{
    class Student
    {
        public string studentid { get; set; }
        public string name { get; set; }
        public string mark { get; set; }
        public override string ToString()
        {
            var s = String.Format($"{0,-8}{1,-10}{2,-25}", studentid, name, mark);
            return s;
        }
        public void InputStudent()
        {
            Console.WriteLine("Nhap id: ");
            studentid = Console.ReadLine();
            Console.WriteLine("Nhap name: ");
            name = Console.ReadLine();
            Console.WriteLine("Nhap mark: ");
            mark = Console.ReadLine();
        }

        public void Output()
        {
            Console.WriteLine($"id: {studentid}\tname: {name}\tmark: {mark}");
        }
    }
}
