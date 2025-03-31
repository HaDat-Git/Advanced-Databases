namespace GeneralClinicManagement
{
    partial class BenhAn
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
            panelTitle_Bar = new Panel();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            textBox10 = new TextBox();
            textBox11 = new TextBox();
            textBox12 = new TextBox();
            textBox13 = new TextBox();
            lblPatientName = new Label();
            lblGender = new Label();
            lblPhone = new Label();
            lblEmail = new Label();
            lblAbout = new Label();
            lblDescription = new Label();
            lblAppointmentDate = new Label();
            lblDoctor = new Label();
            lblDiagnosis = new Label();
            lblTreatment = new Label();
            lblCreatedDate = new Label();
            textBox19 = new TextBox();
            lblAddress = new Label();
            textBox20 = new TextBox();
            btnClose = new Button();
            dgvServices = new DataGridView();
            panelTitle_Bar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvServices).BeginInit();
            SuspendLayout();
            // 
            // panelTitle_Bar
            // 
            panelTitle_Bar.Controls.Add(textBox1);
            panelTitle_Bar.Dock = DockStyle.Top;
            panelTitle_Bar.Location = new Point(0, 0);
            panelTitle_Bar.Name = "panelTitle_Bar";
            panelTitle_Bar.Size = new Size(570, 46);
            panelTitle_Bar.TabIndex = 0;
            panelTitle_Bar.MouseDown += panelTitleBar_MouseDown;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Control;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(205, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(222, 28);
            textBox1.TabIndex = 1;
            textBox1.Text = "HỒ SƠ KHÁM BỆNH";
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Control;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(12, 73);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(92, 14);
            textBox2.TabIndex = 1;
            textBox2.Text = "Họ tên bệnh nhân:";
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.Control;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(12, 224);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(70, 14);
            textBox3.TabIndex = 2;
            textBox3.Text = "Lý do khám:";
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.Control;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(12, 254);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(92, 14);
            textBox4.TabIndex = 3;
            textBox4.Text = "Mô tả triệu chứng:";
            // 
            // textBox5
            // 
            textBox5.BackColor = SystemColors.Control;
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox5.Location = new Point(12, 285);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(85, 14);
            textBox5.TabIndex = 4;
            textBox5.Text = "Ngày hẹn khám:";
            // 
            // textBox6
            // 
            textBox6.BackColor = SystemColors.Control;
            textBox6.BorderStyle = BorderStyle.None;
            textBox6.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox6.Location = new Point(288, 73);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(92, 14);
            textBox6.TabIndex = 5;
            textBox6.Text = "Bác sĩ phụ trách:";
            // 
            // textBox7
            // 
            textBox7.BackColor = SystemColors.Control;
            textBox7.BorderStyle = BorderStyle.None;
            textBox7.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox7.Location = new Point(12, 448);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(52, 14);
            textBox7.TabIndex = 6;
            textBox7.Text = "Ngày tạo: ";
            // 
            // textBox8
            // 
            textBox8.BackColor = SystemColors.Control;
            textBox8.BorderStyle = BorderStyle.None;
            textBox8.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox8.Location = new Point(288, 102);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(92, 14);
            textBox8.TabIndex = 7;
            textBox8.Text = "Chuẩn đoán bệnh: ";
            // 
            // textBox9
            // 
            textBox9.BackColor = SystemColors.Control;
            textBox9.BorderStyle = BorderStyle.None;
            textBox9.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox9.Location = new Point(288, 163);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(76, 14);
            textBox9.TabIndex = 8;
            textBox9.Text = "Hướng điều trị:";
            // 
            // textBox10
            // 
            textBox10.BackColor = SystemColors.Control;
            textBox10.BorderStyle = BorderStyle.None;
            textBox10.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox10.Location = new Point(12, 102);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(54, 14);
            textBox10.TabIndex = 9;
            textBox10.Text = "Giới tính: ";
            // 
            // textBox11
            // 
            textBox11.BackColor = SystemColors.Control;
            textBox11.BorderStyle = BorderStyle.None;
            textBox11.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox11.Location = new Point(12, 132);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(70, 14);
            textBox11.TabIndex = 10;
            textBox11.Text = "Số điện thoại:";
            // 
            // textBox12
            // 
            textBox12.BackColor = SystemColors.Control;
            textBox12.BorderStyle = BorderStyle.None;
            textBox12.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox12.Location = new Point(12, 163);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(40, 14);
            textBox12.TabIndex = 11;
            textBox12.Text = "Email: ";
            // 
            // textBox13
            // 
            textBox13.BackColor = SystemColors.Control;
            textBox13.BorderStyle = BorderStyle.None;
            textBox13.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox13.Location = new Point(12, 320);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(141, 14);
            textBox13.TabIndex = 12;
            textBox13.Text = "CÁC DỊCH VỤ SỬ DỤNG";
            // 
            // lblPatientName
            // 
            lblPatientName.AutoSize = true;
            lblPatientName.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPatientName.Location = new Point(110, 73);
            lblPatientName.Name = "lblPatientName";
            lblPatientName.Size = new Size(35, 15);
            lblPatientName.TabIndex = 18;
            lblPatientName.Text = "label1";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGender.Location = new Point(110, 102);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(35, 15);
            lblGender.TabIndex = 19;
            lblGender.Text = "label2";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPhone.Location = new Point(110, 132);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(35, 15);
            lblPhone.TabIndex = 20;
            lblPhone.Text = "label3";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(110, 162);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(35, 15);
            lblEmail.TabIndex = 21;
            lblEmail.Text = "label4";
            // 
            // lblAbout
            // 
            lblAbout.AutoSize = true;
            lblAbout.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAbout.Location = new Point(110, 224);
            lblAbout.Name = "lblAbout";
            lblAbout.Size = new Size(35, 15);
            lblAbout.TabIndex = 22;
            lblAbout.Text = "label5";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescription.Location = new Point(110, 254);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(35, 15);
            lblDescription.TabIndex = 23;
            lblDescription.Text = "label6";
            // 
            // lblAppointmentDate
            // 
            lblAppointmentDate.AutoSize = true;
            lblAppointmentDate.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAppointmentDate.Location = new Point(110, 285);
            lblAppointmentDate.Name = "lblAppointmentDate";
            lblAppointmentDate.Size = new Size(35, 15);
            lblAppointmentDate.TabIndex = 24;
            lblAppointmentDate.Text = "label7";
            // 
            // lblDoctor
            // 
            lblDoctor.AutoSize = true;
            lblDoctor.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDoctor.Location = new Point(386, 73);
            lblDoctor.Name = "lblDoctor";
            lblDoctor.Size = new Size(35, 15);
            lblDoctor.TabIndex = 25;
            lblDoctor.Text = "label8";
            // 
            // lblDiagnosis
            // 
            lblDiagnosis.AutoSize = true;
            lblDiagnosis.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDiagnosis.Location = new Point(386, 102);
            lblDiagnosis.Name = "lblDiagnosis";
            lblDiagnosis.Size = new Size(35, 15);
            lblDiagnosis.TabIndex = 26;
            lblDiagnosis.Text = "label9";
            // 
            // lblTreatment
            // 
            lblTreatment.AutoSize = true;
            lblTreatment.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTreatment.Location = new Point(386, 163);
            lblTreatment.Name = "lblTreatment";
            lblTreatment.Size = new Size(41, 15);
            lblTreatment.TabIndex = 27;
            lblTreatment.Text = "label10";
            // 
            // lblCreatedDate
            // 
            lblCreatedDate.AutoSize = true;
            lblCreatedDate.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCreatedDate.Location = new Point(72, 447);
            lblCreatedDate.Name = "lblCreatedDate";
            lblCreatedDate.Size = new Size(41, 15);
            lblCreatedDate.TabIndex = 33;
            lblCreatedDate.Text = "label16";
            // 
            // textBox19
            // 
            textBox19.BackColor = SystemColors.Control;
            textBox19.BorderStyle = BorderStyle.None;
            textBox19.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox19.Location = new Point(409, 448);
            textBox19.Name = "textBox19";
            textBox19.Size = new Size(122, 14);
            textBox19.TabIndex = 34;
            textBox19.Text = "Họ tên và chữ ký bác sĩ";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAddress.Location = new Point(110, 195);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(41, 15);
            lblAddress.TabIndex = 36;
            lblAddress.Text = "label17";
            // 
            // textBox20
            // 
            textBox20.BackColor = SystemColors.Control;
            textBox20.BorderStyle = BorderStyle.None;
            textBox20.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox20.Location = new Point(12, 195);
            textBox20.Name = "textBox20";
            textBox20.Size = new Size(70, 14);
            textBox20.TabIndex = 35;
            textBox20.Text = "Địa chỉ:";
            // 
            // btnClose
            // 
            btnClose.Location = new Point(483, 602);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 37;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // dgvServices
            // 
            dgvServices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServices.Location = new Point(12, 340);
            dgvServices.Name = "dgvServices";
            dgvServices.Size = new Size(331, 102);
            dgvServices.TabIndex = 38;
            // 
            // BenhAn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(570, 627);
            Controls.Add(dgvServices);
            Controls.Add(btnClose);
            Controls.Add(lblAddress);
            Controls.Add(textBox20);
            Controls.Add(textBox19);
            Controls.Add(lblCreatedDate);
            Controls.Add(lblTreatment);
            Controls.Add(lblDiagnosis);
            Controls.Add(lblDoctor);
            Controls.Add(lblAppointmentDate);
            Controls.Add(lblDescription);
            Controls.Add(lblAbout);
            Controls.Add(lblEmail);
            Controls.Add(lblPhone);
            Controls.Add(lblGender);
            Controls.Add(lblPatientName);
            Controls.Add(textBox13);
            Controls.Add(textBox12);
            Controls.Add(textBox11);
            Controls.Add(textBox10);
            Controls.Add(textBox9);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(panelTitle_Bar);
            Name = "BenhAn";
            Text = "BenhAn";
            panelTitle_Bar.ResumeLayout(false);
            panelTitle_Bar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvServices).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelTitle_Bar;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox9;
        private TextBox textBox10;
        private TextBox textBox11;
        private TextBox textBox12;
        private TextBox textBox13;
        private Label lblPatientName;
        private Label lblGender;
        private Label lblPhone;
        private Label lblEmail;
        private Label lblAbout;
        private Label lblDescription;
        private Label lblAppointmentDate;
        private Label lblDoctor;
        private Label lblDiagnosis;
        private Label lblTreatment;
        private Label lblCreatedDate;
        private TextBox textBox19;
        private Label lblAddress;
        private TextBox textBox20;
        private Button btnClose;
        private DataGridView dgvServices;
    }
}