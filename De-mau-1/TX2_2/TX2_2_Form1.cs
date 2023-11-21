using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TX2_2
{
    public partial class TX2_2_Form1 : Form
    {
        public List<NhanVien> listNV = new List<NhanVien>();
        public TX2_2_Form1()
        {
            InitializeComponent();
        }

        private void TX2_2_Form1_Load(object sender, EventArgs e)
        {

        }

        private void hệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string ma = txtMaNV.Text;
            string ten = txtHoTen.Text;
            DateTime date = dtpDate.Value;
            string gt = radNam.Checked == true ? "Nam" : "Nữ";
            int luong = int.Parse(txtLuong.Text);
            int ngay = int.Parse(txtNgay.Text);
            NhanVien nv = new NhanVien(ma, ten, gt, date, luong, ngay);
            listNV.Add(nv);
        }

        private void hIểnThịToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            foreach(NhanVien nv in listNV)
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
            dtpDate.Value = DateTime.Today;
            radNam.Checked = true;
            radNu.Checked = false;
            txtMaNV.Focus();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];
                string maNV = item.Text;

                TX2_2_Form2 form2 = new TX2_2_Form2(maNV, listNV);
                form2.ShowDialog();
            }
        }
    }
}
