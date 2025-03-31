namespace GeneralClinicManagement
{
    partial class UpdateInforControl
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
            btnManageDoctor = new Button();
            btnManageAppointment = new Button();
            textBox1 = new TextBox();
            btnManageDoctorTime = new Button();
            btnAddService = new Button();
            SuspendLayout();
            // 
            // btnManageDoctor
            // 
            btnManageDoctor.Location = new Point(125, 293);
            btnManageDoctor.Name = "btnManageDoctor";
            btnManageDoctor.Size = new Size(190, 35);
            btnManageDoctor.TabIndex = 0;
            btnManageDoctor.Text = "Manage Appointment";
            btnManageDoctor.UseVisualStyleBackColor = true;
            btnManageDoctor.Click += btnManageDoctor_Click;
            // 
            // btnManageAppointment
            // 
            btnManageAppointment.Location = new Point(125, 199);
            btnManageAppointment.Name = "btnManageAppointment";
            btnManageAppointment.Size = new Size(190, 35);
            btnManageAppointment.TabIndex = 1;
            btnManageAppointment.Text = "Manage Appointmet";
            btnManageAppointment.UseVisualStyleBackColor = true;
            btnManageAppointment.Click += btnManageAppointment_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ActiveCaption;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Imprint MT Shadow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(125, 69);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(437, 25);
            textBox1.TabIndex = 2;
            textBox1.Text = "MANAGE ACCOUNT & INFORMATION";
            // 
            // btnManageDoctorTime
            // 
            btnManageDoctorTime.Location = new Point(407, 199);
            btnManageDoctorTime.Name = "btnManageDoctorTime";
            btnManageDoctorTime.Size = new Size(190, 35);
            btnManageDoctorTime.TabIndex = 3;
            btnManageDoctorTime.Text = "Manage Doctor Working Time";
            btnManageDoctorTime.UseVisualStyleBackColor = true;
            btnManageDoctorTime.Click += btnManageDoctorTime_Click;
            // 
            // btnAddService
            // 
            btnAddService.Location = new Point(407, 293);
            btnAddService.Name = "btnAddService";
            btnAddService.Size = new Size(190, 35);
            btnAddService.TabIndex = 4;
            btnAddService.Text = "Add Service";
            btnAddService.UseVisualStyleBackColor = true;
            btnAddService.Click += btnAddService_Click;
            // 
            // UpdateInforControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(btnAddService);
            Controls.Add(btnManageDoctorTime);
            Controls.Add(textBox1);
            Controls.Add(btnManageAppointment);
            Controls.Add(btnManageDoctor);
            Name = "UpdateInforControl";
            Size = new Size(689, 392);
            Load += UpdateInforControl_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnManageDoctor;
        private Button btnManageAppointment;
        private TextBox textBox1;
        private Button btnManageDoctorTime;
        private Button btnAddService;
    }
}
