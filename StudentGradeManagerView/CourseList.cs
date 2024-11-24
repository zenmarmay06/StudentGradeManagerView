using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using StudentGradeManagerView.Store;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;


namespace StudentGradeManagerView
{
    public partial class CourseList : Form
    {
       
        public CourseList()
        {
            InitializeComponent();
        }

        // Fetch and display all courses in DataGridView
        private async Task<List<Course>> FetchAllCoursesAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44330/api/Admin/Courses"); // Replace with your actual API URL
                HttpResponseMessage response = await client.GetAsync("Courses");

                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<List<Course>>(jsonString);
                }
                else
                {
                    MessageBox.Show("Failed to fetch courses.");
                    return new List<Course>();
                }
            }
        }
        private async Task<Course> FetchCourseByIdAsync(int id)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44330/api/Admin/Courses"); // Replace with your actual API URL
                HttpResponseMessage response = await client.GetAsync($"Courses/{id}");

                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<Course>(jsonString);
                }
                else
                {
                    MessageBox.Show("Teache not found.");
                    return null;
                }
            }
        }

        private async Task<bool> UpdateCourseAsync(Course updatedCourse)
        {
            try
            {
                string json = JsonConvert.SerializeObject(updatedCourse);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://localhost:44330/api/Admin/Courses");
                    HttpResponseMessage response = await client.PutAsync($"Courses/{updatedCourse.CourseID}", content);

                    return response.IsSuccessStatusCode;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating course: {ex.Message}");
                return false;
            }
        }

        private async Task<bool> DeleteCourseAsync(int courseId)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://localhost:44330/api/Admin/Courses");
                    HttpResponseMessage response = await client.DeleteAsync($"Courses/{courseId}");

                    return response.IsSuccessStatusCode;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting course: {ex.Message}");
                return false;
            }
        }

        private async Task AddCourseAsync()
        {
            int courseId;
            if (!int.TryParse(txtCourseID.Text, out courseId))
            {
                MessageBox.Show("Please enter a valid Course ID.");
                return;
            }

            string courseName = txtCourseName.Text.Trim();
            if (string.IsNullOrWhiteSpace(courseName))
            {
                MessageBox.Show("Course name cannot be empty.");
                return;
            }

            Course newCourse = new Course
            {
                CourseID = courseId,
                CourseName = courseName
            };

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44330/api/Admin/Courses");

                // Serialize the course to JSON
                var jsonContent = JsonConvert.SerializeObject(newCourse);
                var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PostAsync("Add", content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Course added successfully.");
                    txtCourseID.Clear();
                    txtCourseName.Clear();
                }
                else
                {
                    var errorMessage = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"Error adding course: {errorMessage}");
                }
            }
        }

        private void ClearCourseFields()
        {
            txtCourseID.Text = string.Empty;
            txtCourseName.Text = string.Empty;
            
        }


        private async Task RefreshCourseListAsync()
        {
            dgvCourse.DataSource = null;
            var courses = await FetchAllCoursesAsync();

            if (courses.Any())
            {
                dgvCourse.DataSource = courses;
            }
            else
            {
                MessageBox.Show("No courses found.");
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

        private void btnCourse_Click(object sender, EventArgs e)
        {
            CourseList courselist = new CourseList();
            courselist.Show();
            this.Hide();
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtCourse.Text, out int courseId))
            {
                var course = await FetchCourseByIdAsync(courseId);
                if (course != null)
                {
                    txtCourseID.Text = course.CourseID.ToString();
                    txtCourseName.Text = course.CourseName;
                    
                }
                else
                {
                    MessageBox.Show("Course not found.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid Course ID.");
            }
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtCourseID.Text, out int courseId))
            {
                MessageBox.Show("Invalid Course ID.");
                return;
            }


            var updatedCourse = new Course
            {
                CourseID = courseId,
                CourseName = txtCourseName.Text,
               
            };

            // Call the API to update the admin
            var isUpdated = await UpdateCourseAsync(updatedCourse);

            if (isUpdated)
            {
                MessageBox.Show("Teacher updated successfully.");
                await RefreshCourseListAsync(); // Refresh the DataGridView
                txtCourseID.ResetText();

                txtCourseName.Clear();
            }
            else
            {
                MessageBox.Show("Failed to update teacher.");
            }
           
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtCourseID.Text, out int courseId))
            {
                MessageBox.Show("Invalid Course ID.");
                return;
            }

            var confirmResult = MessageBox.Show("Are you sure to delete this course?",
                                                 "Confirm Delete",
                                                 MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                var isDeleted = await DeleteCourseAsync(courseId);

                if (isDeleted)
                {
                    MessageBox.Show("Course deleted successfully.");
                    await RefreshCourseListAsync(); // Refresh the DataGridView
                    ClearCourseFields(); // Clear the fields
                }
                else
                {
                    MessageBox.Show("Failed to delete course.");
                }
            }
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            await AddCourseAsync();
        }

        private async void btnCourseList_Click(object sender, EventArgs e)
        {
            dgvCourse.DataSource = null;
            var courses = await FetchAllCoursesAsync();

            if (courses.Any())
            {
                dgvCourse.DataSource = courses;
            }
            else
            {
                MessageBox.Show("No courses found.");
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
