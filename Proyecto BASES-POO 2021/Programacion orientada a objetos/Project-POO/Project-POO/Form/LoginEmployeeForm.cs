using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Project_POO.Context;
using Project_POO.Model;

namespace Project_POO.Form
{
    public partial class LoginEmployeeForm : System.Windows.Forms.Form
    {
        public LoginEmployeeForm()
        {
            InitializeComponent();
        }


        private void btnLog_Click(object sender, EventArgs e)
        {
            var db = new VaccinationContext();

            var listaGestors = db.Gestors
                .OrderBy(c => c.Id)
                .ToList();
            var result = listaGestors.Where(
                u => u.Username.Equals(txtUsername.Text) &&
                     u.Pass.Equals(txtPass.Text)
            ).ToList();

            Gestor g = result[0];

            if (result.Count == 0)


                MessageBox.Show("El usuario no existe", "Gestor de vacunación",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                MessageBox.Show("Bienvenido", "Gestor de vacunación",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                List<Register> registers = db.Registers.ToList();
                
                Register register = new Register()
                {
                    LoginDay = dtmPicker.Value.ToString("dd/MM/yyyy"),
                    LoginTime = (dtmPicker.Value.TimeOfDay).ToString(),
                    IdGestor = g.Id,
                    Gestor = g.Username
                };
                registers.Add(register);
                db.SaveChanges();
                Hide();
                var window = new AppointmentForm();
                window.Show();
            }
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            var db = new VaccinationContext();
            var gestores = db.Gestors.ToList();
            Gestor gestor = new Gestor()
            {
                Username = txtUsername.Text,
                Pass = txtPass.Text
            };

            bool validation = txtUsername.Text.Length < 5 || txtPass.Text.Length < 5;

            if (validation)
            {
                MessageBox.Show("Error al ingresar usuario, la cantidad de caracteres introducidos es menor a 5",
                    "¡Intente de nuevo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                gestores.Add(gestor);
                db.SaveChanges();
                Hide();
                var window = new AppointmentForm();
                window.Show();
            }
        }
    }
}