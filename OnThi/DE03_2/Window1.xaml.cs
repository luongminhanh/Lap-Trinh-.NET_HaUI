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
using DE03_2.Models;

namespace DE03_2
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        QLNhanvienContext db = new QLNhanvienContext();
        public Window1()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var query1 = from t in db.Nhanviens
                         group t by t.MaPhong into tk
                         select new
                         {
                             MaPhong = tk.Key,
                             TongTien = tk.Sum(x => x.Thuong + x.Luong),
                             SoNV = tk.Count()
                         };
            var query2 = from t in query1
                         join s in db.PhongBans on t.MaPhong equals s.MaPhong
                         select new
                         {
                             MaPhong = t.MaPhong,
                             TenPhong = s.TenPhong,
                             TongTien = t.TongTien,
                             SoNV = t.SoNV
                         };
            dgNV.ItemsSource = query2.ToList();
        }
    }
}
