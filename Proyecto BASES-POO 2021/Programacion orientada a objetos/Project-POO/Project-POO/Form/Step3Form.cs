using System;
using System.Linq;
using System.Timers;
using System.Windows.Forms;
using Project_POO.Context;

namespace Project_POO
{
    public partial class Step3Form : Form
    {
        int tiempo = 0;
        public Step3Form()
        {
            InitializeComponent();
        }
        
        private void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            tiempo++;
            prbVacunando.Value++;
            
            if (prbVacunando.Value < 100)
                prbVacunando.Value++;
            if (prbVacunando.Value == 100)
                timer.Enabled = false;
        }
        private void btnDui_Click(object sender, EventArgs e)
        {
            timer.Enabled = true;
            prbVacunando.Value = 0;

        }
    }
}