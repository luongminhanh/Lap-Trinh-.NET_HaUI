using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TX2_7
{
    public partial class TX_7_Form2 : Form
    {
        NhanVien nv;
        public TX_7_Form2()
        {
            InitializeComponent();
        }
        public TX_7_Form2(string ma, List<NhanVien> listNV)
        {
            InitializeComponent();
            nv = listNV.FirstOrDefault(x => x.MaNV == ma);
            txtMaNV.Text = nv.MaNV;
            txtHoTen.Text = nv.HoTen;
            radNam.Checked = nv.GioiTinh == "Nam";
            radNu.Checked = nv.GioiTinh == "Nữ";
            dtpDate.Value = nv.NgaySinh;
            txtLuong.Text = nv.LuongNgay.ToString();
            txtNgay.Text = nv.SoNgay.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
