using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TX2_3_Form1
{
    public partial class TX2_3_Form2 : Form
    {
        NhanVien selectedNV;
        public TX2_3_Form2()
        {
            InitializeComponent();
        }

        public TX2_3_Form2(string maNV, List<NhanVien> listNV)
        {
            InitializeComponent();
            selectedNV = listNV.FirstOrDefault(x => x.MaNV == maNV);
            dtpDate.Value = selectedNV.NgaySinh;
            txtHoTen.Text = selectedNV.HoTen;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void radNu_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radNam_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNgay_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLuong_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
