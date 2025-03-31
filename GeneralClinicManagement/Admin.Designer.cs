
namespace GeneralClinicManagement
{
    partial class Admin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panelMenu = new Panel();
            iconBtnSignOut = new FontAwesome.Sharp.IconButton();
            iconBtnAddDoctor = new FontAwesome.Sharp.IconButton();
            iconBtnUpdate = new FontAwesome.Sharp.IconButton();
            iconBtnAddAppointment = new FontAwesome.Sharp.IconButton();
            iconBtnHome = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            iconHospital = new FontAwesome.Sharp.IconButton();
            btnMenu = new FontAwesome.Sharp.IconButton();
            panelTitleBar = new Panel();
            btnMaximize = new FontAwesome.Sharp.IconButton();
            btnMinimize = new FontAwesome.Sharp.IconButton();
            btnClose = new FontAwesome.Sharp.IconButton();
            iconBtnDashBoard = new FontAwesome.Sharp.IconButton();
            panelDesktop = new Panel();
            notifyIcon1 = new NotifyIcon(components);
            panelMenu.SuspendLayout();
            panel2.SuspendLayout();
            panelTitleBar.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(98, 102, 244);
            panelMenu.Controls.Add(iconBtnSignOut);
            panelMenu.Controls.Add(iconBtnAddDoctor);
            panelMenu.Controls.Add(iconBtnUpdate);
            panelMenu.Controls.Add(iconBtnAddAppointment);
            panelMenu.Controls.Add(iconBtnHome);
            panelMenu.Controls.Add(panel2);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Padding = new Padding(10, 0, 0, 15);
            panelMenu.Size = new Size(231, 536);
            panelMenu.TabIndex = 0;
            // 
            // iconBtnSignOut
            // 
            iconBtnSignOut.Dock = DockStyle.Bottom;
            iconBtnSignOut.FlatAppearance.BorderSize = 0;
            iconBtnSignOut.FlatStyle = FlatStyle.Flat;
            iconBtnSignOut.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconBtnSignOut.ForeColor = Color.White;
            iconBtnSignOut.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            iconBtnSignOut.IconColor = Color.White;
            iconBtnSignOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBtnSignOut.IconSize = 30;
            iconBtnSignOut.ImageAlign = ContentAlignment.MiddleLeft;
            iconBtnSignOut.Location = new Point(10, 475);
            iconBtnSignOut.Name = "iconBtnSignOut";
            iconBtnSignOut.Padding = new Padding(10, 0, 0, 0);
            iconBtnSignOut.Size = new Size(221, 46);
            iconBtnSignOut.TabIndex = 8;
            iconBtnSignOut.Tag = "Sign Out";
            iconBtnSignOut.Text = "   Sign Out";
            iconBtnSignOut.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconBtnSignOut.UseVisualStyleBackColor = true;
            iconBtnSignOut.Click += iconBtnSignOut_Click;
            // 
            // iconBtnAddDoctor
            // 
            iconBtnAddDoctor.Dock = DockStyle.Top;
            iconBtnAddDoctor.FlatAppearance.BorderSize = 0;
            iconBtnAddDoctor.FlatStyle = FlatStyle.Flat;
            iconBtnAddDoctor.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconBtnAddDoctor.ForeColor = Color.White;
            iconBtnAddDoctor.IconChar = FontAwesome.Sharp.IconChar.HospitalUser;
            iconBtnAddDoctor.IconColor = Color.White;
            iconBtnAddDoctor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBtnAddDoctor.IconSize = 30;
            iconBtnAddDoctor.ImageAlign = ContentAlignment.MiddleLeft;
            iconBtnAddDoctor.Location = new Point(10, 223);
            iconBtnAddDoctor.Name = "iconBtnAddDoctor";
            iconBtnAddDoctor.Padding = new Padding(10, 0, 0, 0);
            iconBtnAddDoctor.Size = new Size(221, 46);
            iconBtnAddDoctor.TabIndex = 4;
            iconBtnAddDoctor.Tag = "Add Doctor";
            iconBtnAddDoctor.Text = "   Add Doctor";
            iconBtnAddDoctor.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconBtnAddDoctor.UseVisualStyleBackColor = true;
            iconBtnAddDoctor.Click += iconBtnAddDoctor_Click;
            // 
            // iconBtnUpdate
            // 
            iconBtnUpdate.Dock = DockStyle.Top;
            iconBtnUpdate.FlatAppearance.BorderSize = 0;
            iconBtnUpdate.FlatStyle = FlatStyle.Flat;
            iconBtnUpdate.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconBtnUpdate.ForeColor = Color.White;
            iconBtnUpdate.IconChar = FontAwesome.Sharp.IconChar.Wrench;
            iconBtnUpdate.IconColor = Color.White;
            iconBtnUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBtnUpdate.IconSize = 30;
            iconBtnUpdate.ImageAlign = ContentAlignment.MiddleLeft;
            iconBtnUpdate.Location = new Point(10, 177);
            iconBtnUpdate.Name = "iconBtnUpdate";
            iconBtnUpdate.Padding = new Padding(10, 0, 0, 0);
            iconBtnUpdate.Size = new Size(221, 46);
            iconBtnUpdate.TabIndex = 3;
            iconBtnUpdate.Tag = "Update Infor";
            iconBtnUpdate.Text = "   Update Infor";
            iconBtnUpdate.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconBtnUpdate.UseVisualStyleBackColor = true;
            iconBtnUpdate.Click += iconBtnUpdate_Click;
            // 
            // iconBtnAddAppointment
            // 
            iconBtnAddAppointment.Dock = DockStyle.Top;
            iconBtnAddAppointment.FlatAppearance.BorderSize = 0;
            iconBtnAddAppointment.FlatStyle = FlatStyle.Flat;
            iconBtnAddAppointment.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconBtnAddAppointment.ForeColor = Color.White;
            iconBtnAddAppointment.IconChar = FontAwesome.Sharp.IconChar.CalendarPlus;
            iconBtnAddAppointment.IconColor = Color.White;
            iconBtnAddAppointment.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBtnAddAppointment.IconSize = 30;
            iconBtnAddAppointment.ImageAlign = ContentAlignment.MiddleLeft;
            iconBtnAddAppointment.Location = new Point(10, 131);
            iconBtnAddAppointment.Name = "iconBtnAddAppointment";
            iconBtnAddAppointment.Padding = new Padding(10, 0, 0, 0);
            iconBtnAddAppointment.Size = new Size(221, 46);
            iconBtnAddAppointment.TabIndex = 2;
            iconBtnAddAppointment.Tag = "Add Appointment";
            iconBtnAddAppointment.Text = "   Add Appointment";
            iconBtnAddAppointment.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconBtnAddAppointment.UseVisualStyleBackColor = true;
            iconBtnAddAppointment.Click += iconBtnAddAppointment_Click;
            // 
            // iconBtnHome
            // 
            iconBtnHome.Dock = DockStyle.Top;
            iconBtnHome.FlatAppearance.BorderSize = 0;
            iconBtnHome.FlatStyle = FlatStyle.Flat;
            iconBtnHome.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconBtnHome.ForeColor = Color.White;
            iconBtnHome.IconChar = FontAwesome.Sharp.IconChar.House;
            iconBtnHome.IconColor = Color.White;
            iconBtnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBtnHome.IconSize = 30;
            iconBtnHome.ImageAlign = ContentAlignment.MiddleLeft;
            iconBtnHome.Location = new Point(10, 85);
            iconBtnHome.Name = "iconBtnHome";
            iconBtnHome.Padding = new Padding(10, 0, 0, 0);
            iconBtnHome.Size = new Size(221, 46);
            iconBtnHome.TabIndex = 1;
            iconBtnHome.Tag = "Home";
            iconBtnHome.Text = "   Home";
            iconBtnHome.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconBtnHome.UseVisualStyleBackColor = true;
            iconBtnHome.Click += iconBtnHome_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(iconHospital);
            panel2.Controls.Add(btnMenu);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(10, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(221, 85);
            panel2.TabIndex = 0;
            // 
            // iconHospital
            // 
            iconHospital.BackColor = Color.FromArgb(98, 102, 244);
            iconHospital.IconChar = FontAwesome.Sharp.IconChar.HouseMedicalFlag;
            iconHospital.IconColor = Color.White;
            iconHospital.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconHospital.Location = new Point(24, 9);
            iconHospital.Name = "iconHospital";
            iconHospital.Size = new Size(122, 67);
            iconHospital.TabIndex = 2;
            iconHospital.UseVisualStyleBackColor = false;
            // 
            // btnMenu
            // 
            btnMenu.FlatAppearance.BorderSize = 0;
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.IconChar = FontAwesome.Sharp.IconChar.Bars;
            btnMenu.IconColor = Color.White;
            btnMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMenu.IconSize = 30;
            btnMenu.Location = new Point(152, 3);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(69, 79);
            btnMenu.TabIndex = 1;
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // panelTitleBar
            // 
            panelTitleBar.Controls.Add(btnMaximize);
            panelTitleBar.Controls.Add(btnMinimize);
            panelTitleBar.Controls.Add(btnClose);
            panelTitleBar.Controls.Add(iconBtnDashBoard);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(231, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(595, 85);
            panelTitleBar.TabIndex = 3;
            panelTitleBar.MouseDown += panelTitleBar_MouseDown;
            // 
            // btnMaximize
            // 
            btnMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximize.BackColor = Color.DodgerBlue;
            btnMaximize.FlatAppearance.BorderSize = 0;
            btnMaximize.FlatStyle = FlatStyle.Flat;
            btnMaximize.IconChar = FontAwesome.Sharp.IconChar.ExternalLinkAlt;
            btnMaximize.IconColor = Color.White;
            btnMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMaximize.IconSize = 20;
            btnMaximize.Location = new Point(518, 0);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(40, 20);
            btnMaximize.TabIndex = 5;
            btnMaximize.UseVisualStyleBackColor = false;
            btnMaximize.Click += btnMaximize_Click;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.BackColor = Color.Turquoise;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            btnMinimize.IconColor = Color.White;
            btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMinimize.IconSize = 20;
            btnMinimize.Location = new Point(481, 0);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(40, 20);
            btnMinimize.TabIndex = 4;
            btnMinimize.UseVisualStyleBackColor = false;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.BackColor = Color.HotPink;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.IconChar = FontAwesome.Sharp.IconChar.Close;
            btnClose.IconColor = Color.White;
            btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnClose.IconSize = 20;
            btnClose.Location = new Point(555, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(40, 20);
            btnClose.TabIndex = 3;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // iconBtnDashBoard
            // 
            iconBtnDashBoard.Dock = DockStyle.Left;
            iconBtnDashBoard.FlatAppearance.BorderSize = 0;
            iconBtnDashBoard.FlatStyle = FlatStyle.Flat;
            iconBtnDashBoard.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconBtnDashBoard.ForeColor = Color.Black;
            iconBtnDashBoard.IconChar = FontAwesome.Sharp.IconChar.House;
            iconBtnDashBoard.IconColor = Color.Black;
            iconBtnDashBoard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBtnDashBoard.IconSize = 30;
            iconBtnDashBoard.ImageAlign = ContentAlignment.MiddleLeft;
            iconBtnDashBoard.Location = new Point(0, 0);
            iconBtnDashBoard.Name = "iconBtnDashBoard";
            iconBtnDashBoard.Padding = new Padding(10, 0, 0, 0);
            iconBtnDashBoard.Size = new Size(158, 85);
            iconBtnDashBoard.TabIndex = 2;
            iconBtnDashBoard.Text = "   DASHBOARD";
            iconBtnDashBoard.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconBtnDashBoard.UseVisualStyleBackColor = true;
            iconBtnDashBoard.Click += iconBtnDashBoard_Click;
            // 
            // panelDesktop
            // 
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.Location = new Point(231, 85);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(595, 451);
            panelDesktop.TabIndex = 2;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(826, 536);
            Controls.Add(panelDesktop);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            Name = "Admin";
            Text = "AdminForm";
            Resize += AdminForm_Resize;
            panelMenu.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panelTitleBar.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void mouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion

        private Panel panelMenu;
        private Panel panel2;
        private Panel panelTitleBar;
        private Panel panelDesktop;
        private NotifyIcon notifyIcon1;
        private FontAwesome.Sharp.IconButton btnMenu;
        private FontAwesome.Sharp.IconButton iconBtnHome;
        private FontAwesome.Sharp.IconButton iconBtnSignOut;
        private FontAwesome.Sharp.IconButton iconBtnAddDoctor;
        private FontAwesome.Sharp.IconButton iconBtnUpdate;
        private FontAwesome.Sharp.IconButton iconBtnAddAppointment;
        private FontAwesome.Sharp.IconButton iconBtnDashBoard;
        private FontAwesome.Sharp.IconButton btnMaximize;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private FontAwesome.Sharp.IconButton btnClose;
        private FontAwesome.Sharp.IconButton iconHospital;
    }
}
