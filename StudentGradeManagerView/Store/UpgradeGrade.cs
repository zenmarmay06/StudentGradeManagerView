using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradeManagerView.Store
{
    public class UpdateGradeRequest
    {
        public string Semester { get; set; } // Options: "First Semester" or "Second Semester"

        
        public double MidtermGrade { get; set; }

        
        public double FinalGrade { get; set; }
        public int CourseID { get; set; }
    }
}
