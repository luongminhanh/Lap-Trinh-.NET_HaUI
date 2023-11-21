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
using DE04.Models;

namespace DE04
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        QLBanHang1Context db = new QLBanHang1Context();
        public Window1()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var qr1 = from t in db.SanPhams
                      group t by t.MaLoai into tk
                      select new
                      {
                          MaLoai = tk.Key,
                          SoLuongCo = tk.Count(),
                          TongTien = tk.Sum(x => x.DonGia * x.SoLuongCo)
                      };
            var qr2 = from t in qr1
                      join s in db.LoaiSps on t.MaLoai equals s.MaLoai
                      select new
                      {
                          MaLoai = t.MaLoai,
                          TenLoai = s.TenLoai,
                          SoLuongCo = t.SoLuongCo,
                          TongTien = t.TongTien
                      };
            dgSP.ItemsSource = qr2.ToList();
        }
    }
}
