using System;
using System.Collections.Generic;
using System.ComponentModel;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneralClinicManagement
{
    public partial class AddService : Form
    {
        private string connectionString = @"Server=LAPTOP-RA8AK0H5;Database=general_clinic_manage;Trusted_Connection=True;TrustServerCertificate=True;";
        private SqlConnection conn;
        public AddService()
        {
            InitializeComponent();
            LoadServices();
        }

        private void LoadServices()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM MedicalServices";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvService.DataSource = dt;

                dgvService.Columns["ServiceID"].Visible = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtServiceName.Text) || string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO MedicalServices (ServiceName, Price) VALUES (@name, @price)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", txtServiceName.Text);
                    cmd.Parameters.AddWithValue("@price", decimal.Parse(txtPrice.Text));
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            LoadServices();  // Cập nhật lại danh sách
            txtServiceName.Clear();
            txtPrice.Clear();
            MessageBox.Show("Thêm dịch vụ thành công!");
        }

        private void dgvService_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvService.Rows[e.RowIndex];
                txtServiceName.Text = row.Cells["ServiceName"].Value.ToString();
                txtPrice.Text = row.Cells["Price"].Value.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvService.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một dịch vụ để xóa!");
                return;
            }

            int selectedServiceID = Convert.ToInt32(dgvService.SelectedRows[0].Cells["ServiceID"].Value);

            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa dịch vụ này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM MedicalServices WHERE ServiceID = @id";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", selectedServiceID);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
                LoadServices();
                txtServiceName.Clear();
                txtPrice.Clear();
                MessageBox.Show("Xóa dịch vụ thành công!");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvService.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một dịch vụ để cập nhật!");
                return;
            }

            int selectedServiceID = Convert.ToInt32(dgvService.SelectedRows[0].Cells["ServiceID"].Value);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE MedicalServices SET ServiceName = @name, Price = @price WHERE ServiceID = @id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", selectedServiceID);
                    cmd.Parameters.AddWithValue("@name", txtServiceName.Text);
                    cmd.Parameters.AddWithValue("@price", decimal.Parse(txtPrice.Text));
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            LoadServices();
            MessageBox.Show("Cập nhật dịch vụ thành công!");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
