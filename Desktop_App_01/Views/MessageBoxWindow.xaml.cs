using Desktop_App_01.Models;
using System;
using System.Collections;
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
    /// Interaction logic for MessageBoxWindow.xaml
    /// </summary>
    public partial class MessageBoxWindow : Window
    {
        public MessageBoxWindow()
        {
            InitializeComponent();
        }

        int index;

        public MessageBoxWindow(Student student)
        {
            InitializeComponent();
            index = student.ID;
        }

        private void Button_Yes(object sender, RoutedEventArgs e)
        {
            using (var db = new DataBaseContext())
            {
                var students = db.ListofStudents;
                foreach (var s in students)
                {
                    if (index == s.ID)
                    {
                        db.Remove(s);
                        db.SaveChanges();
                    }
                }
            }
            Close();
        }

        private void Button_No(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
