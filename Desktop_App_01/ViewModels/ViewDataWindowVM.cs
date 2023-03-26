using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Desktop_App_01.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Desktop_App_01.ViewModels
{
    public partial class ViewDataWindowVM : ObservableObject
    {
        [ObservableProperty]
        public string firstName;

        [ObservableProperty]
        public string lastName;

        [ObservableProperty]
        public int age;

        [ObservableProperty]
        public string image;

        [ObservableProperty]
        public DateTime dateOfBirth;

        [ObservableProperty]
        public double gPA;

        int index;

        public ViewDataWindowVM()
        {
            FirstName = null;
            LastName = null;
            Age = 0;
            image = null;
            gPA = 0;
        }

        public ViewDataWindowVM(int id, string fname, string lname, int a, string img, double gpa, DateTime dob)
        {
            index = id;
            FirstName = fname;
            LastName = lname;
            Age = a;
            image = img;
            gPA = gpa;
            dateOfBirth = dob;
        }
    }
}
