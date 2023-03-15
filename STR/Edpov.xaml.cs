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
    /// Логика взаимодействия для Edpov.xaml
    /// </summary>
    public partial class Edpov : Window
    {
        string id;
        public Edpov(string id_shop)
        {
            InitializeComponent();
            id = id_shop;
            using (var db = new PovillonsEntities())
            {
                var j = db.pavilions.Where(a => a.num_povil == id).FirstOrDefault();
                flobox.Text = j.floor.ToString();
                areabox.Text = j.area.ToString();
                costbox.Text = j.cost.ToString();
                ratiobox.Text = j.value_added.ToString();
            }
        }

        private void eddpov(object sender, RoutedEventArgs e)
        {
            using (var db = new PovillonsEntities())
            {
                var j = db.pavilions.Where(a => a.num_povil == id).FirstOrDefault();
                j.floor = Convert.ToInt32(flobox.Text);
                j.area = Convert.ToSingle(areabox.Text);
                j.cost = Convert.ToDecimal(costbox.Text);
                j.value_added = Convert.ToSingle(ratiobox.Text);
                db.SaveChanges();
            }
        }
    }
}
