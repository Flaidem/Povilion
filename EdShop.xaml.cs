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
        int id;
        public EdShop(Shop_Centers j)
        {
            InitializeComponent();
            statbox.Items.Add("Строительство");
            statbox.Items.Add("Реализация");
            statbox.Items.Add("Удален");
            namebox.Text = j.Name;
            statbox.Text = " ";
            countbox.Text = j.povil_count.ToString();
            dressbox.Text = j.City;
            costbox.Text = j.Cost.ToString();
            floorbox.Text = j.num_of_floors.ToString();
            ratiobox.Text = j.ratio.ToString();
            id = j.Shop_Centr_id;
        }    
        private void eddshop(object sender, RoutedEventArgs e)
        {
            using(var db = new PovillonsEntities())
            {
                var s = db.Shop_Centers.Find(id);
                if ((namebox.ToString() != null && namebox.Text != "") && (statbox != null) && (statbox.Text != " ") && (dressbox.ToString() != null && dressbox.Text != ""))
                {
                    s.Name = namebox.Text;
                    if (statbox.Text == "Удален")
                    {
                        s.Status_id = 4;
                    }
                    else if (statbox.Text == "Реализация")
                    {
                        s.Status_id = 3;
                    }
                    else
                    {
                        s.Status_id = 2;
                    }
                    s.povil_count = Convert.ToInt32(countbox.Text);
                    s.City = dressbox.Text;
                    s.Cost = Convert.ToDecimal(costbox.Text);
                    s.num_of_floors = Convert.ToInt32(floorbox.Text);
                    s.ratio = Convert.ToSingle(ratiobox.Text);
                    db.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Ошибка изменения");
                }
            }
        }
    }
}
