using System.ComponentModel;

namespace Project_POO.Form
{
    partial class frmVaccine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVaccine));
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.btnVacunar = new System.Windows.Forms.Button();
            this.timer = new System.Timers.Timer();
            ((System.ComponentModel.ISupportInitialize) (this.timer)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(0, 394);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(553, 44);
            this.progressBar.TabIndex = 0;
            // 
            // btnVacunar
            // 
            this.btnVacunar.Location = new System.Drawing.Point(3, 316);
            this.btnVacunar.Name = "btnVacunar";
            this.btnVacunar.Size = new System.Drawing.Size(171, 48);
            this.btnVacunar.TabIndex = 1;
            this.btnVacunar.UseVisualStyleBackColor = true;
            this.btnVacunar.Click += new System.EventHandler(this.btnVacunar_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.SynchronizingObject = this;
            // 
            // frmVaccine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 450);
            this.Controls.Add(this.btnVacunar);
            this.Controls.Add(this.progressBar);
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Name = "frmVaccine";
            this.Text = "Vacunación";
            this.Load += new System.EventHandler(this.frmVaccine_Load);
            ((System.ComponentModel.ISupportInitialize) (this.timer)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Timers.Timer timer;


        private System.Windows.Forms.ProgressBar progressBar;

        private System.Windows.Forms.Button btnVacunar;

        #endregion
    }
}