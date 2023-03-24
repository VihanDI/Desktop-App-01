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
using Desktop_App_01.Models;
using Desktop_App_01.ViewModels;
using Desktop_App_01.Views;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using static System.Net.Mime.MediaTypeNames;

namespace Desktop_App_01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowVM();
        }
        private void Button_Add_Student(object sender, RoutedEventArgs e)
        {
            var window = new AddStudentWindow();
            window.Show();
            Close();
        }

        /*
        private void Button_Quit(object sender, RoutedEventArgs e)
        {
            Close();
            var window = new EditStudentWindow();
            window.Show();
        }
        */

        private void Button_Edit_Student(object sender, RoutedEventArgs e)
        {
            Student selectedStudent = (List1.SelectedItem as Student);

            var window = new EditStudentWindow(selectedStudent.ID, selectedStudent.FirstName, selectedStudent.LastName, selectedStudent.Age, selectedStudent.Image);
            window.Show();
            Close();
            /*
            var window = new EditStudentWindow();
            window.Show();
            */
        }

        private void Button_Delete(object sender, RoutedEventArgs e)
        {
            Student selectedStudent = (List1.SelectedItem as Student);

            //DialogResult result = MessageBox.Show("Are you sure you want to delete this student?", "Confirmation", MessageBoxButton.YesNo);
            
            if(MessageBox.Show("Are you sure you want to delete this student?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                using (var db = new DataBaseContext())
                {
                    var students = db.ListofStudents;
                    foreach (var s in students)
                    {
                        if (selectedStudent.ID == s.ID)
                        {
                            db.Remove(s);
                            db.SaveChanges();
                        }
                    }
                }
            }

            /*
            var window = new EditStudentWindow();
            window.Show();
            */
        }

        /*
        private void ListView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Student selectedStudent = (List1.SelectedItem as Student);
            
            var window = new EditStudentWindow(selectedStudent.ID, selectedStudent.FirstName, selectedStudent.LastName, selectedStudent.Age, selectedStudent.Image);
            window.Show();
            Close();
        }
        */
    }
}
