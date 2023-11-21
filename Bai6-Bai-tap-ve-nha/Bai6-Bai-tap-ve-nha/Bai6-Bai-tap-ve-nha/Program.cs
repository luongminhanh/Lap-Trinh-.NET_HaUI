using System;
using System.Collections.Generic;


namespace Bai6_Bai_tap_ve_nha
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Course> courses = new List<Course>();
            while (true)
            {
                Console.WriteLine("=========MENU==========");
                Console.WriteLine("1. Them 1 khoa hoc");
                Console.WriteLine("2. Hien thi danh sach khoa hoc");
                Console.WriteLine("3. Tim kiem khoa hoc");
                Console.WriteLine("4. Tim kiem sinh vien");
                Console.WriteLine("5. Xoa 1 khoa hoc");
                Console.WriteLine("6. Ket thuc chuong trinh");
                Console.WriteLine("Nhap vao lua chon: ");
                int chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        Course c = new Course();
                        c.InputCourse();
                        courses.Add(c);
                        break;
                    case 2:
                        foreach (Course course in courses)
                            course.DisplayCourseAndStudents();
                        break;
                    case 3:
                        Console.WriteLine("Nhap vao id cua khoa hoc: ");
                        string ID = Console.ReadLine();
                        //int index = courses.FindIndex(c => c.courseId == ID);
                        Course n1 = new Course(ID);
                        int index = courses.IndexOf(n1);
                        if (index != -1)
                        {
                            courses[index].DisplayCourseAndStudents();
                        }
                        else
                        {
                            Console.WriteLine("Khong tim thay khoa hoc");
                        }
                           

                        break;          
                    case 4:
                        Console.WriteLine("Nhap vao ma sinh vien: ");
                        string id = Console.ReadLine();
                        int index1 = courses.FindIndex(c => c.listStd.FindIndex(s => s.studentid == id) != -1);
                        if (index1 != -1)
                        {
                            int index2 = courses[index1].listStd.FindIndex(s => s.studentid == id);
                            courses[index1].listStd[index2].Output();
                        }
                        else
                        {
                            Console.WriteLine("Khong tim thay sinh vien");
                        }
                        break;
                    case 5:
                        Console.WriteLine("Nhap vao id cua khoa hoc: ");
                        string ID1 = Console.ReadLine();
                        int indexRemove = courses.FindIndex(s => s.courseId == ID1);
                        courses.RemoveAt(indexRemove);
                        break;
                    case 6:
                        return;
                    default:
                        Console.WriteLine("Ban nhap sai!");
                        break;
                }
            }
        }
    }
}
