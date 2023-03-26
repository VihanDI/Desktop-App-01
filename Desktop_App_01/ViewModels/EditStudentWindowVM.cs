using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Desktop_App_01.Models;
using Desktop_App_01.Views;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Desktop_App_01.ViewModels
{
    public partial class EditStudentWindowVM : ObservableObject
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
        public DateOnly dateOfBirth;

        [ObservableProperty]
        public double gPA;

        int index;
        public EditStudentWindowVM()
        {
            FirstName = null;
            LastName = null;
            Age = 0;
            image = null;
            GPA = 0;
        }

        public EditStudentWindowVM(int id, string fname, string lname, int a, string img, double gpa, DateOnly dob)
        {
            index = id;
            FirstName = fname;
            LastName = lname;
            Age = a;
            image = img;
            GPA = gpa;
            dateOfBirth = dob;
        }

        [RelayCommand]
        public void editStudent()
        {
            if (firstName == "" || lastName == "" || (age <= 0 || age > 120) || image == "" || (gPA == 0 || gPA > 4.0))
            {
                var window = new EmptyErrorMessageBox();
                window.ShowDialog();
            }
            else
            {
                using (var db = new DataBaseContext())
                {
                    var students = db.ListofStudents;
                    foreach (var s in students)
                    {
                        if (index == s.ID)
                        {
                            s.FirstName = firstName;
                            s.LastName = lastName;
                            s.Age = age;
                            s.Image = image;
                            s.GPA = gPA;
                            s.DateOfBirth = dateOfBirth;
                        }
                    }
                    db.SaveChanges();
                }

                var window = new SavedMessageBoxWindow();
                window.ShowDialog();
            }
        }
    }
}
