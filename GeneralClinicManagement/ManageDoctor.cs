using System;
using System.Collections.Generic;
using System.ComponentModel;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneralClinicManagement
{
    public partial class ManageDoctor : Form
    {
        string connectionString = @"Server=LAPTOP-RA8AK0H5;Database=general_clinic_manage;Trusted_Connection=True;TrustServerCertificate=True;";
        private SqlConnection conn;
        private DataTable doctorTable;
        private int currentDoctorID = -1;
        public ManageDoctor()
        {
            InitializeComponent();
            conn = new SqlConnection(connectionString);
        }

        private void ManageDoctor_Load(object sender, EventArgs e)
        {
            LoadDoctorData();
        }

        private void LoadDoctorData()
        {
            try
            {
                conn.Open();
                string query = @"
                    SELECT u.UserID, u.FullName AS DoctorName, u.Gender, 
                           d.Title, d.ManagementPosition, d.Specialties, 
                           d.ExperienceYears, d.ProfileImage, u.UserName, u.PassWord
                    FROM Users u
                    JOIN DoctorDetails d ON u.UserID = d.DoctorID
                    WHERE u.Role = 'Doctor'";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                doctorTable = new DataTable();
                adapter.Fill(doctorTable);

                // Set up the DataGridView
                dataGridView.DataSource = doctorTable;

                // Configure column display names and visibility
                if (dataGridView.Columns.Count > 0)
                {
                    dataGridView.Columns["UserID"].Visible = false;
                    dataGridView.Columns["PassWord"].Visible = false;
                    dataGridView.Columns["ProfileImage"].Visible = false;
                }

                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading doctor data: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView.Rows[e.RowIndex];

                // Get the doctor ID from the selected row
                currentDoctorID = Convert.ToInt32(row.Cells["UserID"].Value);

                // Populate the form fields
                txtDoctorName.Text = row.Cells["DoctorName"].Value.ToString();
                txtManagePosition.Text = row.Cells["ManagementPosition"].Value?.ToString() ?? "";
                txtExperienceYear.Text = row.Cells["ExperienceYears"].Value.ToString();
                txtTitle.Text = row.Cells["Title"].Value.ToString();
                txtSpecialties.Text = row.Cells["Specialties"].Value.ToString();
                txtPicture.Text = row.Cells["ProfileImage"].Value.ToString();
                txtUserName.Text = row.Cells["UserName"].Value.ToString();
                txtPassWord.Text = row.Cells["PassWord"].Value.ToString();

                // Set the gender radio button
                string gender = row.Cells["Gender"].Value?.ToString();
                ckMale.Checked = gender == "Male";
                ckFemale.Checked = gender == "Female";
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (currentDoctorID == -1)
            {
                MessageBox.Show("Please select a doctor to update.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (string.IsNullOrEmpty(txtDoctorName.Text) || string.IsNullOrEmpty(txtUserName.Text) ||
                string.IsNullOrEmpty(txtPassWord.Text) || string.IsNullOrEmpty(txtSpecialties.Text) ||
                string.IsNullOrEmpty(txtTitle.Text))
            {
                MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    string gender = ckMale.Checked ? "Male" : "Female";

                    conn.Open();

                    // Update Users table
                    string userUpdateQuery = @"
                        UPDATE Users 
                        SET FullName = @FullName, Gender = @Gender, 
                            UserName = @UserName, PassWord = @PassWord
                        WHERE UserID = @UserID";

                    SqlCommand userCmd = new SqlCommand(userUpdateQuery, conn);
                    userCmd.Parameters.AddWithValue("@FullName", txtDoctorName.Text);
                    userCmd.Parameters.AddWithValue("@Gender", gender);
                    userCmd.Parameters.AddWithValue("@UserName", txtUserName.Text);
                    userCmd.Parameters.AddWithValue("@PassWord", txtPassWord.Text);
                    userCmd.Parameters.AddWithValue("@UserID", currentDoctorID);
                    userCmd.ExecuteNonQuery();

                    // Update DoctorDetails table
                    string doctorUpdateQuery = @"
                        UPDATE DoctorDetails 
                        SET Title = @Title, ManagementPosition = @ManagementPosition, 
                            Specialties = @Specialties, ExperienceYears = @ExperienceYears,
                            ProfileImage = @ProfileImage
                        WHERE DoctorID = @DoctorID";

                    SqlCommand doctorCmd = new SqlCommand(doctorUpdateQuery, conn);
                    doctorCmd.Parameters.AddWithValue("@Title", txtTitle.Text);
                    doctorCmd.Parameters.AddWithValue("@ManagementPosition", txtManagePosition.Text);
                    doctorCmd.Parameters.AddWithValue("@Specialties", txtSpecialties.Text);
                    doctorCmd.Parameters.AddWithValue("@ExperienceYears", Convert.ToInt32(txtExperienceYear.Text));

                    // Handle profile image path
                    if (!string.IsNullOrEmpty(txtPicture.Text) && File.Exists(txtPicture.Text))
                        doctorCmd.Parameters.AddWithValue("@ProfileImage", txtPicture.Text);
                    else
                        doctorCmd.Parameters.AddWithValue("@ProfileImage", DBNull.Value);

                    doctorCmd.Parameters.AddWithValue("@DoctorID", currentDoctorID);
                    doctorCmd.ExecuteNonQuery();

                    MessageBox.Show("Doctor information updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error updating doctor information: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // Connection automatically closed by the 'using' statement
            }

            // Only reload data after the connection is closed
            LoadDoctorData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (currentDoctorID == -1)
            {
                MessageBox.Show("Please select a doctor to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this doctor?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();

                        // Delete from Users table (will cascade to DoctorDetails due to constraint)
                        string deleteQuery = "DELETE FROM Users WHERE UserID = @UserID";
                        SqlCommand cmd = new SqlCommand(deleteQuery, conn);
                        cmd.Parameters.AddWithValue("@UserID", currentDoctorID);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Doctor deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Clear form fields and reset current doctor ID
                        ClearForm();
                        currentDoctorID = -1;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error deleting doctor: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    // Connection automatically closed by the 'using' statement
                }

                // Only reload data after the connection is closed
                LoadDoctorData();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.bmp)|*.jpg; *.jpeg; *.png; *.bmp";
                openFileDialog.Title = "Select Profile Image";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string imagePath = openFileDialog.FileName;
                    txtPicture.Text = imagePath;
                }
            }
        }

        private void ClearForm()
        {
            txtDoctorName.Text = "";
            txtManagePosition.Text = "";
            txtExperienceYear.Text = "";
            txtTitle.Text = "";
            txtSpecialties.Text = "";
            txtUserName.Text = "";
            txtPassWord.Text = "";
            txtPicture.Text = "";
            ckMale.Checked = false;
            ckFemale.Checked = false;
        }
    }
}
