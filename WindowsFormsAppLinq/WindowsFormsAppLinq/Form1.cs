using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppLinq
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Them(15, "banh hat", 12, 1);
            HienThi();
        }

        private void HienThi()
        {
            DataClasses1DataContext context = new DataClasses1DataContext();
            var query = from SanPham in context.SanPhams
                        select new { SanPham.MaSP, SanPham.TenSP, SanPham.MaDM };
            dataGridView1.DataSource = query;
        }
        public void Them(int ma, string ten, int gia, int madm)
        {
            DataClasses1DataContext context = new DataClasses1DataContext();
            var sp = context.SanPhams.FirstOrDefault(x => x.MaSP == ma);
            if (sp == null)
            {
                MessageBox.Show("Chua ton tai sp nay");
                SanPham sp1 = new SanPham();
                sp1.MaSP = ma;
                sp1.TenSP = ten;
                sp1.DonGia = gia;
                sp1.MaDM = madm;
                context.SanPhams.InsertOnSubmit(sp1);
                context.SubmitChanges();
            }
        }
        public void Sua(int ma, string ten, int gia, int madm)
        {
            DataClasses1DataContext context = new DataClasses1DataContext();
            var sp = context.SanPhams.FirstOrDefault(x => x.MaSP == ma);
            if (sp != null)
            {               
                sp.MaSP = ma;
                sp.TenSP = ten;
                sp.DonGia = gia;
                sp.MaDM = madm;
                context.SubmitChanges();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sua(12, "Nho say", 20, 1);
            HienThi();
        }

        public void Xoa(int ma, string ten, int gia, int madm)
        {
            DataClasses1DataContext context = new DataClasses1DataContext();
            var sp = context.SanPhams.FirstOrDefault(x => x.MaSP == ma);
            if (sp != null)
            {
                context.SanPhams.DeleteOnSubmit(sp);
                context.SubmitChanges();
            }
            else
            {
                MessageBox.Show("Khong co sp nay de xoa");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Xoa(12, "Nho say", 20, 1);
            HienThi();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HienThi();
        }
    }
}
