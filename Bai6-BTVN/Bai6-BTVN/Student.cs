using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//9h:46
namespace Bai6_BTVN
{
    class Student
    {
        private int _studentid;
        public int studentid
        {
            get { return _studentid; }
            set { _studentid = value; }
        }

        private string _name;
        public string name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _mark;
        public string mark
        {
            get { return _mark; }
            set { _mark = value; }
        }
        public Student()
        {

        }
        public Student(int id)
        {
            this.studentid = id;
        }

        public override string ToString()
        {
            return String.Format("{0, -10}{0, -10}{0, -10}", studentid, name, mark);
        }

        public void InputStudent()
        {
            Console.WriteLine("Nhap masv, ten, diem: ");
            studentid = int.Parse(Console.ReadLine());
            name = Console.ReadLine();
            mark = Console.ReadLine();
        }
    }
}
