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
using uteba.WinLess;
using static uteba.WinLess.ClassApp;



namespace uteba
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static public int sw_roll = 0;
        public MainWindow()
        {
            InitializeComponent();

        }

        enum Role
        {
            admin = 1,
            student
        }

        private void bt_ent_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var user1 = context.Students.ToList().
                    Where(i => log_txtbx.Text == i.login && pass_psbx.Password == i.password).FirstOrDefault();
                var user2 = context.Teachers.ToList().
                    Where(i => log_txtbx.Text == i.login && pass_psbx.Password == i.password).FirstOrDefault();
                AdminWin adminWin = new AdminWin();
                Kabinet studWin = new Kabinet();
                if (user1 != null && user2 == null)
                {
                    Close();
                    usStud = user1;
                    studWin.ShowDialog();
                   // this.Show();

                }
                else if(user1 == null && user2 != null)
                {
                    Close();
                    usTeach = user2;
                    adminWin.ShowDialog();
                    //this.Show();
                }
                else 
                {
                    MessageBox.Show("Логин или пароль введены неверно");
                }
        }
            catch (Exception msg)
            {
                MessageBox.Show(msg.Message);
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
