using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentGradeManagerView
{
    public partial class Admin : Form
    {
        private static readonly HttpClient client = new HttpClient();
        public Admin()
        {
            InitializeComponent();
        }

        private async Task<List<Admin>> GetAdminAsync()
        {
            try
            {
                string url = "https://localhost:44330/api/Admin/Admins";
                var response = await client.GetStringAsync(url);
                return Newtonsoft.Json.JsonConvert.DeserializeObject<List<Admin>>(response);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching data : {ex.Message}");
                return null;
            }
        }

        private  void btnAdminAcc_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Hide();
        }

        private async void btnAdminList_Click(object sender, EventArgs e)
        {
            var admins = await GetAdminAsync();
            if (admins != null)
            {
                dgvAdminAcc.DataSource = admins;
            }
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
