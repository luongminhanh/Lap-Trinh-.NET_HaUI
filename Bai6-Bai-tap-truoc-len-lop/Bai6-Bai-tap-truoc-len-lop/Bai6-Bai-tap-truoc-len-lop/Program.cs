using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6_Bai_tap_truoc_len_lop
{
    class Program
    {
        static List<Student> dssv = new List<Student>();
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("=====MENU=====");
                Console.WriteLine("1.them 1 sinh vien");
                Console.WriteLine("2.Hien thi danh sach sinh vien");
                Console.WriteLine("3.Tim theo id");
                Console.WriteLine("4.Tim kiem sinh vien theo address");
                Console.WriteLine("5.Xoa theo id");
                Console.WriteLine("6.Ket thuc");
                Console.WriteLine("Nhap vao lua chon: ");
                int luachon = int.Parse(Console.ReadLine());
                switch (luachon)
                {
                    case 1:
                        AddStudent();
                        break;
                    case 2:
                        Display();
                        break;
                    case 3:
                        Find();
                        break;
                    case 4:
                        FindByAddress();
                        break;
                    case 5:
                        DeleteById();
                        break;
                    case 6: return;
                }
            }
        }
        public static void AddStudent()
        {
            Student sv = new Student();
            sv.Input();
            dssv.Add(sv);
        }
        public static void Display()
        {
            foreach(Student sv in dssv)
            {
                sv.Output();
            }    
        }
        public static void Find()
        {
            Console.WriteLine("Nhap vao id: ");
            int Id = int.Parse(Console.ReadLine());
            foreach (Student sv in dssv)
            {
                if (sv.id == Id)
                sv.Output();
            }
        }
        public static void FindByAddress()
        {
            Console.WriteLine("Nhap vao dia chi: ");
            string ad = Console.ReadLine();
            foreach (Student sv in dssv)
            {
                if (sv.address == ad)
                    sv.Output();
            }
        }
        public static void DeleteById()
        {
            Console.WriteLine("Nhap vao id: ");
            int Id = int.Parse(Console.ReadLine());
            for (int i = 0; i<dssv.Count; i++)
            {
                if (dssv[i].id == Id)
                    dssv.RemoveAt(i);
            }
        }
    }
}
