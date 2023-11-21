using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TX2_5
{
    public partial class Form1 : Form
    {
        List<NhanVien> listNV = new List<NhanVien>();
        public Form1()
        {
            InitializeComponent();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string ma = txtMaNV.Text;
            string ten = txtHoTen.Text;
            string gt = radNam.Checked == true ? "Nam" : "Nữ";
            int luong = int.Parse(txtLuong.Text);
            int ngay = int.Parse(txtNgay.Text);
            DateTime date = dtpDate.Value;
            NhanVien nv = new NhanVien(ma, ten, gt, date, luong, ngay);
            if (listNV.FirstOrDefault(x => x.MaNV == ma) != null)
            {
                MessageBox.Show("MA nhan vien da ton tai");
            }
            else
            {
                listNV.Add(nv);
            }
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
            radNam.Checked = true;
            radNu.Checked = false;
            dtpDate.Value = DateTime.Today;

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];
                string ma = item.Text;
                TX2_5_Form2 form2 = new TX2_5_Form2(ma, listNV);
                form2.ShowDialog();
            }
        }
    }
}
