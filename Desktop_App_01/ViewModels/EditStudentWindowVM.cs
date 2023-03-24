using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Desktop_App_01.Models;
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

        int index;

        public EditStudentWindowVM()
        {
            FirstName = null;
            LastName = null;
            Age = 0;
            Image = null;
        }

        public EditStudentWindowVM(int id, string fname, string lname, int a, string img)
        {
            index = id;
            FirstName = fname;
            LastName = lname;
            Age = a;
            Image = img;

        }

        [RelayCommand]
        public void editStudent()
        {
            using (var db = new DataBaseContext())
            {
                var students = db.ListofStudents;
                foreach (var s in students)
                {
                    if(index == s.ID)
                    {
                        s.FirstName = firstName;
                        s.LastName = lastName;
                        s.Age = age;
                        s.Image = image;
                    }
                }
                db.SaveChanges();
            }
        }
    }
}
