﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneralClinicManagement
{
    public partial class DashBoardControl : UserControl
    {
        public DashBoardControl()
        {
            InitializeComponent();
            LoadAboutUs();
        }

        private void LoadAboutUs()
        {
            pictureBox1.Image = Image.FromFile(@"C:\Users\USER\OneDrive\Hình ảnh\Saved Pictures\Clinic\picture4.jpg");
        }
    }
}
