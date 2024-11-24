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
    public partial class ViewStudent : Form
    {
        public ViewStudent()
        {
            InitializeComponent();
        }

        private void BtnCourse_Click(object sender, EventArgs e)
        {
            StudentForm courselist = new StudentForm();
            courselist.Show();
            this.Hide();
        }

        private void BtnUpdateAcc_Click(object sender, EventArgs e)
        {
            UpdateStudent update = new UpdateStudent();
            update.Show();
            this.Hide();
        }

        private void BtnView_Click(object sender, EventArgs e)
        {
            ViewStudent view = new ViewStudent();
            view.Show();
            this.Hide();
        }
    }
}
