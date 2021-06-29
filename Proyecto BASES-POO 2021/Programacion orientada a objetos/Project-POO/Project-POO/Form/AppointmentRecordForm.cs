using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Project_POO.Context;
using Project_POO.Model;

namespace Project_POO.Form
{
    public partial class AppointmentRecordForm : System.Windows.Forms.Form
    {
        public AppointmentRecordForm()
        {
            InitializeComponent();
        }
        private void txtDate_TextChanged(object sender, EventArgs e)
        {
            var db = new VaccinationContext();
            //agregando fecha para cita de primera dosis
                var oneDate = new Random();
                DateTime date = new DateTime(2021,07,01);
                DateTime secondDate = new DateTime(2021,07,15);
                int range = (secondDate - date).Days;
                DateTime finalDate = date.AddDays(oneDate.Next(range));

                //agregando hora para cita de primera dosis
                var oneHour = new Random();
                DateTime hour = new DateTime(2021, 07, 01);
                DateTime secondHour = new DateTime(2021,07,01);
                int secondRange = (secondHour - hour).Hours;
                DateTime finalHour = hour.AddHours(oneHour.Next(secondRange));

                var cabins = db.Cabins.ToList();
                var citizens = db.Citizens.ToList();
                var save = 0;
                var cabinId = db.Cabins.Find().Id;
                foreach (var cabin in cabins)
                {
                    var idCabin = 0;
                    idCabin = cabinId;
                    if (cabin.Id != idCabin)
                    {
                        MessageBox.Show("no se encontró la cabina a programar");
                    }
                    else
                    {
                        save = cabin.Id;
                    }

                }

                var secondSave = 0;
                var citizenId = db.Citizens.Find().Id;
                foreach (var secondCitizen in citizens)
                {
                    var idCitizen = 0;
                    idCitizen = citizenId;
                    if (secondCitizen.Id != idCitizen)
                    {
                        MessageBox.Show("No se encontró el Id del ciudadano");
                    }
                    else
                    {
                        secondSave = secondCitizen.Id;
                    }
                }
                
                var consults = db.Consults.ToList();
                Consult consult = new Consult()
                {
                    ConsultationDay = Convert.ToString(finalDate),
                    ConsultationTime = Convert.ToString(finalHour),
                    IdCabin = save,
                    IdCitizen = secondSave
                };
                db.Add(consult);
                db.SaveChanges();
                Hide();
                var window = new AppointmentForm();
                window.Show();
                
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var places = new List<string>()
            {
              "Hospital El Salvador",
              "ISSS, San Salvador",
              "Hospital San Rafael",
              "Hospital Maternidad",
              "Hospital MQ"
            };
            comboBox1.DataSource = places;
        }
    }
}