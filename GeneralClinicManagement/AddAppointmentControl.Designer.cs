namespace GeneralClinicManagement
{
    partial class AddAppointmentControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox2 = new TextBox();
            txtFullName = new TextBox();
            txtPhone = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            txtEmail = new TextBox();
            textBox7 = new TextBox();
            ckMale = new CheckBox();
            ckFemale = new CheckBox();
            textBox8 = new TextBox();
            textBox10 = new TextBox();
            rtbDescription = new RichTextBox();
            textBox11 = new TextBox();
            btnAdd = new Button();
            textBox12 = new TextBox();
            textBox14 = new TextBox();
            cmbDoctor = new ComboBox();
            textBox1 = new TextBox();
            dtpDOB = new DateTimePicker();
            txtAbout = new TextBox();
            btnManage = new Button();
            dtpAppDate = new DateTimePicker();
            textBox6 = new TextBox();
            txtAddress = new TextBox();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.DarkViolet;
            textBox2.ForeColor = SystemColors.Info;
            textBox2.Location = new Point(26, 69);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(67, 23);
            textBox2.TabIndex = 1;
            textBox2.Text = "Full Name";
            // 
            // txtFullName
            // 
            txtFullName.AcceptsReturn = true;
            txtFullName.Location = new Point(154, 69);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(200, 23);
            txtFullName.TabIndex = 2;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(154, 120);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(200, 23);
            txtPhone.TabIndex = 3;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.DarkViolet;
            textBox4.ForeColor = SystemColors.Info;
            textBox4.Location = new Point(26, 120);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(49, 23);
            textBox4.TabIndex = 4;
            textBox4.Text = "Phone";
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.DarkViolet;
            textBox5.ForeColor = SystemColors.Info;
            textBox5.Location = new Point(26, 170);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(38, 23);
            textBox5.TabIndex = 6;
            textBox5.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(154, 170);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(200, 23);
            txtEmail.TabIndex = 5;
            // 
            // textBox7
            // 
            textBox7.BackColor = Color.DarkViolet;
            textBox7.ForeColor = SystemColors.Info;
            textBox7.Location = new Point(25, 282);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(49, 23);
            textBox7.TabIndex = 6;
            textBox7.Text = "Gender";
            // 
            // ckMale
            // 
            ckMale.AutoSize = true;
            ckMale.ForeColor = SystemColors.Info;
            ckMale.Location = new Point(163, 284);
            ckMale.Name = "ckMale";
            ckMale.Size = new Size(52, 19);
            ckMale.TabIndex = 7;
            ckMale.Text = "Male";
            ckMale.UseVisualStyleBackColor = true;
            // 
            // ckFemale
            // 
            ckFemale.AutoSize = true;
            ckFemale.ForeColor = SystemColors.Info;
            ckFemale.Location = new Point(262, 286);
            ckFemale.Name = "ckFemale";
            ckFemale.Size = new Size(64, 19);
            ckFemale.TabIndex = 7;
            ckFemale.Text = "Female";
            ckFemale.UseVisualStyleBackColor = true;
            // 
            // textBox8
            // 
            textBox8.BackColor = Color.DarkViolet;
            textBox8.ForeColor = SystemColors.Info;
            textBox8.Location = new Point(26, 376);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(108, 23);
            textBox8.TabIndex = 9;
            textBox8.Text = "Appointment Date";
            // 
            // textBox10
            // 
            textBox10.BackColor = Color.DarkViolet;
            textBox10.ForeColor = SystemColors.Info;
            textBox10.Location = new Point(393, 167);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(78, 23);
            textBox10.TabIndex = 1;
            textBox10.Text = "* Description";
            // 
            // rtbDescription
            // 
            rtbDescription.Location = new Point(393, 196);
            rtbDescription.Name = "rtbDescription";
            rtbDescription.Size = new Size(309, 161);
            rtbDescription.TabIndex = 10;
            rtbDescription.Text = "";
            // 
            // textBox11
            // 
            textBox11.BackColor = Color.DarkViolet;
            textBox11.ForeColor = SystemColors.Info;
            textBox11.Location = new Point(393, 69);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(42, 23);
            textBox11.TabIndex = 1;
            textBox11.Text = "About";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(525, 393);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(92, 34);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // textBox12
            // 
            textBox12.BackColor = Color.DarkViolet;
            textBox12.BorderStyle = BorderStyle.None;
            textBox12.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox12.ForeColor = SystemColors.Info;
            textBox12.Location = new Point(230, 12);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(289, 26);
            textBox12.TabIndex = 13;
            textBox12.Text = "Get Patient Information";
            // 
            // textBox14
            // 
            textBox14.BackColor = Color.DarkViolet;
            textBox14.ForeColor = SystemColors.Info;
            textBox14.Location = new Point(393, 120);
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(42, 23);
            textBox14.TabIndex = 14;
            textBox14.Text = "Doctor";
            // 
            // cmbDoctor
            // 
            cmbDoctor.FormattingEnabled = true;
            cmbDoctor.Location = new Point(502, 120);
            cmbDoctor.Name = "cmbDoctor";
            cmbDoctor.Size = new Size(200, 23);
            cmbDoctor.TabIndex = 15;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.DarkViolet;
            textBox1.ForeColor = SystemColors.Info;
            textBox1.Location = new Point(25, 221);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(30, 23);
            textBox1.TabIndex = 16;
            textBox1.Text = "DOB";
            // 
            // dtpDOB
            // 
            dtpDOB.Location = new Point(154, 221);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.Size = new Size(200, 23);
            dtpDOB.TabIndex = 17;
            // 
            // txtAbout
            // 
            txtAbout.Location = new Point(502, 69);
            txtAbout.Multiline = true;
            txtAbout.Name = "txtAbout";
            txtAbout.Size = new Size(200, 23);
            txtAbout.TabIndex = 18;
            // 
            // btnManage
            // 
            btnManage.Location = new Point(634, 393);
            btnManage.Name = "btnManage";
            btnManage.Size = new Size(92, 34);
            btnManage.TabIndex = 22;
            btnManage.Text = "Manage";
            btnManage.UseVisualStyleBackColor = true;
            btnManage.Click += btnManage_Click;
            // 
            // dtpAppDate
            // 
            dtpAppDate.Location = new Point(154, 376);
            dtpAppDate.Name = "dtpAppDate";
            dtpAppDate.Size = new Size(200, 23);
            dtpAppDate.TabIndex = 23;
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.DarkViolet;
            textBox6.ForeColor = SystemColors.Info;
            textBox6.Location = new Point(26, 334);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(49, 23);
            textBox6.TabIndex = 25;
            textBox6.Text = "Address";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(154, 334);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(200, 23);
            txtAddress.TabIndex = 24;
            // 
            // AddAppointmentControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkViolet;
            Controls.Add(textBox6);
            Controls.Add(txtAddress);
            Controls.Add(dtpAppDate);
            Controls.Add(btnManage);
            Controls.Add(txtAbout);
            Controls.Add(dtpDOB);
            Controls.Add(textBox1);
            Controls.Add(cmbDoctor);
            Controls.Add(textBox14);
            Controls.Add(textBox12);
            Controls.Add(btnAdd);
            Controls.Add(rtbDescription);
            Controls.Add(textBox8);
            Controls.Add(ckFemale);
            Controls.Add(ckMale);
            Controls.Add(textBox7);
            Controls.Add(textBox5);
            Controls.Add(txtEmail);
            Controls.Add(textBox4);
            Controls.Add(txtPhone);
            Controls.Add(textBox10);
            Controls.Add(textBox11);
            Controls.Add(txtFullName);
            Controls.Add(textBox2);
            Name = "AddAppointmentControl";
            Size = new Size(741, 468);
            Load += panelDesktop_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox2;
        private TextBox txtFullName;
        private TextBox txtPhone;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox txtEmail;
        private TextBox textBox7;
        private CheckBox ckMale;
        private CheckBox ckFemale;
        private TextBox textBox8;
        private TextBox textBox10;
        private RichTextBox rtbDescription;
        private TextBox textBox11;
        private Button btnAdd;
        private TextBox textBox12;
        private TextBox textBox14;
        private ComboBox cmbDoctor;
        private TextBox textBox1;
        private DateTimePicker dtpDOB;
        private TextBox txtAbout;
        private Button btnManage;
        private DateTimePicker dtpAppDate;
        private TextBox textBox6;
        private TextBox txtAddress;
    }
}
