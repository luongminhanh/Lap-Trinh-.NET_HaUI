using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6_BTVN
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<Courses> courses = new List<Courses>();
                while (true)
                {
                    Console.WriteLine("============MENU==============");
                    Console.WriteLine("1.Thêm 1 khóa học");
                    Console.WriteLine("2. Hiển thị các khóa học");
                    Console.WriteLine("3. Tìm kiếm khóa học");
                    Console.WriteLine("4. Tìm kiếm sinh viên");
                    Console.WriteLine("5. Xóa một khóa học");
                    Console.WriteLine("6.Kết thúc");
                    Console.WriteLine("Nhập vào lựa chọn: ");
                    int chon = int.Parse(Console.ReadLine());
                    switch (chon)
                    {
                        case 1:
                            Courses c = new Courses();
                            c.Input();
                            courses.Add(c);
                            break;
                        case 2:
                            foreach (Courses c1 in courses)
                            {
                                c1.DisplayCourseAndStudents();
                            }
                            break;
                        case 3:
                            Console.WriteLine("Nhap id khoa hoc: ");
                            string Id = Console.ReadLine();
                            bool thay = false;
                            foreach(Courses c1 in courses)
                            {
                                if (c1.courseid == Id)
                                {
                                    thay = true;
                                    c1.DisplayCourseAndStudents();
                                }                                
                            }
                            if (thay == false)
                            {
                                Console.WriteLine("Không tìm thấy khóa học");
                            }
                            break;
                        case 4:
                            Console.WriteLine("Nhập mã sinh viên: ");
                            int Ids = int.Parse(Console.ReadLine());
                            bool thay1 = false;
                            foreach (Courses course in courses)
                            {
                                foreach(Student s in course.li)
                                {
                                    if (s.studentid == Ids)
                                    {
                                        thay1 = true;
                                        course.DisplayCourseAndStudents();
                                        break;
                                    }                                    
                                }
                            }
                            if (thay1 == false) Console.WriteLine("Không tìm thấ sinh viên");
                            break;
                        case 5:
                            Console.WriteLine("Nhap id khoa hoc: ");
                            string Id2 = Console.ReadLine();
                            Courses c3 = new Courses(Id2);
                            int index2 = courses.FindIndex(c4 => c4.courseid == Id2);
                            if (index2 == -1)
                            {
                                Console.WriteLine("Không tìm thấy khóa học");
                            }
                            else
                            {
                                courses.RemoveAt(index2);
                            }
                            break;
                        case 6:
                            return;
                        default:
                            Console.WriteLine("Nhập lại lựa chọn");
                            break;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Eror mesage: {0}", e.Message);
            }
        }
    }
}
