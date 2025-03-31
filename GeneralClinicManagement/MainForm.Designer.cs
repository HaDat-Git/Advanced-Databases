namespace GeneralClinicManagement
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            panelMenu = new Panel();
            iconBtnLogin = new FontAwesome.Sharp.IconButton();
            iconBtnService = new FontAwesome.Sharp.IconButton();
            iconBtnOurDoctor = new FontAwesome.Sharp.IconButton();
            iconBtnAboutUs = new FontAwesome.Sharp.IconButton();
            panel3 = new Panel();
            btnMenu = new FontAwesome.Sharp.IconButton();
            iconHospital = new FontAwesome.Sharp.IconButton();
            panelTitleBar = new Panel();
            iconBtnDashBoard = new FontAwesome.Sharp.IconButton();
            btnMaximize = new FontAwesome.Sharp.IconButton();
            btnMinimize = new FontAwesome.Sharp.IconButton();
            btnClose = new FontAwesome.Sharp.IconButton();
            panelDesktop = new Panel();
            contextMenuStrip1 = new ContextMenuStrip(components);
            panelMenu.SuspendLayout();
            panel3.SuspendLayout();
            panelTitleBar.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(98, 102, 244);
            panelMenu.Controls.Add(iconBtnLogin);
            panelMenu.Controls.Add(iconBtnService);
            panelMenu.Controls.Add(iconBtnOurDoctor);
            panelMenu.Controls.Add(iconBtnAboutUs);
            panelMenu.Controls.Add(panel3);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Padding = new Padding(0, 0, 0, 10);
            panelMenu.Size = new Size(220, 590);
            panelMenu.TabIndex = 0;
            // 
            // iconBtnLogin
            // 
            iconBtnLogin.Dock = DockStyle.Bottom;
            iconBtnLogin.FlatAppearance.BorderSize = 0;
            iconBtnLogin.FlatStyle = FlatStyle.Flat;
            iconBtnLogin.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconBtnLogin.ForeColor = Color.White;
            iconBtnLogin.IconChar = FontAwesome.Sharp.IconChar.Key;
            iconBtnLogin.IconColor = Color.White;
            iconBtnLogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBtnLogin.IconSize = 30;
            iconBtnLogin.Location = new Point(0, 540);
            iconBtnLogin.Name = "iconBtnLogin";
            iconBtnLogin.Padding = new Padding(10, 0, 0, 0);
            iconBtnLogin.Size = new Size(220, 40);
            iconBtnLogin.TabIndex = 5;
            iconBtnLogin.Tag = "Login";
            iconBtnLogin.Text = "   Login";
            iconBtnLogin.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconBtnLogin.UseVisualStyleBackColor = true;
            iconBtnLogin.Click += iconBtnLogin_Click;
            // 
            // iconBtnService
            // 
            iconBtnService.Dock = DockStyle.Top;
            iconBtnService.FlatAppearance.BorderSize = 0;
            iconBtnService.FlatStyle = FlatStyle.Flat;
            iconBtnService.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconBtnService.ForeColor = Color.White;
            iconBtnService.IconChar = FontAwesome.Sharp.IconChar.TableList;
            iconBtnService.IconColor = Color.White;
            iconBtnService.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBtnService.IconSize = 30;
            iconBtnService.Location = new Point(0, 192);
            iconBtnService.Name = "iconBtnService";
            iconBtnService.Padding = new Padding(10, 0, 0, 0);
            iconBtnService.Size = new Size(220, 46);
            iconBtnService.TabIndex = 4;
            iconBtnService.Tag = "Service";
            iconBtnService.Text = "   Service";
            iconBtnService.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconBtnService.UseVisualStyleBackColor = true;
            iconBtnService.Click += iconBtnService_Click;
            // 
            // iconBtnOurDoctor
            // 
            iconBtnOurDoctor.Dock = DockStyle.Top;
            iconBtnOurDoctor.FlatAppearance.BorderSize = 0;
            iconBtnOurDoctor.FlatStyle = FlatStyle.Flat;
            iconBtnOurDoctor.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconBtnOurDoctor.ForeColor = Color.White;
            iconBtnOurDoctor.IconChar = FontAwesome.Sharp.IconChar.FolderPlus;
            iconBtnOurDoctor.IconColor = Color.White;
            iconBtnOurDoctor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBtnOurDoctor.IconSize = 30;
            iconBtnOurDoctor.Location = new Point(0, 146);
            iconBtnOurDoctor.Name = "iconBtnOurDoctor";
            iconBtnOurDoctor.Padding = new Padding(10, 0, 0, 0);
            iconBtnOurDoctor.Size = new Size(220, 46);
            iconBtnOurDoctor.TabIndex = 3;
            iconBtnOurDoctor.Tag = "Our Doctor";
            iconBtnOurDoctor.Text = "   Our Doctor";
            iconBtnOurDoctor.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconBtnOurDoctor.UseVisualStyleBackColor = true;
            iconBtnOurDoctor.Click += iconBtnOurDoctor_Click;
            // 
            // iconBtnAboutUs
            // 
            iconBtnAboutUs.Dock = DockStyle.Top;
            iconBtnAboutUs.FlatAppearance.BorderSize = 0;
            iconBtnAboutUs.FlatStyle = FlatStyle.Flat;
            iconBtnAboutUs.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconBtnAboutUs.ForeColor = Color.White;
            iconBtnAboutUs.IconChar = FontAwesome.Sharp.IconChar.HandPointRight;
            iconBtnAboutUs.IconColor = Color.White;
            iconBtnAboutUs.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBtnAboutUs.IconSize = 30;
            iconBtnAboutUs.Location = new Point(0, 100);
            iconBtnAboutUs.Name = "iconBtnAboutUs";
            iconBtnAboutUs.Padding = new Padding(10, 0, 0, 0);
            iconBtnAboutUs.Size = new Size(220, 46);
            iconBtnAboutUs.TabIndex = 2;
            iconBtnAboutUs.Tag = "About Us";
            iconBtnAboutUs.Text = "   About Us";
            iconBtnAboutUs.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconBtnAboutUs.UseVisualStyleBackColor = true;
            iconBtnAboutUs.Click += iconBtnAboutUs_Click;
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
            panelTitleBar.Size = new Size(694, 79);
            panelTitleBar.TabIndex = 1;
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
            iconBtnDashBoard.Size = new Size(158, 79);
            iconBtnDashBoard.TabIndex = 9;
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
            btnMaximize.Location = new Point(614, 3);
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
            btnMinimize.Location = new Point(577, 3);
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
            btnClose.Location = new Point(651, 3);
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
            panelDesktop.Size = new Size(694, 511);
            panelDesktop.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 590);
            Controls.Add(panelDesktop);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            Name = "MainForm";
            Text = "MainForm";
            Resize += MainForm_Resize;
            panelMenu.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panelTitleBar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panel3;
        private Panel panelTitleBar;
        private FontAwesome.Sharp.IconButton iconHospital;
        private FontAwesome.Sharp.IconButton btnMenu;
        private FontAwesome.Sharp.IconButton iconBtnAboutUs;
        private FontAwesome.Sharp.IconButton iconBtnLogin;
        private FontAwesome.Sharp.IconButton iconBtnService;
        private FontAwesome.Sharp.IconButton iconBtnOurDoctor;
        private FontAwesome.Sharp.IconButton btnMaximize;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private FontAwesome.Sharp.IconButton btnClose;
        private FontAwesome.Sharp.IconButton iconBtnDashBoard;
        private Panel panelDesktop;
        private ContextMenuStrip contextMenuStrip1;
    }
}