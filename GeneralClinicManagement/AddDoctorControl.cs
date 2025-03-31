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
    public partial class AddDoctorControl : UserControl
    {

        string connectionString = @"Server=LAPTOP-RA8AK0H5;Database=general_clinic_manage;Trusted_Connection=True;TrustServerCertificate=True;";
        public AddDoctorControl()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra dữ liệu đầu vào
                if (string.IsNullOrEmpty(txtFullName.Text) || string.IsNullOrEmpty(txtTitle.Text) ||
                    string.IsNullOrEmpty(txtManagePosition.Text) || string.IsNullOrEmpty(txtSpecialties.Text) ||
                    string.IsNullOrEmpty(txtUserName.Text) || string.IsNullOrEmpty(txtPassWord.Text) ||
                    string.IsNullOrEmpty(txtConfirmPassWord.Text) || string.IsNullOrEmpty(txtManagePosition.Text) || string.IsNullOrEmpty(txtExperienceYear.Text))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra mật khẩu xác nhận
                if (txtPassWord.Text != txtConfirmPassWord.Text)
                {
                    MessageBox.Show("Mật khẩu xác nhận không khớp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra giới tính được chọn
                string gender = "";
                if (ckMale.Checked)
                    gender = "Male";
                else if (ckFemale.Checked)
                    gender = "Female";
                else
                {
                    MessageBox.Show("Vui lòng chọn giới tính!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kết nối đến database
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Bắt đầu transaction để đảm bảo tính toàn vẹn dữ liệu
                    SqlTransaction transaction = conn.BeginTransaction();

                    try
                    {
                        // Thêm dữ liệu vào bảng Users
                        string userQuery = @"INSERT INTO Users 
                                    (FullName, Gender, Specialties, UserName, PassWord, Role) 
                                    VALUES (@FullName, @Gender, @Specialties, @UserName, @PassWord, 'Doctor');
                                    SELECT SCOPE_IDENTITY();";

                        int newUserID = 0;

                        using (SqlCommand cmd = new SqlCommand(userQuery, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@FullName", txtFullName.Text);
                            cmd.Parameters.AddWithValue("@Gender", gender);
                            cmd.Parameters.AddWithValue("@Specialties", txtSpecialties.Text);
                            cmd.Parameters.AddWithValue("@UserName", txtUserName.Text);
                            cmd.Parameters.AddWithValue("@PassWord", txtPassWord.Text); // Tốt nhất nên mã hóa mật khẩu

                            // Lấy ID của bác sĩ vừa thêm
                            newUserID = Convert.ToInt32(cmd.ExecuteScalar());
                        }

                        // Thêm dữ liệu vào bảng DoctorDetails
                        string doctorQuery = @"INSERT INTO DoctorDetails 
                                      (DoctorID, Title, ManagementPosition, Specialties, ExperienceYears, ProfileImage) 
                                      VALUES (@DoctorID, @Title, @ManagementPosition, @Specialties, @ExperienceYears, @ProfileImage)";

                        using (SqlCommand cmd = new SqlCommand(doctorQuery, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@DoctorID", newUserID);
                            cmd.Parameters.AddWithValue("@Title", txtTitle.Text);
                            cmd.Parameters.AddWithValue("@ManagementPosition", txtManagePosition.Text);
                            cmd.Parameters.AddWithValue("@Specialties", txtSpecialties.Text);
                            cmd.Parameters.AddWithValue("@ExperienceYears", txtExperienceYear.Text);
                            cmd.Parameters.AddWithValue("@ProfileImage", txtPicture.Text);
                            cmd.ExecuteNonQuery();
                        }

                        // Commit transaction nếu tất cả thành công
                        transaction.Commit();

                        MessageBox.Show("Tạo tài khoản bác sĩ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Xóa thông tin trên form sau khi thêm thành công
                        ClearForm();
                    }
                    catch (Exception ex)
                    {
                        // Rollback nếu có lỗi
                        transaction.Rollback();
                        MessageBox.Show("Lỗi khi tạo tài khoản: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearForm()
        {
            // Xóa dữ liệu trên form
            txtFullName.Text = "";
            txtTitle.Text = "";
            txtManagePosition.Text = "";
            txtSpecialties.Text = "";
            txtUserName.Text = "";
            txtPassWord.Text = "";
            txtConfirmPassWord.Text = "";
            ckMale.Checked = false;
            ckFemale.Checked = false;
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\";
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                openFileDialog.Title = "Select an Image";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtPicture.Text = openFileDialog.FileName; // Hiển thị đường dẫn ảnh
                }
            }
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            ManageDoctor manageDoctor = new ManageDoctor(); 
            manageDoctor.Show();
        }
    }
}
