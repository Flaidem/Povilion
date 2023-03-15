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

namespace Povilion
{
    /// <summary>
    /// Логика взаимодействия для EdShop.xaml
    /// </summary>
    public partial class EdShop : Window
    {
        public EdShop(Shop_Centers j)
        {
            j.Name = "Реутов Парк";
            InitializeComponent();
            using (var db = new PovillonsEntities())
            {
                var s = db.Shop_Centers.Find(j.Shop_Centr_id);
                MessageBox.Show(s.Name);
                s.Name = j.Name;
                MessageBox.Show(s.Name);
                db.SaveChanges();
            }
        }
    }
}
