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
using static uteba.WinLess.ClassApp;

namespace uteba
{
    /// <summary>
    /// Логика взаимодействия для Kabinet.xaml
    /// </summary>
    public partial class Kabinet : Window
    {
       
        public Kabinet()
        {
            InitializeComponent();
        }

        private void btn_lessons_Click(object sender, RoutedEventArgs e)
        {
            Lession lession = new Lession();
            Close();
            lession.ShowDialog();            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            txtblk_fName.Text = usStud.fName;
            txtblk_lName.Text = usStud.lName;
            txtblk_group.Text = usStud.group.ToString();
            pb_Lesson.Value = (int)usStud.lessCheck;
        }

        private void btn_Exit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            Close();
            mainWindow.ShowDialog();
        }

    }
}
