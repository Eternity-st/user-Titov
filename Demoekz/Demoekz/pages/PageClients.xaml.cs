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
using Demoekz.sources;
using Demoekz.pages;

namespace Demoekz.pages
{
    /// <summary>
    /// Логика взаимодействия для PageClients.xaml
    /// </summary>
    public partial class PageClients : Page
    {
        public PageClients()
        {
            InitializeComponent();
        }

        private void first_Click(object sender, RoutedEventArgs e)
        {
            FrameObj.frameObj.Navigate(new PageFirst());
        }

        private void second_Click(object sender, RoutedEventArgs e)
        {
            FrameObj.frameObj.Navigate(new PageSecond());
        }

        private void third_Click(object sender, RoutedEventArgs e)
        {
            FrameObj.frameObj.Navigate(new Pagethird());
        }

        private void four_Click(object sender, RoutedEventArgs e)
        {
            FrameObj.frameObj.Navigate(new Pagefour());
        }

        private void five_Click(object sender, RoutedEventArgs e)
        {
            FrameObj.frameObj.Navigate(new Pagefive());
        }

        private void another_Click(object sender, RoutedEventArgs e)
        {
            FrameObj.frameObj.Navigate(new Pageanother());
        }
    }
}
