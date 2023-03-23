using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Desktop_App_01.Models;
using Desktop_App_01.ViewModels;
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

        [RelayCommand]
        public void InsertStudent()
        {
            Student s = new Student()
            {
                FirstName = FirstName,
                LastName = LastName,
                Image = Image,
                Age = age
            };

            using (var db = new DataBaseContext())
            {
                db.ListofStudents.Add(s);
                db.SaveChanges();
            }
        }
    }
}
