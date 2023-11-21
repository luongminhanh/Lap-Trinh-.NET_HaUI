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
using KT_3.Models;
using System.Text.RegularExpressions;
using System.Reflection;


namespace KT_3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        QLBanHangContext db = new QLBanHangContext();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            HienThiDL();
            HienThiCB();
        }
        private void HienThiCB()
        {
            var query = from t in db.LoaiSanPhams
                        select t;
            cbLoai.ItemsSource = query.ToList();
            cbLoai.DisplayMemberPath = "TenLoai";
            cbLoai.SelectedValuePath = "MaLoai";
            cbLoai.SelectedIndex = 0;
        }
        private void HienThiDL()
        {
            var query = from t in db.SanPhams
                        select new
                        {
                            t.MaSp,
                            t.TenSp,
                            t.MaLoai,
                            t.SoLuong,
                            t.DonGia,
                            TongTien = t.SoLuong * t.DonGia
                        };
            dgSP.ItemsSource = query.ToList();
        }

        private bool CheckDL()
        {
            string tb = "";
            if (txtMa.Text == "" || txtTen.Text == "" || txtSoLuong.Text == "" || txtGia.Text == "")
            {
                tb += "Phải điền đủ thông tin";
            }
            if (!Regex.IsMatch(txtSoLuong.Text, @"\d+"))
            {
                tb += "Số lượng phải là số nguyên";
            }
            else if (int.Parse(txtSoLuong.Text) < 0)
            {
                tb += "Số lượng phải lớn hơn 0";
            }
            if (!Regex.IsMatch(txtGia.Text, @"\d+"))
            {
                tb += "Đơn giá phải là số";
            }
            else if (int.Parse(txtGia.Text) < 0)
            {
                tb += "Đơn giá phải lớn hơn 0";
            }
            if (tb != "")
            {
                MessageBox.Show(tb);
                return false;
            }
            return true;
        }
        private void btnThem_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SanPham sp = new SanPham();
                var sp1 = db.SanPhams.SingleOrDefault(x => x.MaSp == txtMa.Text);
                if (sp1 != null)
                {
                    MessageBox.Show("Sản phẩm đã tồn tại");
                    HienThiDL();
                }
                else
                {
                    if (CheckDL())
                    {
                        sp.MaSp = txtMa.Text;
                        sp.TenSp = txtTen.Text;
                        sp.SoLuong = int.Parse(txtSoLuong.Text);
                        sp.DonGia = float.Parse(txtGia.Text);
                        sp.MaLoai = ((LoaiSanPham)cbLoai.SelectedItem).MaLoai;
                        db.SanPhams.Add(sp);
                        db.SaveChanges();
                        MessageBox.Show("Thêm sản phẩm thành công");
                        HienThiDL();
                    }
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            };            
        }

        private void btnSua_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var sp1 = db.SanPhams.SingleOrDefault(x => x.MaSp == txtMa.Text);
                if (sp1 == null)
                {
                    MessageBox.Show("Không tìm thấy sản phẩm");
                    HienThiDL();
                }
                else
                {
                    if (CheckDL())
                    {
                        sp1.TenSp = txtTen.Text;
                        sp1.SoLuong = int.Parse(txtSoLuong.Text);
                        sp1.DonGia = float.Parse(txtGia.Text);
                        sp1.MaLoai = ((LoaiSanPham)cbLoai.SelectedItem).MaLoai;
                        db.SaveChanges();
                        MessageBox.Show("Sửa thông tin sản phẩm thành công");
                        HienThiDL();
                    }
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            };
        }

        private void btnXoa_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var sp1 = db.SanPhams.SingleOrDefault(x => x.MaSp == txtMa.Text);
                if (sp1 == null)
                {
                    MessageBox.Show("Không tìm thấy sản phẩm");
                    HienThiDL();
                }
                else
                {
                    MessageBoxResult rs = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo", MessageBoxButton.YesNoCancel);
                    if (rs == MessageBoxResult.Yes)
                    {
                        db.SanPhams.Remove(sp1);
                        db.SaveChanges();
                        HienThiDL();
                        MessageBox.Show("Xóa sp thành công");
                    }                                        
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            };
        }

        private void dgSP_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                if (dgSP.SelectedItem != null)
                {
                    Type t = dgSP.SelectedItem.GetType();
                    PropertyInfo[] p = t.GetProperties();
                    txtMa.Text = p[0].GetValue(dgSP.SelectedItem).ToString();
                    txtTen.Text = p[1].GetValue(dgSP.SelectedItem).ToString();
                    txtSoLuong.Text = p[3].GetValue(dgSP.SelectedItem).ToString();
                    txtGia.Text = p[4].GetValue(dgSP.SelectedItem).ToString();
                    cbLoai.SelectedValue = p[2].GetValue(dgSP.SelectedValue).ToString();
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            };
        }

        private void btnTK_Click(object sender, RoutedEventArgs e)
        {
            Window1 a = new Window1();
            a.ShowDialog();
        }

        private void btnTim_Click(object sender, RoutedEventArgs e)
        {
            string ma = ((LoaiSanPham)cbLoai.SelectedItem).MaLoai;
            var query = from t in db.SanPhams
                        where t.MaLoai == ma
                        select new
                        {
                            t.MaSp,
                            t.TenSp,
                            t.MaLoai,
                            t.SoLuong,
                            t.DonGia,
                            TongTien = t.SoLuong * t.DonGia
                        };
            dgSP.ItemsSource = query.ToList();
        }
    }
}
