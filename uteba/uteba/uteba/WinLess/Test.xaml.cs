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
    /// Логика взаимодействия для Test.xaml
    /// </summary>
    public partial class Test : Window
    {
        public int testNum = 1;
        public Test(int pageNum)
        {
            InitializeComponent();
           
            
        }

        private void next_Click(object sender, RoutedEventArgs e)
        {
            testNum = 2;
        }

        private void nazad_Click(object sender, RoutedEventArgs e)
        {



        }
    }
}
