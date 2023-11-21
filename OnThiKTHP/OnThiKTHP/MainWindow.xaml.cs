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
using OnThiKTHP.Models;
using System.Text.RegularExpressions;
using System.Reflection;

namespace OnThiKTHP
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        QLSachContext db = new QLSachContext();
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
            /*var query = from t in db.TacGia
                        select t;
            cbTacGia.ItemsSource = query.ToList();
            cbTacGia.DisplayMemberPath = "TenTg";
            cbTacGia.SelectedValuePath = "MaTg";
            cbTacGia.SelectedIndex = 0;
            */
            var query = from t in db.TacGia
                        select t;
            cbTacGia.ItemsSource = query.ToList();
            cbTacGia.DisplayMemberPath = "TenTg";
            cbTacGia.SelectedValuePath = "MaTg";
            cbTacGia.SelectedIndex = 0;

        }
        private List<TT> LayDL()
        {
            /*var query = from t in db.Saches
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
            */
            var query = from t in db.Saches
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
                Type t = dgSach.SelectedItem.GetType();
                PropertyInfo[] p = t.GetProperties();
                txtMa.Text = p[0].GetValue(dgSach.SelectedValue).ToString();
                txtName.Text = p[1].GetValue(dgSach.SelectedValue).ToString();
                txtNamXB.Text = p[3].GetValue(dgSach.SelectedValue).ToString();
                cbTacGia.SelectedItem = (from t1 in db.TacGia
                                         where t1.MaTg == int.Parse(p[2].GetValue(dgSach.SelectedItem).ToString())
                                         select t1).FirstOrDefault();
                txtSoTrang.Text = p[4].GetValue(dgSach.SelectedValue).ToString();
            }
        }

        private bool CheckDL()
        {
            string mess = "";
            if (txtMa.Text == "" || txtName.Text == "" || txtNamXB.Text == "" || txtSoTrang.Text == "")
            {
                mess += "Khong duoc de trong cac o!";
            }
            if (!Regex.IsMatch(txtNamXB.Text, @"\d+"))
            {
                mess += "\nNam xuat ban phai la so nguyen";
            }
            else
            {
                int sl = int.Parse(txtNamXB.Text);
                if (sl < 0)
                {
                    mess += "\nSo trang phai la so duong";
                }
            }
            if (!Regex.IsMatch(txtSoTrang.Text, @"\d+"))
            {
                mess += "\nNam xuat ban phai la so nguyen";
            }
            else
            {
                int sl = int.Parse(txtSoTrang.Text);
                if (sl < 0)
                {
                    mess += "\nSo trang phai la so duong";
                }
            }
            if (mess != "")
            {
                MessageBox.Show(mess, "Thong bao", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            return true;
        }
        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            var a = db.Saches.SingleOrDefault(x => x.MaSach == int.Parse(txtMa.Text));
            if (a != null)
                if (CheckDL())
            {
                a.TenSach = txtName.Text;
                a.NamXuatBan = int.Parse(txtSoTrang.Text);
                a.SoTrang = int.Parse(txtSoTrang.Text);
                a.MaTg = ((TacGium)cbTacGia.SelectedItem).MaTg;
                    db.SaveChanges();
                    HienThiDL();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (CheckDL())
            {
                var query = db.Saches.FirstOrDefault(x => x.MaSach == int.Parse(txtMa.Text));
                if (query != null)
                {
                    MessageBox.Show("Da ton ma sach");
                }
                else
                {
                    Sach a = new Sach();
                    a.MaSach = int.Parse(txtMa.Text);
                    a.TenSach = txtName.Text;
                    a.NamXuatBan = int.Parse(txtSoTrang.Text);
                    a.SoTrang = int.Parse(txtSoTrang.Text);
                    TacGium dm = (TacGium)cbTacGia.SelectedItem;
                    a.MaTg = dm.MaTg;
                    db.Saches.Add(a);
                    db.SaveChanges();
                    MessageBox.Show("Them thanh cong", "Thong bao", MessageBoxButton.OK);
                    HienThiDL();
                }
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {

            var query = db.Saches.SingleOrDefault(t => t.MaSach.Equals(int.Parse(txtMa.Text)));
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
        }

        private void btnStatistic_Click(object sender, RoutedEventArgs e)
        {
            Window1 f = new Window1();
            f.ShowDialog();
        }
    }
}
