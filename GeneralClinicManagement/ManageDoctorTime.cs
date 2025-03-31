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
    public partial class ManageDoctorTime : Form
    {
        string connectionString = @"Server=LAPTOP-RA8AK0H5;Database=general_clinic_manage;Trusted_Connection=True;TrustServerCertificate=True;";
        private SqlConnection conn;
        private int selectedScheduleID = -1;
        public ManageDoctorTime()
        {
            InitializeComponent();
        }

        private void ManageDoctorTime_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(connectionString);

            // Load danh sách bác sĩ vào combobox
            LoadDoctors();

            // Khởi tạo combobox ngày trong tuần
            InitWeekDayComboBox();

            // Hiển thị DataGridView
            DesignDataGridView();
        }

        private void InitWeekDayComboBox()
        {
            // Tạo combobox cho các ngày trong tuần
            cmbWorkDate.Items.Clear();
            cmbWorkDate.Items.Add(new { Text = "Thứ Hai", Value = 1 });
            cmbWorkDate.Items.Add(new { Text = "Thứ Ba", Value = 2 });
            cmbWorkDate.Items.Add(new { Text = "Thứ Tư", Value = 3 });
            cmbWorkDate.Items.Add(new { Text = "Thứ Năm", Value = 4 });
            cmbWorkDate.Items.Add(new { Text = "Thứ Sáu", Value = 5 });
            cmbWorkDate.Items.Add(new { Text = "Thứ Bảy", Value = 6 });
            cmbWorkDate.Items.Add(new { Text = "Chủ Nhật", Value = 7 });
            cmbWorkDate.DisplayMember = "Text";
            cmbWorkDate.ValueMember = "Value";
        }

        private void DesignDataGridView()
        {
            // Thiết kế DataGridView
            dgvSchedule.AutoGenerateColumns = false;
            dgvSchedule.Columns.Clear();

            // Thêm cột ScheduleID (ẩn)
            DataGridViewTextBoxColumn colScheduleID = new DataGridViewTextBoxColumn();
            colScheduleID.DataPropertyName = "ScheduleID";
            colScheduleID.HeaderText = "ScheduleID";
            colScheduleID.Visible = false;
            dgvSchedule.Columns.Add(colScheduleID);

            // Thêm cột DoctorID (ẩn)
            DataGridViewTextBoxColumn colDoctorID = new DataGridViewTextBoxColumn();
            colDoctorID.DataPropertyName = "DoctorID";
            colDoctorID.HeaderText = "DoctorID";
            colDoctorID.Visible = false;
            dgvSchedule.Columns.Add(colDoctorID);

            // Thêm cột Tên bác sĩ
            DataGridViewTextBoxColumn colDoctorName = new DataGridViewTextBoxColumn();
            colDoctorName.DataPropertyName = "DoctorName";
            colDoctorName.HeaderText = "Tên bác sĩ";
            colDoctorName.Width = 150;
            dgvSchedule.Columns.Add(colDoctorName);

            // Thêm cột Ngày trong tuần
            DataGridViewTextBoxColumn colWeekDay = new DataGridViewTextBoxColumn();
            colWeekDay.DataPropertyName = "WeekDayName";
            colWeekDay.HeaderText = "Ngày làm việc";
            colWeekDay.Width = 120;
            dgvSchedule.Columns.Add(colWeekDay);

            // Thêm cột Giờ bắt đầu
            DataGridViewTextBoxColumn colStartTime = new DataGridViewTextBoxColumn();
            colStartTime.DataPropertyName = "StartTime";
            colStartTime.HeaderText = "Giờ bắt đầu";
            colStartTime.Width = 100;
            dgvSchedule.Columns.Add(colStartTime);

            // Thêm cột Giờ kết thúc
            DataGridViewTextBoxColumn colEndTime = new DataGridViewTextBoxColumn();
            colEndTime.DataPropertyName = "EndTime";
            colEndTime.HeaderText = "Giờ kết thúc";
            colEndTime.Width = 100;
            dgvSchedule.Columns.Add(colEndTime);
        }

        private void LoadDoctors()
        {
            try
            {
                conn.Open();
                string query = "SELECT UserID, FullName FROM Users WHERE Role = 'Doctor' ORDER BY FullName";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // Thêm item mặc định
                DataRow dr = dt.NewRow();
                dr["UserID"] = -1;
                dr["FullName"] = "-- Chọn bác sĩ --";
                dt.Rows.InsertAt(dr, 0);

                cmbDoctorName.DataSource = dt;
                cmbDoctorName.DisplayMember = "FullName";
                cmbDoctorName.ValueMember = "UserID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách bác sĩ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }

            }
        }

        private void LoadDoctorSchedule(int doctorID)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)  // Chỉ mở nếu đang đóng
                {
                    conn.Open();
                }
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
                cmd.Parameters.AddWithValue("@DoctorID", doctorID);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvSchedule.DataSource = dt;

                dgvSchedule.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải lịch làm việc: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        private void cmbDoctorName_SelectIndexChange(object sender, EventArgs e)
        {
            if (cmbDoctorName.SelectedIndex > 0)
            {
                int doctorID = Convert.ToInt32(cmbDoctorName.SelectedValue);
                LoadDoctorSchedule(doctorID);
            }
            else
            {
                // Xóa dữ liệu trong DataGridView nếu chưa chọn bác sĩ
                dgvSchedule.DataSource = null;
            }
        }

        private void dgvSchedule_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy thông tin từ hàng được chọn
                DataGridViewRow row = dgvSchedule.Rows[e.RowIndex];

                // Lấy ScheduleID từ cột ẩn (cột 0)
                selectedScheduleID = Convert.ToInt32(row.Cells[0].Value);

                // Hiển thị thông tin lên các controls
                cmbDoctorName.SelectedValue = Convert.ToInt32(row.Cells[1].Value); // DoctorID

                // Lấy giá trị Work Date và chọn trong combobox
                string workDate = row.Cells[3].Value.ToString(); // WeekDayName
                for (int i = 0; i < cmbWorkDate.Items.Count; i++)
                {
                    if ((cmbWorkDate.Items[i] as dynamic).Text == workDate)
                    {
                        cmbWorkDate.SelectedIndex = i;
                        break;
                    }
                }

                // Hiển thị giờ bắt đầu và kết thúc
                txtStartTime.Text = row.Cells[4].Value.ToString(); // StartTime
                txtEndTime.Text = row.Cells[5].Value.ToString();   // EndTime
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu đầu vào
            if (cmbDoctorName.SelectedIndex <= 0)
            {
                MessageBox.Show("Vui lòng chọn bác sĩ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbWorkDate.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn ngày làm việc.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtStartTime.Text))
            {
                MessageBox.Show("Vui lòng nhập giờ bắt đầu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtEndTime.Text))
            {
                MessageBox.Show("Vui lòng nhập giờ kết thúc.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra định dạng thời gian
            TimeSpan startTime, endTime;
            if (!TimeSpan.TryParse(txtStartTime.Text, out startTime))
            {
                MessageBox.Show("Giờ bắt đầu không hợp lệ. Vui lòng nhập theo định dạng HH:mm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!TimeSpan.TryParse(txtEndTime.Text, out endTime))
            {
                MessageBox.Show("Giờ kết thúc không hợp lệ. Vui lòng nhập theo định dạng HH:mm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (startTime >= endTime)
            {
                MessageBox.Show("Giờ bắt đầu phải sớm hơn giờ kết thúc.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(connectionString);
                conn.Open();
                string query = @"
            INSERT INTO DoctorSchedules (DoctorID, WeekDay, StartTime, EndTime)
            VALUES (@DoctorID, @WeekDay, @StartTime, @EndTime)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@DoctorID", Convert.ToInt32(cmbDoctorName.SelectedValue));
                cmd.Parameters.AddWithValue("@WeekDay", (cmbWorkDate.SelectedItem as dynamic).Value);
                cmd.Parameters.AddWithValue("@StartTime", startTime);
                cmd.Parameters.AddWithValue("@EndTime", endTime);

                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Thêm lịch làm việc thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Reload dữ liệu
                    LoadDoctorSchedule(Convert.ToInt32(cmbDoctorName.SelectedValue));

                    // Reset các trường nhập liệu
                    ResetFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm lịch làm việc: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedScheduleID == -1)
            {
                MessageBox.Show("Vui lòng chọn lịch làm việc cần cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra dữ liệu đầu vào tương tự như khi thêm mới
            if (cmbDoctorName.SelectedIndex <= 0 || cmbWorkDate.SelectedIndex < 0 ||
                string.IsNullOrWhiteSpace(txtStartTime.Text) || string.IsNullOrWhiteSpace(txtEndTime.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra định dạng thời gian
            TimeSpan startTime, endTime;
            if (!TimeSpan.TryParse(txtStartTime.Text, out startTime) || !TimeSpan.TryParse(txtEndTime.Text, out endTime))
            {
                MessageBox.Show("Định dạng thời gian không hợp lệ. Vui lòng nhập theo định dạng HH:mm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (startTime >= endTime)
            {
                MessageBox.Show("Giờ bắt đầu phải sớm hơn giờ kết thúc.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                conn.Open();
                string query = @"
                UPDATE DoctorSchedules 
                SET DoctorID = @DoctorID, 
                    WeekDay = @WeekDay, 
                    StartTime = @StartTime, 
                    EndTime = @EndTime
                WHERE ScheduleID = @ScheduleID";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ScheduleID", selectedScheduleID);
                cmd.Parameters.AddWithValue("@DoctorID", Convert.ToInt32(cmbDoctorName.SelectedValue));
                cmd.Parameters.AddWithValue("@WeekDay", (cmbWorkDate.SelectedItem as dynamic).Value);
                cmd.Parameters.AddWithValue("@StartTime", startTime);
                cmd.Parameters.AddWithValue("@EndTime", endTime);

                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Cập nhật lịch làm việc thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Reload dữ liệu
                    LoadDoctorSchedule(Convert.ToInt32(cmbDoctorName.SelectedValue));

                    // Reset các trường nhập liệu
                    ResetFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật lịch làm việc: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedScheduleID == -1)
            {
                MessageBox.Show("Vui lòng chọn lịch làm việc cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Xác nhận trước khi xóa
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa lịch làm việc này?",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM DoctorSchedules WHERE ScheduleID = @ScheduleID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ScheduleID", selectedScheduleID);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Xóa lịch làm việc thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Reload dữ liệu
                        LoadDoctorSchedule(Convert.ToInt32(cmbDoctorName.SelectedValue));

                        // Reset các trường nhập liệu
                        ResetFields();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa lịch làm việc: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                        conn.Close();
                }
            }
        }

        private void ResetFields()
        {
            selectedScheduleID = -1;
            cmbWorkDate.SelectedIndex = -1;
            txtStartTime.Text = string.Empty;
            txtEndTime.Text = string.Empty;
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
