using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OT2
{
    class SinhVienUDPM : SinhVienFPOLY
    {
        private int _chuyenNganhHep;
        public int chuyenNganhHep
        {
            get { return _chuyenNganhHep; }
            set { _chuyenNganhHep = value; }
        }

        public SinhVienUDPM(int ma, string ten, int chuyenNganh, int chuyenNganhHep) : base(ma, ten, chuyenNganh)
        {           
            this.chuyenNganhHep = chuyenNganhHep;
        }
        public void inThongTin()
        {
            base.inThongTin();
            Console.WriteLine($"Chuyen Nganh Hep: {chuyenNganhHep}");
        }
    }
}
