namespace GeneralClinicManagement
{
    partial class DoctorDetail
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
            pictureBoxDoctor = new PictureBox();
            lblName = new Label();
            lblGender = new Label();
            lblTitle = new Label();
            lblPosition = new Label();
            lblSpecialties = new Label();
            lblExperienceYears = new Label();
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            btnMaximize = new FontAwesome.Sharp.IconButton();
            btnMinimize = new FontAwesome.Sharp.IconButton();
            btnClose = new FontAwesome.Sharp.IconButton();
            panelTitleBar = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDoctor).BeginInit();
            panelTitleBar.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBoxDoctor
            // 
            pictureBoxDoctor.Location = new Point(26, 56);
            pictureBoxDoctor.Name = "pictureBoxDoctor";
            pictureBoxDoctor.Size = new Size(131, 111);
            pictureBoxDoctor.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxDoctor.TabIndex = 0;
            pictureBoxDoctor.TabStop = false;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(10, 187);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 1;
            lblName.Text = "Name";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(376, 59);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(45, 15);
            lblGender.TabIndex = 2;
            lblGender.Text = "Gender";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(376, 97);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(30, 15);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "Title";
            // 
            // lblPosition
            // 
            lblPosition.AutoSize = true;
            lblPosition.Location = new Point(376, 190);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(50, 15);
            lblPosition.TabIndex = 4;
            lblPosition.Text = "Position";
            // 
            // lblSpecialties
            // 
            lblSpecialties.AutoSize = true;
            lblSpecialties.Location = new Point(376, 143);
            lblSpecialties.Name = "lblSpecialties";
            lblSpecialties.Size = new Size(62, 15);
            lblSpecialties.TabIndex = 5;
            lblSpecialties.Text = "Specialties";
            // 
            // lblExperienceYears
            // 
            lblExperienceYears.AutoSize = true;
            lblExperienceYears.Location = new Point(376, 234);
            lblExperienceYears.Name = "lblExperienceYears";
            lblExperienceYears.Size = new Size(90, 15);
            lblExperienceYears.TabIndex = 6;
            lblExperienceYears.Text = "ExperienceYears";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(237, 56);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(57, 23);
            textBox1.TabIndex = 7;
            textBox1.Text = "Giới tính";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(237, 94);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(57, 23);
            textBox3.TabIndex = 9;
            textBox3.Text = "Chức vụ";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(237, 140);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(77, 23);
            textBox4.TabIndex = 10;
            textBox4.Text = "Chuyên Khoa";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(237, 187);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(85, 23);
            textBox5.TabIndex = 11;
            textBox5.Text = "Vị trí nắm giữ";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(237, 231);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(119, 23);
            textBox6.TabIndex = 12;
            textBox6.Text = "Số năm kinh nghiệm";
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
            btnMaximize.Location = new Point(901, 3);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(40, 20);
            btnMaximize.TabIndex = 15;
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
            btnMinimize.Location = new Point(864, 3);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(40, 20);
            btnMinimize.TabIndex = 14;
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
            btnClose.Location = new Point(938, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(40, 20);
            btnClose.TabIndex = 13;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = SystemColors.Highlight;
            panelTitleBar.Controls.Add(btnClose);
            panelTitleBar.Controls.Add(btnMaximize);
            panelTitleBar.Controls.Add(btnMinimize);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(0, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(981, 36);
            panelTitleBar.TabIndex = 16;
            panelTitleBar.MouseDown += panelTitleBar_MouseDown;
            // 
            // DoctorDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(981, 260);
            Controls.Add(panelTitleBar);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Controls.Add(lblExperienceYears);
            Controls.Add(lblSpecialties);
            Controls.Add(lblPosition);
            Controls.Add(lblTitle);
            Controls.Add(lblGender);
            Controls.Add(lblName);
            Controls.Add(pictureBoxDoctor);
            Name = "DoctorDetail";
            Text = "DoctorDetail";
            ((System.ComponentModel.ISupportInitialize)pictureBoxDoctor).EndInit();
            panelTitleBar.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxDoctor;
        private Label lblName;
        private Label lblGender;
        private Label lblTitle;
        private Label lblPosition;
        private Label lblSpecialties;
        private Label lblExperienceYears;
        private TextBox textBox1;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private FontAwesome.Sharp.IconButton btnMaximize;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private FontAwesome.Sharp.IconButton btnClose;
        private Panel panelTitleBar;
    }
}