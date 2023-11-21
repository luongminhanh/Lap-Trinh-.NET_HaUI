using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TX2_10
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<NhanVien> listNV = new List<NhanVien>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void menuInsert_Click(object sender, RoutedEventArgs e)
        {
            string ma = txtMaNV.Text;
            string ten = txtHoTen.Text;
            string gt = radNam.IsChecked == true ? "Nam" : "Nu";
            DateTime date = dtpDate.SelectedDate.Value;
            int luong = int.Parse(txtLuong.Text);
            int ngay = int.Parse(txtNgay.Text);
            NhanVien nv = new NhanVien(ma, ten, gt, date, luong, ngay, 0);
            listNV.Add(nv);
        }

        private void menuHienThi_Click(object sender, RoutedEventArgs e)
        {
            listView1.ItemsSource = listNV;
        }

        private void menuXoa_Click(object sender, RoutedEventArgs e)
        {
            txtHoTen.Text = "";
            txtMaNV.Text = "";
            txtMaNV.Focus();
        }

        private void listView1_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (listView1.SelectedItem != null)
            {
                NhanVien nv = (NhanVien)listView1.SelectedItem;
                Window1 form2 = new Window1(nv);
                form2.Show();
            }
        }
    }
}
