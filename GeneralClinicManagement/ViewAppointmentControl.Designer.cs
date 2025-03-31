namespace GeneralClinicManagement
{
    partial class ViewAppointmentControl
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
            dgvAppointment = new DataGridView();
            textBox1 = new TextBox();
            txtTreatment = new TextBox();
            textBox4 = new TextBox();
            txtDiagnosis = new TextBox();
            textBox8 = new TextBox();
            txtPrice = new TextBox();
            textBox6 = new TextBox();
            textBox11 = new TextBox();
            textBox5 = new TextBox();
            cmbService1 = new ComboBox();
            cmbService2 = new ComboBox();
            txtPrescribedMedicine = new TextBox();
            textBox7 = new TextBox();
            btnSave = new Button();
            textBox2 = new TextBox();
            cmbStatus = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvAppointment).BeginInit();
            SuspendLayout();
            // 
            // dgvAppointment
            // 
            dgvAppointment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAppointment.Location = new Point(37, 190);
            dgvAppointment.Name = "dgvAppointment";
            dgvAppointment.Size = new Size(616, 220);
            dgvAppointment.TabIndex = 0;
            dgvAppointment.SelectionChanged += dgvAppointment_SelectionChanged;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ActiveCaption;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(206, 13);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(249, 26);
            textBox1.TabIndex = 2;
            textBox1.Text = "APPOINTMENT VIEW";
            // 
            // txtTreatment
            // 
            txtTreatment.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTreatment.Location = new Point(478, 102);
            txtTreatment.Name = "txtTreatment";
            txtTreatment.Size = new Size(175, 22);
            txtTreatment.TabIndex = 14;
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.ActiveCaption;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(379, 105);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(93, 15);
            textBox4.TabIndex = 13;
            textBox4.Text = "Treatment";
            // 
            // txtDiagnosis
            // 
            txtDiagnosis.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDiagnosis.Location = new Point(478, 53);
            txtDiagnosis.Name = "txtDiagnosis";
            txtDiagnosis.Size = new Size(175, 22);
            txtDiagnosis.TabIndex = 12;
            // 
            // textBox8
            // 
            textBox8.BackColor = SystemColors.ActiveCaption;
            textBox8.BorderStyle = BorderStyle.None;
            textBox8.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox8.Location = new Point(379, 56);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(93, 15);
            textBox8.TabIndex = 11;
            textBox8.Text = "Diagnosis";
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrice.Location = new Point(571, 149);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(82, 22);
            txtPrice.TabIndex = 18;
            // 
            // textBox6
            // 
            textBox6.BackColor = SystemColors.ActiveCaption;
            textBox6.BorderStyle = BorderStyle.None;
            textBox6.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox6.Location = new Point(510, 152);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(44, 15);
            textBox6.TabIndex = 17;
            textBox6.Text = "Price";
            // 
            // textBox11
            // 
            textBox11.BackColor = SystemColors.ActiveCaption;
            textBox11.BorderStyle = BorderStyle.None;
            textBox11.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox11.Location = new Point(37, 57);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(63, 15);
            textBox11.TabIndex = 15;
            textBox11.Text = "Service 1";
            // 
            // textBox5
            // 
            textBox5.BackColor = SystemColors.ActiveCaption;
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox5.Location = new Point(37, 102);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(63, 15);
            textBox5.TabIndex = 19;
            textBox5.Text = "Service 2";
            // 
            // cmbService1
            // 
            cmbService1.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbService1.FormattingEnabled = true;
            cmbService1.Location = new Point(126, 54);
            cmbService1.Name = "cmbService1";
            cmbService1.Size = new Size(174, 22);
            cmbService1.TabIndex = 20;
            // 
            // cmbService2
            // 
            cmbService2.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbService2.FormattingEnabled = true;
            cmbService2.Location = new Point(126, 99);
            cmbService2.Name = "cmbService2";
            cmbService2.Size = new Size(174, 22);
            cmbService2.TabIndex = 21;
            // 
            // txtPrescribedMedicine
            // 
            txtPrescribedMedicine.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrescribedMedicine.Location = new Point(175, 149);
            txtPrescribedMedicine.Name = "txtPrescribedMedicine";
            txtPrescribedMedicine.Size = new Size(125, 22);
            txtPrescribedMedicine.TabIndex = 23;
            // 
            // textBox7
            // 
            textBox7.BackColor = SystemColors.ActiveCaption;
            textBox7.BorderStyle = BorderStyle.None;
            textBox7.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox7.Location = new Point(36, 153);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(133, 15);
            textBox7.TabIndex = 22;
            textBox7.Text = "Prescribed Medicine";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(575, 433);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(78, 27);
            btnSave.TabIndex = 24;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.ActiveCaption;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(338, 154);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(63, 15);
            textBox2.TabIndex = 25;
            textBox2.Text = "Status";
            // 
            // cmbStatus
            // 
            cmbStatus.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(394, 150);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(78, 22);
            cmbStatus.TabIndex = 26;
            // 
            // ViewAppointmentControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(cmbStatus);
            Controls.Add(textBox2);
            Controls.Add(btnSave);
            Controls.Add(txtPrescribedMedicine);
            Controls.Add(textBox7);
            Controls.Add(cmbService2);
            Controls.Add(cmbService1);
            Controls.Add(textBox5);
            Controls.Add(txtPrice);
            Controls.Add(textBox6);
            Controls.Add(textBox11);
            Controls.Add(txtTreatment);
            Controls.Add(textBox4);
            Controls.Add(txtDiagnosis);
            Controls.Add(textBox8);
            Controls.Add(textBox1);
            Controls.Add(dgvAppointment);
            Name = "ViewAppointmentControl";
            Size = new Size(686, 463);
            Load += ViewAppointmentControl_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAppointment).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvAppointment;
        private TextBox textBox1;
        private TextBox txtTreatment;
        private TextBox textBox4;
        private TextBox txtDiagnosis;
        private TextBox textBox8;
        private TextBox txtPrice;
        private TextBox textBox6;
        private TextBox textBox11;
        private TextBox textBox5;
        private ComboBox cmbService1;
        private ComboBox cmbService2;
        private TextBox txtPrescribedMedicine;
        private TextBox textBox7;
        private Button btnSave;
        private TextBox textBox2;
        private ComboBox cmbStatus;
    }
}
