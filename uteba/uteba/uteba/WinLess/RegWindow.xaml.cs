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
using uteba.WinLess;
using static uteba.WinLess.ClassApp;

namespace uteba
{
    /// <summary>
    /// Логика взаимодействия для RegWindow.xaml
    /// </summary>
    public partial class RegWindow : Window
    {

        public RegWindow()
        {
            InitializeComponent();


        }
        private void Reg_Click(object sender, RoutedEventArgs e)
        {
            try
            {

            if (name_txt.Text != string.Empty && surname_txt.Text != string.Empty && rlog_txt.Text != string.Empty && rpsw_txt.Password != string.Empty)
            {
                Students students = context.Students.Add(new Students
                {
                    fName = name_txt.Text,
                    lName = surname_txt.Text,
                    login = rlog_txt.Text,
                    password = rpsw_txt.Password,
                    group = cb_group.SelectedIndex + 1,
                    lessCheck = 0,
                    available = 1,
                    dob = dobPick.SelectedDate ?? DateTime.MinValue
                }
                ) ;
                context.SaveChanges();
                MessageBox.Show("Данные внесены");
            }
            else
            {
                MessageBox.Show("Заполните все поля!");
            }

            }
            catch 
            {

                MessageBox.Show("Проверьте корректность введённых данных!!!!!");
            }
            
        }
        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
            {
                e.Handled = true;
            }
        }

        private void ComboBox_Loaded(object sender, RoutedEventArgs e)
        {
            var gr = context.Group;
            cb_group.ItemsSource = gr.ToList();
        }

        private void btn_Exit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            Close();
            mainWindow.ShowDialog();
        }
    }
}
