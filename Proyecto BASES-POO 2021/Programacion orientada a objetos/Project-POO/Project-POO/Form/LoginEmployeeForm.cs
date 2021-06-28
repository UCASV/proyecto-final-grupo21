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

            var listaEmployees = db.Employees
                .OrderBy(c => c.Id)
                .ToList();
            var result = listaEmployees.Where(
                u => u.EmployeeName.Equals(txtEmployee.Text) &&
                     u.Id.Equals(Convert.ToInt32(txtId.Text))
            ).ToList();

            Employee u = result[0];

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
                    IdGestor = u.IdCabin,
                    Gestor = u.EmployeeName
                };
                db.Add(register);
                db.SaveChanges();
            }
        }
    }
}