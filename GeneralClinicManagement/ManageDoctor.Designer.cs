namespace GeneralClinicManagement
{
    partial class ManageDoctor
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
            dataGridView = new DataGridView();
            txtManagePosition = new TextBox();
            textBox9 = new TextBox();
            textBox7 = new TextBox();
            textBox5 = new TextBox();
            txtDoctorName = new TextBox();
            textBox2 = new TextBox();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnClose = new Button();
            txtSpecialties = new TextBox();
            textBox3 = new TextBox();
            txtExperienceYear = new TextBox();
            textBox4 = new TextBox();
            txtPicture = new TextBox();
            textBox6 = new TextBox();
            txtPassWord = new TextBox();
            textBox8 = new TextBox();
            txtUserName = new TextBox();
            textBox11 = new TextBox();
            textBox13 = new TextBox();
            ckMale = new CheckBox();
            ckFemale = new CheckBox();
            btnImport = new Button();
            txtTitle = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(26, 233);
            dataGridView.Name = "dataGridView";
            dataGridView.Size = new Size(976, 208);
            dataGridView.TabIndex = 0;
            dataGridView.CellClick += dataGridView_CellClick;
            // 
            // txtManagePosition
            // 
            txtManagePosition.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtManagePosition.Location = new Point(463, 68);
            txtManagePosition.Name = "txtManagePosition";
            txtManagePosition.Size = new Size(182, 22);
            txtManagePosition.TabIndex = 26;
            // 
            // textBox9
            // 
            textBox9.BackColor = SystemColors.ActiveCaption;
            textBox9.BorderStyle = BorderStyle.None;
            textBox9.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox9.ForeColor = SystemColors.WindowText;
            textBox9.Location = new Point(328, 72);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(104, 15);
            textBox9.TabIndex = 25;
            textBox9.Text = "ManagePosition";
            // 
            // textBox7
            // 
            textBox7.BackColor = SystemColors.ActiveCaption;
            textBox7.BorderStyle = BorderStyle.None;
            textBox7.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox7.ForeColor = SystemColors.WindowText;
            textBox7.Location = new Point(25, 124);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(35, 15);
            textBox7.TabIndex = 23;
            textBox7.Text = "Title";
            // 
            // textBox5
            // 
            textBox5.BackColor = SystemColors.ActiveCaption;
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox5.ForeColor = SystemColors.WindowText;
            textBox5.Location = new Point(25, 74);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(90, 15);
            textBox5.TabIndex = 22;
            textBox5.Text = "Doctor Name";
            // 
            // txtDoctorName
            // 
            txtDoctorName.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDoctorName.Location = new Point(121, 71);
            txtDoctorName.Name = "txtDoctorName";
            txtDoctorName.Size = new Size(173, 22);
            txtDoctorName.TabIndex = 21;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(316, 12);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(368, 31);
            textBox2.TabIndex = 20;
            textBox2.Text = "Manage Doctor Information Page";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(751, 458);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 27);
            btnDelete.TabIndex = 34;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(843, 458);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 27);
            btnUpdate.TabIndex = 33;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(936, 458);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 27);
            btnClose.TabIndex = 32;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // txtSpecialties
            // 
            txtSpecialties.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSpecialties.Location = new Point(463, 120);
            txtSpecialties.Name = "txtSpecialties";
            txtSpecialties.Size = new Size(182, 22);
            txtSpecialties.TabIndex = 36;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.ActiveCaption;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.ForeColor = SystemColors.WindowText;
            textBox3.Location = new Point(328, 124);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(77, 15);
            textBox3.TabIndex = 35;
            textBox3.Text = "Specialties";
            // 
            // txtExperienceYear
            // 
            txtExperienceYear.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtExperienceYear.Location = new Point(820, 68);
            txtExperienceYear.Name = "txtExperienceYear";
            txtExperienceYear.Size = new Size(163, 22);
            txtExperienceYear.TabIndex = 38;
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.ActiveCaption;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.ForeColor = SystemColors.WindowText;
            textBox4.Location = new Point(685, 72);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(111, 15);
            textBox4.TabIndex = 37;
            textBox4.Text = "Experience Years";
            // 
            // txtPicture
            // 
            txtPicture.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPicture.Location = new Point(820, 117);
            txtPicture.Name = "txtPicture";
            txtPicture.Size = new Size(163, 22);
            txtPicture.TabIndex = 40;
            // 
            // textBox6
            // 
            textBox6.BackColor = SystemColors.ActiveCaption;
            textBox6.BorderStyle = BorderStyle.None;
            textBox6.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox6.ForeColor = SystemColors.WindowText;
            textBox6.Location = new Point(685, 121);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(90, 15);
            textBox6.TabIndex = 39;
            textBox6.Text = "Profile Image";
            // 
            // txtPassWord
            // 
            txtPassWord.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassWord.Location = new Point(820, 174);
            txtPassWord.Name = "txtPassWord";
            txtPassWord.Size = new Size(163, 22);
            txtPassWord.TabIndex = 46;
            // 
            // textBox8
            // 
            textBox8.BackColor = SystemColors.ActiveCaption;
            textBox8.BorderStyle = BorderStyle.None;
            textBox8.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox8.ForeColor = SystemColors.WindowText;
            textBox8.Location = new Point(685, 178);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(90, 15);
            textBox8.TabIndex = 45;
            textBox8.Text = "PassWord";
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUserName.Location = new Point(463, 177);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(182, 22);
            txtUserName.TabIndex = 44;
            // 
            // textBox11
            // 
            textBox11.BackColor = SystemColors.ActiveCaption;
            textBox11.BorderStyle = BorderStyle.None;
            textBox11.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox11.ForeColor = SystemColors.WindowText;
            textBox11.Location = new Point(328, 181);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(77, 15);
            textBox11.TabIndex = 43;
            textBox11.Text = "User Name";
            // 
            // textBox13
            // 
            textBox13.BackColor = SystemColors.ActiveCaption;
            textBox13.BorderStyle = BorderStyle.None;
            textBox13.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox13.ForeColor = SystemColors.WindowText;
            textBox13.Location = new Point(25, 181);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(35, 15);
            textBox13.TabIndex = 41;
            textBox13.Text = "Title";
            // 
            // ckMale
            // 
            ckMale.AutoSize = true;
            ckMale.Location = new Point(134, 177);
            ckMale.Name = "ckMale";
            ckMale.Size = new Size(52, 19);
            ckMale.TabIndex = 47;
            ckMale.Text = "Male";
            ckMale.UseVisualStyleBackColor = true;
            // 
            // ckFemale
            // 
            ckFemale.AutoSize = true;
            ckFemale.Location = new Point(204, 177);
            ckFemale.Name = "ckFemale";
            ckFemale.Size = new Size(64, 19);
            ckFemale.TabIndex = 48;
            ckFemale.Text = "Female";
            ckFemale.UseVisualStyleBackColor = true;
            // 
            // btnImport
            // 
            btnImport.Location = new Point(989, 117);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(28, 22);
            btnImport.TabIndex = 49;
            btnImport.Text = "...";
            btnImport.UseVisualStyleBackColor = true;
            btnImport.Click += btnImport_Click;
            // 
            // txtTitle
            // 
            txtTitle.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTitle.Location = new Point(121, 121);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(173, 22);
            txtTitle.TabIndex = 50;
            // 
            // ManageDoctor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1023, 497);
            Controls.Add(txtTitle);
            Controls.Add(btnImport);
            Controls.Add(ckFemale);
            Controls.Add(ckMale);
            Controls.Add(txtPassWord);
            Controls.Add(textBox8);
            Controls.Add(txtUserName);
            Controls.Add(textBox11);
            Controls.Add(textBox13);
            Controls.Add(txtPicture);
            Controls.Add(textBox6);
            Controls.Add(txtExperienceYear);
            Controls.Add(textBox4);
            Controls.Add(txtSpecialties);
            Controls.Add(textBox3);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnClose);
            Controls.Add(txtManagePosition);
            Controls.Add(textBox9);
            Controls.Add(textBox7);
            Controls.Add(textBox5);
            Controls.Add(txtDoctorName);
            Controls.Add(textBox2);
            Controls.Add(dataGridView);
            Name = "ManageDoctor";
            Text = "ManageDoctor";
            Load += ManageDoctor_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView;
        private ComboBox cmbDoctorName;
        private TextBox txtManagePosition;
        private TextBox textBox9;
        private TextBox txtAbout;
        private TextBox textBox7;
        private TextBox textBox5;
        private TextBox txtDoctorName;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnClose;
        private TextBox txtSpecialties;
        private TextBox textBox3;
        private TextBox txtExperienceYear;
        private TextBox textBox4;
        private TextBox txtPicture;
        private TextBox textBox6;
        private TextBox txtPassWord;
        private TextBox textBox8;
        private TextBox txtUserName;
        private TextBox textBox11;
        private TextBox textBox13;
        private CheckBox ckMale;
        private CheckBox ckFemale;
        private Button btnImport;
        private TextBox txtTitle;
    }
}