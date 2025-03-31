using System;
using System.Collections.Generic;
using System.ComponentModel;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneralClinicManagement
{
    public partial class BenhAn : Form
    {
        private int recordID;
        private DateTime createdDate;
        private string connectionString = @"Server=LAPTOP-RA8AK0H5;Database=general_clinic_manage;Trusted_Connection=True;TrustServerCertificate=True;";
        private SqlConnection conn;
        private int borderSize = 2;
        public BenhAn(int recordID, DateTime createdDate)
        {
            InitializeComponent();
            this.recordID = recordID;
            this.createdDate = createdDate;
            LoadMedicalRecord();

            this.Padding = new Padding(borderSize);
        }

        private void LoadMedicalRecord()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT 
                        p.FullName AS PatientName, p.Gender, p.Phone, p.Email, p.Address,
                        u.FullName AS DoctorName,
                        mr.Diagnosis, mr.Treatment, mr.StatusPayment, 
                        a.About, a.Description, a.AppointmentDate,
                        ms.ServiceName, ms.Price, mrs.Quantity,
                        (ms.Price * mrs.Quantity) AS TotalPrice, 
                        mr.RecordID
                    FROM MedicalRecords mr
                    JOIN Appointments a ON mr.AppointmentID = a.AppointmentID
                    JOIN Patients p ON a.PatientID = p.PatientID
                    JOIN Users u ON a.DoctorID = u.UserID
                    LEFT JOIN MedicalRecordServices mrs ON mr.RecordID = mrs.RecordID
                    LEFT JOIN MedicalServices ms ON mrs.ServiceID = ms.ServiceID
                    WHERE mr.RecordID = @RecordID;";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@RecordID", recordID);
                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];

                    // Hiển thị thông tin bệnh nhân
                    lblPatientName.Text = row["PatientName"].ToString();
                    lblGender.Text = row["Gender"].ToString();
                    lblPhone.Text = row["Phone"].ToString();
                    lblEmail.Text = row["Email"].ToString();
                    lblAddress.Text = row["Address"].ToString();

                    // Hiển thị thông tin bác sĩ
                    lblDoctor.Text = row["DoctorName"].ToString();

                    // Hiển thị lý do khám và mô tả triệu chứng
                    lblAbout.Text = row["About"].ToString();
                    lblDescription.Text = row["Description"].ToString();

                    // Hiển thị ngày hẹn khám và ngày tạo hồ sơ
                    lblAppointmentDate.Text = Convert.ToDateTime(row["AppointmentDate"]).ToString("dd/MM/yyyy");
                    lblCreatedDate.Text = createdDate.ToString("dd/MM/yyyy HH:mm:ss");

                    // Hiển thị chẩn đoán và hướng điều trị
                    lblDiagnosis.Text = row["Diagnosis"].ToString();
                    lblTreatment.Text = row["Treatment"].ToString();

                    // Hiển thị danh sách dịch vụ
                    dgvServices.DataSource = dt;
                    dgvServices.Columns["RecordID"].Visible = false;
                    dgvServices.Columns["PatientName"].Visible = false;
                    dgvServices.Columns["Gender"].Visible = false;
                    dgvServices.Columns["Phone"].Visible = false;
                    dgvServices.Columns["Email"].Visible = false;
                    dgvServices.Columns["DoctorName"].Visible = false;
                    dgvServices.Columns["Diagnosis"].Visible = false;
                    dgvServices.Columns["Treatment"].Visible = false;
                    dgvServices.Columns["StatusPayment"].Visible = false;
                    dgvServices.Columns["About"].Visible = false;
                    dgvServices.Columns["Description"].Visible = false;
                    dgvServices.Columns["AppointmentDate"].Visible = false;
                    dgvServices.Columns["Quantity"].Visible = false;
                    dgvServices.Columns["Address"].Visible = false;
                    dgvServices.Columns["TotalPrice"].Visible = false;

                    // Ensure only ServiceName and Price are visible
                    dgvServices.Columns["ServiceName"].Visible = true;
                    dgvServices.Columns["Price"].Visible = true;

                }
                else
                {
                    MessageBox.Show("Không tìm thấy hồ sơ bệnh án!");
                }
            }
        }
      


        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }
            base.WndProc(ref m);
        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
