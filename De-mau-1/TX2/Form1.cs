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
    public partial class Form1 : Form
    {
        private List<NhanVien> nhanVienList;
        public Form1()
        {
            InitializeComponent();
            nhanVienList = new List<NhanVien>();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lvNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvNhanVien.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lvNhanVien.SelectedItems[0];
                string maNV = selectedItem.Text;

                // Mở Form2 và truyền mã nhân viên được chọn
                Form2 form2 = new Form2(maNV, nhanVienList);
                form2.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            
        }
        private void ClearFields()
        {
            txtMaNV.Text = "";
            txtHoTen.Text = "";
            radNam.Checked = true;
            radNu.Checked = false;
            dtpDate.Value = DateTime.Today;
            txtLuongNgay.Text = "";
            txtSoNgay.Text = "";

            txtMaNV.Focus();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
                
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string maNV = txtMaNV.Text;
            string hoTen = txtHoTen.Text;
            string gioiTinh = radNam.Checked ? "Nam" : "Nữ";
            DateTime ngaySinh = dtpDate.Value;
            int luongNgay = int.Parse(txtLuongNgay.Text);
            int soNgayLamViec = int.Parse(txtSoNgay.Text);

            NhanVien nhanVien = new NhanVien(maNV, hoTen, gioiTinh, ngaySinh, luongNgay, soNgayLamViec);
            nhanVienList.Add(nhanVien);

        }

        private void hiểnThịToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvNhanVien.Items.Clear();

            foreach (NhanVien nhanVien in nhanVienList)
            {
                ListViewItem item = new ListViewItem(nhanVien.MaNV);
                item.SubItems.Add(nhanVien.HoTen);
                item.SubItems.Add(nhanVien.GioiTinh);
                item.SubItems.Add(nhanVien.NgaySinh.ToShortDateString());
                item.SubItems.Add(nhanVien.LuongNgay.ToString());
                item.SubItems.Add(nhanVien.SoNgayLamViec.ToString());
                item.SubItems.Add((nhanVien.TinhLuong()).ToString());
                lvNhanVien.Items.Add(item);
            }
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtMaNV.Text = "";
            txtHoTen.Text = "";
            radNam.Checked = true;
            radNu.Checked = false;
            dtpDate.Value = DateTime.Today;
            txtLuongNgay.Text = "";
            txtSoNgay.Text = "";

            txtMaNV.Focus();
        }
    }
}
