using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3
{
    class Nguoi
    {
        private string _hoTen;
        public string hoTen
        {
            get { return _hoTen; }
            set { _hoTen = value; }
        }
        private string _diaChi;
        public string diaChi
        {
            get { return _diaChi; }
            set { _diaChi = value; }
        }

        public void nhapThongTin()
        {
            Console.WriteLine("Nhap ho ten va dia chi: ");
            hoTen = Console.ReadLine();
            diaChi = Console.ReadLine();
        }
    }
}
