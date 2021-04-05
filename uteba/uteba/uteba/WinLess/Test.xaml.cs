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
using static uteba.WinLess.ClassApp;

namespace uteba
{
    /// <summary>
    /// Логика взаимодействия для Test.xaml
    /// </summary>
    public partial class Test : Window
    {

        int testNum;
        int progressNum;
        int a = 0;
        public Test(int pageNum)
        {
            InitializeComponent();

            testNum = pageNum;

        }

        private void testp_Loaded(object sender, RoutedEventArgs e)
        {


            // StreamReader sr = new StreamReader($@"D:\uchebnizurnal\uteba\uteba\uteba\tests\test{testNum}_1.txt");
            StreamReader sr = new StreamReader($@"C:\Users\WSR\source\repos\uchebnizurnal\uteba\uteba\uteba\tsts\test{testNum}_1.txt");
            testp.Text = sr.ReadToEnd();


        }

        private void next_Click(object sender, RoutedEventArgs e)
        {

            //StreamReader sr = new StreamReader($@"D:\uchebnizurnal\uteba\uteba\uteba\tests\test{testNum}_2.txt");


            if (testNum == 1)
            {
                if (vC.IsChecked == true)
                {
                    StreamReader sr = new StreamReader($@"C:\Users\WSR\source\repos\uchebnizurnal\uteba\uteba\uteba\tsts\test{testNum}_2.txt");
                    testp.Text = sr.ReadToEnd();
                     a++;

                }
                else
                {
                    MessageBox.Show("Вы выбрали неверный ответ!");
                    Close();
                }
            }
        }

        private void nazad_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void finish_Click(object sender, RoutedEventArgs e)
        {

            if (testNum == 1)
            {
                if (vA.IsChecked == true)
                {
                    a++;
                    progressNum = (int)usStud.lessCheck;

                    if (testNum - progressNum == 1 && a == 2)
                    {

                    }

                }
                else
                {
                    MessageBox.Show("Вы выбрали неверный ответ!");
                    Close();
                }
            }
        }
    }
    
}
