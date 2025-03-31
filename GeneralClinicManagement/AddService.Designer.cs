namespace GeneralClinicManagement
{
    partial class AddService
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
            dgvService = new DataGridView();
            btnAdd = new Button();
            btnDelete = new Button();
            btnClose = new Button();
            textBox2 = new TextBox();
            txtServiceName = new TextBox();
            txtPrice = new TextBox();
            Price = new TextBox();
            btnUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvService).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ActiveCaption;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(40, 23);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(210, 26);
            textBox1.TabIndex = 0;
            textBox1.Text = "Add Service Page";
            // 
            // dgvService
            // 
            dgvService.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvService.Location = new Point(40, 155);
            dgvService.Name = "dgvService";
            dgvService.Size = new Size(240, 150);
            dgvService.TabIndex = 1;
            dgvService.CellClick += dgvService_CellClick;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(3, 326);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(165, 326);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(246, 326);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 4;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.ActiveCaption;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(40, 72);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 15);
            textBox2.TabIndex = 5;
            textBox2.Text = "Service Name";
            // 
            // txtServiceName
            // 
            txtServiceName.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtServiceName.Location = new Point(150, 69);
            txtServiceName.Name = "txtServiceName";
            txtServiceName.Size = new Size(130, 22);
            txtServiceName.TabIndex = 6;
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrice.Location = new Point(150, 110);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(130, 22);
            txtPrice.TabIndex = 8;
            // 
            // Price
            // 
            Price.BackColor = SystemColors.ActiveCaption;
            Price.BorderStyle = BorderStyle.None;
            Price.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Price.Location = new Point(40, 113);
            Price.Name = "Price";
            Price.Size = new Size(100, 15);
            Price.TabIndex = 7;
            Price.Text = "Price";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(84, 326);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // AddService
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(323, 369);
            Controls.Add(btnUpdate);
            Controls.Add(txtPrice);
            Controls.Add(Price);
            Controls.Add(txtServiceName);
            Controls.Add(textBox2);
            Controls.Add(btnClose);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(dgvService);
            Controls.Add(textBox1);
            Name = "AddService";
            Text = "AddService";
            ((System.ComponentModel.ISupportInitialize)dgvService).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private DataGridView dgvService;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnClose;
        private TextBox textBox2;
        private TextBox txtServiceName;
        private TextBox txtPrice;
        private TextBox Price;
        private Button btnUpdate;
    }
}