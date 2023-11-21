using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4_Bai_tap_tren_lop
{
    class Student
    {
        public string id { get; set; }
        public string name { get; set; }
        public int mark { get; set; }
        private int scholarship;
        public int Scholarship
        {
            get
            {
                if (mark > 8) return 500;
                else if (mark >= 7 && mark <= 8) return 300;
                else return 0;
            }
        }
        public Student()
        {
            this.id = "";
            this.name = "";
            this.mark = 0;
        }
        public Student(string id, string name, int mark, int scholarship)
        {
            this.id = id;
            this.name = name;
            this.mark = mark;
        }
        public Student(string id)
        {
            this.id = id;
        }    
    }
}
