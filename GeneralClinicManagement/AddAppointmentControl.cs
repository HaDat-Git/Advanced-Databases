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
    public partial class AddAppointmentControl : UserControl
    {
        public AddAppointmentControl()
        {
            InitializeComponent();
        }

        string connectionString = @"Server=LAPTOP-RA8AK0H5;Database=general_clinic_manage;Trusted_Connection=True;TrustServerCertificate=True;";

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // 1️⃣ Thêm bệnh nhân vào bảng Patients nếu chưa tồn tại
                    string insertPatientQuery = @"
                          DECLARE @InsertedPatientID INT;

                            IF NOT EXISTS (SELECT 1 FROM Patients WHERE Phone = @Phone)
                            BEGIN
                                INSERT INTO Patients (FullName, Phone, Email, DOB, Gender, Address)
                                VALUES (@FullName, @Phone, @Email, @DOB, @Gender, @Address);
    
                                SET @InsertedPatientID = SCOPE_IDENTITY();
                            END
                            ELSE
                            BEGIN
                                SELECT @InsertedPatientID = PatientID FROM Patients WHERE Phone = @Phone;
                            END

                            SELECT @InsertedPatientID;";  // Trả về PatientID

                    int patientID;
                    using (SqlCommand cmd = new SqlCommand(insertPatientQuery, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@FullName", txtFullName.Text);
                        cmd.Parameters.AddWithValue("@Phone", txtPhone.Text);
                        cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                        cmd.Parameters.AddWithValue("@DOB", dtpDOB.Value);
                        cmd.Parameters.AddWithValue("@Gender", ckMale.Checked ? "Male" : "Female");
                        cmd.Parameters.AddWithValue("@Address", txtAddress.Text);

                        patientID = Convert.ToInt32(cmd.ExecuteScalar()); // Nhận giá trị PatientID từ truy vấn trên
                    }

                    // 3️⃣ Thêm cuộc hẹn vào bảng Appointments
                    string insertAppointmentQuery = @"
                INSERT INTO Appointments (PatientID, DoctorID, About, Description, AppointmentDate)
                VALUES (@PatientID, @DoctorID, @About, @Description, @AppointmentDate)";

                    using (SqlCommand cmd = new SqlCommand(insertAppointmentQuery, conn, transaction))
                    {

                        if (string.IsNullOrWhiteSpace(txtFullName.Text))
                        {
                            MessageBox.Show("Vui lòng nhập tên bệnh nhân!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        if (string.IsNullOrWhiteSpace(txtPhone.Text))
                        {
                            MessageBox.Show("Vui lòng nhập số điện thoại bệnh nhân!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        if (string.IsNullOrWhiteSpace(txtEmail.Text))
                        {
                            MessageBox.Show("Vui lòng nhập số email bệnh nhân!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        if (string.IsNullOrWhiteSpace(txtAddress.Text))
                        {
                            MessageBox.Show("Vui lòng nhập số địa chỉ của bệnh nhân!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        if (string.IsNullOrWhiteSpace(txtAbout.Text) )
                        {
                            MessageBox.Show("Vui lòng nhập thông tin về lý do khám!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return; // Dừng lưu dữ liệu
                        }

                        if (string.IsNullOrWhiteSpace(rtbDescription.Text))
                        {
                            MessageBox.Show("Vui lòng nhập mô tả chi tiết!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        cmd.Parameters.AddWithValue("@PatientID", patientID);
                        cmd.Parameters.AddWithValue("@DoctorID", cmbDoctor.SelectedValue);
                        cmd.Parameters.AddWithValue("@About", txtAbout.Text);
                        cmd.Parameters.AddWithValue("@Description", rtbDescription.Text);
                        if (dtpAppDate.Value < DateTime.Now)
                        {
                            MessageBox.Show("Ngày hẹn khám không thể lớn hơn ngày hiện tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return; 
                        }
                        cmd.Parameters.AddWithValue("@AppointmentDate", dtpAppDate.Value);
                        cmd.ExecuteNonQuery();
                    }

                    // ✅ Hoàn tất transaction
                    transaction.Commit();
                    MessageBox.Show("Appointment added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ClearAllFields();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error: " + ex.Message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void LoadDoctors()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT UserID AS DoctorID, FullName FROM Users WHERE Role = 'Doctor'";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbDoctor.DataSource = dt;
                cmbDoctor.DisplayMember = "FullName";
                cmbDoctor.ValueMember = "DoctorID";
            }
        }

        private void ClearAllFields()
        {
            // Clear all textboxes
            txtFullName.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtAbout.Text = string.Empty;

            // Clear rich text box
            rtbDescription.Text = string.Empty;

            // Reset date time pickers to current date (or you can set to a specific default)
            dtpDOB.Value = DateTime.Now;
            dtpAppDate.Value = DateTime.Now;

            // Reset checkboxes if needed
            ckMale.Checked = false;

            // Reset combobox selection if needed
            if (cmbDoctor.Items.Count > 0)
                cmbDoctor.SelectedIndex = 0;
        }

        private void panelDesktop_Load(object sender, EventArgs e)
        {
            LoadDoctors();
        }

        private void btnManage_Click(object sender, EventArgs e)
        {

                ManageAppointment manageAppointment = new ManageAppointment();
                manageAppointment.Show();
        }
    }
}
