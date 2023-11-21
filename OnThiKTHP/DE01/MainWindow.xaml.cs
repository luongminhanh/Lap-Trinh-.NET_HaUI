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
using DE01.Models;
using System.Reflection;

namespace DE01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        QLNhanvienContext db = new QLNhanvienContext();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void dgNV_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                if (dgNV.SelectedItem != null)
                {
                   
                    Type t = dgNV.SelectedItem.GetType();
                    PropertyInfo[] p = t.GetProperties();
                    txtMa.Text = p[0].GetValue(dgNV.SelectedItem).ToString();
                    txtTen.Text = p[2].GetValue(dgNV.SelectedItem).ToString();
                    txtLuong.Text = p[3].GetValue(dgNV.SelectedItem).ToString();
                    txtThuong.Text = p[4].GetValue(dgNV.SelectedItem).ToString();
                   /* cbPhong.SelectedItem = (from t1 in db.PhongBans
                                            where t1.MaPhong == p[1].GetValue(dgNV.SelectedItem).ToString()
                                            select t1).FirstOrDefault();
                   */
                    cbPhong.SelectedValue = p[1].GetValue(dgNV.SelectedValue).ToString();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            HienThiCB();
            HienThiDL();
        }
        private void HienThiCB()
        {
            var query = from t in db.PhongBans
                        select t;
            cbPhong.ItemsSource = query.ToList();
            cbPhong.DisplayMemberPath = "TenPhong";
            cbPhong.SelectedValuePath = "MaPhong";
            cbPhong.SelectedIndex = 0;
        }
        private void HienThiDL()
        {
            var query = from t in db.Nhanviens
                        select new
                        {
                            t.MaNv,
                            t.MaPhong,
                            t.Hoten,
                            t.Luong,
                            t.Thuong,
                            TongTien = t.Luong + t.Thuong
                        };
            dgNV.ItemsSource = query.ToList();
        }
    }
}
