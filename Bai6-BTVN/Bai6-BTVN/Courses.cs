using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6_BTVN
{
    class Courses
    {
        private string _courseid;
        public string courseid
        {
            get { return _courseid; }
            set { _courseid = value; }
        }
        private string _courseName;
        public string courseName
        {
            get { return _courseName; }
            set { _courseName = value; }
        }
        private int _fee;
        public int fee
        {
            get { return _fee; }
            set { _fee = value; }
        }

        private List<Student> _li;
        public List<Student> li
        {
            get { return _li; }
            set { _li = value;  }
        }

        public Courses()
        {
            li = new List<Student>();
        }

        public Courses(string id)
        {
            this.courseid = id;
        }

        public void DisplayCourseAndStudents()
        {
            Console.WriteLine($"courseid: {courseid}, courseName: {courseName}, fee: {fee}");
            foreach (Student s in li)
                Console.WriteLine(s.ToString());
        }

        public void Input()
        {
            Console.WriteLine("Nhap courseid, name, fee: ");
            courseid = Console.ReadLine();
            courseName = Console.ReadLine();
            fee = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so sinh vien: ");
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i<number; i++)
            {
                Student s = new Student();
                s.InputStudent();
                li.Add(s);
            }    
        }
    }
}
