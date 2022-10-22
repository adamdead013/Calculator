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

namespace Calculator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        long a, b, c; //a - first num b - second c - result
        char sign; //what sign used (+ - * /)
        public MainWindow()
        {
            InitializeComponent();
        }

        private void operation(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            sign = btn.Content.ToString().ToCharArray().FirstOrDefault(); //sign is current button text
            a = Convert.ToInt64(textblock.Content); // a is first number
            Clear(); //clear text field
        }

        private void textAdd_0(object sender, RoutedEventArgs e)
        {
            //this function add current num for text field
            Button current = (Button)sender;
            textblock.Content += current.Content.ToString();
        }

        private void result(object sender, RoutedEventArgs e)
        {
           
            b = Convert.ToInt64(textblock.Content); //b is second num
            _ = sign == '/' ? c = a / b : sign == '+' ? c = a + b : sign == '-' ? c = a - b : c = a * b;
            textblock.Content = c.ToString();
        }
        private void Clear()
        {
            textblock.Content = null;
        }
        private void Clear(object sender, RoutedEventArgs e)
        {
            textblock.Content = null;
        }
    }
}
