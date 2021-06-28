using System.Windows.Forms;
using System;
using System.Data.Common;
using Microsoft.EntityFrameworkCore;
using Project_POO.Context;
using Project_POO.Model;
using Project_POO.Context;
using System.Linq;

namespace Project_POO
{
    public partial class ProgrammingAppointmentForm : System.Windows.Forms.Form
    {
        public ProgrammingAppointmentForm()
        {
            InitializeComponent();
        }

        private void btnVerification_Click(object sender, EventArgs e)
        {
            var db = new VaccinationContext();

            foreach (var citizen in db.Citizens.ToList())
            {
                string dui = txtVerification.Text;

                if (dui != citizen.Dui)
                {
                    MessageBox.Show("información incorrecta o inválida","favor intentar de nuevo", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Hide();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide();
            var window = new AppointmentForm();
            window.Show();
        }
    }
}