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
using System.Windows.Shapes;
using KT_3.Models;

namespace KT_3
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        QLBanHangContext db = new QLBanHangContext();
        public Window1()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var query = from t in db.SanPhams
                        join s in db.LoaiSanPhams on t.MaLoai equals s.MaLoai
                        select new
                        {
                            t.MaSp,
                            t.TenSp,
                            s.TenLoai,
                            t.SoLuong,
                            t.DonGia,
                            TongTien = t.SoLuong * t.DonGia
                        };
            var query1 = from t in db.SanPhams
                         group t by t.MaLoai into TGGR
                         select new
                         {
                             MaLoai = TGGR.Key,
                             TongTien = TGGR.Sum(x => x.DonGia * x.SoLuong)
                         };
            var query2 = from t in query1
                         join s in db.LoaiSanPhams on t.MaLoai equals s.MaLoai
                         select new
                         {
                             TenLoai = s.TenLoai,
                             TongTien = t.TongTien
                         };
            dgSP.ItemsSource = query2.ToList();
        }
    }
}
