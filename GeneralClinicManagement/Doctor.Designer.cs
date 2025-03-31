namespace GeneralClinicManagement
{
    partial class Doctor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelMenu = new Panel();
            iconBtnSignOut = new FontAwesome.Sharp.IconButton();
            iconBtnReturnRs = new FontAwesome.Sharp.IconButton();
            iconBtnAppointment = new FontAwesome.Sharp.IconButton();
            iconBtnSchedule = new FontAwesome.Sharp.IconButton();
            panel3 = new Panel();
            btnMenu = new FontAwesome.Sharp.IconButton();
            iconHospital = new FontAwesome.Sharp.IconButton();
            panelTitleBar = new Panel();
            iconBtnDashBoard = new FontAwesome.Sharp.IconButton();
            btnMaximize = new FontAwesome.Sharp.IconButton();
            btnMinimize = new FontAwesome.Sharp.IconButton();
            btnClose = new FontAwesome.Sharp.IconButton();
            panelDesktop = new Panel();
            panelMenu.SuspendLayout();
            panel3.SuspendLayout();
            panelTitleBar.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(98, 102, 244);
            panelMenu.Controls.Add(iconBtnSignOut);
            panelMenu.Controls.Add(iconBtnReturnRs);
            panelMenu.Controls.Add(iconBtnAppointment);
            panelMenu.Controls.Add(iconBtnSchedule);
            panelMenu.Controls.Add(panel3);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Padding = new Padding(0, 0, 0, 10);
            panelMenu.Size = new Size(220, 508);
            panelMenu.TabIndex = 3;
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
            iconBtnSignOut.Location = new Point(0, 452);
            iconBtnSignOut.Name = "iconBtnSignOut";
            iconBtnSignOut.Padding = new Padding(10, 0, 0, 0);
            iconBtnSignOut.Size = new Size(220, 46);
            iconBtnSignOut.TabIndex = 9;
            iconBtnSignOut.Tag = "Sign Out";
            iconBtnSignOut.Text = "   Sign Out";
            iconBtnSignOut.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconBtnSignOut.UseVisualStyleBackColor = true;
            iconBtnSignOut.Click += iconBtnSignOut_Click;
            // 
            // iconBtnReturnRs
            // 
            iconBtnReturnRs.Dock = DockStyle.Top;
            iconBtnReturnRs.FlatAppearance.BorderSize = 0;
            iconBtnReturnRs.FlatStyle = FlatStyle.Flat;
            iconBtnReturnRs.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconBtnReturnRs.ForeColor = Color.White;
            iconBtnReturnRs.IconChar = FontAwesome.Sharp.IconChar.SheetPlastic;
            iconBtnReturnRs.IconColor = Color.White;
            iconBtnReturnRs.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBtnReturnRs.IconSize = 30;
            iconBtnReturnRs.Location = new Point(0, 192);
            iconBtnReturnRs.Name = "iconBtnReturnRs";
            iconBtnReturnRs.Padding = new Padding(10, 0, 0, 0);
            iconBtnReturnRs.Size = new Size(220, 46);
            iconBtnReturnRs.TabIndex = 4;
            iconBtnReturnRs.Tag = "Return Result";
            iconBtnReturnRs.Text = "   Return Result";
            iconBtnReturnRs.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconBtnReturnRs.UseVisualStyleBackColor = true;
            iconBtnReturnRs.Click += iconBtnReturnRs_Click;
            // 
            // iconBtnAppointment
            // 
            iconBtnAppointment.Dock = DockStyle.Top;
            iconBtnAppointment.FlatAppearance.BorderSize = 0;
            iconBtnAppointment.FlatStyle = FlatStyle.Flat;
            iconBtnAppointment.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconBtnAppointment.ForeColor = Color.White;
            iconBtnAppointment.IconChar = FontAwesome.Sharp.IconChar.CalendarPlus;
            iconBtnAppointment.IconColor = Color.White;
            iconBtnAppointment.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBtnAppointment.IconSize = 30;
            iconBtnAppointment.Location = new Point(0, 146);
            iconBtnAppointment.Name = "iconBtnAppointment";
            iconBtnAppointment.Padding = new Padding(10, 0, 0, 0);
            iconBtnAppointment.Size = new Size(220, 46);
            iconBtnAppointment.TabIndex = 3;
            iconBtnAppointment.Tag = "Appointment";
            iconBtnAppointment.Text = "   Appointment";
            iconBtnAppointment.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconBtnAppointment.UseVisualStyleBackColor = true;
            iconBtnAppointment.Click += iconBtnAppointment_Click;
            // 
            // iconBtnSchedule
            // 
            iconBtnSchedule.Dock = DockStyle.Top;
            iconBtnSchedule.FlatAppearance.BorderSize = 0;
            iconBtnSchedule.FlatStyle = FlatStyle.Flat;
            iconBtnSchedule.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconBtnSchedule.ForeColor = Color.White;
            iconBtnSchedule.IconChar = FontAwesome.Sharp.IconChar.TableCells;
            iconBtnSchedule.IconColor = Color.White;
            iconBtnSchedule.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBtnSchedule.IconSize = 30;
            iconBtnSchedule.Location = new Point(0, 100);
            iconBtnSchedule.Name = "iconBtnSchedule";
            iconBtnSchedule.Padding = new Padding(10, 0, 0, 0);
            iconBtnSchedule.Size = new Size(220, 46);
            iconBtnSchedule.TabIndex = 2;
            iconBtnSchedule.Tag = "Schedule";
            iconBtnSchedule.Text = "   Schedule";
            iconBtnSchedule.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconBtnSchedule.UseVisualStyleBackColor = true;
            iconBtnSchedule.Click += iconBtnSchedule_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnMenu);
            panel3.Controls.Add(iconHospital);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(220, 100);
            panel3.TabIndex = 0;
            // 
            // btnMenu
            // 
            btnMenu.FlatAppearance.BorderSize = 0;
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.IconChar = FontAwesome.Sharp.IconChar.Bars;
            btnMenu.IconColor = Color.White;
            btnMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMenu.IconSize = 30;
            btnMenu.Location = new Point(140, 12);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(69, 79);
            btnMenu.TabIndex = 4;
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // iconHospital
            // 
            iconHospital.BackColor = Color.FromArgb(98, 102, 244);
            iconHospital.IconChar = FontAwesome.Sharp.IconChar.HouseMedicalFlag;
            iconHospital.IconColor = Color.White;
            iconHospital.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconHospital.Location = new Point(12, 12);
            iconHospital.Name = "iconHospital";
            iconHospital.Size = new Size(122, 67);
            iconHospital.TabIndex = 3;
            iconHospital.UseVisualStyleBackColor = false;
            // 
            // panelTitleBar
            // 
            panelTitleBar.Controls.Add(iconBtnDashBoard);
            panelTitleBar.Controls.Add(btnMaximize);
            panelTitleBar.Controls.Add(btnMinimize);
            panelTitleBar.Controls.Add(btnClose);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(220, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(632, 79);
            panelTitleBar.TabIndex = 4;
            panelTitleBar.MouseDown += panelTitleBar_MouseDown;
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
            iconBtnDashBoard.Size = new Size(159, 79);
            iconBtnDashBoard.TabIndex = 10;
            iconBtnDashBoard.Text = "   DASHBOARD";
            iconBtnDashBoard.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconBtnDashBoard.UseVisualStyleBackColor = true;
            iconBtnDashBoard.Click += iconBtnDashBoard_Click;
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
            btnMaximize.Location = new Point(553, 3);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(40, 20);
            btnMaximize.TabIndex = 8;
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
            btnMinimize.Location = new Point(516, 3);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(40, 20);
            btnMinimize.TabIndex = 7;
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
            btnClose.Location = new Point(590, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(40, 20);
            btnClose.TabIndex = 6;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // panelDesktop
            // 
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.Location = new Point(220, 79);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(632, 429);
            panelDesktop.TabIndex = 5;
            // 
            // Doctor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(852, 508);
            Controls.Add(panelDesktop);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            Name = "Doctor";
            Text = "Doctor";
            Resize += DoctorForm_Resize;
            panelMenu.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panelTitleBar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panelMenu;
        private FontAwesome.Sharp.IconButton iconBtnReturnRs;
        private FontAwesome.Sharp.IconButton iconBtnAppointment;
        private FontAwesome.Sharp.IconButton iconBtnSchedule;
        private Panel panel3;
        private FontAwesome.Sharp.IconButton btnMenu;
        private FontAwesome.Sharp.IconButton iconHospital;
        private FontAwesome.Sharp.IconButton iconBtnSignOut;
        private Panel panelTitleBar;
        private Panel panelDesktop;
        private FontAwesome.Sharp.IconButton btnMaximize;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private FontAwesome.Sharp.IconButton btnClose;
        private FontAwesome.Sharp.IconButton iconBtnDashBoard;
    }
}