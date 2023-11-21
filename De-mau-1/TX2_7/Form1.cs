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
    public partial class Form1 : Form
    {
        List<NhanVien> listNV = new List<NhanVien>();
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
            txtHoTen.Text = "";
            txtLuong.Text = "";
            txtMaNV.Text = "";
            txtNgay.Text = "";
            dtpDate.Value = DateTime.Today;
            radNam.Checked = true;
            radNu.Checked = false;
            txtMaNV.Focus();
            */
            ListViewItem item = listView1.SelectedItems[0];
            listView1.Items.Remove(item);
            string ma = item.Text;
            listNV.RemoveAll(x => x.MaNV == ma);
        }

        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string ma = txtMaNV.Text;
            string ten = txtHoTen.Text;
            string gt = radNam.Checked == true ? "Nam" : "Nữ";
            int luong = int.Parse(txtLuong.Text);
            int ngay = int.Parse(txtNgay.Text);
            DateTime date = dtpDate.Value;
            if (listNV.FirstOrDefault(x => x.MaNV == ma) != null)
            {
                MessageBox.Show("Da ton tai ma nv");
            }
            else
            {
                NhanVien nv = new NhanVien(ma, ten, gt, date, luong, ngay);
                listNV.Add(nv);
            }
        }

        private void hiểnThịToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];
                string ma = item.Text;
                TX_7_Form2 form2 = new TX_7_Form2(ma, listNV);
                form2.ShowDialog();
            }
            */
            MessageBox.Show("Da chon dong");
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];
                string ma = item.Text;

                TX_7_Form2 form2 = new TX_7_Form2(ma, listNV);
                form2.ShowDialog();
            }
        }

        private void sửaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
