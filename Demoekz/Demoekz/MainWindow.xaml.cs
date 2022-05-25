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
using Demoekz.sources;
using Demoekz.pages;

namespace Demoekz
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            FrameObj.frameObj = BtnMain;
            BtnMain.Navigate(new PageClients());
            
        }

        private void BackMain_Click(object sender, RoutedEventArgs e)
        {
            if (FrameObj.frameObj.CanGoBack) {
                FrameObj.frameObj.GoBack();
            }
        }
    }
}
