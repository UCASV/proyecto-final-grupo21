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
            var window = new AppointmentForm();
            window.Show();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            var db = new VaccinationContext();
            List<Citizen> citizens = db.Citizens.ToList();
            Citizen citizen = new Citizen()
            {
                FullName = txtName.Text,
                Age = Convert.ToInt32(txtAge.Text),
                Dui = txtDUI.ToString(),
                Adress = txtAdress.Text,
                Phone = Convert.ToInt32(txtPhone.Text),
                Email = txtMail.Text,
                IdInstitution = ((Institution) cmbInstitution.SelectedItem).Id,
            };
            bool Validation = txtName.Text.Length < 5 || txtAge.Text.Length < 0 || txtDUI.Text.Length < 8 ||
                              txtAdress.Text.Length < 5;
            if (Validation)
            {
                MessageBox.Show("Digite correctamente los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                citizens.Add(citizen);
                db.SaveChanges();
                MessageBox.Show("Se registró el ciudadano", "Registro exitoso", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                Hide();
            }
            MessageBox.Show("Se registró el ciudadano", "Registro exitoso", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide();
            var window = new AppointmentForm();
            window.Show();
        }
    }
}
    
    

