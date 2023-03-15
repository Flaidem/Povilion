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
    public partial class PovilElem : Window
    {
        public PovilElem(Shop_Centers j)
        {
            List<KeyValuePair<int, string>> sl = new List<KeyValuePair<int, string>>();
            InitializeComponent();
            using (var db = new PovillonsEntities())
            {
                var list = db.PovilTabFil(j.Shop_Centr_id).ToList();
                for (int i = 0; i < list.Count; i++)
                {
                    sl.Add(new KeyValuePair<int, string>(i, list[i].num_povil));
                }
                dg.ItemsSource = list;
            }
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
