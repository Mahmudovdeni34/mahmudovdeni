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

namespace mahmudov
{
    /// <summary>
    /// Логика взаимодействия для Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int number = Convert.ToInt32(NumberX.Text);
            if (number >= 0 & number <= 14) Resultat.Content = "Число в промежутке [0-14]";
            else if (number >= 15 & number <= 35) Resultat.Content = "Число в промежутке [15-35]";
            else if (number >= 36 & number <= 50) Resultat.Content = "Число в промежутке [36-50]";
            else if (number >= 51 & number <= 100) Resultat.Content = "Число в промежутке [50-100]";
            else Resultat.Content = "Число не найдено";
        }

        private void NumberX_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow pw = new MainWindow();
            pw.Show();
            Close();
        }
    }
}
