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
    public partial class UpdateTeacher : Form
    {
        public UpdateTeacher()
        {
            InitializeComponent();
        }

        private void BtnCourse_Click(object sender, EventArgs e)
        {
            TeacherForm courselist = new TeacherForm();
            courselist.Show();
            this.Hide();
        }

        private void BtnUpdateAcc_Click(object sender, EventArgs e)
        {
            UpdateTeacher update = new UpdateTeacher();
            update.Show();
            this.Hide();
        }

        private void BtnInput_Click(object sender, EventArgs e)
        {
            InputGrades input = new InputGrades();
            input.Show();
            this.Hide();
        }

        private void BtnViewGrades_Click(object sender, EventArgs e)
        {
            ViewTeacher view = new ViewTeacher();
            view.Show();
            this.Hide();
        }
    }
}
