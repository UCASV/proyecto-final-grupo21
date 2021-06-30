using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Project_POO.Form;

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
            string sickness = txtSickness.Text;
            
            var db = new VaccinationContext();
            List<Citizen> citizens = db.Citizens.ToList();
            var sicknesses = db.Sicknesses.ToList();
            var Sickness = new Sickness()
            {
                Sickness1 = sickness
            };
            sicknesses.Add(Sickness);
            
            Citizen citizen = new Citizen()
            {
                FullName = FullName,
                Age = AgeParse,
                Dui = dui,
                Adress = address,
                Phone = Convert.ToInt32(phone),
                Email = email,
                IdInstitution = institucion,
                Sicknesses = sicknesses
            };
            bool validatePriorityGroup = ValidatePriorityGroup(AgeParse,institucion );
            bool Validation = ValidateData(FullName, Age, dui, address, phone, email, AgeParse);

            if (!validatePriorityGroup)
            {
                MessageBox.Show("Usted pertenece a uno de los grupos de prioridad de vacunación", "Registrando...",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (Validation)
            {
                MessageBox.Show("Digite correctamente los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Se registró el ciudadano", "Registro exitoso", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                db.Add(citizen);
                db.SaveChanges();
                Hide();
                var window = new AppointmentRecordForm();
                window.Show();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide();
            var window = new AppointmentForm();
            window.Show();
        }

        private bool ValidateData(string FullName, string Age, string dui, string address,
            string phone, string email, int AgeParse)
        {
            bool success = Int32.TryParse(Age, out AgeParse);
            if (FullName == null)
            {
                MessageBox.Show("El nombre no debe estar vacio.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!success)
            {
                MessageBox.Show("El formato de edad no es valido.", "ERROR", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return false;
            }
            if (phone == null)
            {
                MessageBox.Show("El telefono no debe estar vacio.", "ERROR", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
            if (dui == null)
            {
                MessageBox.Show("El DUI no debe estar vacio.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (address == null)
            {
                MessageBox.Show("El DUI no debe estar vacio.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (email == null)
            {
                MessageBox.Show("El email no debe estar vacio.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private bool ValidatePriorityGroup(
            int Age, int institution 
            )
        {
            if (Age > 60)
            {
                return true;
            }
            if (Age > 18 && txtSickness.Text.Length != 0)
            {
                return true;
            }
            if (institution != 0)
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
    
    

