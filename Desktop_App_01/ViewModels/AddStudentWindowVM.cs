using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Desktop_App_01.Models;
using Desktop_App_01.ViewModels;
using Desktop_App_01.Views;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop_App_01.ViewModels
{
    public partial class AddStudentWindowVM : ObservableObject
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

        public AddStudentWindowVM()
        {
            FirstName = null;
            LastName = null;
            Age = 0;
            image = null;
            gPA = 0;
        }

        [RelayCommand]
        public void InsertStudent()
        {
            Student s = new Student()
            {
                FirstName = firstName,
                LastName = lastName,
                Image = image,
                Age = age,
                GPA = gPA,
                DateOfBirth = dateOfBirth
            };

            if(firstName == "" || lastName == "" || (age <= 0 || age > 120) || image == "" || (gPA == 0 || gPA > 4.0))
            {
                var window = new EmptyErrorMessageBox();
                window.ShowDialog();
            }
            else
            {
                using (var db = new DataBaseContext())
                {
                    db.ListofStudents.Add(s);
                    db.SaveChanges();
                }

                var window = new SavedMessageBoxWindow();
                window.ShowDialog();
            }
        }
    }
}
