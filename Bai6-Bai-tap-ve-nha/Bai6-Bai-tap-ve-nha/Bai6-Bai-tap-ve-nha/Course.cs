using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6_Bai_tap_ve_nha
{
    class Course
    {
        public string courseId { get; set; }
        public string courseName { get; set; }
        public int fee { get; set; }
        public List<Student> listStd;
        public Course()
        {
            listStd = new List<Student>();
        }
        public Course(string id)
        {
            this.courseId = id;
        }
        public void InputCourse()
        {
            Console.WriteLine("Nhap courseId: ");
            courseId = Console.ReadLine();
            Console.WriteLine("Nhap courseName: ");
            courseName = Console.ReadLine();
            Console.WriteLine("Nhap fee: ");
            fee = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhap so student: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i<n; i++)
            {
                Student s = new Student();
                s.InputStudent();
                listStd.Add(s);
            }
            /*string chon;
            do
            {
                Student s = new Student();
                s.InputStudent();
                listStd.Add(s);
                Console.WriteLine("Nhap tiep: (y/n)");
                chon = Console.ReadLine();
            } while (chon == "y")*/
        }

        public void DisplayCourseAndStudents()
        {
            Console.WriteLine($"courseId: {courseId}\tcourseName: {courseName}\tfee: {fee}");
            foreach (Student s in listStd)
                s.Output();
        }

        public List<Student> GetAllStudents()
        {
            return listStd;
        }
    }
}
