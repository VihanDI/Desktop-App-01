using Desktop_App_01.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Desktop_App_01
{
    public class DataBaseContext : DbContext
    {
        private readonly string path = @"D:\Data\Documents\Academics\My Works\GitHub Projects\Desktop-App-01\Desktop_App_01\student.db";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlite($"Data Source={path}");

        public DbSet<Student> ListofStudents { get; set; }
    }
}
