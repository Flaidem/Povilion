﻿using System;
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
    /// Логика взаимодействия для AddPov.xaml
    /// </summary>
    public partial class AddPov : Window
    {
        int id;
        public AddPov(int id_shop)
        {
            InitializeComponent();
            id = id_shop;
        }
        //Проверки
        private void addpov(object sender, RoutedEventArgs e)
        {
            using (var db = new PovillonsEntities())
            {
                var j = new pavilion();
                j.Shop_Centr_id = id;
                j.num_povil = numbox.Text;
                j.floor = Convert.ToInt32(flobox.Text);
                j.status_id = 1;
                j.area = Convert.ToSingle(areabox.Text);
                j.cost = Convert.ToDecimal(costbox.Text);
                j.value_added = Convert.ToSingle(ratiobox.Text);
                db.pavilions.Add(j);
                db.SaveChanges();
            }
        }
    }
}
