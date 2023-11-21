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
using Bai1.Models;
using System.Text.RegularExpressions;
using System.Reflection;

namespace Bai1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        QLSachContext db = new();
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
            var query = from t in db.TacGia
                        select t;
            cbTacGia.ItemsSource = query.ToList();
            cbTacGia.DisplayMemberPath = "TenTacGia";
            cbTacGia.SelectedValuePath = "MaTG";
            cbTacGia.SelectedIndex = 0;
        }
        private List<TT> LayDL()
        {
            var query = from t in db.Saches
                        where t.SoTrang >= 10
                        orderby t.SoTrang descending
                        select new TT
                        {
                            MaSach = t.MaSach,
                            TenSach = t.TenSach,
                            MaTG = t.MaTg,
                            NamXuatBan = t.NamXuatBan,
                            SoTrang = t.SoTrang,
                            TongTien = t.SoTrang * 80000
                        };
            return query.ToList<TT>();
        }
        private void HienThiDL()
        {
            dgSach.ItemsSource = LayDL();
        }

        private void dgSach_SelectedCellsChanged_1(object sender, SelectedCellsChangedEventArgs e)
        {
            if (dgSach.SelectedItem != null)
            {
                try
                {
                    Type t = dgSach.SelectedItem.GetType();
                    PropertyInfo[] p = t.GetProperties();
                    txtMa.Text = p[0].GetValue(dgSach.SelectedValue).ToString();
                    txtName.Text = p[1].GetValue(dgSach.SelectedValue).ToString();
                    txtNamXB.Text = p[3].GetValue(dgSach.SelectedValue).ToString();
                    txtSoTrang.Text = p[4].GetValue(dgSach.SelectedValue).ToString();
                    cbTacGia.SelectedItem = (from t1 in db.TacGia
                                             where t1.MaTg == p[2].GetValue(dgSach.SelectedValue).ToString()
                                             select t1).FirstOrDefault();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi khi chọn hàng " + ex.Message, "Thông báo", 
                    MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }    
        }

        private bool checkDL()
        {
            string mess = "";
            if (txtMa.Text == "" || txtName.Text == "" || txtSoTrang.Text == "" || txtNamXB.Text == "")
            {
                mess += "\nBan can nhap day du du lieu";
            }
            if (!Regex.IsMatch(txtSoTrang.Text, @"\d+"))
            {
                mess += "\nSo trang nhap phai la so nguyen";
            }
            else
            {
                int sl = int.Parse(txtSoTrang.Text);
                if (sl < 0)
                {
                    mess += "\nSo luong nhap phai la so duong";
                }
            }
            if (!Regex.IsMatch(txtNamXB.Text, @"\d+"))
            {
                mess += "\nNam xb nhap phai la so nguyen";
            }
            else
            {
                int gia = int.Parse(txtNamXB.Text);
                if (gia < 0)
                {
                    mess += "\nNam xb nhap phai la so duong";
                }
            }
            if (mess != "")
            {
                MessageBox.Show(mess, "Thong bao", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            return true;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (checkDL())
                {
                    var query = db.Saches.SingleOrDefault(t => t.MaSach.Equals(txtMa.Text));
                    if (query != null)
                    {
                        MessageBox.Show("Da ton tai", "Thong bao", MessageBoxButton.OK);
                        HienThiDL();
                    }
                    else
                    {
                        Sach a = new Sach();
                        a.MaSach = txtMa.Text;
                        a.TenSach = txtName.Text;
                        a.SoTrang = int.Parse(txtSoTrang.Text);
                        a.NamXuatBan = int.Parse(txtNamXB.Text);
                        TacGium dm = (TacGium)cbTacGia.SelectedItem;
                        a.MaTg = dm.MaTg;
                        db.Saches.Add(a);
                        db.SaveChanges();
                        MessageBox.Show("Thanh cong", "Thong bao", MessageBoxButton.OK);
                        HienThiDL();
                    }
                }
            }
            catch(Exception er)
            {
                MessageBox.Show("Co loi khi them: " + er.Message, "Thong bao", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var sachSua = db.Saches.SingleOrDefault(sp => sp.MaSach == txtMa.Text);
                if (sachSua != null)
                {
                    if (checkDL())
                    {
                        sachSua.TenSach = txtName.Text;
                        sachSua.SoTrang = int.Parse(txtSoTrang.Text);
                        sachSua.NamXuatBan = int.Parse(txtNamXB.Text);
                        sachSua.MaTg = ((TacGium)cbTacGia.SelectedItem).MaTg;
                        db.SaveChanges();
                        HienThiDL();
                    }
                }
                else
                {
                    MessageBox.Show("Khong tim thay sach can sua");
                }
            }
            catch(Exception err)
            {
                MessageBox.Show("Co loi khi them: " + err.Message, "Thong bao", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var query = db.Saches.SingleOrDefault(t => t.MaSach.Equals(txtMa.Text));
                if (query != null)
                {
                    MessageBoxResult rs = MessageBox.Show("Ban co chac chan muon xoa ?", "Thong bao", MessageBoxButton.YesNoCancel);
                    if (rs == MessageBoxResult.Yes)
                    {
                        db.Saches.Remove(query);
                        db.SaveChanges();
                        HienThiDL();
                    }
                }
                else
                {
                    MessageBox.Show("Chua ton tai thuoc can xoa", "Thong bao");
                    HienThiDL();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Co loi khi them: " + err.Message, "Thong bao", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnStatistic_Click(object sender, RoutedEventArgs e)
        {
            Window1 f = new Window1();
            f.ShowDialog();
        }
    }
}
