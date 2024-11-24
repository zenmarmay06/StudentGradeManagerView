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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
           
        }

        private async Task<List<Admin>> FetchAllAdminsAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44330/api/Admin/Admins"); // Replace with your actual API URL
                HttpResponseMessage response = await client.GetAsync("Admins");

                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<List<Admin>>(jsonString);
                }
                else
                {
                    MessageBox.Show("Failed to fetch admins.");
                    return new List<Admin>();
                }
            }
        }
        private async Task<Admin> FetchAdminByIdAsync(int id)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44330/api/Admin/Admins"); // Replace with your actual API URL
                HttpResponseMessage response = await client.GetAsync($"Admins/{id}");

                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<Admin>(jsonString);
                }
                else
                {
                    MessageBox.Show("Admin not found.");
                    return null;
                }
            }
        }

        private async Task<bool> UpdateAdminAsync(Admin updatedAdmin)
        {
            try
            {
                string json = JsonConvert.SerializeObject(updatedAdmin);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://localhost:44330/api/Admin/Admins");
                    HttpResponseMessage response = await client.PutAsync($"Admins/{updatedAdmin.AdminID}", content);

                    return response.IsSuccessStatusCode;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating admin: {ex.Message}");
                return false;
            }
        }

        private async Task<bool> DeleteAdminAsync(int adminId)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://localhost:44330/api/Admin/Admins");
                    HttpResponseMessage response = await client.DeleteAsync($"Admins/{adminId}");

                    return response.IsSuccessStatusCode;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting admin: {ex.Message}");
                return false;
            }
        }

        private void ClearAdminFields()
        {
            lblAdminID.Text = string.Empty;
            txtFullName.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }

        // New method to refresh the admin list in the DataGridView
        private async Task RefreshAdminListAsync()
        {
            dgvAdminAcc.DataSource = null; // Clear existing data
            var admins = await FetchAllAdminsAsync(); // Fetch the updated list of admins

            if (admins.Any())
            {
                dgvAdminAcc.DataSource = admins; // Bind the updated list of Admins to the DataGridView
            }
            else
            {
                MessageBox.Show("No admins found.");
            }
        }

        private void btnAdminAcc_Click(object sender, EventArgs e)
        {
            AdminForm admin = new AdminForm();
            admin.Show();
            this.Hide();
        }

        private async void btnAdminList_Click(object sender, EventArgs e)
        {
            dgvAdminAcc.DataSource = null; // Clear existing data
            var admins = await FetchAllAdminsAsync(); // Fetch the list of admins

            if (admins.Any())
            {
                dgvAdminAcc.DataSource = admins; // Bind the list of Admins to the DataGridView
            }
            else
            {
                MessageBox.Show("No admins found.");
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

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtAdmin.Text, out int adminId))
            {
                var admin = await FetchAdminByIdAsync(adminId);
                if (admin != null)
                {
                    lblAdminID.Text = admin.AdminID.ToString();
                    txtFullName.Text = admin.Name;
                    txtEmail.Text = admin.Email;
                    txtPassword.Text = admin.Password;
                }
                else
                {
                    MessageBox.Show("Admin not found.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid Admin ID.");
            }
            
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(lblAdminID.Text, out int adminId))
            {
                MessageBox.Show("Invalid Admin ID.");
                return;
            }

            // Create an Admin object with updated information
            var updatedAdmin = new Admin
            {
                AdminID = adminId,
                Name = txtFullName.Text,
                Email = txtEmail.Text,
                Password = txtPassword.Text
            };

            // Call the API to update the admin
            var isUpdated = await UpdateAdminAsync(updatedAdmin);

            if (isUpdated)
            {
                MessageBox.Show("Admin updated successfully.");
                await RefreshAdminListAsync(); // Refresh the DataGridView
                lblAdminID.ResetText();
                txtAdmin.Clear();
                txtFullName.Clear();
                txtEmail.Clear();
                txtPassword.Clear();
           
            }
            else
            {
                MessageBox.Show("Failed to update admin.");
            }

        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(lblAdminID.Text, out int adminId))
            {
                MessageBox.Show("Invalid Admin ID.");
                return;
            }

            var confirmResult = MessageBox.Show("Are you sure to delete this admin?",
                                                 "Confirm Delete",
                                                 MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                var isDeleted = await DeleteAdminAsync(adminId);

                if (isDeleted)
                {
                    MessageBox.Show("Admin deleted successfully.");
                    await RefreshAdminListAsync(); // Refresh the DataGridView
                    ClearAdminFields(); // Clear the fields
                }
                else
                {
                    MessageBox.Show("Failed to delete admin.");
                }
            }

        }

        private void btnCourseAssigned_Click(object sender, EventArgs e)
        {
            AssignedCourse assignedCourse = new AssignedCourse();
            assignedCourse.Show();
            this.Hide();
        }

        private void btnPerformance_Click(object sender, EventArgs e)
        {

        }
    }
}
