using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Minh Anh 17h30 11/7/2023
namespace XepLoaiHS_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao ho ten cua hoc sinh: ");
            string HoTen = Console.ReadLine();
            Console.WriteLine("Nhap vao diem cua hoc sinh: ");
            float Diem = Convert.ToSingle(Console.ReadLine());
            Console.Write($"Hoc sinh {HoTen.ToUpper()} co xep loai ");
            if (Diem >= 8)
                Console.Write("Gioi");
            else if (Diem < 8 && Diem >= 6.5)
                Console.Write("Kha");
            else if (Diem < 6.5 && Diem >= 5)
                Console.WriteLine("Trung binh");
            else Console.WriteLine("Yeu");
            Console.ReadLine();
        }
    }
}
