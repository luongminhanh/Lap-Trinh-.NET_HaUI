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
using KT_1.Models;
using System.Text.RegularExpressions;
using System.Reflection;

namespace KT_1
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
            var query = from t in db.TacGia
                        select t;
            cbTacGia.ItemsSource = query.ToList();
            cbTacGia.DisplayMemberPath = "TenTg";
            cbTacGia.SelectedItem = "MaTg";
            cbTacGia.SelectedIndex = 0;
        }
        private List<TT> LayDL()
        {
            var query = from t in db.Saches
                        select new TT
                        {
                            MaSach = t.MaSach,
                            TenSach = t.TenSach,
                            SoTrang = t.SoTrang,
                            NamXB = t.NamXuatBan,
                            MaTG = t.MaTg,
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
                    txtMa.Text = p[0].GetValue(dgSach.SelectedItem).ToString();
                    txtName.Text = p[1].GetValue(dgSach.SelectedItem).ToString();
                    txtNamXB.Text = p[3].GetValue(dgSach.SelectedItem).ToString();
                    txtSoTrang.Text = p[4].GetValue(dgSach.SelectedItem).ToString();
                    cbTacGia.SelectedItem = (from t1 in db.TacGia
                                             where t1.MaTg == int.Parse(p[2].GetValue(dgSach.SelectedItem).ToString())
                                             select t1).FirstOrDefault();                        ;
                }
                catch (Exception err)
                {
                    MessageBox.Show("Co loi xay ra: " + err.Message);
                }
            }
        }
        private bool CheckDL()
        {
            string mess = "";
            if (txtMa.Text == "" || txtName.Text == "" || txtSoTrang.Text == "" || txtNamXB.Text == "")
            {
                mess += ("Phai dien day du cac thong tin");
            }
            else
            {
                if (!Regex.IsMatch(txtNamXB.Text, @"\d+"))
                {
                    mess += "Nam xuat ban phai la so nguyen";
                }
                else
                {
                    int nam = int.Parse(txtNamXB.Text);
                    if (nam < 0)
                    {
                        mess += "Nam xuat ban phai lon hon 0";
                    }
                }
                if (!Regex.IsMatch(txtSoTrang.Text, @"\d+"))
                {
                    mess += "So trang phai la so nguyen";
                }
                else
                {
                    int nam = int.Parse(txtSoTrang.Text);
                    if (nam < 0)
                    {
                        mess += "So trang phai lon hon 0";
                    }
                }
            }
            if (mess != "")
            {
                MessageBox.Show(mess);
                return false;
            }
            return true;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var ma = db.Saches.FirstOrDefault(x => x.MaSach == int.Parse(txtMa.Text));
                if (ma == null)
                {
                    Sach s = new Sach();
                    s.MaSach = int.Parse(txtMa.Text);
                    s.TenSach = txtName.Text;
                    s.NamXuatBan = int.Parse(txtNamXB.Text);
                    s.SoTrang = int.Parse(txtSoTrang.Text);
                    s.MaTg = ((TacGium)cbTacGia.SelectedItem).MaTg;
                    db.Saches.Add(s);
                    db.SaveChanges();
                    HienThiDL();
                }
            }
            catch(Exception err)
            {
                MessageBox.Show("Co loi xay ra " + err.Message);
            }
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var s = db.Saches.FirstOrDefault(x => x.MaSach == int.Parse(txtMa.Text));
                if (s != null)
                {
                    s.TenSach = txtName.Text;
                    s.NamXuatBan = int.Parse(txtNamXB.Text);
                    s.SoTrang = int.Parse(txtSoTrang.Text);
                    s.MaTg = ((TacGium)cbTacGia.SelectedItem).MaTg;
                    db.SaveChanges();
                    HienThiDL();
                }
            }
            catch(Exception err)
            {
                MessageBox.Show("Co loi xay ra: " + err.Message);
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var s = db.Saches.FirstOrDefault(x => x.MaSach == int.Parse(txtMa.Text));
                if (s != null)
                {
                    MessageBoxResult rs = MessageBox.Show("Co muon xoa ? ", "Thong báo", MessageBoxButton.YesNoCancel);
                    if (rs == MessageBoxResult.Yes)
                    {
                        db.Saches.Remove(s);
                        db.SaveChanges();
                        HienThiDL();
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Co loi xay ra " + err.Message);
            };
        }

        private void btnStatistic_Click(object sender, RoutedEventArgs e)
        {
            Window1 form2 = new Window1();
            form2.Show();
        }
    }
}
