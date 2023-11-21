using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTapKT
{
    class SinhVienUDPM : SinhVienFPOLY
    {
        private int _chuyenNganhHep;
        public int chuyenNganhHep 
        {
            get { return _chuyenNganhHep; }
            set { _chuyenNganhHep = value; }
        }
        public SinhVienUDPM(int maSV, string hoTen, int chuyenNganh, int chuyenNganhHep):base(maSV, hoTen, chuyenNganh)
        {
            this.chuyenNganhHep = chuyenNganhHep;
        }
        public void inThongTin()
        {
            base.inThongTin();
            Console.WriteLine($", Chuyen nganh hep: {this.chuyenNganhHep}");
        }
    }
}
