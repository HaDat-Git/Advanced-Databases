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
    public partial class UpdateInforControl : UserControl
    {
        public UpdateInforControl()
        {
            InitializeComponent();
        }

        private void btnManageAppointment_Click(object sender, EventArgs e)
        {
            ManageAppointment manageAppointment = new ManageAppointment();
            manageAppointment.Show();
        }

        private void btnManageDoctor_Click(object sender, EventArgs e)
        {
            ManageDoctor manageDoctor = new ManageDoctor();
            manageDoctor.Show();
        }

        private void UpdateInforControl_Load(object sender, EventArgs e)
        {

        }

        private void btnManageDoctorTime_Click(object sender, EventArgs e)
        {
            ManageDoctorTime manageDoctorTime = new ManageDoctorTime();
            manageDoctorTime.Show();
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            AddService addService = new AddService();
            addService.Show();
        }
    }
}
