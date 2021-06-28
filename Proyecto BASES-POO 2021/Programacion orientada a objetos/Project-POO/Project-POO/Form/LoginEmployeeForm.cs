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

            Gestor u = result[0];

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
                    IdGestor = u.Id,
                    Gestor = u.Username
                };
                db.Add(register);
                db.SaveChanges();
            }
        }
    }
}