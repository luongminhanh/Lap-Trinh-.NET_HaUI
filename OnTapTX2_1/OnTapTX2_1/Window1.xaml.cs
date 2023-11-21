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
using OnTapTX2_1.Models;

namespace OnTapTX2_1
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            QLSachContext db = new QLSachContext();
            var query = from t in db.Saches
                        group t by t.MaTg into TGGR
                        select new
                        {
                            MaTg = TGGR.Key,
                            TongTien = (long)TGGR.Sum(x => x.SoTrang * 800)
                        };
            var query1 = from t in query
                         join s in db.TacGia on t.MaTg equals s.MaTg
                         select new
                         {
                             MaTg = t.MaTg,
                             TenTg = s.TenTg,
                             t.TongTien
                         };
            dgTG.ItemsSource = query1.ToList();
        }
    }
}
