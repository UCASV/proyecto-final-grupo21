using System;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Project_POO
{
    public partial class FouthVaccinationStep : System.Windows.Forms.Form
    {
        public FouthVaccinationStep()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            
            var db = new VaccinationContext();
            var seccondaryEffects = db.SecondaryEffects.ToList();
            var newEffects = new SecondaryEffect()
            {
                SeccondaryEffects = txtSeccondaryEffects.Text
            };
            seccondaryEffects.Add(newEffects);
            
            int idConsult = Convert.ToInt32(txtIdCita.Text);
            var processes = db.VaccinationProcesses.ToList();
            var process = processes.Where(p => p.Id.Equals(idConsult));
            
            foreach (var p in process)
            {
                p.SecondVaccinationDay = txtDate.Text;
                p.SecondVaccinationTime = txtHour.Text;
                p.SecondaryEffects = seccondaryEffects;
            }
            
        }
    }
}