namespace GeneralClinicManagement
{
    partial class AboutUsControl
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox4 = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(163, 18);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(347, 27);
            textBox1.TabIndex = 0;
            textBox1.Text = "Giới thiệu về Phòng khám của chúng tôi";
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.ActiveCaption;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(74, 97);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(363, 15);
            textBox2.TabIndex = 1;
            textBox2.Text = "Phòng khám đa khoa ABC được thành lập từ năm 2010";
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.ActiveCaption;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(74, 118);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(488, 15);
            textBox4.TabIndex = 3;
            textBox4.Text = "Cung cấp dịch vụ y tế chất lượng cao với đội ngũ bác sĩ giàu kinh nghiệm...\"";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(86, 181);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(234, 125);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(392, 149);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(187, 99);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(363, 272);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(246, 96);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // AboutUsControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(textBox4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "AboutUsControl";
            Size = new Size(655, 423);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}
