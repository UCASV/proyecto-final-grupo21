using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Data.Common;
using Microsoft.EntityFrameworkCore;
using Project_POO.Context;
using Project_POO.Model;
using Project_POO.Context;
using System.Linq;

namespace Project_POO
{
    public partial class Step2Form : System.Windows.Forms.Form
    {
        public Step2Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox2.Text == "")
                MessageBox.Show("No se han registrado la fecha y hora de la primera dosis", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                var db = new VaccinationContext();
                List<VaccinationProcess> processes = db.VaccinationProcesses.ToList();
                VaccinationProcess process = new VaccinationProcess();
                {
                    process.VaccunationDay = textBox1.Text;
                    process.VaccunationTime = textBox2.Text;
                };
                processes.Add(process);
                db.SaveChanges();
                MessageBox.Show("Se registró la fecha y el dia exitosamente", "Registro exitoso", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                Hide();
            }
        }
    }
}