using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradeManagerView.Store
{
    public class CourseAssignment
    {
        public int TeacherID { get; set; }
        public int CourseID { get; set; }
        public string CourseName { get; set; } // New property for course name
        public List<int> StudentIDs { get; set; } = new List<int>();
        public List<int> TeacherIDs { get; set; } = new List<int>();
    }
}
