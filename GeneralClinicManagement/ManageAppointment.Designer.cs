namespace GeneralClinicManagement
{
    partial class ManageAppointment
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
            btnClose = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            txtPatientName = new TextBox();
            textBox5 = new TextBox();
            txtAbout = new TextBox();
            textBox7 = new TextBox();
            txtDescription = new TextBox();
            textBox9 = new TextBox();
            textBox11 = new TextBox();
            textBox13 = new TextBox();
            cmbStatus = new ComboBox();
            dtpAppointmentDate = new DateTimePicker();
            cmbDoctorName = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(31, 186);
            dataGridView.Name = "dataGridView";
            dataGridView.Size = new Size(1031, 279);
            dataGridView.TabIndex = 0;
            dataGridView.CellClick += dataGridView_CellClick;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(987, 481);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 27);
            btnClose.TabIndex = 1;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(894, 481);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 27);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(802, 481);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 27);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ActiveCaption;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = SystemColors.WindowText;
            textBox1.Location = new Point(31, 69);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(90, 15);
            textBox1.TabIndex = 4;
            textBox1.Text = "Patient Name";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(383, 12);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(360, 31);
            textBox2.TabIndex = 5;
            textBox2.Text = "Management Appointment Page";
            // 
            // txtPatientName
            // 
            txtPatientName.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPatientName.Location = new Point(127, 66);
            txtPatientName.Name = "txtPatientName";
            txtPatientName.Size = new Size(159, 22);
            txtPatientName.TabIndex = 6;
            // 
            // textBox5
            // 
            textBox5.BackColor = SystemColors.ActiveCaption;
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox5.ForeColor = SystemColors.WindowText;
            textBox5.Location = new Point(31, 113);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(90, 15);
            textBox5.TabIndex = 7;
            textBox5.Text = "Doctor Name";
            // 
            // txtAbout
            // 
            txtAbout.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAbout.Location = new Point(432, 66);
            txtAbout.Name = "txtAbout";
            txtAbout.Size = new Size(152, 22);
            txtAbout.TabIndex = 10;
            // 
            // textBox7
            // 
            textBox7.BackColor = SystemColors.ActiveCaption;
            textBox7.BorderStyle = BorderStyle.None;
            textBox7.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox7.ForeColor = SystemColors.WindowText;
            textBox7.Location = new Point(336, 72);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(46, 15);
            textBox7.TabIndex = 9;
            textBox7.Text = "About";
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescription.Location = new Point(432, 110);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(152, 22);
            txtDescription.TabIndex = 12;
            // 
            // textBox9
            // 
            textBox9.BackColor = SystemColors.ActiveCaption;
            textBox9.BorderStyle = BorderStyle.None;
            textBox9.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox9.ForeColor = SystemColors.WindowText;
            textBox9.Location = new Point(336, 116);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(76, 15);
            textBox9.TabIndex = 11;
            textBox9.Text = "Description";
            // 
            // textBox11
            // 
            textBox11.BackColor = SystemColors.ActiveCaption;
            textBox11.BorderStyle = BorderStyle.None;
            textBox11.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox11.ForeColor = SystemColors.WindowText;
            textBox11.Location = new Point(643, 71);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(122, 15);
            textBox11.TabIndex = 13;
            textBox11.Text = "Appointment Date";
            // 
            // textBox13
            // 
            textBox13.BackColor = SystemColors.ActiveCaption;
            textBox13.BorderStyle = BorderStyle.None;
            textBox13.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox13.ForeColor = SystemColors.WindowText;
            textBox13.Location = new Point(643, 112);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(48, 15);
            textBox13.TabIndex = 15;
            textBox13.Text = "Status";
            // 
            // cmbStatus
            // 
            cmbStatus.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(782, 109);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(153, 22);
            cmbStatus.TabIndex = 16;
            // 
            // dtpAppointmentDate
            // 
            dtpAppointmentDate.CalendarFont = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpAppointmentDate.Location = new Point(782, 65);
            dtpAppointmentDate.Name = "dtpAppointmentDate";
            dtpAppointmentDate.Size = new Size(196, 23);
            dtpAppointmentDate.TabIndex = 17;
            // 
            // cmbDoctorName
            // 
            cmbDoctorName.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbDoctorName.FormattingEnabled = true;
            cmbDoctorName.Location = new Point(127, 110);
            cmbDoctorName.Name = "cmbDoctorName";
            cmbDoctorName.Size = new Size(159, 22);
            cmbDoctorName.TabIndex = 18;
            // 
            // ManageAppointment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1088, 520);
            Controls.Add(cmbDoctorName);
            Controls.Add(dtpAppointmentDate);
            Controls.Add(cmbStatus);
            Controls.Add(textBox13);
            Controls.Add(textBox11);
            Controls.Add(txtDescription);
            Controls.Add(textBox9);
            Controls.Add(txtAbout);
            Controls.Add(textBox7);
            Controls.Add(textBox5);
            Controls.Add(txtPatientName);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnClose);
            Controls.Add(dataGridView);
            Name = "ManageAppointment";
            Text = "ManageAppointment";
            Load += ManageAppointment_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView;
        private Button btnClose;
        private Button btnUpdate;
        private Button btnDelete;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox txtPatientName;
        private TextBox textBox5;
        private TextBox txtAbout;
        private TextBox textBox7;
        private TextBox txtDescription;
        private TextBox textBox9;
        private TextBox textBox11;
        private TextBox textBox13;
        private ComboBox cmbStatus;
        private DateTimePicker dtpAppointmentDate;
        private ComboBox cmbDoctorName;
    }
}