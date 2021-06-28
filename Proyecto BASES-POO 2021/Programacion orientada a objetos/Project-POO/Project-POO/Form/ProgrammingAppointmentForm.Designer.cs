using System.ComponentModel;
using System;

namespace Project_POO
{
    partial class ProgrammingAppointmentForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVerification = new System.Windows.Forms.TextBox();
            this.btnVerification = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(133, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Citas Programadas";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(43, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(278, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Verificación de Cita, por favor ingrese el DUI del cliente:";
            // 
            // txtVerification
            // 
            this.txtVerification.Location = new System.Drawing.Point(57, 106);
            this.txtVerification.Name = "txtVerification";
            this.txtVerification.Size = new System.Drawing.Size(247, 20);
            this.txtVerification.TabIndex = 2;
            // 
            // btnVerification
            // 
            this.btnVerification.BackColor = System.Drawing.Color.White;
            this.btnVerification.Location = new System.Drawing.Point(57, 164);
            this.btnVerification.Name = "btnVerification";
            this.btnVerification.Size = new System.Drawing.Size(113, 46);
            this.btnVerification.TabIndex = 3;
            this.btnVerification.Text = "Verificar Cita";
            this.btnVerification.UseVisualStyleBackColor = false;
            this.btnVerification.Click += new System.EventHandler(this.btnVerification_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(191, 164);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(113, 46);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ProgrammingAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (136)))), ((int) (((byte) (182)))));
            this.ClientSize = new System.Drawing.Size(360, 272);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnVerification);
            this.Controls.Add(this.txtVerification);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ProgrammingAppointmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Verificación de Cita Programada";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnCancel;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVerification;
        private System.Windows.Forms.Button btnVerification;

        #endregion
    }
}