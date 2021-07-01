using System.Windows.Forms;
using System;

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
                    var consults = db.Consults.ToList();
                    foreach (var consult in consults)
                    {
                        if (citizen.Id != consult.IdCitizen)
                        {
                            MessageBox.Show("no se encuentra la cita programada del cliente");
                        }
                        else
                        {
                            Console.WriteLine(citizen);
                        }
                    }
                    
                    Hide();
                    var window = new AppointmentForm();
                    window.Show();
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