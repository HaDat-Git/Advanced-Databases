namespace GeneralClinicManagement
{
    partial class ReturnResultControl
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
            dgvReturnResult = new DataGridView();
            btnPreView = new Button();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvReturnResult).BeginInit();
            SuspendLayout();
            // 
            // dgvReturnResult
            // 
            dgvReturnResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReturnResult.Location = new Point(46, 91);
            dgvReturnResult.Name = "dgvReturnResult";
            dgvReturnResult.Size = new Size(592, 260);
            dgvReturnResult.TabIndex = 0;
            // 
            // btnPreView
            // 
            btnPreView.Location = new Point(563, 373);
            btnPreView.Name = "btnPreView";
            btnPreView.Size = new Size(75, 23);
            btnPreView.TabIndex = 1;
            btnPreView.Text = "PreView";
            btnPreView.UseVisualStyleBackColor = true;
            btnPreView.Click += btnPreView_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Control;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(184, 36);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(310, 26);
            textBox1.TabIndex = 2;
            textBox1.Text = "LIST OF MEDICAL RESULT";
            // 
            // ReturnResultControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(textBox1);
            Controls.Add(btnPreView);
            Controls.Add(dgvReturnResult);
            Name = "ReturnResultControl";
            Size = new Size(692, 412);
            ((System.ComponentModel.ISupportInitialize)dgvReturnResult).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvReturnResult;
        private Button btnPreView;
        private TextBox textBox1;
    }
}
