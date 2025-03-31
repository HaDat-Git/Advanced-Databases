namespace GeneralClinicManagement
{
    partial class ManageDoctorTime
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
            textBox1 = new TextBox();
            cmbDoctorName = new ComboBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            cmbWorkDate = new ComboBox();
            txtStartTime = new TextBox();
            txtEndTime = new TextBox();
            dgvSchedule = new DataGridView();
            textBox5 = new TextBox();
            btnClose = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSchedule).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ActiveCaption;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(82, 87);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(84, 16);
            textBox1.TabIndex = 0;
            textBox1.Text = "Doctor Name";
            // 
            // cmbDoctorName
            // 
            cmbDoctorName.FormattingEnabled = true;
            cmbDoctorName.Location = new Point(183, 84);
            cmbDoctorName.Name = "cmbDoctorName";
            cmbDoctorName.Size = new Size(228, 23);
            cmbDoctorName.TabIndex = 1;
            cmbDoctorName.SelectedIndexChanged += cmbDoctorName_SelectIndexChange;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.ActiveCaption;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Location = new Point(82, 144);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(65, 16);
            textBox2.TabIndex = 2;
            textBox2.Text = "Work Date";
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.ActiveCaption;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Location = new Point(549, 144);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(58, 16);
            textBox3.TabIndex = 3;
            textBox3.Text = "End Time";
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.ActiveCaption;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Location = new Point(549, 83);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(58, 16);
            textBox4.TabIndex = 4;
            textBox4.Text = "Start Time";
            // 
            // cmbWorkDate
            // 
            cmbWorkDate.FormattingEnabled = true;
            cmbWorkDate.Location = new Point(183, 141);
            cmbWorkDate.Name = "cmbWorkDate";
            cmbWorkDate.Size = new Size(228, 23);
            cmbWorkDate.TabIndex = 5;
            // 
            // txtStartTime
            // 
            txtStartTime.Location = new Point(664, 80);
            txtStartTime.Name = "txtStartTime";
            txtStartTime.Size = new Size(219, 23);
            txtStartTime.TabIndex = 6;
            // 
            // txtEndTime
            // 
            txtEndTime.Location = new Point(664, 144);
            txtEndTime.Name = "txtEndTime";
            txtEndTime.Size = new Size(219, 23);
            txtEndTime.TabIndex = 7;
            // 
            // dgvSchedule
            // 
            dgvSchedule.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSchedule.Location = new Point(38, 182);
            dgvSchedule.Name = "dgvSchedule";
            dgvSchedule.Size = new Size(908, 209);
            dgvSchedule.TabIndex = 8;
            dgvSchedule.CellClick += dgvSchedule_CellClick;
            // 
            // textBox5
            // 
            textBox5.BackColor = SystemColors.ActiveCaption;
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Font = new Font("Lucida Bright", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox5.Location = new Point(298, 21);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(393, 25);
            textBox5.TabIndex = 9;
            textBox5.Text = "MANAGE DOCTOR WORKING TIME";
            // 
            // btnClose
            // 
            btnClose.Location = new Point(882, 406);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 10;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click_1;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(720, 406);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(801, 406);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(639, 406);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // ManageDoctorTime
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(986, 450);
            Controls.Add(btnAdd);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnClose);
            Controls.Add(textBox5);
            Controls.Add(dgvSchedule);
            Controls.Add(txtEndTime);
            Controls.Add(txtStartTime);
            Controls.Add(cmbWorkDate);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(cmbDoctorName);
            Controls.Add(textBox1);
            Name = "ManageDoctorTime";
            Text = "ManageDoctorTime";
            Load += ManageDoctorTime_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSchedule).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private ComboBox cmbDoctorName;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private ComboBox cmbWorkDate;
        private TextBox txtStartTime;
        private TextBox txtEndTime;
        private DataGridView dgvSchedule;
        private TextBox textBox5;
        private Button btnClose;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnAdd;
    }
}