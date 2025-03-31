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
using System.Runtime.InteropServices;

namespace GeneralClinicManagement
{
    public partial class DoctorDetail : Form
    {
        private int doctorId;
        private string connectionString = @"Server=LAPTOP-RA8AK0H5;Database=general_clinic_manage;Trusted_Connection=True;TrustServerCertificate=True;"; // Thay bằng chuỗi kết nối của bạn
        private int borderSize = 2;
        public DoctorDetail(int doctorId)
        {
            InitializeComponent();
            this.doctorId = doctorId;
            LoadDoctorDetails();
            this.Padding = new Padding(borderSize);
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

        private void LoadDoctorDetails()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"SELECT u.FullName, u.Gender, d.Title, d.ManagementPosition, 
                                    d.Specialties, d.ExperienceYears, d.ProfileImage
                             FROM Users u
                             JOIN DoctorDetails d ON u.UserID = d.DoctorID
                             WHERE u.UserID = @DoctorID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@DoctorID", doctorId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            lblName.Text = reader["FullName"].ToString();
                            lblGender.Text = reader["Gender"].ToString();
                            lblTitle.Text = reader["Title"].ToString();
                            lblPosition.Text = reader["ManagementPosition"].ToString();
                            lblSpecialties.Text = reader["Specialties"].ToString();
                            lblExperienceYears.Text = reader["ExperienceYears"].ToString() + " năm";

                            string imagePath = reader["ProfileImage"].ToString();
                            if (!string.IsNullOrEmpty(imagePath) && System.IO.File.Exists(imagePath))
                            {
                                pictureBoxDoctor.Image = Image.FromFile(imagePath);
                            }
                        }
                    }
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
