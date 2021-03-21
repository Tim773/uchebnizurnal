using System;
using System.Collections.Generic;
using System.IO;
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
        
        int testNum;
        public Test(int pageNum)
        {
            InitializeComponent();

             testNum = pageNum;
             
        }

        private void testp_Loaded(object sender, RoutedEventArgs e)
        {


            // StreamReader sr = new StreamReader($@"D:\uchebnizurnal\uteba\uteba\uteba\tests\test{testNum}_1.txt");
            StreamReader sr = new StreamReader($@"F:\uchebnizurnal\uteba\uteba\uteba\tests\test{testNum}_1.txt");
            testp.Text = sr.ReadToEnd();

            
        }

        private void next_Click(object sender, RoutedEventArgs e)
        {
            
            //StreamReader sr = new StreamReader($@"D:\uchebnizurnal\uteba\uteba\uteba\tests\test{testNum}_2.txt");
            StreamReader sr = new StreamReader($@"F:\uchebnizurnal\uteba\uteba\uteba\tests\test{testNum}_2.txt");
            testp.Text = sr.ReadToEnd();
        }

        private void nazad_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

    }
}
