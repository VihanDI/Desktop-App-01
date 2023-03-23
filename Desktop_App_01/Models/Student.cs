using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop_App_01.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        //public double GPA { get; set; }
        //public string DateOfBirth { get; set; }
        public string Image { get; set; }
        public string ImageURL
        {
            get
            {
                return $"/Images/{Image}";
            }
        }
    }
}
