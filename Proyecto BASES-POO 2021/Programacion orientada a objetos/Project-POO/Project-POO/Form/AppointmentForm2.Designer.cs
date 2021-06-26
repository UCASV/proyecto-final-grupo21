using System.ComponentModel;

namespace Project_POO
{
    partial class AppointmentForm2
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDUI = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSickness = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbInstitution = new System.Windows.Forms.ComboBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.lblChange = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(40, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre y apellido:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(180, 84);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 22);
            this.txtName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(40, 172);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "DUI:";
            // 
            // txtDUI
            // 
            this.txtDUI.Location = new System.Drawing.Point(180, 172);
            this.txtDUI.Margin = new System.Windows.Forms.Padding(4);
            this.txtDUI.Name = "txtDUI";
            this.txtDUI.Size = new System.Drawing.Size(200, 22);
            this.txtDUI.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(40, 218);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 33);
            this.label3.TabIndex = 4;
            this.label3.Text = "domicilio actual:";
            // 
            // txtAdress
            // 
            this.txtAdress.Location = new System.Drawing.Point(180, 218);
            this.txtAdress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdress.Multiline = true;
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(200, 46);
            this.txtAdress.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(40, 290);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 33);
            this.label4.TabIndex = 6;
            this.label4.Text = "teléfono:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(180, 290);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(200, 22);
            this.txtPhone.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(40, 338);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 55);
            this.label5.TabIndex = 8;
            this.label5.Text = "correo electrónico (opcional):";
            // 
            // label6
            // 
            this.label6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label6.Location = new System.Drawing.Point(40, 398);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 55);
            this.label6.TabIndex = 10;
            this.label6.Text = "padecimientos crónicos:";
            // 
            // txtSickness
            // 
            this.txtSickness.Location = new System.Drawing.Point(180, 398);
            this.txtSickness.Margin = new System.Windows.Forms.Padding(4);
            this.txtSickness.Multiline = true;
            this.txtSickness.Name = "txtSickness";
            this.txtSickness.Size = new System.Drawing.Size(200, 54);
            this.txtSickness.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label7.Location = new System.Drawing.Point(40, 479);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 33);
            this.label7.TabIndex = 12;
            this.label7.Text = "entidad gubernamental:";
            // 
            // label8
            // 
            this.label8.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label8.Location = new System.Drawing.Point(40, 127);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 33);
            this.label8.TabIndex = 14;
            this.label8.Text = "edad:";
            // 
            // cmbInstitution
            // 
            this.cmbInstitution.FormattingEnabled = true;
            this.cmbInstitution.Location = new System.Drawing.Point(180, 479);
            this.cmbInstitution.Margin = new System.Windows.Forms.Padding(4);
            this.cmbInstitution.Name = "cmbInstitution";
            this.cmbInstitution.Size = new System.Drawing.Size(200, 24);
            this.cmbInstitution.TabIndex = 15;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(180, 347);
            this.txtMail.Margin = new System.Windows.Forms.Padding(4);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(200, 22);
            this.txtMail.TabIndex = 16;
            // 
            // lblChange
            // 
            this.lblChange.BackColor = System.Drawing.Color.Transparent;
            this.lblChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblChange.ForeColor = System.Drawing.Color.Black;
            this.lblChange.Location = new System.Drawing.Point(40, 538);
            this.lblChange.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(248, 33);
            this.lblChange.TabIndex = 17;
            this.lblChange.Text = "¿Ya posees una cita? Haz click aquí      si ya tienes una cita programada.";
            this.lblChange.Click += new System.EventHandler(this.lblChange_Click);
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(180, 127);
            this.txtAge.Margin = new System.Windows.Forms.Padding(4);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(200, 22);
            this.txtAge.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label9.Location = new System.Drawing.Point(113, 28);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(248, 33);
            this.label9.TabIndex = 19;
            this.label9.Text = "Bienvenido a Programación de Citas";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(315, 525);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(110, 46);
            this.btnRegistrar.TabIndex = 20;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // AppointmentForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (136)))), ((int) (((byte) (182)))));
            this.ClientSize = new System.Drawing.Size(463, 604);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.lblChange);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.cmbInstitution);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSickness);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAdress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDUI);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AppointmentForm2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Programming Appointment";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnRegistrar;


        private System.Windows.Forms.Label label9;

        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.ComboBox cmbInstitution;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.TextBox txtDUI;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSickness;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;

        #endregion
    }
}