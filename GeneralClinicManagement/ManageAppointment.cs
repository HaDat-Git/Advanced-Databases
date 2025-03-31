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
    public partial class ManageAppointment : Form
    {

        string connectionString = @"Server=LAPTOP-RA8AK0H5;Database=general_clinic_manage;Trusted_Connection=True;TrustServerCertificate=True;";
        private int currentAppointmentID = 0;
        private int currentDoctorID = 0;
        public ManageAppointment()
        {
            InitializeComponent();
            dataGridView.CellClick += dataGridView_CellClick;
            btnDelete.Click += btnDelete_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnClose.Click += btnClose_Click;
            this.Load += ManageAppointment_Load;
        }

        private void LoadDoctors()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT UserID, FullName FROM Users WHERE Role = 'Doctor' ORDER BY FullName";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Thiết lập ComboBox
                    cmbDoctorName.DataSource = dt;
                    cmbDoctorName.DisplayMember = "FullName";
                    cmbDoctorName.ValueMember = "UserID";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading doctors: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadAppointments()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"
                        SELECT a.AppointmentID, p.FullName AS PatientName, u.FullName AS DoctorName,
                               a.About, a.Description, a.AppointmentDate, a.Status, a.DoctorID
                        FROM Appointments a
                        INNER JOIN Patients p ON a.PatientID = p.PatientID
                        INNER JOIN Users u ON a.DoctorID = u.UserID
                        ORDER BY a.AppointmentDate DESC";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView.DataSource = dt;

                    // Ẩn cột DoctorID nếu không muốn hiển thị
                    if (dataGridView.Columns.Contains("DoctorID"))
                    {
                        dataGridView.Columns["DoctorID"].Visible = false;
                    }

                    dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading appointments: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView.Rows[e.RowIndex];

                txtPatientName.Text = row.Cells["PatientName"].Value.ToString();
                currentDoctorID = Convert.ToInt32(row.Cells["DoctorID"].Value);
                cmbDoctorName.SelectedValue = currentDoctorID;
                txtAbout.Text = row.Cells["About"].Value.ToString();
                txtDescription.Text = row.Cells["Description"].Value.ToString();
                dtpAppointmentDate.Value = Convert.ToDateTime(row.Cells["AppointmentDate"].Value);
                cmbStatus.Text = row.Cells["Status"].Value.ToString();

                currentAppointmentID = Convert.ToInt32(row.Cells["AppointmentID"].Value);
            }
        }

        

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (currentAppointmentID == 0)
            {
                MessageBox.Show("Please select an appointment to delete", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this appointment?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        string query = "DELETE FROM Appointments WHERE AppointmentID = @AppointmentID";

                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@AppointmentID", currentAppointmentID);
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Appointment deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ClearFields();
                                LoadAppointments(); 
                            }
                            else
                            {
                                MessageBox.Show("No appointment found with the given ID", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting appointment: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ClearFields()
        {
            txtPatientName.Text = string.Empty;
            cmbDoctorName.SelectedIndex = -1;
            txtAbout.Text = string.Empty;
            txtDescription.Text = string.Empty;
            dtpAppointmentDate.Value = DateTime.Now;
            cmbStatus.SelectedIndex = -1;
            currentAppointmentID = 0;
            currentDoctorID = 0;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (currentAppointmentID == 0)
            {
                MessageBox.Show("Please select an appointment to update", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    // Bây giờ chúng ta cập nhật cả DoctorID từ ComboBox
                    string query = @"
                        UPDATE Appointments 
                        SET About = @About,
                            Description = @Description,
                            AppointmentDate = @AppointmentDate,
                            Status = @Status,
                            DoctorID = @DoctorID
                        WHERE AppointmentID = @AppointmentID";

                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@AppointmentID", currentAppointmentID);
                        cmd.Parameters.AddWithValue("@About", txtAbout.Text);
                        cmd.Parameters.AddWithValue("@Description", txtDescription.Text);
                        cmd.Parameters.AddWithValue("@AppointmentDate", dtpAppointmentDate.Value);
                        cmd.Parameters.AddWithValue("@Status", cmbStatus.Text);
                        cmd.Parameters.AddWithValue("@DoctorID", cmbDoctorName.SelectedValue);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Appointment updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadAppointments(); // Refresh the DataGridView
                        }
                        else
                        {
                            MessageBox.Show("No appointment found with the given ID", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating appointment: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ManageAppointment_Load(object sender, EventArgs e)
        {
            cmbStatus.Items.Clear();
            cmbStatus.Items.Add("Pending");
            cmbStatus.Items.Add("Completed");
            cmbStatus.Items.Add("Cancelled");

            LoadDoctors();
            LoadAppointments();
        }
    }
}
