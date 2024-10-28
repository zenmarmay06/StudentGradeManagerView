using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentGradeManagerView
{
    public partial class CourseList : Form
    {
        public CourseList()
        {
            InitializeComponent();
        }

        private void btnAdminAcc_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Hide();
        }

        private void btnStudentAcc_Click(object sender, EventArgs e)
        {
            StudentAcc studentacc = new StudentAcc();
            studentacc.Show();
            this.Hide();
        }

        private void btnTeacherAcc_Click(object sender, EventArgs e)
        {
            TeacherAcc teacheracc = new TeacherAcc();
            teacheracc.Show();
            this.Hide();
        }

        private void btnCourse_Click(object sender, EventArgs e)
        {
            CourseList courselist = new CourseList();
            courselist.Show();
            this.Hide();
        }
    }
}
