using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


namespace Project_POO.Form
{
    public partial class AppointmentRecordForm : System.Windows.Forms.Form
    {
        public AppointmentRecordForm()
        {
            InitializeComponent();
        }
 
        private void AppointmentRecordForm_Load_1(object sender, EventArgs e)
        {
            var places = new List<string>()
            {
                "Hospital El Salvador",
                "ISSS, San Salvador",
                "Hospital San Rafael",
                "Hospital Maternidad",
                "Hospital MQ"
            };
            cmbVaccination.DataSource = places;
        }      


        
        private void btnRegister_Click_1(object sender, EventArgs e)
        {
            var db = new VaccinationContext();

            string date = txtDate.Text;
            string hour = txtHour.Text;
            string save = "";
            string secondSave = "";
            var cabins = db.Cabins.ToList();

            if (txtCabin.Text.Length != 0)
            {
                var idCabin = cabins.Where(cabin => cabin.Id.Equals(txtCabin.Text)).ToList();

                foreach (var cabin in idCabin)
                {
                    save = Convert.ToString(cabin.Id);
                }

            }
            else
            {
                MessageBox.Show("Número de cabina inexsistente", "ingrese un número de cabina existente",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            var citizens = db.Citizens.ToList();

            if (txtIdCitizen.Text.Length != 0)
            {
                var idCitizen = citizens.Where(citizen => citizen.Id.Equals(txtIdCitizen.Text)).ToList();
                foreach (var citizen in idCitizen)
                {
                    secondSave = Convert.ToString(citizen.Id);
                }
            }
            else
            {
                MessageBox.Show("Error, id de ciudadano inexsistente", "Ingrese un id válido",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            var consults = db.Consults.ToHashSet();
            Consult consult = new Consult()
            {
                ConsultationDay = date,
                ConsultationTime = hour,
                IdCabin = Convert.ToInt32(save),
                IdCitizen = Convert.ToInt32(secondSave)
            };
            consults.Add(consult);

        var processes = db.VaccinationProcesses.ToHashSet();
            var Process = new VaccinationProcess()
            {
                VaccunationDay = date,
                VaccunationTime = hour,
                VaccunationPlace = (string) (cmbVaccination.SelectedItem)
            };
            processes.Add(Process);

            int consultId = 0;

            foreach (var c in consults)
            {
                if (c.ConsultationDay != Process.VaccunationDay)
                {
                    MessageBox.Show("Cita equivocada", "verifique la cita registrada", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                {
                    consultId = c.Id;
                }
            }
            Process.IdConsult = consultId;
            
            db.SaveChanges();
            Hide();
            var window = new AppointmentForm();
            window.Show();

        }

    }
}