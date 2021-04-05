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

namespace uteba
{
    /// <summary>
    /// Логика взаимодействия для Lession.xaml
    /// </summary>
    public partial class Lession : Window
    {
        private int pageNum = 0;
        public Lession()
        {
            InitializeComponent();
            lespage.Navigate(new LesPage(pageNum));
        }

       

        private void les1_Click(object sender, RoutedEventArgs e)
        {
            pageNum = 1;
            lespage.Navigate(new LesPage(pageNum));
        }

        private void les2_Click(object sender, RoutedEventArgs e)
        {
            pageNum = 2;
            lespage.Navigate(new LesPage(pageNum));
        }

        private void les3_Click(object sender, RoutedEventArgs e)
        {
            pageNum = 3;
            lespage.Navigate(new LesPage(pageNum));
        }

        private void les4_Click(object sender, RoutedEventArgs e)
        {
            pageNum = 4;
            lespage.Navigate(new LesPage(pageNum));
        }

        private void les5_Click(object sender, RoutedEventArgs e)
        {
            pageNum = 5;
            lespage.Navigate(new LesPage(pageNum));
        }

        private void les6_Click(object sender, RoutedEventArgs e)
        {
            pageNum = 6;
            lespage.Navigate(new LesPage(pageNum));
        }

        private void les7_Click(object sender, RoutedEventArgs e)
        {
            pageNum = 7;
            lespage.Navigate(new LesPage(pageNum));
        }

        private void les8_Click(object sender, RoutedEventArgs e)
        {
            pageNum = 8;
            lespage.Navigate(new LesPage(pageNum));
        }

        private void les9_Click(object sender, RoutedEventArgs e)
        {
            pageNum = 9;
            lespage.Navigate(new LesPage(pageNum));
        }

        private void les10_Click(object sender, RoutedEventArgs e)
        {
            pageNum = 10;
            lespage.Navigate(new LesPage(pageNum));
        }
    }
}
