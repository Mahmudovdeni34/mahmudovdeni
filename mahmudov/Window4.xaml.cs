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
    /// Логика взаимодействия для Window4.xaml 
    /// </summary> 
    public partial class Window4 : Window
    {
        public Window4()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string password1 = Convert.ToString(NumberX.Text);
            string password = "qwerty";
            if (password1 == "qwerty") Resultat.Content = "Пароль верный. ";
            else if (password1 != password) Resultat.Content = "Пароль неверный, попробуйте ещё.";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow pw = new MainWindow();
            pw.Show();
            Close();
        }

        private void NumberX_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}