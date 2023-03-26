using Desktop_App_01.ViewModels;
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

namespace Desktop_App_01.Views
{
    /// <summary>
    /// Interaction logic for EditStudentWindow.xaml
    /// </summary>
    public partial class EditStudentWindow : Window
    {
        public EditStudentWindow()
        {
            InitializeComponent();
            DataContext = new EditStudentWindowVM();
        }

        public EditStudentWindow(int id, string fname, string lname, int age, string img, double gpa, DateTime dob)
        {
            InitializeComponent();
            DataContext = new EditStudentWindowVM(id, fname, lname, age, img, gpa, dob);
        }

        private void Button_Cancel(object sender, RoutedEventArgs e)
        {
            var mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }

        private void Button_Edit(object sender, RoutedEventArgs e)
        {
            //var mainWindow = new MainWindow();
            //mainWindow.Show();
            //Close();
        }

        private void Button_Back(object sender, RoutedEventArgs e)
        {
            var mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }
    }
}
