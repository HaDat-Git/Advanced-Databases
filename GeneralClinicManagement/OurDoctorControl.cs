using System;
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
    public partial class OurDoctorControl : UserControl
    {
        public OurDoctorControl()
        {
            InitializeComponent();
            LoadAboutUs();
        }

        private void LoadAboutUs()
        {
            pictureBox1.Image = Image.FromFile(@"C:\Users\USER\OneDrive\Hình ảnh\Saved Pictures\Clinic\doctor1.png");
            pictureBox1.Tag = 1;
            pictureBox2.Image = Image.FromFile(@"C:\Users\USER\OneDrive\Hình ảnh\Saved Pictures\Clinic\doctor2.png");
            pictureBox2.Tag = 2;
            pictureBox3.Image = Image.FromFile(@"C:\Users\USER\OneDrive\Hình ảnh\Saved Pictures\Clinic\doctor3.png");
            pictureBox3.Tag = 3;
            pictureBox4.Image = Image.FromFile(@"C:\Users\USER\OneDrive\Hình ảnh\Saved Pictures\Clinic\doctor4.png");
            pictureBox4.Tag = 4;
            pictureBox5.Image = Image.FromFile(@"C:\Users\USER\OneDrive\Hình ảnh\Saved Pictures\Clinic\doctor5.png");
            pictureBox5.Tag = 5;
            pictureBox6.Image = Image.FromFile(@"C:\Users\USER\OneDrive\Hình ảnh\Saved Pictures\Clinic\doctor6.png");
            pictureBox6.Tag = 6;
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox? pic = sender as PictureBox;
            if (pic != null)
            {
                if (pic.Tag == null)
                {
                    MessageBox.Show("Tag của PictureBox chưa được gán!");
                    return;
                }

                int doctorId;
                if (!int.TryParse(pic.Tag.ToString(), out doctorId))
                {
                    MessageBox.Show("Tag không phải là số hợp lệ!");
                    return;
                }

                DoctorDetail doctorDetailForm = new DoctorDetail(doctorId);
                doctorDetailForm.ShowDialog();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            PictureBox? pic = sender as PictureBox;
            if (pic != null)
            {
                if (pic.Tag == null)
                {
                    MessageBox.Show("Tag của PictureBox chưa được gán!");
                    return;
                }

                int doctorId;
                if (!int.TryParse(pic.Tag.ToString(), out doctorId))
                {
                    MessageBox.Show("Tag không phải là số hợp lệ!");
                    return;
                }

                DoctorDetail doctorDetailForm = new DoctorDetail(doctorId);
                doctorDetailForm.ShowDialog();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            PictureBox? pic = sender as PictureBox;
            if (pic != null)
            {
                if (pic.Tag == null)
                {
                    MessageBox.Show("Tag của PictureBox chưa được gán!");
                    return;
                }

                int doctorId;
                if (!int.TryParse(pic.Tag.ToString(), out doctorId))
                {
                    MessageBox.Show("Tag không phải là số hợp lệ!");
                    return;
                }

                DoctorDetail doctorDetailForm = new DoctorDetail(doctorId);
                doctorDetailForm.ShowDialog();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            PictureBox? pic = sender as PictureBox;
            if (pic != null)
            {
                if (pic.Tag == null)
                {
                    MessageBox.Show("Tag của PictureBox chưa được gán!");
                    return;
                }

                int doctorId;
                if (!int.TryParse(pic.Tag.ToString(), out doctorId))
                {
                    MessageBox.Show("Tag không phải là số hợp lệ!");
                    return;
                }

                DoctorDetail doctorDetailForm = new DoctorDetail(doctorId);
                doctorDetailForm.ShowDialog();
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            PictureBox? pic = sender as PictureBox;
            if (pic != null)
            {
                if (pic.Tag == null)
                {
                    MessageBox.Show("Tag của PictureBox chưa được gán!");
                    return;
                }

                int doctorId;
                if (!int.TryParse(pic.Tag.ToString(), out doctorId))
                {
                    MessageBox.Show("Tag không phải là số hợp lệ!");
                    return;
                }

                DoctorDetail doctorDetailForm = new DoctorDetail(doctorId);
                doctorDetailForm.ShowDialog();
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            PictureBox? pic = sender as PictureBox;
            if (pic != null)
            {
                if (pic.Tag == null)
                {
                    MessageBox.Show("Tag của PictureBox chưa được gán!");
                    return;
                }

                int doctorId;
                if (!int.TryParse(pic.Tag.ToString(), out doctorId))
                {
                    MessageBox.Show("Tag không phải là số hợp lệ!");
                    return;
                }

                DoctorDetail doctorDetailForm = new DoctorDetail(doctorId);
                doctorDetailForm.ShowDialog();
            }
        }
    }

}
