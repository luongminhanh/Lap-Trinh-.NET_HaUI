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
using DE05.Models;
using System.Text.RegularExpressions;
using System.Reflection;

namespace DE05
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SALESMANAGEMENTContext db = new SALESMANAGEMENTContext();
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
            var query = from t in db.Categories
                        select t;
            cbLoai.ItemsSource = query.ToList();
            cbLoai.DisplayMemberPath = "CatName";
            cbLoai.SelectedValuePath = "CatId";
            cbLoai.SelectedIndex = 0;
        }
        private void HienThiDL()
        {
            var query = from t in db.Products
                        where t.Quantity <= 150
                        orderby t.ProductName
                        select new
                        {
                            t.ProductId,
                            t.ProductName,
                            t.CatId,
                            t.UnitPrice,
                            t.Quantity,
                            Amount = t.UnitPrice * t.Quantity
                        };
            dgSP.ItemsSource = query.ToList();
        }
        private bool CheckDL()
        {
            string tb = "";
            if (txtMa.Text == ""|| txtTen.Text == ""|| txtSL.Text == "" || txtSL.Text == "")
            {
                tb += "Phai dien day du thong tin";
            }
            if (!Regex.IsMatch(txtSL.Text, @"\d+"))
            {
                tb += "So luong phai la so nguyen duong";
            }
            if (!Regex.IsMatch(txtGia.Text, @"\d+"))
            {
                tb += "Gia phai la so nguyen duong";
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
                var query = db.Products.SingleOrDefault(x => x.ProductId == txtMa.Text);
                if (query != null)
                {
                    MessageBox.Show("SP da ton tai");
                }
                else
                {
                    if (CheckDL())
                    {
                        Product p = new Product();
                        p.ProductId = txtMa.Text;
                        p.ProductName = txtTen.Text;
                        p.UnitPrice = int.Parse(txtGia.Text);
                        p.Quantity = int.Parse(txtSL.Text);
                        p.CatId = ((Category)cbLoai.SelectedItem).CatId;
                        db.Products.Add(p);
                        db.SaveChanges();
                        HienThiDL();
                        MessageBox.Show("Them sp moi thanh cong");
                    }
                    
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnSua_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var p = db.Products.SingleOrDefault(x => x.ProductId == txtMa.Text);
                if (p == null)
                {
                    MessageBox.Show("SP ko ton tai");
                }
                else
                {
                    if (CheckDL())
                    {
                        p.ProductName = txtTen.Text;
                        p.UnitPrice = int.Parse(txtGia.Text);
                        p.Quantity = int.Parse(txtSL.Text);
                        p.CatId = ((Category)cbLoai.SelectedItem).CatId;
                        db.SaveChanges();
                        MessageBox.Show("Sua thong tin sp thanh cong");
                        HienThiDL();
                    }
                    
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnXoa_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var query = db.Products.SingleOrDefault(x => x.ProductId == txtMa.Text);
                if (query == null)
                {
                    MessageBox.Show("SP ko ton tai");
                }
                else
                {
                    MessageBoxResult rs = MessageBox.Show("Ban co chac chan muon xoa?", "Thong bao", MessageBoxButton.YesNoCancel);
                    if (rs == MessageBoxResult.Yes)
                    {
                        db.Products.Remove(query);
                        db.SaveChanges();
                        MessageBox.Show("Xoa thanh cong");
                        HienThiDL();
                    }                    
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnTim_Click(object sender, RoutedEventArgs e)
        {
            Window1 a = new Window1();
            a.ShowDialog();
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
                    txtGia.Text = p[3].GetValue(dgSP.SelectedItem).ToString();
                    txtSL.Text = p[4].GetValue(dgSP.SelectedItem).ToString();
                    cbLoai.SelectedValue = p[2].GetValue(dgSP.SelectedValue).ToString();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}
