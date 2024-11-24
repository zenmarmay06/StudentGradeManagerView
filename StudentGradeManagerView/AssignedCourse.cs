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
    public partial class AssignedCourse : Form
    {
        public AssignedCourse()
        {
            InitializeComponent();
        }

        private async Task<List<CourseAssignment>> FetchAllCourseAssignmentsAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44330/api/Admin/");
                HttpResponseMessage response = await client.GetAsync("GetAllCourseAssignments");

                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<List<CourseAssignment>>(jsonString);
                }
                else
                {
                    MessageBox.Show("Failed to fetch course assignments.");
                    return new List<CourseAssignment>();
                }
            }
        }


        private async Task SearchCourseAsync()
        {
            // Validate Course ID input
            int courseId;
            if (!int.TryParse(txtAssigned.Text, out courseId))
            {
                MessageBox.Show("Please enter a valid Course ID.");
                return;
            }

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44330/api/Admin/GetAllCourseAssignments");

                // Make the GET request to fetch course details
                HttpResponseMessage response = await client.GetAsync($"Courses/{courseId}");

                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    var courseDetails = JsonConvert.DeserializeObject<Course>(jsonString); // Assuming you have a Course class

                    // Display the Course ID in the label
                    lblCourseID.Text = courseDetails.CourseID.ToString();
                    // Populate other fields based on the course details if applicable
                    txtTeacher.Text = courseDetails.TeacherID.ToString(); // Adjust as necessary
                    txtSemester.Text = courseDetails.Semester; // Adjust if this is stored in the course
                    txtStudent.Text = string.Join(", ", courseDetails.StudentIDs); // Assuming a list of student IDs
                }
                else
                {
                    MessageBox.Show("Course not found. Please check the Course ID.");
                }
            }
        }

        private async Task AssignCourseAsync()
        {
            // Retrieve user inputs from the form
            int courseId;
            if (!int.TryParse(lblCourseID.Text, out courseId)) // Use the course ID from the label
            {
                MessageBox.Show("Please search for a valid Course ID first.");
                return;
            }



            // Validate student ID
            int studentId;

            if (!int.TryParse(txtStudent.Text, out studentId)) // Use the course ID from the label
            {
                MessageBox.Show("Please enter a valid Student ID.");
                return;
            }



            // Validate teacher ID
            int teacherId;
            if (!int.TryParse(txtTeacher.Text, out teacherId)) // Use the course ID from the label
            {
                MessageBox.Show("Please enter a valid Teacher ID.");
                return;
            }

            // Validate semester
            string semester = txtSemester.Text.Trim();
            if (string.IsNullOrWhiteSpace(semester))
            {
                MessageBox.Show("Semester cannot be empty.");
                return;
            }

           
            // Create the request object
            var request = new
            {
                StudentId = studentId,
                CourseId = courseId,
                TeacherId = teacherId,
                Semester = semester
                
            };

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44330/api/Admin/GetAllCourseAssignments"); // Adjust the base URL as needed

                // Serialize the request object to JSON
                var jsonContent = JsonConvert.SerializeObject(request);
                var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

                // Make the POST request to AssignCourseToStudent endpoint
                HttpResponseMessage response = await client.PostAsync("AssignCourseToStudent", content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Course assigned to student successfully.");
                    // Optionally clear the input fields
                    txtStudent.Clear();
                    txtAssigned.Clear(); // Clear the search field as well
                    lblCourseID.Text = string.Empty; // Clear the label
                    txtTeacher.Clear();
                    txtSemester.Clear();
                   
                }
                else
                {
                    var errorMessage = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"Error assigning course: {errorMessage}");
                }
            }
        }

        private async Task<bool> UpdateStudentCourseAssignmentAsync(int studentId, int courseId, int teacherId, string newSemester)
        {
            try
            {
                // Create the request object with the new semester
                var request = new
                {
                    StudentId = studentId,
                    CourseId = courseId,
                    TeacherId = teacherId,
                    NewSemester = newSemester
                };

                string json = JsonConvert.SerializeObject(request);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://localhost:44330/api/Admin/GetAllCourseAssignments");
                    HttpResponseMessage response = await client.PutAsync("UpdateStudentCourseAssignment", content);

                    return response.IsSuccessStatusCode;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating course assignment: {ex.Message}");
                return false;
            }
        }


        private async Task<bool> RemoveStudentFromCourseAsync(int courseId, int studentId)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://localhost:44330/api/Admin/GetAllCourseAssignments");
                    HttpResponseMessage response = await client.DeleteAsync($"RemoveStudentFromCourse/{courseId}?studentId={studentId}");

                    return response.IsSuccessStatusCode;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error removing student from course: {ex.Message}");
                return false;
            }
        }





        private async Task RefreshCourseListAsync()
        {
            dgvCourseAss.DataSource = null; // Clear previous data
            var courses = await FetchAllCourseAssignmentsAsync();

            if (courses.Any())
            {
                dgvCourseAss.DataSource = courses;

                // Optionally, check column names and set headers if necessary
                dgvCourseAss.Columns["CourseID"].HeaderText = "Course ID";
                dgvCourseAss.Columns["StudentID"].HeaderText = "Student ID";
                dgvCourseAss.Columns["Semester"].HeaderText = "Semester";
                dgvCourseAss.Columns["CourseName"].HeaderText = "Course Name";
                dgvCourseAss.Columns["TeacherName"].HeaderText = "Teacher Name";
                dgvCourseAss.Columns["TeacherID"].HeaderText = "Teacher ID";
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

        private void btnCourseAssigned_Click(object sender, EventArgs e)
        {
            AssignedCourse assignedCourse = new AssignedCourse();
            assignedCourse.Show();
            this.Hide();
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            await AssignCourseAsync();
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            // Validate inputs
            if (!int.TryParse(txtStudent.Text, out int studentId))
            {
                MessageBox.Show("Invalid Student ID.");
                return;
            }

            if (!int.TryParse(lblCourseID.Text, out int courseId))
            {
                MessageBox.Show("Invalid Course ID.");
                return;
            }

            if (!int.TryParse(txtTeacher.Text, out int teacherId))
            {
                MessageBox.Show("Invalid Teacher ID.");
                return;
            }

            string newSemester = txtSemester.Text.Trim();
            if (string.IsNullOrWhiteSpace(newSemester))
            {
                MessageBox.Show("Semester cannot be empty.");
                return;
            }

            // Call the API to update the course assignment
            bool isUpdated = await UpdateStudentCourseAssignmentAsync(studentId, courseId, teacherId, newSemester);

            if (isUpdated)
            {
                MessageBox.Show("Course assignment updated successfully.");
                await RefreshCourseListAsync();
                txtStudent.Clear();
                lblCourseID.ResetText();
                txtTeacher.Clear();
                txtSemester.Clear();
            }
            else
            {
                MessageBox.Show("Failed to update course assignment.");
            }
        }

        private async void btnCourseList_Click(object sender, EventArgs e)
        {
            // Fetch the course assignments
            dgvCourseAss.DataSource = null;
            var courseAssignments = await FetchAllCourseAssignmentsAsync();

            if (courseAssignments.Any())
            {
                // Assuming you have a DataGridView named dgvCourseAssignments
                dgvCourseAss.DataSource = courseAssignments; // Directly set the data source
            }
            else
            {
                MessageBox.Show("No course assignments available.");
            }
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            await SearchCourseAsync();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            int courseId, studentId;

            // Validate course ID
            if (!int.TryParse(lblCourseID.Text, out courseId)) // Assuming you display course ID in a label after searching
            {
                MessageBox.Show("Please search for a valid Course ID first.");
                return;
            }

            // Validate student ID
            if (!int.TryParse(txtStudent.Text, out studentId)) // Assuming you have a TextBox for Student ID
            {
                MessageBox.Show("Please enter a valid Student ID.");
                return;
            }

            // Call the remove method
            bool result = await RemoveStudentFromCourseAsync(courseId, studentId);

            if (result)
            {
                MessageBox.Show("Student removed from course successfully.");
                lblCourseID.ResetText();
                txtStudent.Clear();
                txtTeacher.Clear();
                txtSemester.Clear();
            }
            else
            {
                MessageBox.Show("Failed to remove student from course.");
            }
        }
    }
}
