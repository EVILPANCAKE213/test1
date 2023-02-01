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
    /// Логика взаимодействия для Window5.xaml
    /// </summary>
    public partial class Window5 : Window
    {
        public Window5()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            cl1.Foreground = new SolidColorBrush(Colors.Yellow);
            cl2.Foreground = new SolidColorBrush(Colors.Red);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            cl1.Foreground = new SolidColorBrush(Colors.Blue);
            cl2.Foreground = new SolidColorBrush(Colors.Orange);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            cl1.Foreground = new SolidColorBrush(Colors.White);
            cl2.Foreground = new SolidColorBrush(Colors.White);
        }

        private void Grid_MouseEnter(object sender, MouseEventArgs e)
        {
     
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
           
        }

        private void Grid_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            cl1.Foreground = new SolidColorBrush(Colors.White);
            cl2.Foreground = new SolidColorBrush(Colors.White);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Window6 win6 = new Window6();
            win6.Show();
        }
    }
}
