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

namespace Povilion
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            using (var db = new PovillonsEntities())
            {
                db.Empoloys.ToList();
            }
            InitializeComponent();
            PageHelper.vau = this;
            PageHelper.vau.mainframe.Navigate(new Avtoriz());
        }
    }
}
