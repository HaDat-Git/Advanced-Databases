using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace GeneralClinicManagement
{
    public partial class MainForm : Form
    {
        private int borderSize = 2;
        public MainForm()
        {
            InitializeComponent();
            CollapseMenu();
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

        private void MainForm_Resize(object sender, EventArgs e)
        {
            AdjustForm();
        }

        private void AdjustForm()
        {
            switch (this.WindowState)
            {
                case FormWindowState.Maximized:
                    this.Padding = new Padding(8, 8, 8, 0);
                    break;
                case FormWindowState.Normal:
                    if (this.Padding.Top != borderSize)
                        this.Padding = new Padding(borderSize);
                    break;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            CollapseMenu();
        }

        private void CollapseMenu()
        {
            if (this.panelMenu.Width > 200)
            {
                panelMenu.Width = 100;
                iconHospital.Visible = false;
                btnMenu.Dock = DockStyle.Top;
                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(0);
                }
            }
            else
            {
                panelMenu.Width = 230;
                iconHospital.Visible = true;
                btnMenu.Dock = DockStyle.None;
                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "        " + menuButton.Tag;
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(10, 0, 0, 0);
                }
            }
        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void iconBtnLogin_Click(object sender, EventArgs e)
        {
            // Hiển thị Panel chứa giao diện đăng nhập/đăng ký
            panelDesktop.Visible = true;

            // Xóa các Control cũ trong Panel (nếu có)
            panelDesktop.Controls.Clear();

            // Khởi tạo Form đăng nhập
            LoginControl login = new LoginControl();
            login.Dock = DockStyle.Fill; // Để căn chỉnh toàn Panel

            // Thêm vào Panel
            panelDesktop.Controls.Add(login);
        }


        private void iconBtnAboutUs_Click(object sender, EventArgs e)
        {
            panelDesktop.Visible = true;
            panelDesktop.Controls.Clear(); // Xóa nội dung cũ trong Panel

            AboutUsControl aboutUs = new AboutUsControl();
            aboutUs.Dock = DockStyle.Fill; // Hiển thị toàn bộ panel

            panelDesktop.Controls.Add(aboutUs);
        }

        private void iconBtnOurDoctor_Click(object sender, EventArgs e)
        {
            panelDesktop.Visible = true;
            panelDesktop.Controls.Clear(); // Xóa nội dung cũ trong Panel

            OurDoctorControl ourDoctor = new OurDoctorControl();
            ourDoctor.Dock = DockStyle.Fill; // Hiển thị toàn bộ panel

            panelDesktop.Controls.Add(ourDoctor);
        }

        private void iconBtnService_Click(object sender, EventArgs e)
        {
            panelDesktop.Visible = true;
            panelDesktop.Controls.Clear(); // Xóa nội dung cũ trong Panel

            ServiceControl service = new ServiceControl();
            service.Dock = DockStyle.Fill; // Hiển thị toàn bộ panel

            panelDesktop.Controls.Add(service);
        }


        private void iconBtnDashBoard_Click(object sender, EventArgs e)
        {
            panelDesktop.Visible = true;
            panelDesktop.Controls.Clear(); // Xóa nội dung cũ trong Panel

            DashBoardControl hospital = new DashBoardControl();
            hospital.Dock = DockStyle.Fill; // Hiển thị toàn bộ panel

            panelDesktop.Controls.Add(hospital);
        }
    }
}


