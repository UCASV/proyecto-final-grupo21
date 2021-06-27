using System;
using System.Windows.Forms;

namespace Project_POO
{
    public partial class AppointmentForm : Form
    {
        public AppointmentForm()
        {
            InitializeComponent();
        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            Hide();
            var window = new AppointmentForm2();
            window.Show();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            Hide();
            var window = new ProgrammingAppointmentForm();
            window.Show();
        }
    }
}