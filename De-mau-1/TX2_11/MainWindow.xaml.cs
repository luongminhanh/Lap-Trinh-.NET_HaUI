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

namespace TX2_11
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
            string ma = txtMaNV.Text;
            string ten = txtHoTen.Text;
            string gt = radNam.IsChecked == true ? "Nam" : "Nữ";
            DateTime date = dtpDate.SelectedDate.Value;
            int luong = int.Parse(txtLuong.Text);
            int ngay = int.Parse(txtNgay.Text);
            NhanVien nv = new NhanVien(ma, ten, gt, date, luong, ngay, 0);
            listNV.Add(nv);
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            dgView1.Items.Clear();
            foreach( NhanVien nv in listNV)
            {
                dgView1.Items.Add(nv);
            }
            listView1.Items.Clear();
            foreach (NhanVien nv in listNV)
            {
                listView1.Items.Add(nv);
            }
        }

        private void listView1_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void dgView1_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            if (dgView1.SelectedItem != null)
            {
                NhanVien nv = (NhanVien)dgView1.SelectedItem;
                Window1 form2 = new Window1(nv);
                form2.Show();
            }
        }

        private void listView1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            NhanVien nv = (NhanVien)listView1.SelectedItem;
            Window1 form2 = new Window1(nv);
            form2.Show();
        }
    }
}
