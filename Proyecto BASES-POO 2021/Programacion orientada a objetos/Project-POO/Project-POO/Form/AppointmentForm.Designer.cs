using System.ComponentModel;

namespace Project_POO
{
    partial class AppointmentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStart = new System.Windows.Forms.Button();
            this.btnContinue = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVaccinationProcess = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.BackColor = System.Drawing.Color.White;
            this.btnStart.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnStart.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStart.Location = new System.Drawing.Point(98, 75);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(213, 65);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Programación de Cita";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnContinue
            // 
            this.btnContinue.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.btnContinue.BackColor = System.Drawing.Color.White;
            this.btnContinue.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnContinue.Location = new System.Drawing.Point(98, 160);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(213, 69);
            this.btnContinue.TabIndex = 1;
            this.btnContinue.Text = "Seguimiento de Cita Programada";
            this.btnContinue.UseVisualStyleBackColor = false;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.Location = new System.Drawing.Point(47, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 63);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bienvenido a la Plataforma Virtual del Ministerio de Salud para el Proceso de Vac" + "unación contra el COVID-19";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnVaccinationProcess
            // 
            this.btnVaccinationProcess.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVaccinationProcess.BackColor = System.Drawing.Color.White;
            this.btnVaccinationProcess.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnVaccinationProcess.Location = new System.Drawing.Point(98, 250);
            this.btnVaccinationProcess.Name = "btnVaccinationProcess";
            this.btnVaccinationProcess.Size = new System.Drawing.Size(213, 69);
            this.btnVaccinationProcess.TabIndex = 3;
            this.btnVaccinationProcess.Text = "Iniciar Proceso de Vacunación";
            this.btnVaccinationProcess.UseVisualStyleBackColor = false;
            // 
            // AppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (136)))), ((int) (((byte) (182)))));
            this.ClientSize = new System.Drawing.Size(410, 354);
            this.Controls.Add(this.btnVaccinationProcess);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.btnStart);
            this.Name = "AppointmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Appointment process";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnVaccinationProcess;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button btnContinue;
        
        private System.Windows.Forms.Button btnStart;

        #endregion
    }
}