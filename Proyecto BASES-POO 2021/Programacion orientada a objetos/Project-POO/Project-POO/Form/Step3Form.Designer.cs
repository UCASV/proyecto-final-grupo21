using System.ComponentModel;

namespace Project_POO
{
    partial class Step3Form
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
            this.btnDui = new System.Windows.Forms.Button();
            this.timer = new System.Timers.Timer();
            this.prbVacunando = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize) (this.timer)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.Location = new System.Drawing.Point(23, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(465, 49);
            this.label1.TabIndex = 50;
            this.label1.Text = "Aplicacion de primera dosis";
            // 
            // btnDui
            // 
            this.btnDui.Location = new System.Drawing.Point(440, 85);
            this.btnDui.Name = "btnDui";
            this.btnDui.Size = new System.Drawing.Size(106, 42);
            this.btnDui.TabIndex = 51;
            this.btnDui.Text = "Confirmar";
            this.btnDui.UseVisualStyleBackColor = true;
            this.btnDui.Click += new System.EventHandler(this.btnDui_Click);
            // 
            // timer
            // 
            this.timer.SynchronizingObject = this;
            this.timer.Elapsed += new System.Timers.ElapsedEventHandler(this.timer_Elapsed);
            // 
            // prbVacunando
            // 
            this.prbVacunando.Location = new System.Drawing.Point(23, 251);
            this.prbVacunando.Name = "prbVacunando";
            this.prbVacunando.Size = new System.Drawing.Size(523, 52);
            this.prbVacunando.TabIndex = 52;
            // 
            // Step3Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 450);
            this.Controls.Add(this.prbVacunando);
            this.Controls.Add(this.btnDui);
            this.Controls.Add(this.label1);
            this.Name = "Step3Form";
            this.Text = "Primera dosis";
            ((System.ComponentModel.ISupportInitialize) (this.timer)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Timers.Timer timer;

        private System.Windows.Forms.ProgressBar prbVacunando;
        

        private System.Windows.Forms.Button btnDui;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}