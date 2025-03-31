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
    public partial class ReturnResultControl : UserControl
    {
        private string connectionString = @"Server=LAPTOP-RA8AK0H5;Database=general_clinic_manage;Trusted_Connection=True;TrustServerCertificate=True;";
        private SqlConnection conn;
        private int doctorID;
        public ReturnResultControl(int loggedInDoctorID)
        {
            InitializeComponent();
            this.doctorID = loggedInDoctorID;
            LoadDiagnosedPatients();
        }

        private void LoadDiagnosedPatients()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
        SELECT 
            mr.RecordID,  -- Lấy RecordID để mở bệnh án
            p.PatientID,
            p.FullName AS PatientName,
            p.Phone,
            p.Email,
            p.Gender,
            p.Address,
            a.AppointmentDate,
            mr.Diagnosis,
            mr.Treatment
        FROM MedicalRecords mr
        JOIN Appointments a ON mr.AppointmentID = a.AppointmentID
        JOIN Patients p ON a.PatientID = p.PatientID
        WHERE a.DoctorID = @DoctorID;";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@DoctorID", doctorID);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvReturnResult.DataSource = dt;
                dgvReturnResult.Columns["RecordID"].Visible = false;  // Ẩn cột RecordID nếu không muốn hiển thị
            }
        }

        private void btnPreView_Click(object sender, EventArgs e)
        {

            if (dgvReturnResult.SelectedRows.Count > 0) // Kiểm tra xem có dòng nào được chọn không
            {
                int recordID;
                // Ensure that the RecordID can be converted to an integer safely
                if (int.TryParse(dgvReturnResult.SelectedRows[0].Cells["RecordID"].Value.ToString(), out recordID))
                {
                    DateTime createdDate = DateTime.Now;
                    BenhAn benhan = new BenhAn(recordID, createdDate);  // Truyền recordID vào constructor
                    benhan.Show();
                }
                else
                {
                    MessageBox.Show("Dữ liệu không hợp lệ! Không thể lấy RecordID.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một bệnh nhân!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
