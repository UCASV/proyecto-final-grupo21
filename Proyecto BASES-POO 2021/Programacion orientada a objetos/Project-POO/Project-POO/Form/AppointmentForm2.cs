using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using Project_POO.Context;
using Project_POO.Model;

namespace Project_POO
{
    public partial class AppointmentForm2 : System.Windows.Forms.Form
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
            string FullName = txtName.Text;
            string Age = txtAge.Text;
            int AgeParse = 0;
            string dui = txtDUI.Text;
            string address = txtAdress.Text;
            string phone = txtPhone.Text;
            string email = txtMail.Text;
            int institucion = ((Institution) cmbInstitution.SelectedItem).Id;
            
            ValidateData(FullName, Age, dui, address, phone, email, AgeParse);
            
            var db = new VaccinationContext();
            List<Citizen> citizens = db.Citizens.ToList();
            Citizen citizen = new Citizen()
            {
                FullName = FullName,
                Age = AgeParse,
                Dui = dui,
                Adress = address,
                Phone = phone,
                Email = email,
                IdInstitution = institucion,
            };
            bool Validation = txtName.Text.Length < 5 || txtAge.Text.Length < 0 || txtDUI.Text.Length < 8 ||
                              txtAdress.Text.Length < 5;
            
            bool validatePriorityGroup = ValidatePriorityGroup(
                    AgeParse,
                    dui,
                    address,
                    email,
                    institucion
                );

            if (!validatePriorityGroup)
            {
                MessageBox.Show("Usted no aplica a la vacuna", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
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

        private void ValidateData(
            string FullName, string Age, string dui, string address, 
            string phone, string email, int AgeParse
            )
        {
            if (FullName == null)
            {
                MessageBox.Show("El nombre no debe estar vacio.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            bool success = Int32.TryParse(Age, out AgeParse);
            if (!success)
            {
                MessageBox.Show("El formato de edad no es valido.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            if (phone == null)
            {
                MessageBox.Show("El telefono no debe estar vacio.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            if (dui == null)
            {
                MessageBox.Show("El DUI no debe estar vacio.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            if (address == null)
            {
                MessageBox.Show("El DUI no debe estar vacio.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (email == null)
            {
                MessageBox.Show("El email no debe estar vacio.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        
        private bool ValidatePriorityGroup(
            int Age, string dui, string address, string email, int institution 
            )
        {
            if (Age > 60)
            {
                return true;
            }
            
            return false;
        }

        private void AppointmentForm2_Load(object sender, EventArgs e)
        {
            var db = new VaccinationContext();
            List<Institution> institutions = db.Institutions
                .ToList();
            cmbInstitution.DataSource = institutions;
            cmbInstitution.DisplayMember = "institution";
            cmbInstitution.ValueMember = "id";
        }
    }
}
    
    

