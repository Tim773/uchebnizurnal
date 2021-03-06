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
    /// Логика взаимодействия для TestPage1.xaml
    /// </summary>
    public partial class TestPage1 : Page
    {
        int _num;
        int _tstnum;
        public TestPage1(int pageNum, int testNum)
        {
            InitializeComponent();
            _num = pageNum;
            _tstnum = testNum;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            if (_tstnum == 2)
            {
                StreamReader sr = new StreamReader($@"F:\uchebnizurnal\uteba\uteba\uteba\tests\test{_num}_2.txt");
                testp.Text = sr.ReadToEnd();
            }
            else
            {
                StreamReader sr = new StreamReader($@"F:\uchebnizurnal\uteba\uteba\uteba\tests\test{_num}_1.txt");
                testp.Text = sr.ReadToEnd();

            }

        }

      
    }
}
