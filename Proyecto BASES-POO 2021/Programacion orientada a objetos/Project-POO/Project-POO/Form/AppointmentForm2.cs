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

<<<<<<< HEAD
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            var db = new VaccinationContext();
            List<Citizen> citizens = db.Citizens.ToList();
=======

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            var db = new VaccinationContext();
            List<Citizen> citizenz = db.Citizens.ToList();
>>>>>>> 6b6024e55ea0e019ccac9052e8d87b8facda8e7e
            Citizen citizen = new Citizen()
            {
                FullName = txtName.Text,
                Age = Convert.ToInt32(txtAge.Text),
                Dui = txtDUI.ToString(),
                Adress = txtAdress.Text,
                Phone = Convert.ToInt32(txtPhone.Text),
                Email = txtMail.Text,
                IdInstitution = ((Institution) cmbInstitution.SelectedItem).Id,
<<<<<<< HEAD
                
            };

            bool Validation = txtName.Text.Length < 5 || txtAge.Text.Length < 0 || txtDUI.Text.Length < 8 ||
                              txtAdress.Text.Length < 5;
=======
                // Sicknesses = txtSickness.Text, 
                
            };
            
            
            bool Validation = txtName.Text.Length < 5 || txtAge.Text.Length < 0 || txtDUI.Text.Length < 8 || txtAdress.Text.Length < 5;
>>>>>>> 6b6024e55ea0e019ccac9052e8d87b8facda8e7e
            if (Validation)
            {
                MessageBox.Show("Digite correctamente los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                db.Add(citizen);
                db.SaveChanges();
<<<<<<< HEAD
                MessageBox.Show("Se registró el ciudadano", "Registro exitoso", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                Hide();
                

            }

=======
                MessageBox.Show("Se registró el ciudadano", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                
            }
            
            
>>>>>>> 6b6024e55ea0e019ccac9052e8d87b8facda8e7e
        }
    }
    
}
