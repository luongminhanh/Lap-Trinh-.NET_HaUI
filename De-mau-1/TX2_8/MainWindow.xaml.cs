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
using System.Collections.ObjectModel;

namespace TX2_8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<NhanVien> listNV;
        public MainWindow()
        {
            InitializeComponent();
            listNV = new List<NhanVien>();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void menuInsert_Click(object sender, RoutedEventArgs e)
        {
            string ma = txtMaNV.Text;
            string ten = txtHoTen.Text;
            string gt = radNam.IsChecked == true ? "Nam" : "Nữ";
            int luong = int.Parse(txtLuong.Text);
            int ngay = int.Parse(txtNgay.Text);
            DateTime date = dtpDate.SelectedDate.Value;
            int tien = 0;
            if (listNV.FirstOrDefault(x => x.MaNV == ma) != null)
            {
                MessageBox.Show("Da ton tai ma nv");
            }
            else
            {
                NhanVien nv = new NhanVien(ma, ten, gt, date, luong, ngay, tien);
                listNV.Add(nv);
            }
        }

        private void menuHienThi_Click(object sender, RoutedEventArgs e)
        {
            listView1.ItemsSource = listNV;
        }

        private void listView1_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (listView1.SelectedItem != null)
            {
                // Lấy nhân viên được chọn
                NhanVien selectedNV = (NhanVien)listView1.SelectedItem;

                // Tạo một Window mới để hiển thị thông tin chi tiết
                Window1 detailWindow = new Window1(selectedNV);

                // Mở Window chi tiết
                detailWindow.Show();
            }
        }
    }
}
