using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace GeneralClinicManagement
{
    public partial class ViewScheduleControl : UserControl
    {
        private string connectionString = @"Server=LAPTOP-RA8AK0H5;Database=general_clinic_manage;Trusted_Connection=True;TrustServerCertificate=True;";
        private SqlConnection conn;

        // Biến lưu ID bác sĩ đăng nhập
        private int DoctorID;

        public ViewScheduleControl(int doctorID) // Truyền ID bác sĩ từ form đăng nhập
        {
            InitializeComponent();
            conn = new SqlConnection(connectionString);
            DoctorID = doctorID;
            LoadDoctorScheduleForLoggedInDoctor();
        }

        private void LoadDoctorScheduleForLoggedInDoctor()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                string query = @"
                        SELECT 
                            ds.ScheduleID,
                            ds.DoctorID,
                            u.FullName as DoctorName,
                            ds.WeekDay,
                            CASE 
                                WHEN ds.WeekDay = 1 THEN N'Thứ Hai'
                                WHEN ds.WeekDay = 2 THEN N'Thứ Ba'
                                WHEN ds.WeekDay = 3 THEN N'Thứ Tư'
                                WHEN ds.WeekDay = 4 THEN N'Thứ Năm'
                                WHEN ds.WeekDay = 5 THEN N'Thứ Sáu'
                                WHEN ds.WeekDay = 6 THEN N'Thứ Bảy'
                                WHEN ds.WeekDay = 7 THEN N'Chủ Nhật'
                            END as WeekDayName,
                            CONVERT(varchar(5), ds.StartTime, 108) as StartTime,
                            CONVERT(varchar(5), ds.EndTime, 108) as EndTime
                        FROM 
                            DoctorSchedules ds
                            INNER JOIN Users u ON ds.DoctorID = u.UserID
                        WHERE 
                            ds.DoctorID = @DoctorID
                        ORDER BY 
                            ds.WeekDay";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@DoctorID", DoctorID);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvSchedule.DataSource = dt; // Gán dữ liệu vào DataGridView
                dgvSchedule.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                dgvSchedule.Columns["ScheduleID"].Visible = false; // Ẩn cột ScheduleID
                dgvSchedule.Columns["DoctorID"].Visible = false;   // Ẩn cột DoctorID
                dgvSchedule.Columns["WeekDay"].Visible = false;    // Ẩn cột WeekDay

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải lịch làm việc: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        private void panelDesktop_Load(object sender, EventArgs e)
        {
            if (DoctorID != -1)
            {
                LoadDoctorScheduleForLoggedInDoctor();
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin bác sĩ đăng nhập.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
