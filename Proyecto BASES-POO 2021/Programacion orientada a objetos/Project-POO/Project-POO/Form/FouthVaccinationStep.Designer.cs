using System.ComponentModel;

namespace Project_POO
{
    partial class FouthVaccinationStep
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
            this.txtSeccondaryEffects = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtHour = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtIdCita = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSeccondaryEffects
            // 
            this.txtSeccondaryEffects.Location = new System.Drawing.Point(141, 217);
            this.txtSeccondaryEffects.Multiline = true;
            this.txtSeccondaryEffects.Name = "txtSeccondaryEffects";
            this.txtSeccondaryEffects.Size = new System.Drawing.Size(161, 46);
            this.txtSeccondaryEffects.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(410, 49);
            this.label1.TabIndex = 2;
            this.label1.Text = "Programación de la aplicación de la Seguna Dosis en el Proceso de Vacunación";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(96, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(261, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "Efectos Secundarios provocados por la aplicación de la Primera Dosis:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(83, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(274, 31);
            this.label5.TabIndex = 6;
            this.label5.Text = "Registre fecha y hora en que se realizará la cita de la aplicación de la Segunda " + "Dosis";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(46, 372);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(161, 20);
            this.txtDate.TabIndex = 7;
            // 
            // txtHour
            // 
            this.txtHour.Location = new System.Drawing.Point(233, 372);
            this.txtHour.Name = "txtHour";
            this.txtHour.Size = new System.Drawing.Size(161, 20);
            this.txtHour.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(294, 338);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 31);
            this.label6.TabIndex = 9;
            this.label6.Text = "Hora:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(96, 338);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 31);
            this.label7.TabIndex = 10;
            this.label7.Text = "Fecha:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(141, 417);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(161, 37);
            this.btnRegister.TabIndex = 11;
            this.btnRegister.Text = "Registrar";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtIdCita
            // 
            this.txtIdCita.Location = new System.Drawing.Point(141, 124);
            this.txtIdCita.Name = "txtIdCita";
            this.txtIdCita.Size = new System.Drawing.Size(161, 20);
            this.txtIdCita.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(193, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 31);
            this.label2.TabIndex = 13;
            this.label2.Text = "Id de Cita:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FouthVaccinationStep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (136)))), ((int) (((byte) (182)))));
            this.ClientSize = new System.Drawing.Size(434, 479);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdCita);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtHour);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSeccondaryEffects);
            this.Name = "FouthVaccinationStep";
            this.Text = "Proceso de Vacunación - Cuarto Paso";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtIdCita;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox txtSeccondaryEffects;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtHour;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;

        #endregion
    }
}