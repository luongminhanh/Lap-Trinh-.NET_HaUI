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
    public partial class TX2_2_Form2 : Form
    {
        NhanVien selectedNV;
        List<NhanVien> listNV = new List<NhanVien>();
        public TX2_2_Form2()
        {
            InitializeComponent();
        }

        public TX2_2_Form2(string maNV, List<NhanVien> listNV)
        {
            InitializeComponent();
            selectedNV = listNV.FirstOrDefault(x => x.MaNV == maNV);
            txtMaNV.Text = selectedNV.MaNV;
            dtpDate.Value = selectedNV.NgaySinh;

        }
        private void TX2_2_Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
