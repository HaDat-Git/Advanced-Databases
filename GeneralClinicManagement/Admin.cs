using System.Runtime.InteropServices;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GeneralClinicManagement
{
    public partial class Admin : Form
    {
        //Fields
        private int borderSize = 2;

        //Constructor
        public Admin()
        {
            InitializeComponent();
            CollapseMenu();
            this.Padding = new Padding(borderSize);
            //this.BackColor = Color.FromArgb(98, 102, 244);    
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, EventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }
            base.WndProc(ref m);
        }

        private void AdminForm_Resize(object sender, EventArgs e)
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
                    menuButton.Text = "   " + menuButton.Tag;
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(10, 0, 0, 0);
                }
            }
        }

        private void iconBtnDashBoard_Click(object sender, EventArgs e)
        {
            panelDesktop.Visible = true;
            panelDesktop.Controls.Clear();

            DashBoardControl hospital = new DashBoardControl();
            hospital.Dock = DockStyle.Fill;

            panelDesktop.Controls.Add(hospital);
        }

        private void iconBtnHome_Click(object sender, EventArgs e)
        {
            panelDesktop.Visible = true;
            panelDesktop.Controls.Clear();

            DashBoardControl hospital = new DashBoardControl();
            hospital.Dock = DockStyle.Fill;

            panelDesktop.Controls.Add(hospital);
        }

        private void iconBtnSignOut_Click(object sender, EventArgs e)
        {

            this.Close();

            MainForm mainForm = new MainForm();
            mainForm.Show();

            //Application.Restart();
        }

        private void iconBtnAddAppointment_Click(object sender, EventArgs e)
        {
            panelDesktop.Visible = true;
            panelDesktop.Controls.Clear();

            AddAppointmentControl addappointment = new AddAppointmentControl();
            addappointment.Dock = DockStyle.Fill;

            panelDesktop.Controls.Add(addappointment);
        }

        private void iconBtnAddDoctor_Click(object sender, EventArgs e)
        {
            panelDesktop.Visible = true;
            panelDesktop.Controls.Clear();

            AddDoctorControl addDoctor = new AddDoctorControl();
            addDoctor.Dock = DockStyle.Fill;

            panelDesktop.Controls.Add(addDoctor);
        }

        private void iconBtnUpdate_Click(object sender, EventArgs e)
        {
            panelDesktop.Visible = true;
            panelDesktop.Controls.Clear();

            UpdateInforControl updateInfor = new UpdateInforControl();
            updateInfor.Dock = DockStyle.Fill;

            panelDesktop.Controls.Add(updateInfor);
        }
    }
}
