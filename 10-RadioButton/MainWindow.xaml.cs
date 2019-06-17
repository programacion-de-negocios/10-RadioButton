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

namespace _10_RadioButton
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void YesChecked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("SIIIII!!");
        }

        private void NoChecked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("NOOOOOOOOO!");
        }

        private void Maybe_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("pueda ser");
        }
    }
}
