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

namespace Povilion.STR
{
    /// <summary>
    /// Логика взаимодействия для AdmAvt.xaml
    /// </summary>
    public partial class AdmAvt : Page
    {
        public AdmAvt()
        {
            InitializeComponent();
        }

        private void BackAvtor(object sender, RoutedEventArgs e)
        {
            PageHelper.vau.mainframe.Navigate(new Avtoriz());
        }

        private void addem(object sender, RoutedEventArgs e)
        {
            STR.AddEmp tab = new STR.AddEmp();
            tab.ShowDialog();
        }

        private void eddemp(object sender, RoutedEventArgs e)
        {

        }

        private void delemp(object sender, RoutedEventArgs e)
        {

        }
    }
}
