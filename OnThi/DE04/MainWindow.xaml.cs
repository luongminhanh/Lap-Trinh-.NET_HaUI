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
using DE04.Models;
using System.Text.RegularExpressions;
using System.Reflection;

namespace DE04
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        QLBanHang1Context db = new QLBanHang1Context();
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
            var query = from t in db.LoaiSps
                        select t;
            cbLoai.ItemsSource = query.ToList();
            cbLoai.DisplayMemberPath = "TenLoai";
            cbLoai.SelectedValuePath = "MaLoai";
            cbLoai.SelectedIndex = 0;
        }
        private void HienThiDL()
        {
            var query = from t in db.SanPhams
                        where t.DonGia > 100
                        orderby t.TenSp
                        select new
                        {
                            t.MaSp,
                            t.TenSp,
                            t.MaLoai,
                            t.DonGia,
                            t.SoLuongCo,
                            TongTien = t.DonGia * t.SoLuongCo
                        };
            dgSP.ItemsSource = query.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
        
                if (CheckDL())
                {
                    var query = db.SanPhams.SingleOrDefault(x => x.MaSp == txtMa.Text);
                   
                     if (query != null)
                        MessageBox.Show("Sp da ton tai");
                  
                    else
                    {
                        SanPham sp = new SanPham();
                        sp.MaSp = txtMa.Text;
                        sp.TenSp = txtTen.Text;
                        sp.MaLoai = ((LoaiSp)cbLoai.SelectedItem).MaLoai;
                        sp.DonGia = int.Parse(txtGia.Text);
                        sp.SoLuongCo = int.Parse(txtSL.Text);
                        db.SanPhams.Add(sp);
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
                    var sp = db.SanPhams.SingleOrDefault(x => x.MaSp == txtMa.Text);
                    
                        if (sp == null) 
                       
                            MessageBox.Show("Sp ko ton tai");
                    
                    else
                    {
                        sp.TenSp = txtTen.Text;
                        sp.MaLoai = ((LoaiSp)cbLoai.SelectedItem).MaLoai;
                        sp.DonGia = int.Parse(txtGia.Text);
                        sp.SoLuongCo = int.Parse(txtSL.Text);
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
                    var sp = db.SanPhams.SingleOrDefault(x => x.MaSp == txtMa.Text);
                  
                        if (sp == null)
                            MessageBox.Show("Sp ko ton tai");
               
                    else
                    {
                        MessageBoxResult rs = MessageBox.Show("Ban co chac chan muon xoa?", "Thong bao", MessageBoxButton.YesNoCancel);
                        if (rs== MessageBoxResult.Yes)
                        {
                            db.SanPhams.Remove(sp);
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
            a.ShowDialog();
        }
        private bool CheckDL()
        {
            string tb = "";
            if (txtMa.Text == ""|| txtTen.Text == "" || txtGia.Text == "" || txtSL.Text == "")
            {
                tb += "\nPhai dien day du thong tin";
            }
            if (!Regex.IsMatch(txtSL.Text, @"\d+"))
            {
                tb += "So luong phai la so nguyen";
            }
            if (!Regex.IsMatch(txtGia.Text, @"\d+"))
            {
                tb += "So luong phai la so nguyen";
            }
            if (tb != "")
            {
                MessageBox.Show(tb);
                return false;
            }
            return true;
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
                    txtSL.Text = p[3].GetValue(dgSP.SelectedItem).ToString();
                    txtGia.Text = p[4].GetValue(dgSP.SelectedItem).ToString();
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
