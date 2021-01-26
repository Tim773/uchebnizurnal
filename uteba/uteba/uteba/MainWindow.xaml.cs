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

namespace uteba
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string login = "admin";
        string password = "123";
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void bt_ent_Click(object sender, RoutedEventArgs e)
        {
           if (log_txtbx.Text == login && pass_psbx.Password == password)
           {
                Kabinet kabinet = new Kabinet();
                this.Close();
                kabinet.ShowDialog();
           }
            else
            {
                MessageBox.Show("Логин или пароль введены неверно");
            }
           
        }

        private void bt_reg_Click(object sender, RoutedEventArgs e)
        {
            RegWindow reg = new RegWindow();
            this.Hide();
            reg.ShowDialog();
            this.Show();
        }
    }
}
