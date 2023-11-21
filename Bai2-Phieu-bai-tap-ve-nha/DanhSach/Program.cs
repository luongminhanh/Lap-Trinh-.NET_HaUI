using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanhSach
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> ThanhPho = new List<string>();
            Console.WriteLine("Nhap ten 5 thanh pho truc thuoc TW: ");
            for (int i = 0; i < 5; i++)
                ThanhPho.Add(Console.ReadLine());
            Console.WriteLine("5 thanh pho truc thuoc TW sau khi sap xep ten: ");
            ThanhPho.Sort();
            ThanhPho.ForEach(tp => Console.WriteLine(tp));
            Console.WriteLine("Cac thanh pho truc thuoc TW sau khi xoa 'Ha Noi' va them 5 thanh pho khac: ");
            ThanhPho.Remove("Ha Noi");
            ThanhPho.Add("Vinh");
            ThanhPho.Add("Da Nang");
            ThanhPho.Add("Hoi An");
            ThanhPho.Add("Bac Kan");
            ThanhPho.Add("Tay Nguyen");
            ThanhPho.ForEach(tp => Console.WriteLine(tp));
            Console.ReadLine();

        }
    }
}
