using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OT1
{
    class SinhVienFPOLY
    {
        private int _maSV;
        public int maSV
        {
            get { return _maSV; }
            set { _maSV = value; }
        }
        private string _hoTen;
        public string hoTen
        {
            get { return _hoTen; }
            set { _hoTen = value; }
        }
        private int _chuyenNganh;
        public int chuyenNganh
        {
            get { return _chuyenNganh; }
            set { _chuyenNganh = value; }
        }

        public SinhVienFPOLY(int maSV, string hoTen, int chuyenNganh)
        {
            this.maSV = maSV;
            this.hoTen = hoTen;
            this.chuyenNganh = chuyenNganh;
        }

        public SinhVienFPOLY()
        {

        }

        public void inThongTin()
        {
            Console.WriteLine($"Ma SV: {this.maSV}, Ho ten: {this.hoTen}, Chuyen nganh: {this.chuyenNganh}");
        }
    }
}
