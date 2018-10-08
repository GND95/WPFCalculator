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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();           // 
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            lblResult.Content = startingValue.ToString();
        }

        public decimal startingValue;
        class Storage
        {
            public string input, result;            
            public bool add = false, subtract = false, multiply = false, divide = false;
        }
        Storage S1 = new Storage();

        private void btnDecimal_Click(object sender, RoutedEventArgs e)
        {
            S1.input += ".";
            lblInput.Content = S1.input;
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            S1.input += 0;
            lblInput.Content = S1.input;          
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            S1.input += 1;
            lblInput.Content = S1.input;
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            S1.input += 2;
            lblInput.Content = S1.input;
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            S1.input += 3;
            lblInput.Content = S1.input;
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            S1.input += 4;
            lblInput.Content = S1.input;
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            S1.input += 5;
            lblInput.Content = S1.input;
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            S1.input += 6;
            lblInput.Content = S1.input;
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            S1.input += 7;
            lblInput.Content = S1.input;
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            S1.input += 8;
            lblInput.Content = S1.input;
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            S1.input += 9;
            lblInput.Content = S1.input;
        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            S1.add = true;
            S1.subtract = false;
            S1.multiply = false;
            S1.divide = false;
            
            S1.result = lblResult.Content.ToString();
            if (S1.add == true)
            {
                lblResult.Content = (Convert.ToDouble(S1.result) + Convert.ToDouble(S1.input)).ToString();
            }
         
            S1.input = "0";
            lblInput.Content = 0;
        }

        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            S1.add = false;
            S1.subtract = true;
            S1.multiply = false;
            S1.divide = false;

            S1.result = lblResult.Content.ToString();
            if (S1.subtract == true)
            {
                lblResult.Content = (Convert.ToDouble(S1.result) - Convert.ToDouble(S1.input)).ToString();
            }

            S1.input = "0";
            lblInput.Content = 0;
        }

        private void btnMultiply_Click(object sender, RoutedEventArgs e)
        {
            S1.add = false;
            S1.subtract = false;
            S1.multiply = true;
            S1.divide = false;

            S1.result = lblResult.Content.ToString();
            if (S1.multiply == true)
            {
                lblResult.Content = (Convert.ToDouble(S1.result) * Convert.ToDouble(S1.input)).ToString();
            }

            S1.input = "0";
            lblInput.Content = 0;
        }

        private void btnDivide_Click(object sender, RoutedEventArgs e)
        {
            S1.add = false;
            S1.subtract = false;
            S1.multiply = false;
            S1.divide = true;

            S1.result = lblResult.Content.ToString();
            if (S1.divide == true)
            {
                lblResult.Content = (Convert.ToDouble(S1.result) / Convert.ToDouble(S1.input)).ToString();
            }

            S1.input = "0";
            lblInput.Content = 0;
        }        
    }
}
