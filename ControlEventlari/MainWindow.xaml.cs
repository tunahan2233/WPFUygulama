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

namespace ControlEventlari
{
    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show(ogrenci.OgrenciAdi);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int a = 10;
            int b;
            b = a * 2;
            string deger = b.ToString();
            MessageBox.Show($"Sayinin Karesi = {deger}");
            this.Title = "Butona tıklandı!";
        }
    }

}
