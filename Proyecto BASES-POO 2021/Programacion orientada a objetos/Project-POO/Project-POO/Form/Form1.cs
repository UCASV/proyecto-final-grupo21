using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Windows.Forms;
using Project_POO.Context;
using Project_POO.Model;

namespace Project_POO.Form
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
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
                    LoginDay = (dtmPicker.Value).ToString(),
                    LoginTime = (dtmPicker.Value.TimeOfDay).ToString(),
                    IdGestor = u.IdCabin,
                    Gestor = lblNameCabin.Text
                };
                db.Add(register);
                db.SaveChanges();
            }
        }
    }
}
    