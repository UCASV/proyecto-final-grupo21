using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Windows.Forms;
using Project_POO.Context;
using Project_POO.Model;

namespace Project_POO.Form
{
    public partial class frmVaccine : System.Windows.Forms.Form
    {
        
        
        
        public frmVaccine(object sender, EventArgs e )
        {
            InitializeComponent();
         

        }
        
        private void frmVaccine_Load(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void btnVacunar_Click(object sender, EventArgs e)
        {
            int contador = 0;
            try
            {
                progressBar.Visible = true;
                timer.Enabled = true;
                contador++;
                
                //if (contador == )

            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }
    }
}