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

namespace WpfApplication5
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
   kjhjjj
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (txt1.Text == "admin" && ps1.Password == "123")
            {

                anaekran ana = new anaekran();
                ana.Show();
                this.Hide();




            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Yanlış");
            }



        }
    }
}
