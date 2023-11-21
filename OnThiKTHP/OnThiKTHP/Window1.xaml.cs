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
using OnThiKTHP.Models;

namespace OnThiKTHP
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

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            QLSachContext db = new QLSachContext();
            var query = from t in db.Saches
                        group t by t.MaTg into TGGR
                        select new
                        {
                            MaTG = TGGR.Key,
                            TongTien = TGGR.Sum(t => t.SoTrang * 80000)
                        };
            var query2 = from t in query 
                         join s in db.TacGia on t.MaTG equals s.MaTg
                         select new TacGiaViewModel
                         {
                             MaTG = t.MaTG,
                             TenTG = s.TenTg,
                             TongTien = t.TongTien
                         };
            dtTK.ItemsSource = query2.ToList();
        }
    }
}
