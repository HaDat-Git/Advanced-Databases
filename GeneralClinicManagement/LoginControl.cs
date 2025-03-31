using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GeneralClinicManagement
{
    public partial class LoginControl : UserControl
    {
        
        public LoginControl()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập tài khoản và mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = @"Server=LAPTOP-RA8AK0H5;Database=general_clinic_manage;Trusted_Connection=True;TrustServerCertificate=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT UserID, Role FROM Users WHERE UserName = @username AND PassWord = @password";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    
                    using (SqlDataReader result = cmd.ExecuteReader()) 
                    {
                        if (result.Read())
                        {
                            string role = result["Role"].ToString();
                            if (role == "Admin")
                            {
                                MessageBox.Show("Đăng nhập thành công! Chào mừng Admin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                Form mainForm = this.FindForm();
                                if (mainForm != null)
                                {
                                    mainForm.Hide(); 
                                    Admin adminForm = new Admin();
                                    adminForm.Show();
                                    
                                }

                            }
                            else if (role == "Doctor")
                            {
                                int doctorID = Convert.ToInt32(result["UserID"]);

                                MessageBox.Show("Đăng nhập thành công! Chào mừng Bác sĩ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Form mainForm = this.FindForm();
                                if (mainForm != null)
                                {
                                    mainForm.Hide(); // Ẩn MainForm
                                    Doctor doctorForm = new Doctor(doctorID);
                                    doctorForm.Show();
                                    
                                }
                            }
                            else
                            {
                                MessageBox.Show("Vai trò không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    
                }
            }
        }
    }
}
