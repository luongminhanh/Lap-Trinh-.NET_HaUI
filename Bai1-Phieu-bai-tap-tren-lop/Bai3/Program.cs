using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap he so a, b cua PT bac nhat: ");
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            if (a == 0 && b != 0) Console.WriteLine("PT vo nghiem");
            else if (a == 0 && b == 0) Console.WriteLine("PT co vo so nghiem");
            else Console.WriteLine($"PT co nghiem la {-b / a}");
            Console.WriteLine("Nhap he so cua PT bac 2: ");
            float c = float.Parse(Console.ReadLine());
            float d = float.Parse(Console.ReadLine());
            float e = float.Parse(Console.ReadLine());
            //Coi nhu ko xet TH dac biet
            float delta = d * d - 4 * e * c;
            if (delta < 0) Console.WriteLine("PT vo nghiem");
            else if (delta == 0) Console.WriteLine($"PT co nghiem kep {-d / (2 * c)}");
            else Console.WriteLine($"PT co 2 nghiem phan biet {((-d - Math.Sqrt(delta)) / (2 * c))} va {((-d + Math.Sqrt(delta)) / (2 * c))}");
            Console.ReadLine();
        }
    }
}
