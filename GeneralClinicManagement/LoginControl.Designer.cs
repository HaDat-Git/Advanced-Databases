namespace GeneralClinicManagement
{
    partial class LoginControl
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
            txtUserName = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            txtPassword = new TextBox();
            textBox4 = new TextBox();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(329, 200);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(159, 23);
            txtUserName.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.DarkOrange;
            textBox2.Location = new Point(207, 200);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 1;
            textBox2.Text = "User Name";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.DarkOrange;
            textBox1.Location = new Point(207, 240);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 3;
            textBox1.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(329, 240);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(159, 23);
            txtPassword.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.SpringGreen;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(267, 120);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(147, 26);
            textBox4.TabIndex = 4;
            textBox4.Text = "Login Page";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(428, 293);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(101, 28);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // LoginControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SpringGreen;
            Controls.Add(btnLogin);
            Controls.Add(textBox4);
            Controls.Add(textBox1);
            Controls.Add(txtPassword);
            Controls.Add(textBox2);
            Controls.Add(txtUserName);
            Name = "LoginControl";
            Size = new Size(664, 390);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUserName;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox txtPassword;
        private TextBox textBox4;
        private Button btnLogin;
    }
}
