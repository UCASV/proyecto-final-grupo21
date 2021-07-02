using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace Project_POO.Form
{
    public partial class Step1Form : System.Windows.Forms.Form
    {
        public Step1Form()
        {
            InitializeComponent();
        }
        
        private void btnVerifyDui_Click(object sender, EventArgs e)
        {
            var db = new VaccinationContext();
            
            var listPatient = db.Consults
                .Include(i => i.IdCitizenNavigation)
                .Include(i=> i.IdCabinNavigation)
                .Where(i=> i.IdCitizenNavigation.Dui.Equals(txtDui.Text))
                .Select(x => new
                {
                    //Numero_de_cita = x.Id,
                    Nombre = x.IdCitizenNavigation.FullName,
                    DUI = x.IdCitizenNavigation.Dui,
                    AGE = x.IdCitizenNavigation.Age,
                    Telefono = x.IdCitizenNavigation.Phone,
                    Adress = x.IdCitizenNavigation.Adress,
                    Email = x.IdCitizenNavigation.Email,
                    Fecha_cita = Convert.ToDateTime(x.ConsultationDay.ToString()).ToString("yyyy-MM-dd"),
                    Hora_cita = x.ConsultationTime,
                    //Hora_llegada = x.HourArrival,
                    //Hora_vacuna = x.HourVaccine
                })
                .ToList();
        
            dgvPreChequeo.DataSource = null;
            dgvPreChequeo.DataSource = listPatient;
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            Hide();
            var window = new Step2Form();
            window.Show();
            /*{
                var validationdui = new VaccinationContext();
                bool validate = true;
                foreach (var citizen in validationdui.Citizens.ToList())
                {
                    string verificationdui = txtDui.Text;
                    if (verificationdui != citizen.Dui)
                        validate = false;
                    else
                        validate = true;
                }

                bool validation = checkBox1.Checked == true && txtDui.Text.Length == 9;
                if (validation && validate)
                {
                    Hide();
                    var window = new Step2Form();
                    window.Show();
                }
                else
                    MessageBox.Show(
                        "Ha habido un error al acceder al proceso de vacunación. Por favor, verifique si ha digitado bien el DUI o si no se ha marcado la " +
                        "confirmación de consentimiento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }

        private void lbl1_Click_1(object sender, EventArgs e)
        {
            Hide();
            var window = new AppointmentForm2();
            window.Show();
        }
    }
}