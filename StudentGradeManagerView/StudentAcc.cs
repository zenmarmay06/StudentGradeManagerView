using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentGradeManagerView
{
    public partial class StudentAcc : Form
    {
        private static readonly HttpClient client = new HttpClient();
        public StudentAcc()
        {
            InitializeComponent();
        }

        private async Task<List<Student>> GetStudentAsync()
        {
            try
            {
                string url = "https://localhost:44330/api/Admin/Admins";
                var response = await client.GetStringAsync(url);
                return Newtonsoft.Json.JsonConvert.DeserializeObject<List<Student>>(response);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching data : {ex.Message}");
                return null;
            }
        }

        private void btnStudentAcc_Click(object sender, EventArgs e)
        {
            StudentAcc studentacc = new StudentAcc();
            studentacc.Show();
            this.Hide();
        }

        private async void btnStudentList_Click(object sender, EventArgs e)
        {
            var students = await GetStudentAsync();
            if (students != null)
            {
                dgvStudentAcc.DataSource = students;
            }
        }

        private void btnAdminAcc_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
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
