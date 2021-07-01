using System;
using System.Collections.Generic;
using System.Linq;
using System.Timers;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Project_POO.ViewModel;

namespace Project_POO
{
    public partial class Step3Form : System.Windows.Forms.Form
    {
        private bool showFromDb = false;
        int tiempo = 0;
        public Step3Form()
        {
            InitializeComponent();
        }
        
        private void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            tiempo++;
            prbVacunando.Value++;
            
            if (prbVacunando.Value < 100)
                prbVacunando.Value++;
            if (prbVacunando.Value == 100)
                timer.Enabled = false;
        }
        private void btnDui_Click(object sender, EventArgs e)
        {
            timer.Enabled = true;
            prbVacunando.Value = 0;

        }

        private void button1_Click(object sender, EventArgs e)
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
                    Telefono = x.IdCitizenNavigation.Phone,
                    Direccion = x.IdCitizenNavigation.Adress,
                    //Email = x.IdCitizenNavigation.Email,
                    Cabina = x.IdCabinNavigation.Adress,
                    Fecha_cita = Convert.ToDateTime(x.ConsultationDay.ToString()).ToString("yyyy-MM-dd"),
                    Hora_cita = x.ConsultationTime,
                    //Hora_llegada = x.HourArrival,
                    //Hora_vacuna = x.HourVaccine
                })
                .ToList();
            
            dataGridView.DataSource = null;
            dataGridView.DataSource = listPatient; 
            
        }
    }
}