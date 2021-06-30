using System.ComponentModel;

namespace Project_POO
{
    partial class Step1Form
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
            this.btnContinuar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.btnVerifyDui = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.dgvPreChequeo = new System.Windows.Forms.DataGridView();
            this.txtDui = new System.Windows.Forms.TextBox();
            this.groupBox10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvPreChequeo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnContinuar
            // 
            this.btnContinuar.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnContinuar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContinuar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnContinuar.Location = new System.Drawing.Point(627, 184);
            this.btnContinuar.Margin = new System.Windows.Forms.Padding(4);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(316, 70);
            this.btnContinuar.TabIndex = 40;
            this.btnContinuar.Text = "CONTINUAR";
            this.btnContinuar.UseVisualStyleBackColor = false;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.Location = new System.Drawing.Point(207, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(616, 39);
            this.label1.TabIndex = 41;
            this.label1.Text = "Paso 1: PreChequeo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBox1
            // 
            this.checkBox1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.checkBox1.Location = new System.Drawing.Point(12, 28);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(556, 34);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Acepto y doy consentimiento en el proceso de vacunación";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.checkBox1);
            this.groupBox10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.groupBox10.Location = new System.Drawing.Point(69, 307);
            this.groupBox10.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox10.Size = new System.Drawing.Size(647, 62);
            this.groupBox10.TabIndex = 39;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Al aceptar nos brinda su consentimiento en el proceso de vacunación";
            // 
            // btnVerifyDui
            // 
            this.btnVerifyDui.BackColor = System.Drawing.Color.Snow;
            this.btnVerifyDui.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerifyDui.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnVerifyDui.Location = new System.Drawing.Point(308, 197);
            this.btnVerifyDui.Margin = new System.Windows.Forms.Padding(4);
            this.btnVerifyDui.Name = "btnVerifyDui";
            this.btnVerifyDui.Size = new System.Drawing.Size(157, 44);
            this.btnVerifyDui.TabIndex = 47;
            this.btnVerifyDui.Text = "Verificar DUI";
            this.btnVerifyDui.UseVisualStyleBackColor = false;
            this.btnVerifyDui.Click += new System.EventHandler(this.btnVerifyDui_Click);
            // 
            // lbl1
            // 
            this.lbl1.BackColor = System.Drawing.Color.Transparent;
            this.lbl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl1.ForeColor = System.Drawing.Color.Black;
            this.lbl1.Location = new System.Drawing.Point(743, 313);
            this.lbl1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(266, 56);
            this.lbl1.TabIndex = 48;
            this.lbl1.Text = "¿Aun no has agendado una cita? Haz click aquí";
            this.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvPreChequeo
            // 
            this.dgvPreChequeo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPreChequeo.Location = new System.Drawing.Point(23, 72);
            this.dgvPreChequeo.Name = "dgvPreChequeo";
            this.dgvPreChequeo.RowTemplate.Height = 24;
            this.dgvPreChequeo.Size = new System.Drawing.Size(1047, 105);
            this.dgvPreChequeo.TabIndex = 49;
            // 
            // txtDui
            // 
            this.txtDui.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtDui.Location = new System.Drawing.Point(78, 197);
            this.txtDui.Multiline = true;
            this.txtDui.Name = "txtDui";
            this.txtDui.Size = new System.Drawing.Size(206, 44);
            this.txtDui.TabIndex = 51;
            // 
            // Step1Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 396);
            this.Controls.Add(this.txtDui);
            this.Controls.Add(this.dgvPreChequeo);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnVerifyDui);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnContinuar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Step1Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PreChequeo";
            this.groupBox10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dgvPreChequeo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtDui;

        private System.Windows.Forms.DataGridView dgvPreChequeo;


        private System.Windows.Forms.Button btnVerifyDui;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.CheckBox checkBox1;

        #endregion
    }
}