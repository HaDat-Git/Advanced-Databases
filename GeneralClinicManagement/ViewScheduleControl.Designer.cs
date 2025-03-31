namespace GeneralClinicManagement
{
    partial class ViewScheduleControl
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
            dgvSchedule = new DataGridView();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvSchedule).BeginInit();
            SuspendLayout();
            // 
            // dgvSchedule
            // 
            dgvSchedule.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSchedule.Location = new Point(26, 78);
            dgvSchedule.Name = "dgvSchedule";
            dgvSchedule.Size = new Size(701, 323);
            dgvSchedule.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ActiveCaption;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Dubai", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(305, 20);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(168, 36);
            textBox1.TabIndex = 1;
            textBox1.Text = "Working Schedule";
            // 
            // ViewScheduleControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(textBox1);
            Controls.Add(dgvSchedule);
            Name = "ViewScheduleControl";
            Size = new Size(768, 437);
            Load += this.panelDesktop_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSchedule).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvSchedule;
        private TextBox textBox1;
    }
}
