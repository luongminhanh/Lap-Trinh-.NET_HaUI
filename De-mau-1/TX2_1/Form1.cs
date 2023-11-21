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
    public partial class Form1 : Form
    {
        private List<NhanVien> listNhanVien;
        public Form1()
        {
            InitializeComponent();
            listNhanVien = new List<NhanVien>();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string MaNV = txtMaNV.Text;
            string HoTen = txtHoTen.Text;
            string GioiTinh = radNam.Checked == true ? "Nam" : "Nữ";
            DateTime NgaySinh = dtpDate.Value;
            int LuongNgay = int.Parse(txtLuong.Text);
            int SoNgay = int.Parse(txtNgay.Text);
            NhanVien nv = new NhanVien(MaNV, HoTen, GioiTinh, NgaySinh, LuongNgay, SoNgay);
            listNhanVien.Add(nv);
        }

        private void hIểnThịToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            foreach(NhanVien nv in listNhanVien)
            {
                ListViewItem item = new ListViewItem(nv.MaNV);
                item.SubItems.Add(nv.HoTen);
                item.SubItems.Add(nv.GioiTinh);
                item.SubItems.Add(nv.NgaySinh.ToString());
                item.SubItems.Add(nv.LuongNgay.ToString());
                item.SubItems.Add(nv.SoNgay.ToString());
                item.SubItems.Add(nv.TinhLuong().ToString());
                listView1.Items.Add(item);
            }
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtMaNV.Text = "";
            txtHoTen.Text = "";
            txtLuong.Text = "";
            txtNgay.Text = "";
            radNam.Checked = true;
            radNu.Checked = false;
            dtpDate.Value = DateTime.Today;
            txtMaNV.Focus();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0){
                ListViewItem selectedNV = listView1.SelectedItems[0];
                string maNV = selectedNV.Text;
                Form2 form2 = new Form2(maNV, listNhanVien);
                form2.ShowDialog();
            }
        }
    }
}
