using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            string save = null;
            int id_cabin = 0;
            int id_cabin2 = 0;
            string secondSave = null;
            var cabins = db.Cabins.ToList();

            if (txtCabin.Text.Length != 0)
            {
                var idCabin = cabins.Where(cabin => cabin.Id.Equals(Convert.ToInt32(txtCabin.Text))).ToList();
                id_cabin = idCabin.First().Id;
            }
            else
            {
                MessageBox.Show("Número de cabina inexsistente", "ingrese un número de cabina existente",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            var citizens = db.Citizens.ToList();

            if (txtIdCitizen.Text.Length != 0)
            {
                var idCitizen = citizens.Where(citizen => citizen.Id.Equals(Convert.ToInt32(txtIdCitizen.Text))).ToList();
                id_cabin2 = idCitizen.First().Id;
            }
            else
            {
                MessageBox.Show("Error, id de ciudadano inexsistente", "Ingrese un id válido",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Consult consult = new Consult()
            {
                ConsultationDay = date,
                ConsultationTime = hour,
                IdCabin = id_cabin,
                IdCitizen = id_cabin2
            };
            Debug.WriteLine(consult.Id);
            var consults = db.Consults.ToHashSet();
            db.Consults.Add(consult);
            db.SaveChanges();

            Debug.WriteLine("paso1");
        var processes = db.VaccinationProcesses.ToHashSet();
            var Process = new VaccinationProcess()
            {
                VaccunationDay = date,
                VaccunationTime = hour,
                VaccunationPlace = (string) (cmbVaccination.SelectedItem),
                SecondVaccinationDay = "Pendiente",
                SecondVaccinationTime = "Pendiente"
            };
            db.VaccinationProcesses.Add(Process);
            Debug.WriteLine("paso2");
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