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

namespace mahmudov
{

    public partial class Window2 : Window
    {
        private string Number = "";
        private string Numb = "";
        private string operation = "";
        private bool Operator = false;

        public Window2()
        {
            InitializeComponent();
        }
        private void number_Click(object sender, RoutedEventArgs e)
        {
            if (Operator)
            {
                Number = "";
                Operator = false;
            }

            Button button = (Button)sender;
            Number += button.Content.ToString();
            ICRAN.Text = Number;
        }

        private void operation_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Content.ToString();
            Numb = Number;
            Operator = true;
        }



        private void result_Click(object sender, RoutedEventArgs e)
        {
            double result = Calculate();
            ICRAN.Text = result.ToString();
            Number = result.ToString();
            Numb = "";
            operation = "";
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            Number = "";
            Numb = "";
            operation = "";
            Operator = false;
            ICRAN.Text = "0";
        }

        private void ICRAN_TextChanged(object sender, TextChangedEventArgs e)
        {


        }

        private void EXIT_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private double Calculate()
        {

            double num1 = Convert.ToDouble(Number);
            double num2 = Convert.ToDouble(Numb);


            switch (operation)
            {
                case "!":
                    if (num1 == 0)
                    {
                        return 1;
                    }

                    long res = 1;

                    for (int i = 1; i <= num1; i++)
                    {
                        res *= i;
                    }
                    return res;
                case "+":

                    return num1 + num2;

                case "-":

                    return num1 - num2;

                case "*":

                    return num1 * num2;

                case "/":
                    if (num2 == 0)
                    {
                        MessageBox.Show("Деление на ноль невозможно!");
                        return 0;
                    }

                    return num2 / num1;

                case "^":

                    if (num2 == 0)
                    {
                        return 1;

                    }

                    return Math.Pow(num2, num1);





                default:

                    return 0;



            }

        }
        private void ONE_Click(object sender, RoutedEventArgs e)
        {
            if (Number.Length > 0)
            {
                Number = Number.Substring(0, Number.Length - 1);
                ICRAN.Text = Number;
            }
        }

    }
}