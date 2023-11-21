using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4_Bai_tap_tren_lop
{
    class Circle
    {
        public double radius { get; set; }

        public Circle()
        {
            this.radius = 0;
        }
        public Circle(double x)
        { 
            this.radius = x;
        }
        public double Area()
        {
            return 3.14 * radius * radius;
        }
        public double Perimeter()
        {
            return 2 * 3.14 * radius;
        }
    }
}
