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
        public int pageNum = 0;
        public Lession()
        {
            InitializeComponent();
            lespage.Navigate(new LesPage(pageNum));
        }

       

        private void les1_Click(object sender, RoutedEventArgs e)
        {
            pageNum = 1;
            lespage.Navigate(new LesPage(pageNum));
            if (testl1.Visibility == Visibility.Visible)
            {
                testl1.Visibility = Visibility.Collapsed;
            }
            else
            {
                testl1.Visibility = Visibility.Visible;

            }
        }

        private void les2_Click(object sender, RoutedEventArgs e)
        {
            pageNum = 2;
            lespage.Navigate(new LesPage(pageNum));
            if (testl2.Visibility == Visibility.Visible)
            {
                testl2.Visibility = Visibility.Collapsed;
            }
            else
            {
                testl2.Visibility = Visibility.Visible;

            }
        }

        private void les3_Click(object sender, RoutedEventArgs e)
        {
            pageNum = 3;
            lespage.Navigate(new LesPage(pageNum));
            if (testl3.Visibility == Visibility.Visible)
            {
                testl3.Visibility = Visibility.Collapsed;
            }
            else
            {
                testl3.Visibility = Visibility.Visible;

            }
        }

        private void les4_Click(object sender, RoutedEventArgs e)
        {
            pageNum = 4;
            lespage.Navigate(new LesPage(pageNum));
            if (testl4.Visibility == Visibility.Visible)
            {
                testl4.Visibility = Visibility.Collapsed;
            }
            else
            {
                testl4.Visibility = Visibility.Visible;

            }
        }

        private void les5_Click(object sender, RoutedEventArgs e)
        {
            pageNum = 5;
            lespage.Navigate(new LesPage(pageNum));
            if (testl5.Visibility == Visibility.Visible)
            {        
                testl5.Visibility = Visibility.Collapsed;
            }        
            else     
            {        
                testl5.Visibility = Visibility.Visible;

            }
        }

        private void les6_Click(object sender, RoutedEventArgs e)
        {
            pageNum = 6;
            lespage.Navigate(new LesPage(pageNum));
            if (testl6.Visibility == Visibility.Visible)
            {
                testl6.Visibility = Visibility.Collapsed;
            }
            else
            {
                testl6.Visibility = Visibility.Visible;

            }
        }

        private void les7_Click(object sender, RoutedEventArgs e)
        {
            pageNum = 7;
            lespage.Navigate(new LesPage(pageNum));
            if (testl7.Visibility == Visibility.Visible)
            {
                testl7.Visibility = Visibility.Collapsed;
            }
            else
            {
                testl7.Visibility = Visibility.Visible;

            }
        }

        private void les8_Click(object sender, RoutedEventArgs e)
        {
            pageNum = 8;
            lespage.Navigate(new LesPage(pageNum));
            if (testl8.Visibility == Visibility.Visible)
            {
                testl8.Visibility = Visibility.Collapsed;
            }
            else
            {
                testl8.Visibility = Visibility.Visible;

            }
        }

        private void les9_Click(object sender, RoutedEventArgs e)
        {
            pageNum = 9;
            lespage.Navigate(new LesPage(pageNum));
            if (testl9.Visibility == Visibility.Visible)
            {
                testl9.Visibility = Visibility.Collapsed;
            }
            else
            {
                testl9.Visibility = Visibility.Visible;

            }
        }

        private void les10_Click(object sender, RoutedEventArgs e)
        {
            pageNum = 10;
            lespage.Navigate(new LesPage(pageNum));
            if (testl10.Visibility == Visibility.Visible)
            {
                testl10.Visibility = Visibility.Collapsed;
            }
            else
            {
                testl10.Visibility = Visibility.Visible;

            }
        }

        private void testl1_Click(object sender, RoutedEventArgs e)
        {
            Test test = new Test(pageNum);
            Hide();
            test.ShowDialog();
            Show();
        }

      
    }
}
