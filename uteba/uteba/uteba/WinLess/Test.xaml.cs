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
        
        int a = 0;
        public Test(int pageNum)
        {
            InitializeComponent();

            testNum = pageNum;

        }

        private void testp_Loaded(object sender, RoutedEventArgs e)
        {

            progress = (int)usStud.lessCheck;
            // StreamReader sr = new StreamReader($@"D:\uchebnizurnal\uteba\uteba\uteba\tests\test{testNum}_1.txt");
            StreamReader sr = new StreamReader($@"C:\Users\WSR\source\repos\uchebnizurnal\uteba\uteba\uteba\tsts\test{testNum}_1.txt");
            testp.Text = sr.ReadToEnd();


        }

        private void next_Click(object sender, RoutedEventArgs e)
        {

            //StreamReader sr = new StreamReader($@"D:\uchebnizurnal\uteba\uteba\uteba\tests\test{testNum}_2.txt");
           
                StreamReader sr = new StreamReader($@"C:\Users\WSR\source\repos\uchebnizurnal\uteba\uteba\uteba\tsts\test{testNum}_2.txt");
                testp.Text = sr.ReadToEnd();
                otveti.Visibility = Visibility.Hidden;
                otveti2.Visibility = Visibility.Visible;

        }

        private void nazad_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void finish_Click(object sender, RoutedEventArgs e)
        {
            if (a == 2)
            {

                progress += 1;
                usStud.lessCheck = progress;
               
                MessageBox.Show("Вы прошли тест, ваш результат учтён!");
                context.SaveChanges();
                if (testNum - progress ==1)
                {

                }
                Close();
               
                a = 0;
            }
            else
            {
                MessageBox.Show("Один или несколько ответов неверные!!!!!!");
                a = 0;
            }

        }

        private void ansChecked(object sender, RoutedEventArgs e)
        {
            RadioButton ans = (RadioButton)sender;
            if (testNum == 1)
            {
              if (ans.Name == "vC" && ans.GroupName == "ans1" ) a++;
              else if (ans.Name == "vA2" && ans.GroupName == "ans2") a++;

            }
            if (testNum == 2)
            {
                if (ans.Name == "vC" && ans.GroupName == "ans1") a++;
                else if (ans.Name == "vA2" && ans.GroupName == "ans2") a++;

            }
            if (testNum == 3)
            {
                if (ans.Name == "vC" && ans.GroupName == "ans1") a++;
                else if (ans.Name == "vA2" && ans.GroupName == "ans2") a++;

            }
            if (testNum == 4)
            {
                if (ans.Name == "vC" && ans.GroupName == "ans1") a++;
                else if (ans.Name == "vA2" && ans.GroupName == "ans2") a++;

            }
            if (testNum == 5)
            {
                if (ans.Name == "vC" && ans.GroupName == "ans1") a++;
                else if (ans.Name == "vA2" && ans.GroupName == "ans2") a++;

            }
            if (testNum == 6)
            {
                if (ans.Name == "vC" && ans.GroupName == "ans1") a++;
                else if (ans.Name == "vA2" && ans.GroupName == "ans2") a++;

            }
            if (testNum == 7)
            {
                if (ans.Name == "vC" && ans.GroupName == "ans1") a++;
                else if (ans.Name == "vA2" && ans.GroupName == "ans2") a++;

            }
            if (testNum == 8)
            {
                if (ans.Name == "vC" && ans.GroupName == "ans1") a++;
                else if (ans.Name == "vA2" && ans.GroupName == "ans2") a++;

            }
            if (testNum == 9)
            {
                if (ans.Name == "vC" && ans.GroupName == "ans1") a++;
                else if (ans.Name == "vA2" && ans.GroupName == "ans2") a++;

            }
            if (testNum == 10)
            {
                if (ans.Name == "vC" && ans.GroupName == "ans1") a++;
                else if (ans.Name == "vA2" && ans.GroupName == "ans2") a++;

            }


        }
    }

}
