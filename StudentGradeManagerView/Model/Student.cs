using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradeManagerView.Models
{
    public class Student
    {
        public int StudentID { get; set; }

        
        public string Name { get; set; }

        
        public string Email { get; set; }

        
        public string Password { get; set; }
        public string YearSection { get; set; }
        public List<int> CourseIDs { get; set; } // List of Course IDs

    }
}
