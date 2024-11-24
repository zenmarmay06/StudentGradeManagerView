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
    public partial class StudentAcc : Form
    {
        
        public StudentAcc()
        {
            InitializeComponent();
        }

        private async Task<List<Student>>FetchAllStudentsAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44330/api/Admin/Students"); // Replace with your actual API URL
                HttpResponseMessage response = await client.GetAsync("Students");

                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<List<Student>>(jsonString);
                }
                else
                {
                    MessageBox.Show("Failed to fetch students.");
                    return new List<Student>();
                }
            }
        }

        private async Task<Student> FetchStudentByIdAsync(int id)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44330/api/Admin/Students"); // Replace with your actual API URL
                HttpResponseMessage response = await client.GetAsync($"Students/{id}");

                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<Student>(jsonString);
                }
                else
                {
                    MessageBox.Show("Student not found.");
                    return null;
                }
            }
        }

        private async Task<bool> UpdateStudentAsync(Student updatedStudent)
        {
            try
            {
                string json = JsonConvert.SerializeObject(updatedStudent);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://localhost:44330/api/Admin/Students");
                    HttpResponseMessage response = await client.PutAsync($"Students/{updatedStudent.StudentID}", content);

                    return response.IsSuccessStatusCode;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating student: {ex.Message}");
                return false;
            }
        }

        private async Task<bool> DeleteStudentAsync(int studentId)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://localhost:44330/api/Admin/Students");
                    HttpResponseMessage response = await client.DeleteAsync($"Students/{studentId}");

                    return response.IsSuccessStatusCode;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting student: {ex.Message}");
                return false;
            }
        }

        private void ClearStudentFields()
        {
            lblStudentID.Text = string.Empty;
            txtFullName.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtYearSection.Text = string.Empty;
        }

       
        private async Task RefreshStudentListAsync()
        {
            dgvStudentAcc.DataSource = null; 
            var students = await FetchAllStudentsAsync(); 

            if (students.Any())
            {
                dgvStudentAcc.DataSource = students; 
            }
            else
            {
                MessageBox.Show("No students found.");
            }
        }

        private void btnStudentAcc_Click(object sender, EventArgs e)
        {
            StudentAcc studentacc = new StudentAcc();
            studentacc.Show();
            this.Hide();
        }

        private void btnAdminAcc_Click(object sender, EventArgs e)
        {
            AdminForm admin = new AdminForm();
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

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(lblStudentID.Text, out int studentId))
            {
                MessageBox.Show("Invalid Student ID.");
                return;
            }

            var confirmResult = MessageBox.Show("Are you sure to delete this student?",
                                                 "Confirm Delete",
                                                 MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                var isDeleted = await DeleteStudentAsync(studentId);

                if (isDeleted)
                {
                    MessageBox.Show("Student deleted successfully.");
                    await RefreshStudentListAsync(); // Refresh the DataGridView
                    ClearStudentFields(); // Clear the fields
                }
                else
                {
                    MessageBox.Show("Failed to delete student.");
                }
            }
        }

        private async void btnStudentList_Click(object sender, EventArgs e)
        {
            dgvStudentAcc.DataSource = null; 
            var students = await FetchAllStudentsAsync(); 

            if (students.Any())
            {
                dgvStudentAcc.DataSource = students; 
            }
            else
            {
                MessageBox.Show("No students found.");
            }
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(lblStudentID.Text, out int studentId))
            {
                MessageBox.Show("Invalid Student ID.");
                return;
            }

            
            var updatedStudent = new Student
            {
                StudentID = studentId,
                Name = txtFullName.Text,
                Email = txtEmail.Text,
                Password = txtPassword.Text,
                YearSection = txtYearSection.Text
            };

           
            var isUpdated = await UpdateStudentAsync(updatedStudent);

            if (isUpdated)
            {
                MessageBox.Show("Student updated successfully.");
                await RefreshStudentListAsync();
                lblStudentID.ResetText();
                txtStudent.Clear();
                txtFullName.Clear();
                txtEmail.Clear();
                txtPassword.Clear();
                txtYearSection.Clear();
            }
            else
            {
                MessageBox.Show("Failed to update studnet.");
            }
            
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtStudent.Text, out int studentId))
            {
                var student = await FetchStudentByIdAsync(studentId);
                if (student != null)
                {
                    lblStudentID.Text = student.StudentID.ToString();
                    txtFullName.Text = student.Name;
                    txtEmail.Text = student.Email;
                    txtPassword.Text = student.Password;
                    txtYearSection.Text = student.YearSection;
                }
                else
                {
                    MessageBox.Show("Student not found.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid Student ID.");
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
