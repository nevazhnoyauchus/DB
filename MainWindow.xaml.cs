﻿using database2.Pages;
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

namespace database2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            BaseClass.Base = new Entities();
            FrameClass.FrameMain = MainFrame;
            FrameClass.FrameMain.Navigate(new AutoPage());
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FrameClass.FrameMain.Navigate(new RegPage());
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            FrameClass.FrameMain.Navigate(new AutoPage());
        }
    }
}
