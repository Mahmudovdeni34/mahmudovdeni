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
using WeatherTranslator;

namespace mahmudov
{
    /// <summary> 
    /// Interaction logic for MainWindow.xaml 
    /// </summary> 
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 Window = new Window1();
            Window.Show();
            this.Close();
        }
        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            Window2 Window = new Window2();
            Window.Show();
            this.Close();
        }
        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            Window3 Window = new Window3();
            Window.Show();
            this.Close();
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            Window4 Window = new Window4();
            Window.Show();
            this.Close();
        }
    }
}