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
    /// Interaction logic for ViewDataWindow.xaml
    /// </summary>
    public partial class ViewDataWindow : Window
    {
        public ViewDataWindow(int id, string fname, string lname, int age, string img, double gpa, DateTime dob)
        {
            InitializeComponent();
            DataContext = new ViewDataWindowVM(id, fname, lname, age, img, gpa, dob);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }
    }

}
