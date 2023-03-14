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

namespace Povilion.STR
{
    /// <summary>
    /// Логика взаимодействия для PovilElem.xaml
    /// </summary>
    public partial class PovilElem : Window
    {
        public PovilElem(Shop_Centers j)
        {
            InitializeComponent();
            using (var db = new PovillonsEntities())
            {
                //var s = db.Shop_Centers.Find(j.Shop_Centr_id);
                dg.ItemsSource = db.pavilions.Where(a => a.Shop_Centr_id == j.Shop_Centr_id).ToList();
            }
                //dg.ItemsSource = db.MainWindTable("Строительство", "").ToList();  Изменить
        }

        private void addpov(object sender, RoutedEventArgs e)
        {
            STR.AddPov tab = new STR.AddPov();
            tab.ShowDialog();
        }

        private void eddpov(object sender, RoutedEventArgs e)
        {

        }

        private void delpov(object sender, RoutedEventArgs e)
        {

        }
    }
}
