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

namespace ViideoBaiGiang1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnXem_Click(object sender, RoutedEventArgs e)
        {
            string strMessage, strHoTen, strTitle, strNgoaiNgu = "";
            strHoTen = txtHoDem.Text + " " + txtTen.Text;
            if (radioNam.IsChecked==true)
            {
                strTitle = "Mr. ";
            }
            else
            {
                strTitle = "Miss/Mrs. ";
            }
            strMessage = "Xin chào " + strTitle + strHoTen;
            if (chkTrung.IsChecked == true)
            {
                strNgoaiNgu = "Tiếng Trung";
            }
            if (chkAnh.IsChecked == true)
            {
                strNgoaiNgu = (strNgoaiNgu.Length == 0) ? "Tiếng Trung" : "Tiếng Anh và Tiếng Trung";
            }
            strMessage += "\nNgoại ngữ: " + strNgoaiNgu;
            if (cboQueQuan.SelectedIndex>=0)
            {
                strMessage += "\nQuê quán: " + cboQueQuan.Text;
            }
            MessageBox.Show(strMessage);
        }
    }
}
