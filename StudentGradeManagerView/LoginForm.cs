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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnAdmiN_Click(object sender, EventArgs e)
        {
            LoginAdmin admin = new LoginAdmin();
            admin.Show();
            this.Hide();
        }

        private void btnTeacher_Click(object sender, EventArgs e)
        {
            LoginTeacher teacher = new LoginTeacher();
            teacher.Show();
            this.Hide();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            LoginStudent student = new LoginStudent();
            student.Show();
            this.Hide();
        }
    }
}
