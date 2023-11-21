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
using Bai1.Models;

namespace Bai1
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
                            TongTien = TGGR.Sum(x => x.SoTrang * 80000)
                        };
            var query2 = from t in query
                         join s in db.TacGia on t.MaTg equals s.MaTg
                         select new
                         {
                             s.MaTg,
                             s.TenTacGia,
                             //s.TongTien
                         };
            dtTK.ItemsSource = query2.ToList();
        }
    }
}
