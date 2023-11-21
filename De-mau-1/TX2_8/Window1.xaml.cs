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
using System.Windows.Shapes;

namespace TX2_8
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }
        public Window1(NhanVien selectedNV)
        {
            InitializeComponent();

            // Hiển thị thông tin nhân viên trên các điều khiển trong Window
            txtMaNV.Text = selectedNV.MaNV;
            txtHoTen.Text = selectedNV.HoTen;
            radNam.IsChecked = selectedNV.GioiTinh == "Nam";
            radNu.IsChecked = selectedNV.GioiTinh == "Nữ";
            dtpDate.SelectedDate = selectedNV.NgaySinh;
            txtLuong.Text = selectedNV.LuongNgay.ToString();
            txtNgay.Text = selectedNV.SoNgay.ToString();
        }

        private void dtpDate_Loaded(object sender, RoutedEventArgs e)
        {
            dtpDate.SelectedDate = DateTime.Today;
        }
    }
}
