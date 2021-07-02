using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms.VisualStyles;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Project_POO.ViewModel;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Project_POO
{
    
    public partial class ProgrammingAppointmentForm : System.Windows.Forms.Form
    {
        
        public ProgrammingAppointmentForm()
        {
            InitializeComponent();
            
        }

        private void btnVerification_Click(object sender, EventArgs e)
        {
            var bd = new VaccinationContext();
            
            var citizens = bd.Citizens.ToList();
            var exist = citizens
                .Where(c => c.Dui == txtVerification.Text).ToList();
            var consult = bd.Consults.ToList();
            var appointments = consult
                .Where(a =>  a.IdCitizenNavigation.Dui == txtVerification.Text)
                .OrderBy(a => a.IdCitizenNavigation).ToList();
            
            if(exist.Count == 0 && appointments.Count == 0)
            {
                MessageBox.Show("No se encontro el dui del ciudadano en la Base de Datos,", "Consultas",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            int size = appointments.Count() - 1;
            
            string appointmentname = appointments[size].IdCitizenNavigation.FullName;
            string appointmentdui = appointments[size].IdCitizenNavigation.Dui;
            string appointmentdate = appointments[size].ConsultationDay;
            string appointmenthour = appointments[size].ConsultationTime;
            string phone = appointments[size].IdCitizenNavigation.Phone.ToString();
            string age = appointments[size].IdCitizenNavigation.Age.ToString();

            using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = "PDF file|*.pdf", ValidateNames = true })
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FileStream file = new FileStream(saveFileDialog.FileName, FileMode.Create);
                    Document document = new Document(PageSize.A4);
                    PdfWriter pdf = PdfWriter.GetInstance(document, file);
                    document.Open();
                    document.Add(new Paragraph("DETALLE DE LA CITA DEL CIUDADANO " + appointmentname));
                    document.Add(Chunk.NEWLINE);
                    PdfPTable tblconsult = new PdfPTable(6);
                    tblconsult.WidthPercentage = 100;
                    
                    PdfPCell clDUI = new PdfPCell(new Phrase("DUI", new Font(iTextSharp.text.Font.FontFamily.HELVETICA)));
                    clDUI.BorderWidth = 0;
                    clDUI.BorderWidthBottom = 0.75f;
 
                    PdfPCell clName = new PdfPCell(new Phrase("Nombre Completo", new Font(iTextSharp.text.Font.FontFamily.HELVETICA)));
                    clName.BorderWidth = 0;
                    clName.BorderWidthBottom = 0.75f;
 
                    PdfPCell clDate = new PdfPCell(new Phrase("Fecha de cita", new Font(iTextSharp.text.Font.FontFamily.HELVETICA)));
                    clDate.BorderWidth = 0;
                    clDate.BorderWidthBottom = 0.75f;

                    PdfPCell clTime = new PdfPCell(new Phrase("Hora de cita", new Font(iTextSharp.text.Font.FontFamily.HELVETICA)));
                    clTime.BorderWidth = 0;
                    clTime.BorderWidthBottom = 0.75f;
                    
                    PdfPCell clPhone = new PdfPCell(new Phrase("Celular", new Font(iTextSharp.text.Font.FontFamily.HELVETICA)));
                    clPhone.BorderWidth = 0;
                    clPhone.BorderWidthBottom = 0.75f;
                    
                    PdfPCell clAge = new PdfPCell(new Phrase("Edad", new Font(iTextSharp.text.Font.FontFamily.HELVETICA)));
                    clAge.BorderWidth = 0;
                    clAge.BorderWidthBottom = 0.75f;

                    tblconsult.AddCell(clDUI);
                    tblconsult.AddCell(clName);
                    tblconsult.AddCell(clDate);
                    tblconsult.AddCell(clTime);
                    tblconsult.AddCell(clPhone);
                    tblconsult.AddCell(clAge);

                    clDUI = new PdfPCell(new Phrase(appointmentdui));
                    clDUI.BorderWidth = 0;
                    clName = new PdfPCell(new Phrase(appointmentname));
                    clName.BorderWidth = 0;
                    clDate = new PdfPCell(new Phrase(appointmentdate));
                    clDate.BorderWidth = 0;
                    clTime = new PdfPCell(new Phrase(appointmenthour));
                    clTime.BorderWidth = 0;
                    clPhone = new PdfPCell(new Phrase(phone));
                    clPhone.BorderWidth = 0;
                    clAge = new PdfPCell(new Phrase(age));
                    clAge.BorderWidth = 0;
                    
                    tblconsult.AddCell(clDUI);
                    tblconsult.AddCell(clName);
                    tblconsult.AddCell(clDate);
                    tblconsult.AddCell(clTime);
                    tblconsult.AddCell(clPhone);
                    tblconsult.AddCell(clAge);
                    
                    document.Add(tblconsult);
                    document.Close();
                    pdf.Close();
                  
                }

            }
        }
    }
}
