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

        private void btnCourse_Click(object sender, EventArgs e)
        {
            Student courselist = new Student();
            courselist.Show();
            this.Hide();
        }

        private void btnUpdateAcc_Click(object sender, EventArgs e)
        {
            UpdateStudent update = new UpdateStudent();
            update.Show();
            this.Hide();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            ViewStudent view = new ViewStudent();
            view.Show();
            this.Hide();
        }
    }
}
