using System;
using System.Windows.Forms;

namespace Project_POO
{
    public partial class AppointmentForm2 : Form
    {
        public AppointmentForm2()
        {
            InitializeComponent();
        }

        private void lblChange_Click(object sender, EventArgs e)
        {
            Hide();
            var ventana = new AppointmentForm();
            ventana.Show();
        }
    }
}