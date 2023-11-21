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
using System.Text.RegularExpressions;
using System.Reflection;
using DE03_2.Models;

namespace DE03_2
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
                        where t.Luong > 5000
                        orderby t.Luong
                        select new
                        {
                            t.MaPhong,
                            t.MaNv,
                            t.Hoten,
                            t.Luong,
                            t.Thuong,
                            TongTien = t.Luong + t.Thuong
                        };
            dgNV.ItemsSource = query.ToList();
        }

        private void dgNV_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                if (dgNV.SelectedItem != null)
                {
                    Type t = dgNV.SelectedItem.GetType();
                    PropertyInfo[] p = t.GetProperties();
                    txtMa.Text = p[1].GetValue(dgNV.SelectedItem).ToString();
                    txtTen.Text = p[2].GetValue(dgNV.SelectedItem).ToString();
                    txtLuong.Text = p[3].GetValue(dgNV.SelectedItem).ToString();
                    txtThuong.Text = p[4].GetValue(dgNV.SelectedItem).ToString();
                    cbPhong.SelectedValue = p[0].GetValue(dgNV.SelectedValue).ToString();
                }
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private bool CheckDL()
        {
            string tb = "";
            try
            {
                if (txtMa.Text == "" || txtTen.Text == "" ||
                    txtLuong.Text == "" ||
                    txtThuong.Text == "")
                {
                    MessageBox.Show("Phai dien du thong tin");
                }
                    if (!Regex.IsMatch(txtLuong.Text, @"\d+"))
                    {
                        tb += "Luong phai la so nguyen";
                    }
                int luong = int.Parse(txtLuong.Text);
                if (luong < 3000 || luong > 9000)
                {
                    tb += "Luong nam trong khoang 3000 den 9000";
                }
                    if (!Regex.IsMatch(txtThuong.Text, @"\d+"))
                    {
                        tb += "Thuong phai la so nguyen";
                    }
                int thuong = int.Parse(txtThuong.Text);
                if (thuong < 100 || thuong > 900)
                {
                    tb += "Thuong nam trong khoang 100 den 900";
                }

                if (tb != "")
                {
                    MessageBox.Show(tb);
                    return false;
                }
                return true;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                return false;
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (CheckDL())
                {
                    var query = db.Nhanviens.SingleOrDefault(x => x.MaNv == txtMa.Text);
                    if (query != null)
                    {
                        MessageBox.Show("Ma nhan vien da ton tai");
                    }
                    else
                    {
                        Nhanvien nv = new Nhanvien();
                        nv.MaNv = txtMa.Text;
                        nv.Hoten = txtTen.Text;
                        nv.Luong = int.Parse(txtLuong.Text);
                        nv.Thuong = int.Parse(txtThuong.Text);
                        nv.MaPhong = ((PhongBan)cbPhong.SelectedItem).MaPhong;
                        db.Nhanviens.Add(nv);
                        db.SaveChanges();
                        HienThiDL();
                        MessageBox.Show("Them thanh cong");
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                if (CheckDL())
                {
                    var nv = db.Nhanviens.SingleOrDefault(x => x.MaNv == txtMa.Text);
                    if (nv == null)
                    {
                        MessageBox.Show("Ma nhan vien ko ton tai");
                    }
                    else
                    {
                        nv.Hoten = txtTen.Text;
                        nv.Luong = int.Parse(txtLuong.Text);
                        nv.Thuong = int.Parse(txtThuong.Text);
                        nv.MaPhong = ((PhongBan)cbPhong.SelectedItem).MaPhong;
                        db.SaveChanges();
                        HienThiDL();
                        MessageBox.Show("Sua thanh cong");
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            try
            {
                if (CheckDL())
                {
                    var nv = db.Nhanviens.SingleOrDefault(x => x.MaNv == txtMa.Text);
                    if (nv == null)
                    {
                        MessageBox.Show("Ma nhan vien ko ton tai");
                    }
                    else
                    {
                        MessageBoxResult rs = MessageBox.Show("Ban co muon xoa?", "Thong bao", MessageBoxButton.YesNoCancel);
                        if (rs == MessageBoxResult.Yes)
                        {
                            db.Nhanviens.Remove(nv);
                            db.SaveChanges();
                            HienThiDL();
                            MessageBox.Show("Xoa thanh cong");
                        }
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Window1 a = new Window1();
            a.Show();
        }
    }
}
