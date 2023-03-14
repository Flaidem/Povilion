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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Povilion
{
    /// <summary>
    /// Логика взаимодействия для Avtoriz.xaml
    /// </summary>
    public partial class Avtoriz : Page
    {
        public Avtoriz()
        {
            InitializeComponent();

        }
        //проверка на должность осталось
        private void Avtor(object sender, RoutedEventArgs e)
        {
            using (var db = new PovillonsEntities())
            {
                db.Empoloys.ToList();
                var log = db.Empoloys.Where(a => a.login == Logbox.Text).FirstOrDefault();
                if ((Logbox.Text == log.login) && (log.password == Passbox.Password))
                {
                    if (log.post_id == 1)
                    {
                        PageHelper.vau.mainframe.Navigate(new STR.AdmAvt());
                    }
                    else if (log.post_id == 3)
                    {
                        PageHelper.vau.mainframe.Navigate(new Maintable());
                    }
                }
                else
                {
                    MessageBox.Show("Ошибка ввода");
                }
            }
        }

        private void TextBox_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            FalsePass.Visibility = Visibility.Hidden;
            Passbox.Focus();
        }

        private void Pass_LostFocus(object sender, RoutedEventArgs e)
        {
            if (Passbox.Password == "")
            {
                FalsePass.Visibility = Visibility.Visible;
            }
        }

        private void Log_LostFocus(object sender, RoutedEventArgs e)
        {
            if (Logbox.Text == "")
            {
                FalseLog.Visibility = Visibility.Visible;
            }
        }

        private void FalseLog_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            FalseLog.Visibility = Visibility.Hidden;
            Logbox.Focus();
        }

        private void Pass_GotFocus(object sender, RoutedEventArgs e)
        {
            FalsePass.Visibility = Visibility.Hidden;
            Passbox.Focus();
        }

        private void FalseLog_GotFocus(object sender, RoutedEventArgs e)
        {
            FalseLog.Visibility = Visibility.Hidden;
            Logbox.Focus();
            Logbox.Foreground = Brushes.Black;
        }

        private void open(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("PackFrame/Reg.xaml", UriKind.Relative));
        }
    }
}
