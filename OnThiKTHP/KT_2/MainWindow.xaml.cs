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
using KT_2.Models;
using System.Text.RegularExpressions;
using System.Reflection;

namespace KT_2
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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

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
            cbTacGia.SelectedValuePath = "MaTg";
            cbTacGia.SelectedIndex = 0;
        }
        private void HienThiDL()
        {
            //dgSach.ItemsSource = LayDL();
            var b = from t in db.Saches
                    select new
                    {
                        t.MaSach,
                        t.TenSach,
                        t.MaTg,
                        t.NamXuatBan,
                        t.SoTrang,                        
                        TongTien = t.SoTrang * 80000
                    };
            dgSach.ItemsSource = b.ToList();
        }
        private List<TT> LayDL()
        {
            var query = from t in db.Saches
                        select new TT
                        {
                            MaSach = t.MaSach,
                            TenSach = t.TenSach,
                            MaTG = t.MaTg,
                            SoTrang = t.SoTrang,
                            NamXB = t.NamXuatBan,
                            TongTien = t.SoTrang * 80000
                        };
            return query.ToList<TT>();
        }

        private bool CheckDL()
        {
            string mess = "";
            if (txtMa.Text == "" || txtNamXB.Text == "" || txtTenSach.Text == "" || txtSoTrang.Text == "")
            {
                mess += "Phai dien du cac truong";
            }
            if (mess != "")
            {
                MessageBox.Show(mess);
                return false;
            }
            return true;
        }
        private void btnThem_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (CheckDL())
                {
                    var query = db.Saches.FirstOrDefault(x => x.MaSach == int.Parse(txtMa.Text));
                    if (query == null)
                    {
                        Sach s = new Sach();
                        s.MaSach = int.Parse(txtMa.Text);
                        s.SoTrang = int.Parse(txtSoTrang.Text);
                        s.NamXuatBan = int.Parse(txtNamXB.Text);
                        s.MaTg = ((TacGium)cbTacGia.SelectedItem).MaTg;
                        s.TenSach = txtTenSach.Text;
                        db.Saches.Add(s);
                        db.SaveChanges();
                        HienThiDL();
                    }
                    else
                    {
                        MessageBox.Show("Ma sach da ton tai");
                    }
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void btnSua_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (CheckDL())
                {
                    var s = db.Saches.FirstOrDefault(x => x.MaSach == int.Parse(txtMa.Text));
                    if (s != null)
                    {
                        s.SoTrang = int.Parse(txtSoTrang.Text);
                        s.NamXuatBan = int.Parse(txtNamXB.Text);
                        s.MaTg = ((TacGium)cbTacGia.SelectedItem).MaTg;
                        s.TenSach = txtTenSach.Text;
                        db.SaveChanges();
                        HienThiDL();
                    }
                    else
                    {
                        MessageBox.Show("Ma sach ko ton tai");
                    }
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void btnXoa_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                
                    var s = db.Saches.FirstOrDefault(x => x.MaSach == int.Parse(txtMa.Text));
                    if (s != null)
                    {
                        db.Saches.Remove(s);
                        db.SaveChanges();
                        HienThiDL();
                    }
                    else
                    {
                        MessageBox.Show("Ma sach ko ton tai");
                    }
                
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }

        }

        private void btnTK_Click(object sender, RoutedEventArgs e)
        {
            Window1 form2 = new Window1();
            form2.ShowDialog();
        }

        private void dgSach_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var s = dgSach.SelectedItem;
            if (s != null)
            {
                Type t = dgSach.SelectedItem.GetType();
                PropertyInfo[] p = t.GetProperties();
                txtMa.Text = p[0].GetValue(dgSach.SelectedItem).ToString();
                txtTenSach.Text = p[1].GetValue(dgSach.SelectedItem).ToString();
                txtNamXB.Text = p[3].GetValue(dgSach.SelectedItem).ToString();
                txtSoTrang.Text = p[4].GetValue(dgSach.SelectedItem).ToString();
                cbTacGia.SelectedItem = (from t1 in db.TacGia
                                         where t1.MaTg == int.Parse(p[2].GetValue(dgSach.SelectedItem).ToString())
                                         select t1).FirstOrDefault();                                         
            }
        }
    }
}