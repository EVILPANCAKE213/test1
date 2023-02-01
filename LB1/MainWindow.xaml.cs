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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LB1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Fon.Background = new SolidColorBrush(Colors.Red);
        }

        private void Green_Click(object sender, RoutedEventArgs e)
        {
            Fon.Background = new SolidColorBrush(Colors.Green);
        }

        private void Blue_Click(object sender, RoutedEventArgs e)
        {
            Fon.Background = new SolidColorBrush(Colors.Blue);
        }

        private void Yellow_Click(object sender, RoutedEventArgs e)
        {
            Fon.Background = new SolidColorBrush(Colors.Yellow);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window2 win2 = new Window2(); 
            win2.Show();
        }
    }
}