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
using OnTapTX2_1.Models;
using System.Text.RegularExpressions;
using System.Reflection;

namespace OnTapTX2_1
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
            cboTacGia.ItemsSource = query.ToList();
            cboTacGia.DisplayMemberPath = "TenTg";
            cboTacGia.SelectedValuePath = "MaTg";
            cboTacGia.SelectedIndex = 0;           
        }
        private List<TT> LayDL()
        {
            var query = from t in db.Saches
                        where t.SoTrang >= 120
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

        private void dgSach_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            try
            {
                if (dgSach.SelectedItem != null)
                {
                    Type t = dgSach.SelectedItem.GetType();
                    PropertyInfo[] p = t.GetProperties();
                    txtMaSach.Text = p[0].GetValue(dgSach.SelectedValue).ToString();
                    txtTenSach.Text = p[1].GetValue(dgSach.SelectedValue).ToString();
                    cboTacGia.SelectedItem = (from t1 in db.TacGia
                                              where t1.MaTg == int.Parse(p[4].GetValue(dgSach.SelectedValue).ToString())
                                              select t1).FirstOrDefault();
                    txtNamXB.Text = p[2].GetValue(dgSach.SelectedValue).ToString();
                    txtSoTrang.Text = p[3].GetValue(dgSach.SelectedValue).ToString();
                }
               
            }
            catch (Exception er)
            {
                MessageBox.Show("Co loi xay ra " + er.Message);
            }
        }

        private bool CheckDL()
        {
            string mess = "";
            if (txtMaSach.Text == "" || txtTenSach.Text == "" || txtSoTrang.Text == "" || txtNamXB.Text == "")
            {
                mess += "\nPhai nhap day du cac o du lieu!";
            }
            
            if (!Regex.IsMatch(txtMaSach.Text, @"\d+"))
            {
                mess += "\nMa sach phai la so nguyen";
            }
            else
            {
                int sl = int.Parse(txtMaSach.Text);
                if (sl < 0)
                {
                    mess += "\nMa sach phai la so duong";
                }
            }
            if (!Regex.IsMatch(txtSoTrang.Text, @"\d+"))
            {
                mess += "\nSo trang phai la so nguyen";
            }
            else
            {
                int sl1 = int.Parse(txtSoTrang.Text);
                if (sl1 < 0)
                {
                    mess += "\nSo trang phai la so duong";
                }
            }
            if (mess != "")
            {
                MessageBox.Show("Co loi xay ra " + mess);
                return false;
            }
            return true;
        }

        private void btnInsert_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (CheckDL())
                {
                    var query = db.Saches.SingleOrDefault(x => x.MaSach == int.Parse(txtMaSach.Text));
                    if (query != null)
                    {
                        MessageBox.Show("Ma sach da ton tai", "Thong bao", MessageBoxButton.OK);
                    }
                    else
                    {
                        Sach s1 = new Sach();
                        s1.MaSach = int.Parse(txtMaSach.Text);
                        s1.SoTrang = int.Parse(txtSoTrang.Text);
                        s1.NamXuatBan = int.Parse(txtNamXB.Text);
                        s1.TenSach = txtTenSach.Text;
                        TacGium tg = (TacGium)cboTacGia.SelectedItem;                       
                        s1.MaTg = tg.MaTg;
                        db.Saches.Add(s1);
                        db.SaveChanges();
                        MessageBox.Show("Them sach thanh cong");
                        HienThiDL();    
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Co loi xay ra " + err.Message);
            }
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            var spSua = db.Saches.SingleOrDefault(x => x.MaSach == int.Parse(txtMaSach.Text));
            if (spSua != null)
            {
                spSua.TenSach = txtTenSach.Text;
                spSua.SoTrang = int.Parse(txtSoTrang.Text);
                spSua.NamXuatBan = int.Parse(txtNamXB.Text);
                spSua.MaTg = ((TacGium)cboTacGia.SelectedItem).MaTg;
                db.SaveChanges();
                HienThiDL();
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            var spXoa = db.Saches.SingleOrDefault(x => x.MaSach == int.Parse(txtMaSach.Text));
            if (spXoa != null)
            {
                MessageBoxResult rs = MessageBox.Show("Ban co chac chan muon xoa ?", "Thong bao", MessageBoxButton.YesNoCancel);
                if (rs == MessageBoxResult.Yes)
                {
                    db.Remove(spXoa);
                    db.SaveChanges();
                    HienThiDL();
                }                    
            }
        }

        private void btnStatistic_Click(object sender, RoutedEventArgs e)
        {
            Window f = new Window1();
            f.ShowDialog();
        }
    }
}
