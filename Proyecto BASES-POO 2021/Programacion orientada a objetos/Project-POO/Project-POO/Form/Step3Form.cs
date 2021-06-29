using System;
using System.Collections.Generic;
using System.Linq;
using System.Timers;
using System.Windows.Forms;
using Project_POO.Context;
using Project_POO.Model;
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
            var listaCitizen = db.Citizens
                .OrderBy(c => c.Id)
                .ToList();
            //Busco el dui 
            var result = listaCitizen.Where(
                u => u.Dui.Equals(txtDui.Text)
                ).ToList();

            if (result.Count == 0)
            {
                MessageBox.Show("No se encontró ningun ciudadano registrado con el dui digitado", "Búsqueda",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (!showFromDb)
                {
                    var citizen = db.Citizens.ToList();
                    var mappedDS = new List<CitizenVM>();
                    foreach (var item in citizen.Where(i => i.Dui == txtDui.Text))
                    {
                        mappedDS.Add(VaccinationMapper.MapCitizenVm(item));
                    }
                    dataGridView.DataSource = mappedDS;
                }
            }
        }
    }
}