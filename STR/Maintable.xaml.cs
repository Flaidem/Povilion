using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
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

    public partial class Maintable : Page
    {
       
        List<KeyValuePair<int, int>> sl = new List<KeyValuePair<int, int>>();
        public Maintable()
        {
            InitializeComponent();
            using (var db = new PovillonsEntities())
            {
                var list = db.MainWindTable("Строительство", "").ToList();
                for (int i = 0; i < list.Count; i++)
                {
                    sl.Add(new KeyValuePair<int, int>(i, list[i].Shop_Centr_id));
                }
                dg.ItemsSource = list;
            }
        }

        private void addcent(object sender, RoutedEventArgs e)
        {
            STR.AddSC tab = new STR.AddSC();
            tab.ShowDialog();
        }

        private void EddCent(object sender, RoutedEventArgs e)
        {
            var b = sl[dg.SelectedIndex];
            using (var db = new PovillonsEntities())
            {
                var s = db.Shop_Centers.Find(b.Value);
                EdShop tab = new EdShop(s);
                tab.ShowDialog();
            }
            using (var db = new PovillonsEntities())
            {
                var list = db.MainWindTable("Строительство", "").ToList();
                for (int i = 0; i < list.Count; i++)
                {
                    sl.Add(new KeyValuePair<int, int>(i, list[i].Shop_Centr_id));
                }
                dg.ItemsSource = list;
            }
        }

        private void Delcent(object sender, RoutedEventArgs e)
        {

        }

        private void povilcent(object sender, RoutedEventArgs e)
        {
            var b = sl[dg.SelectedIndex];//не -1
            using (var db = new PovillonsEntities())
            {
                var s = db.Shop_Centers.Find(b.Value);
                STR.PovilElem tab = new STR.PovilElem(s);
                tab.ShowDialog();
            }
        }

        private void BackAvtor(object sender, RoutedEventArgs e)
        {
            PageHelper.vau.mainframe.Navigate(new Avtoriz());
        }
    }
}
