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
    public partial class Step1Form : Form
    {
        public Step1Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var validationdui = new VaccinationContext();
            bool validate = true;
            foreach (var citizen in validationdui.Citizens.ToList())
            {
                string verificationdui = textBox1.Text;
                if (verificationdui != citizen.Dui)
                    validate = false;
                else
                    validate = true;
            }

            bool validation = checkBox1.Checked == true && textBox1.Text.Length == 9;
            if (validation && validate)
            {
                Hide();
                var window = new Step2Form();
                window.Show();
            }
            else
                MessageBox.Show("Ha habido un error al acceder al proceso de vacunación. Por favor, verifique si ha digitado bien el DUI o si no se ha marcado la " + 
                                "confirmación de consentimiento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            var db = new VaccinationContext();
            foreach (var citizen in db.Citizens.ToList())
            {
                string dui = textBox1.Text;

                if (dui != citizen.Dui)
                    MessageBox.Show("El DUI ingresado es incorrecto o no existe","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                else
                {
                    textBox2.Text = citizen.FullName;
                    textBox3.Text = Convert.ToString(citizen.Age);
                    textBox4.Text = citizen.Adress;
                    textBox5.Text = Convert.ToString(citizen.Phone);
                    textBox6.Text = citizen.Email;
                    txtAdress.Text = Convert.ToString(citizen.Sicknesses);
                    comboBox1.SelectedItem = ((Institution) comboBox1.SelectedItem).Id;
                }
            }
        }

        private void lbl1_Click(object sender, EventArgs e)
        {
            Hide();
            var window = new AppointmentForm2();
            window.Show();
        }
    }
}