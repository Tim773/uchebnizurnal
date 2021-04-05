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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace uteba
{
    /// <summary>
    /// Логика взаимодействия для LesPage.xaml
    /// </summary>
    public partial class LesPage : Page
    {
        private int _num;
        public LesPage(int pageNum)
        {
            InitializeComponent();
            _num = pageNum; 
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            //StreamReader sr = new StreamReader($@"D:\uchebnizurnal\uteba\uteba\uteba\lessons\{_num}.txt");
            StreamReader sr = new StreamReader($@"C:\Users\WSR\source\repos\uchebnizurnal\uteba\uteba\uteba\lssns\{_num}.txt");
            urok.Text = sr.ReadToEnd();
           
        }
    }
}
