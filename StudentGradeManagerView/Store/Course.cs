using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradeManagerView.Store
{
    public class Course
    {
        public int CourseID { get; set; }

        public string CourseName { get; set; }

        public string YearSection { get; set; }
        public string Semester { get; set; } // Add this property
        public int TeacherID { get; set; }
        public List<int> StudentIDs { get; set; } = new List<int>();

    }
}
