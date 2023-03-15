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
            statbox.Items.Add("План");
            statbox.Items.Add("Строительство");
            statbox.Items.Add("Реализация");
            statbox.Items.Add("Удален");
        }

        private void addshop(object sender, RoutedEventArgs e)
        {
            //Проверки
            //Функция добавления
            using (var db = new PovillonsEntities())
            {
                try
                { 
                  var i = new Shop_Centers();
                  if ((namebox.ToString() != null && namebox.Text != "") && (statbox != null) && (dressbox.ToString() != null && dressbox.Text != ""))
                  {
                      i.Name = namebox.Text;
                      if (statbox.Text == "План")
                      {
                          i.Status_id = 1;
                      }
                      else if (statbox.Text == "Удален")
                      {
                          i.Status_id = 4;
                      }
                      else if (statbox.Text == "Реализация")
                        {
                            i.Status_id = 3;
                        } else
                        {
                          i.Status_id = 2;
                        }
                      i.povil_count = Convert.ToInt32(countbox.Text);
                      i.City = dressbox.Text;
                      i.Cost = Convert.ToDecimal(costbox.Text);
                      i.num_of_floors = Convert.ToInt32(floorbox.Text);
                      i.ratio = Convert.ToSingle(ratiobox.Text);
                  }
                    var log = db.Shop_Centers.Where(a => a.Name == i.Name).FirstOrDefault();
                    if (log != null)
                    {
                        MessageBox.Show("ТЦ уже добавлен");
                    }
                    else
                    {
                        var j = new pavilion();
                        j.Shop_Centr_id = i.Shop_Centr_id;
                        j.num_povil = num.Text;
                        j.floor = 1;
                        j.status_id = 1;
                        j.area = 10;
                        j.cost = 10;
                        j.value_added = 10;
                        db.pavilions.Add(j);
                        db.Shop_Centers.Add(i);
                        db.SaveChanges();
                        MessageBox.Show("Успешно");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка ввода данных");
                }
            }
        }
    }
}
