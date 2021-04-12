using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using static uteba.WinLess.ClassApp;

namespace uteba.WinLess
{
    /// <summary>
    /// Логика взаимодействия для AdminWin.xaml
    /// </summary>
    public partial class AdminWin : Window
    {
        public AdminWin()
        {
            InitializeComponent();
        }

        private void studGrid_Loaded(object sender, RoutedEventArgs e)
        {
            var stud = context.Students;
            var gr = context.Group;
            grCB.ItemsSource = gr.ToList();

            var result = stud.Where(i => i.available > 0);
            studGrid.ItemsSource = result.ToList();

        }

        private void soft_del_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var itm = studGrid.SelectedItem;
                if (itm == null)
                {
                    return;
                }
                if (MessageBox.Show("Строка пользователя будет удалена из таблицы. Желаете продолжить?", "Удаление", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    int del = (studGrid.SelectedItem as Students).idStudents;

                    Students students = context.Students.Where(i => i.idStudents == del).FirstOrDefault();
                    students.available = 0;
                    context.SaveChanges();
                    studGrid_Loaded(sender, e);
                }
                else return;

            }
            catch (Exception ex)
            {

                MessageBox.Show("Что-то пошло не так!!!!!!", ex.Message);
            }


        }
        private void btn_Exit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            Close();
            mainWindow.ShowDialog();
        }
    }
}
