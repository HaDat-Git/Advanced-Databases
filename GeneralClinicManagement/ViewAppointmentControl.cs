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
    public partial class ViewAppointmentControl : UserControl
    {

        private string connectionString = @"Server=LAPTOP-RA8AK0H5;Database=general_clinic_manage;Trusted_Connection=True;TrustServerCertificate=True;";
        private SqlConnection conn;
        private int doctorId; // Current logged-in doctor's ID
        private DataTable appointmentsTable;
        private decimal totalPrice = 0;
        private int currentAppointmentId = 0;
        public ViewAppointmentControl(int loggedInDoctorID)
        {
            InitializeComponent();
            this.doctorId = loggedInDoctorID;

            // Set up the services dropdown lists
            LoadMedicalServices();
            LoadStatusOptions();
            // Set up event handlers
            cmbService1.SelectedIndexChanged += ServiceSelectionChanged;
            cmbService2.SelectedIndexChanged += ServiceSelectionChanged;

            // Load appointments for this doctor
            LoadAppointments();
        }

        private void LoadAppointments()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
                    SELECT 
                        a.AppointmentID, 
                        p.FullName AS PatientName, 
                        u.FullName AS DoctorName, 
                        a.About, 
                        a.Description, 
                        a.AppointmentDate, 
                        a.Status
                    FROM Appointments a
                    JOIN Patients p ON a.PatientID = p.PatientID
                    JOIN Users u ON a.DoctorID = u.UserID
                    WHERE a.DoctorID = @DoctorID";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@DoctorID", doctorId);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    appointmentsTable = new DataTable();
                    adapter.Fill(appointmentsTable);

                    // Bind to the DataGridView in your form
                    dgvAppointment.DataSource = appointmentsTable;

                    // Configure columns (hide IDs, format date, etc.)
                    dgvAppointment.Columns["AppointmentID"].Visible = false;
                    //dgvAppointment.Columns["PatientID"].Visible = false;
                    dgvAppointment.Columns["Description"].Visible = true;
                    dgvAppointment.Columns["AppointmentDate"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";

                    // Rename columns to Vietnamese
                    dgvAppointment.Columns["PatientName"].HeaderText = "Tên bệnh nhân";
                    dgvAppointment.Columns["DoctorName"].HeaderText = "Bác sĩ phụ trách";
                    dgvAppointment.Columns["AppointmentDate"].HeaderText = "Ngày hẹn";
                    dgvAppointment.Columns["Status"].HeaderText = "Trạng thái";
                    dgvAppointment.Columns["About"].HeaderText = "Lý do khám";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách lịch hẹn: " + ex.Message);
            }
        }

        private void LoadMedicalServices()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT ServiceID, ServiceName, Price FROM MedicalServices";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable services = new DataTable();
                    adapter.Fill(services);

                    // Set up comboboxes
                    cmbService1.DisplayMember = "ServiceName";
                    cmbService1.ValueMember = "ServiceID";
                    cmbService1.DataSource = services.Copy();

                    cmbService2.DisplayMember = "ServiceName";
                    cmbService2.ValueMember = "ServiceID";

                    // Add empty selection for Service2 (optional service)
                    DataTable services2 = services.Copy();
                    DataRow emptyRow = services2.NewRow();
                    emptyRow["ServiceID"] = DBNull.Value;
                    emptyRow["ServiceName"] = "-- Không có --";
                    emptyRow["Price"] = 0;
                    services2.Rows.InsertAt(emptyRow, 0);
                    cmbService2.DataSource = services2;
                    cmbService2.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dịch vụ y tế: " + ex.Message);
            }
        }

        private void ServiceSelectionChanged(object sender, EventArgs e)
        {
            CalculateTotalPrice();
        }

        private void CalculateTotalPrice()
        {
            totalPrice = 0;

            // Get price for Service 1
            if (cmbService1.SelectedValue != null && cmbService1.SelectedValue != DBNull.Value)
            {
                int serviceId = Convert.ToInt32(cmbService1.SelectedValue);
                decimal servicePrice = GetServicePrice(serviceId);
                totalPrice += servicePrice;
            }

            // Get price for Service 2 (if selected)
            if (cmbService2.SelectedIndex > 0 && cmbService2.SelectedValue != null && cmbService2.SelectedValue != DBNull.Value)
            {
                int serviceId = Convert.ToInt32(cmbService2.SelectedValue);
                decimal servicePrice = GetServicePrice(serviceId);
                totalPrice += servicePrice;
            }

            // Update price textbox
            txtPrice.Text = totalPrice.ToString("N0");
        }

        private decimal GetServicePrice(int serviceId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT Price FROM MedicalServices WHERE ServiceID = @ServiceID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ServiceID", serviceId);

                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        return Convert.ToDecimal(result);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy giá dịch vụ: " + ex.Message);
            }

            return 0;
        }

        private void ViewAppointmentControl_Load(object sender, EventArgs e)
        {

        }

        private void dgvAppointment_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAppointment.CurrentRow != null)
            {
                int appointmentId = Convert.ToInt32(dgvAppointment.CurrentRow.Cells["AppointmentID"].Value);
                currentAppointmentId = appointmentId;
                LoadAppointmentDetails(appointmentId);
            }
        }

        private void LoadAppointmentDetails(int appointmentId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
                SELECT a.AppointmentID, p.FullName as PatientName, 
                       u.FullName as DoctorName, a.AppointmentDate, 
                       a.About, a.Description
                FROM Appointments a
                INNER JOIN Patients p ON a.PatientID = p.PatientID
                INNER JOIN Users u ON a.DoctorID = u.UserID
                WHERE a.AppointmentID = @AppointmentID";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@AppointmentID", appointmentId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Fill form fields with appointment data
                            //lblPatientName.Text = reader["PatientName"].ToString();
                            //lblDoctorName.Text = reader["DoctorName"].ToString();
                            //lblAbout.Text = reader["About"].ToString();
                            //lblDescription.Text = reader["Description"].ToString();
                            //lblAppointmentDate.Text = Convert.ToDateTime(reader["AppointmentDate"]).ToString("dd/MM/yyyy HH:mm");
                        }
                    }

                    // Check if there is an existing medical record
                    string recordQuery = @"
                SELECT mr.Diagnosis, mr.Treatment, mrs.ServiceID
                FROM MedicalRecords mr
                LEFT JOIN MedicalRecordServices mrs ON mr.RecordID = mrs.RecordID
                WHERE mr.AppointmentID = @AppointmentID";

                    cmd = new SqlCommand(recordQuery, conn);
                    cmd.Parameters.AddWithValue("@AppointmentID", appointmentId);

                    DataTable recordData = new DataTable();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(recordData);
                    }

                    if (recordData.Rows.Count > 0)
                    {
                        // Get diagnosis and treatment
                        txtDiagnosis.Text = recordData.Rows[0]["Diagnosis"].ToString();
                        txtTreatment.Text = recordData.Rows[0]["Treatment"].ToString();

                        // Reset services first
                        cmbService1.SelectedIndex = 0;
                        cmbService2.SelectedIndex = 0;

                        // Set services based on existing records
                        int serviceCount = 0;
                        foreach (DataRow row in recordData.Rows)
                        {
                            if (row["ServiceID"] != DBNull.Value)
                            {
                                int serviceId = Convert.ToInt32(row["ServiceID"]);
                                if (serviceCount == 0)
                                {
                                    cmbService1.SelectedValue = serviceId;
                                    serviceCount++;
                                }
                                else if (serviceCount == 1)
                                {
                                    cmbService2.SelectedValue = serviceId;
                                    serviceCount++;
                                }
                            }
                        }
                    }
                    else
                    {
                        // Clear fields for new record
                        txtDiagnosis.Text = "";
                        txtTreatment.Text = "";
                        cmbService1.SelectedIndex = 0;
                        cmbService2.SelectedIndex = 0;
                    }

                    // Recalculate price
                    CalculateTotalPrice();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải chi tiết lịch hẹn: " + ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (currentAppointmentId <= 0)
            {
                MessageBox.Show("Vui lòng chọn một lịch hẹn để lưu.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDiagnosis.Text))
            {
                MessageBox.Show("Vui lòng nhập chẩn đoán.");
                txtDiagnosis.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTreatment.Text))
            {
                MessageBox.Show("Vui lòng nhập hướng điều trị.");
                txtTreatment.Focus();
                return;
            }

            if (cmbService1.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một dịch vụ.");
                cmbService1.Focus();
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlTransaction transaction = conn.BeginTransaction();

                    try
                    {
                        // Update appointment status
                        string updateApptQuery = @"
                    UPDATE Appointments
                    SET Status = 'Completed'
                    WHERE AppointmentID = @AppointmentID";

                        SqlCommand cmd = new SqlCommand(updateApptQuery, conn, transaction);
                        cmd.Parameters.AddWithValue("@AppointmentID", currentAppointmentId);
                        cmd.ExecuteNonQuery();

                        // Check if medical record exists
                        string checkRecordQuery = @"
                    SELECT RecordID FROM MedicalRecords 
                    WHERE AppointmentID = @AppointmentID";

                        cmd = new SqlCommand(checkRecordQuery, conn, transaction);
                        cmd.Parameters.AddWithValue("@AppointmentID", currentAppointmentId);

                        object existingRecordId = cmd.ExecuteScalar();
                        int recordId;

                        if (existingRecordId != null && existingRecordId != DBNull.Value)
                        {
                            // Update existing record
                            recordId = Convert.ToInt32(existingRecordId);

                            string updateRecordQuery = @"
                        UPDATE MedicalRecords
                        SET Diagnosis = @Diagnosis,
                            Treatment = @Treatment
                        WHERE RecordID = @RecordID";

                            cmd = new SqlCommand(updateRecordQuery, conn, transaction);
                            cmd.Parameters.AddWithValue("@RecordID", recordId);
                            cmd.Parameters.AddWithValue("@Diagnosis", txtDiagnosis.Text);
                            cmd.Parameters.AddWithValue("@Treatment", txtTreatment.Text);

                            cmd.ExecuteNonQuery();

                            // Delete existing services to re-add them
                            string deleteServicesQuery = @"
                        DELETE FROM MedicalRecordServices
                        WHERE RecordID = @RecordID";

                            cmd = new SqlCommand(deleteServicesQuery, conn, transaction);
                            cmd.Parameters.AddWithValue("@RecordID", recordId);
                            cmd.ExecuteNonQuery();
                        }
                        else
                        {
                            // Create new record
                            string insertRecordQuery = @"
                        INSERT INTO MedicalRecords (AppointmentID, Diagnosis, Treatment, StatusPayment)
                        VALUES (@AppointmentID, @Diagnosis, @Treatment, 'Pending');
                        SELECT SCOPE_IDENTITY();";

                            cmd = new SqlCommand(insertRecordQuery, conn, transaction);
                            cmd.Parameters.AddWithValue("@AppointmentID", currentAppointmentId);
                            cmd.Parameters.AddWithValue("@Diagnosis", txtDiagnosis.Text);
                            cmd.Parameters.AddWithValue("@Treatment", txtTreatment.Text);

                            recordId = Convert.ToInt32(cmd.ExecuteScalar());
                        }

                        // Add Service 1
                        if (cmbService1.SelectedValue != null && cmbService1.SelectedValue != DBNull.Value)
                        {
                            int service1Id = Convert.ToInt32(cmbService1.SelectedValue);

                            string insertService1Query = @"
                        INSERT INTO MedicalRecordServices (RecordID, ServiceID, Quantity)
                        VALUES (@RecordID, @ServiceID, 1)";

                            cmd = new SqlCommand(insertService1Query, conn, transaction);
                            cmd.Parameters.AddWithValue("@RecordID", recordId);
                            cmd.Parameters.AddWithValue("@ServiceID", service1Id);
                            cmd.ExecuteNonQuery();
                        }

                        // Add Service 2 if selected
                        if (cmbService2.SelectedIndex > 0 && cmbService2.SelectedValue != null && cmbService2.SelectedValue != DBNull.Value)
                        {
                            int service2Id = Convert.ToInt32(cmbService2.SelectedValue);

                            string insertService2Query = @"
                        INSERT INTO MedicalRecordServices (RecordID, ServiceID, Quantity)
                        VALUES (@RecordID, @ServiceID, 1)";

                            cmd = new SqlCommand(insertService2Query, conn, transaction);
                            cmd.Parameters.AddWithValue("@RecordID", recordId);
                            cmd.Parameters.AddWithValue("@ServiceID", service2Id);
                            cmd.ExecuteNonQuery();
                        }

                        // Check if medical result exists for this record
                        string checkResultQuery = @"
                        SELECT ResultID FROM MedicalResults 
                        WHERE RecordID = @RecordID";

                        cmd = new SqlCommand(checkResultQuery, conn, transaction);
                        cmd.Parameters.AddWithValue("@RecordID", recordId);

                        object existingResultId = cmd.ExecuteScalar();

                        if (existingResultId != null && existingResultId != DBNull.Value)
                        {
                            // Update existing medical result
                            int resultId = Convert.ToInt32(existingResultId);

                            string updateResultQuery = @"
                            UPDATE MedicalResults
                            SET PrescribedMedicine = @PrescribedMedicine
                            WHERE ResultID = @ResultID";

                            cmd = new SqlCommand(updateResultQuery, conn, transaction);
                            cmd.Parameters.AddWithValue("@ResultID", resultId);
                            cmd.Parameters.AddWithValue("@PrescribedMedicine", txtPrescribedMedicine.Text);
                            cmd.ExecuteNonQuery();
                        }
                        else
                        {
                            // Insert new medical result
                            string insertResultQuery = @"
                            INSERT INTO MedicalResults (RecordID, PrescribedMedicine, PDFFileLink)
                            VALUES (@RecordID, @PrescribedMedicine, @PDFFileLink)";

                            cmd = new SqlCommand(insertResultQuery, conn, transaction);
                            cmd.Parameters.AddWithValue("@RecordID", recordId);
                            cmd.Parameters.AddWithValue("@PrescribedMedicine", txtPrescribedMedicine.Text);
                            cmd.Parameters.AddWithValue("@PDFFileLink", "default.pdf"); // Bạn có thể thay thế bằng đường dẫn thực tế

                            cmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        MessageBox.Show("Đã lưu thông tin khám bệnh thành công.");

                        // Refresh the appointment list
                        LoadAppointments();
                        ClearFields();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Lỗi khi lưu thông tin: " + ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
            }
        }

        private void LoadStatusOptions()
        {
            cmbStatus.Items.Clear();
            cmbStatus.Items.Add("Pending");
            cmbStatus.Items.Add("Completed");
            cmbStatus.Items.Add("Cancelled");
            cmbStatus.SelectedIndex = 0; // Mặc định chọn "Pending"
        }

        private void ClearFields()
        {
            currentAppointmentId = 0;
            txtDiagnosis.Text = "";
            txtTreatment.Text = "";
            cmbService1.SelectedIndex = 0;
            cmbService2.SelectedIndex = 0;
            txtPrice.Text = "0";
        }

    }
}
