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



        public int StudentID { get; set; }
        public string CourseName { get; set; }
        
        public int? MidtermGrade { get; set; }

       
        public int? FinalGrade { get; set; }
        public double? Grade => (MidtermGrade + FinalGrade) / 2;
    }
}
