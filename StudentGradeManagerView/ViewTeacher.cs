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
    public partial class ViewTeacher : Form
    {
        public ViewTeacher()
        {
            InitializeComponent();
        }

        private void btnCourse_Click(object sender, EventArgs e)
        {
            Teacher courselist = new Teacher();
            courselist.Show();
            this.Hide();
        }

        private void btnUpdateAcc_Click(object sender, EventArgs e)
        {
            UpdateTeacher update = new UpdateTeacher();
            update.Show();
            this.Hide();
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            InputGrades input = new InputGrades();
            input.Show();
            this.Hide();
        }

        private void btnViewGrades_Click(object sender, EventArgs e)
        {
            ViewTeacher view = new ViewTeacher();
            view.Show();
            this.Hide();
        }
    }
}
