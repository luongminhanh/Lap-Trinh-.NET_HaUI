using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TX2
{
    public partial class Form2 : Form
    {
        private NhanVien selectedNV;
        private List<NhanVien> nhanVienList;
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(string maNV, List<NhanVien> nhanVienList)
        {
            InitializeComponent();
            txtMaNV1.Text = maNV;
            this.nhanVienList = nhanVienList;
            selectedNV = nhanVienList.FirstOrDefault(nv => nv.MaNV == maNV);
            txtHoTen1.Text = selectedNV.HoTen;
            txtLuongNgay1.Text = selectedNV.LuongNgay.ToString();
            txtSoNgay1.Text = selectedNV.SoNgayLamViec.ToString();
            dtpDate1.Value = selectedNV.NgaySinh;
            radNam1.Checked = selectedNV.GioiTinh == "Nam" ? true : false;
            radNu1.Checked = selectedNV.GioiTinh == "Nam" ? false : true;
        }

        private void btnDongForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
