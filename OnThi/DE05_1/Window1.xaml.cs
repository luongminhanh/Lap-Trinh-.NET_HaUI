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
using DE05_1.Models;

namespace DE05_1
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        SALESMANAGEMENTContext db = new SALESMANAGEMENTContext();
        public Window1()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var query1 = from t in db.Products
                         group t by t.CatId into tk
                         select new
                         {
                             CatId = tk.Key,
                             TongTien = tk.Sum(x => x.Quantity * x.UnitPrice)
                         };
            var query2 = from t in query1
                         join s in db.Categories on t.CatId equals s.CatId
                         select new
                         {
                             CatId = t.CatId,
                             CatName = s.CatName,
                             TongTien = t.TongTien
                         };
            dgSP.ItemsSource = query2.ToList();
        }
    }
}
