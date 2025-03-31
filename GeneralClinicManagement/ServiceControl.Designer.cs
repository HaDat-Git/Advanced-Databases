namespace GeneralClinicManagement
{
    partial class ServiceControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiceControl));
            textBox1 = new TextBox();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(255, 255, 128);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(234, 34);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(259, 26);
            textBox1.TabIndex = 0;
            textBox1.Text = "Some of our services!";
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox1.Location = new Point(42, 92);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(634, 309);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // ServiceControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 128);
            Controls.Add(richTextBox1);
            Controls.Add(textBox1);
            Name = "ServiceControl";
            Size = new Size(707, 474);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private RichTextBox richTextBox1;
    }
}
