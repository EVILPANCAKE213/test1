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

namespace LB1
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
            labik2.Content = "" + tb1.Text +" ";
                
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            labik2.Content = "" + tb1.Text + " ";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Window4 win4 = new Window4();
            win4.Show();
        }
    }
}
