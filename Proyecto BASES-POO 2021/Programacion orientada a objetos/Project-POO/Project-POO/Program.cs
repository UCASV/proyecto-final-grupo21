using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_POO.Form;

namespace Project_POO
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< HEAD
            Application.Run(new AppointmentRecordForm());
=======
            Application.Run(new Step3Form());
>>>>>>> c4ca57421138bc878ffcdfc4064734f815fe6cf7
        }
    }
}