using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Project_POO.Context;
using Project_POO.Model;

namespace Project_POO
{
    public partial class AppointmentForm2 : Form
    {
        public AppointmentForm2()
        {
            InitializeComponent();
        }

        private void lblChange_Click(object sender, EventArgs e)
        {
            Hide();
            var ventana = new AppointmentForm();
            ventana.Show();
        }


        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            var db = new VaccinationContext();
            List<Citizen> citizenz = db.Citizens.ToList();
            Citizen citizen = new Citizen()
            {
                FullName = txtName.Text,
                Age = Convert.ToInt32(txtAge.Text),
                Dui = txtDUI.ToString(),
                Adress = txtAdress.Text,
                Phone = Convert.ToInt32(txtPhone.Text),
                Email = txtMail.Text,
                IdInstitution = ((Institution) cmbInstitution.SelectedItem).Id,
                // Sicknesses = txtSickness.Text, 
                
            };
            
            
            bool Validation = txtName.Text.Length < 4 || txtAge.Text.Length < 0 || txtDUI.Text.Length < 7 || txtAdress.Text.Length < 5;
            if (Validation )
            {
                MessageBox.Show("Digite correctamente los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                db.Add(citizen);
                db.SaveChanges();
                MessageBox.Show("Se registró el ciudadano", "Registro exi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                
            }
            
            
        }
    }
}