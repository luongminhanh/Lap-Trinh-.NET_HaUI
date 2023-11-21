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
using DE05_1.Models;
using System.Text.RegularExpressions;
using System.Reflection;

namespace DE05_1
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
                        select new
                        {
                            t.ProductId,
                            t.ProductName,
                            t.CatId,
                            t.UnitPrice,
                            t.Quantity,
                            TongTien = t.Quantity * t.UnitPrice
                        };
            dgSP.ItemsSource = query.ToList();
        }
        private bool CheckDL()
        {
            string tb = "";
            if (txtMa.Text == "" || txtTen.Text == "" || txtGia.Text == "" || txtSL.Text == "")
            {
                tb += "Phai dien day du thong tin";
            }
            if (!Regex.IsMatch(txtSL.Text, @"\d+"))
            {
                tb += "\nSL phai la so nguyen duong";
            }
            if (!Regex.IsMatch(txtGia.Text, @"\d+"))
            {
                tb += "\nGia phai la so nguyen duong";
            }
            if (tb != "")
            {
                MessageBox.Show(tb);
                return false;
            }
            return true;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var query = db.Products.SingleOrDefault(x => x.ProductId == txtMa.Text);
                if (query != null)
                {
                    MessageBox.Show("Sap pham da ton tai");
                }
                else
                {
                    Product sp = new Product();
                    sp.ProductId = txtMa.Text;
                    sp.ProductName = txtTen.Text;
                    sp.CatId = ((Category)cbLoai.SelectedItem).CatId;
                    sp.Quantity = int.Parse(txtSL.Text);
                    sp.UnitPrice = int.Parse(txtGia.Text);
                    db.Products.Add(sp);
                    db.SaveChanges();
                    HienThiDL();
                    MessageBox.Show("Them thanh cong");
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
                var sp = db.Products.SingleOrDefault(x => x.ProductId == txtMa.Text);
                if (sp == null)
                {
                    MessageBox.Show("Sap pham ko ton tai");
                }
                else
                {
                    sp.ProductName = txtTen.Text;
                    sp.CatId = ((Category)cbLoai.SelectedItem).CatId;
                    sp.Quantity = int.Parse(txtSL.Text);
                    sp.UnitPrice = int.Parse(txtGia.Text);
                    db.SaveChanges();
                    HienThiDL();
                    MessageBox.Show("Sua thanh cong");
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
                var sp = db.Products.SingleOrDefault(x => x.ProductId == txtMa.Text);
                if (sp == null)
                {
                    MessageBox.Show("Sap ko ton tai");
                }
                else
                {
                    MessageBoxResult rs = MessageBox.Show("Ban co muon xoa?", "Thong bao", MessageBoxButton.YesNoCancel);
                    if (rs == MessageBoxResult.Yes)
                    {
                        db.Products.Remove(sp);
                        db.SaveChanges();
                        HienThiDL();
                        MessageBox.Show("Xoa thanh cong");
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
            a.ShowDialog();
        }

        private void dgSP_SelectionChanged(object sender, SelectionChangedEventArgs e)
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
    }
}
