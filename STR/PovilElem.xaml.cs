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
        int id;
        List<KeyValuePair<int, string>> sl = new List<KeyValuePair<int, string>>();
        public PovilElem(Shop_Centers j)
        {
            id = j.Shop_Centr_id;
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
            STR.AddPov tab = new STR.AddPov(id);
            tab.ShowDialog();
            using (var db = new PovillonsEntities())
            {
                var list = db.PovilTabFil(id).ToList();
                for (int i = 0; i < list.Count; i++)
                {
                    sl.Add(new KeyValuePair<int, string>(i, list[i].num_povil));
                }
                dg.ItemsSource = list;
            }
        }

        private void eddpov(object sender, RoutedEventArgs e)
        {
            using (var db = new PovillonsEntities())
            {
                var b = sl[dg.SelectedIndex];//не -1
                var p = db.pavilions.Where(a => a.num_povil == b.Value).FirstOrDefault();
                STR.Edpov tab = new STR.Edpov(p.num_povil);
                tab.ShowDialog();
            }
            using (var db = new PovillonsEntities())
            {
                var list = db.PovilTabFil(id).ToList();
                for (int i = 0; i < list.Count; i++)
                {
                    sl.Add(new KeyValuePair<int, string>(i, list[i].num_povil));
                }
                dg.ItemsSource = list;
            }
        }

        private void delpov(object sender, RoutedEventArgs e)
        {
            try
            {
            using (var db = new PovillonsEntities())
            {
                var b = sl[dg.SelectedIndex];//не -1
                var p = db.pavilions.Where(a => a.num_povil == b.Value).FirstOrDefault();
                p.status_id = 4;
                db.SaveChanges();
            }
            using (var db = new PovillonsEntities())
            {
                var list = db.PovilTabFil(id).ToList();
                for (int i = 0; i < list.Count; i++)
                {
                    sl.Add(new KeyValuePair<int, string>(i, list[i].num_povil));
                }
                dg.ItemsSource = list;
            }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка удаления");
            }
        }
    }
}
