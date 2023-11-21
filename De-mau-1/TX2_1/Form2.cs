using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TX2_1
{
    public partial class Form2 : Form
    {
        public List<NhanVien> listNV = new List<NhanVien>();
        public NhanVien selectedNV;
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(string maNV, List<NhanVien> listNhanVien)
        {
            InitializeComponent();
            listNV = listNhanVien;
            selectedNV = listNV.FirstOrDefault(x => x.MaNV == maNV);
            txtMaNV.Text = selectedNV.MaNV;
            txtHoTen.Text = selectedNV.HoTen;
            txtLuong.Text = selectedNV.LuongNgay.ToString();
            txtNgay.Text = selectedNV.SoNgay.ToString();
            radNam.Checked = selectedNV.GioiTinh == "Nam";
            radNu.Checked = selectedNV.GioiTinh == "Nữ";
            dtpDate.Value = selectedNV.NgaySinh;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
