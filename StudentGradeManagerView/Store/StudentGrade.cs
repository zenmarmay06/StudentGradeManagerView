using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradeManagerView.Store
{
    public class StudentGrade
    {
        public string StudentName { get; set; }

       
        public int CourseId { get; set; }

        public string Semester { get; set; } // Track semester assignment (e.g., "first" or "second")

        public int StudentID { get; set; }
        public string CourseName { get; set; }
        
        public double? MidtermGrade { get; set; }

        
        public double? FinalGrade { get; set; }

        // Calculate the average grade as a double
        
    }
}
