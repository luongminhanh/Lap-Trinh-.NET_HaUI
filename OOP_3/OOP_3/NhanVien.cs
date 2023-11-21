using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3
{
    class NhanVien:Nguoi
    {
        private string _maNV;
        public string maNV
        {
            get { return _maNV; }
            set { _maNV = value; }
        }
        private string _chucVu;
        public string chucVu
        {
            get { return _chucVu; }
            set { _chucVu = value; }
        }
        private int _luongCB;
        public int luongCB
        {
            get { return _luongCB; }
            set { _luongCB = value; }
        }

        public void nhapThongTin()
        {
            base.nhapThongTin();
            Console.WriteLine("Nhap ma nhan vien, chuc vu, luong cb: ");
            maNV = Console.ReadLine();
            chucVu = Console.ReadLine();
            luongCB = int.Parse(Console.ReadLine());
        }
        public int tinhHSL()
        {
            if (chucVu == "Giam Doc") return 10;
            else if (chucVu == "Truong Phong" || chucVu == "Pho Giam Doc") return 6;
            else if (chucVu == "Pho Phong") return 4;
            else return 2;
        }
    }
}
