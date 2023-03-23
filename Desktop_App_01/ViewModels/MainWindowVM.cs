using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Desktop_App_01.Models;

namespace Desktop_App_01.ViewModels
{
    public partial class MainWindowVM : ObservableObject
    {
        [ObservableProperty]
        public ObservableCollection<Student> students;

        [RelayCommand]
        public void LoadStudents()
        {
            using (var db = new DataBaseContext())
            {
                var list = db.ListofStudents.ToList();
                Students = new ObservableCollection<Student>(list);
            }
        }

        public MainWindowVM()
        {
            LoadStudents();
        }
    }
}
