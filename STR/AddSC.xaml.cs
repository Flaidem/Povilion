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
    /// Логика взаимодействия для AddSC.xaml
    /// </summary>
    public partial class AddSC : Window
    {
        public AddSC()
        {
            InitializeComponent();
            statbox.Items.Add('1');
            statbox.Items.Add('2');
            statbox.Items.Add('3');
            statbox.Items.Add('4');
        }

        private void addshop(object sender, RoutedEventArgs e)
        {
            //Проверки
            //Функция добавления
            using (var db = new PovillonsEntities())
            {
                var i = new Shop_Centers();
                i.Name = "a";
                i.Status_id = 1;
                i.povil_count = 1;
                i.City = "a";
                i.Cost = 1;
                i.num_of_floors = 1;
                i.ratio = 1;
                db.Shop_Centers.Add(i);
                db.SaveChanges();
            }
        }
    }
}
