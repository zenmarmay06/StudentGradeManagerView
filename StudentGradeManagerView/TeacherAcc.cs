using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using StudentGradeManagerView.Models;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace StudentGradeManagerView
{
    public partial class TeacherAcc : Form
    {
        
        public TeacherAcc()
        {
            InitializeComponent();
        }

        private async Task<List<Teacher>> FetchAllTeachersAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44330/api/Admin/Teachers"); // Replace with your actual API URL
                HttpResponseMessage response = await client.GetAsync("Teachers");

                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<List<Teacher>>(jsonString);
                }
                else
                {
                    MessageBox.Show("Failed to fetch teachers.");
                    return new List<Teacher>();
                }
            }
        }
        private async Task<Teacher> FetchTeacherByIdAsync(int id)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44330/api/Admin/Teachers"); // Replace with your actual API URL
                HttpResponseMessage response = await client.GetAsync($"Teachers/{id}");

                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<Teacher>(jsonString);
                }
                else
                {
                    MessageBox.Show("Teacher not found.");
                    return null;
                }
            }
        }

        private async Task<bool> UpdateTeacherAsync(Teacher updatedTeacher)
        {
            try
            {
                string json = JsonConvert.SerializeObject(updatedTeacher);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://localhost:44330/api/Admin/Teachers");
                    HttpResponseMessage response = await client.PutAsync($"Teachers/{updatedTeacher.TeacherID}", content);

                    return response.IsSuccessStatusCode;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating teacher: {ex.Message}");
                return false;
            }
        }

        private async Task<bool> DeleteTeacherAsync(int teacherId)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://localhost:44330/api/Admin/Teachers");
                    HttpResponseMessage response = await client.DeleteAsync($"Teachers/{teacherId}");

                    return response.IsSuccessStatusCode;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting teacher: {ex.Message}");
                return false;
            }
        }

        private void ClearTeacherFields()
        {
            lblTeacherID.Text = string.Empty;
            txtFullName.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }

       
        private async Task RefreshTeacherListAsync()
        {
            dgvTeacherAcc.DataSource = null; 
            var teachers = await FetchAllTeachersAsync(); 

            if (teachers.Any())
            {
                dgvTeacherAcc.DataSource = teachers; 
            }
            else
            {
                MessageBox.Show("No teachers found.");
            }
        }

        private void btnCourse_Click(object sender, EventArgs e)
        {
            CourseList courselist = new CourseList();
            courselist.Show();
            this.Hide();
        }

        private async void btnTeacherList_Click(object sender, EventArgs e)
        {
            dgvTeacherAcc.DataSource = null; 
            var teachers = await FetchAllTeachersAsync(); 

            if (teachers.Any())
            {
                dgvTeacherAcc.DataSource = teachers; 
            }
            else
            {
                MessageBox.Show("No teachers found.");
            }
        }

        private void btnAdminAcc_Click(object sender, EventArgs e)
        {
            AdminForm admin = new AdminForm();
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

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtTeacher.Text, out int teacherId))
            {
                var teacher = await FetchTeacherByIdAsync(teacherId);
                if (teacher != null)
                {
                    lblTeacherID.Text = teacher.TeacherID.ToString();
                    txtFullName.Text = teacher.Name;
                    txtEmail.Text = teacher.Email;
                    txtPassword.Text = teacher.Password;
                }
                else
                {
                    MessageBox.Show("Teacher not found.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid Teacher ID.");
            }

        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(lblTeacherID.Text, out int teacherId))
            {
                MessageBox.Show("Invalid Teacher ID.");
                return;
            }

           
            var updatedTeacher = new Teacher
            {
                TeacherID = teacherId,
                Name = txtFullName.Text,
                Email = txtEmail.Text,
                Password = txtPassword.Text
            };

            // Call the API to update the admin
            var isUpdated = await UpdateTeacherAsync(updatedTeacher);

            if (isUpdated)
            {
                MessageBox.Show("Teacher updated successfully.");
                await RefreshTeacherListAsync(); // Refresh the DataGridView
                lblTeacherID.ResetText();
                txtTeacher.Clear();
                txtFullName.Clear();
                txtEmail.Clear();
                txtPassword.Clear();
            }
            else
            {
                MessageBox.Show("Failed to update teacher.");
            }
            
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(lblTeacherID.Text, out int teacherId))
            {
                MessageBox.Show("Invalid Teacher ID.");
                return;
            }

            var confirmResult = MessageBox.Show("Are you sure to delete this teacher?",
                                                 "Confirm Delete",
                                                 MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                var isDeleted = await DeleteTeacherAsync(teacherId);

                if (isDeleted)
                {
                    MessageBox.Show("Teacher deleted successfully.");
                    await RefreshTeacherListAsync(); // Refresh the DataGridView
                    ClearTeacherFields(); // Clear the fields
                }
                else
                {
                    MessageBox.Show("Failed to delete teacher.");
                }
            }
        }

        private void btnCourseAssigned_Click(object sender, EventArgs e)
        {
            AssignedCourse assignedCourse = new AssignedCourse();
            assignedCourse.Show();
            this.Hide();
        }
    }
}
