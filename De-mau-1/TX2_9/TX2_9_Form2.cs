using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TX2_9
{
    public partial class TX2_9_Form2 : Form
    {
        NhanVien nv;
        public TX2_9_Form2()
        {
            InitializeComponent();
        }
        public TX2_9_Form2(string maNV, List<NhanVien> listNV)
        {
            InitializeComponent();
            nv = listNV.FirstOrDefault(x => x.MaNV == maNV);
            txtHoTen.Text = nv.HoTen;
            dtpDate.Value = nv.NgaySinh;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
