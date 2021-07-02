using System.ComponentModel;

namespace Project_POO.Form
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
            this.timer = new System.Timers.Timer();
            this.prbVacunando = new System.Windows.Forms.ProgressBar();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtDui = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnVacunar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.timer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.Location = new System.Drawing.Point(171, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(465, 49);
            this.label1.TabIndex = 50;
            this.label1.Text = "Aplicacion de primera dosis";
            // 
            // timer
            // 
            this.timer.SynchronizingObject = this;
            this.timer.Elapsed += new System.Timers.ElapsedEventHandler(this.timer_Elapsed);
            // 
            // prbVacunando
            // 
            this.prbVacunando.Location = new System.Drawing.Point(12, 338);
            this.prbVacunando.Name = "prbVacunando";
            this.prbVacunando.Size = new System.Drawing.Size(749, 54);
            this.prbVacunando.TabIndex = 52;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(24, 67);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(735, 68);
            this.dataGridView.TabIndex = 53;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(225, 157);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(86, 52);
            this.btnSearch.TabIndex = 54;
            this.btnSearch.Text = "Buscar DUI";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // txtDui
            // 
            this.txtDui.Location = new System.Drawing.Point(24, 166);
            this.txtDui.Multiline = true;
            this.txtDui.Name = "txtDui";
            this.txtDui.Size = new System.Drawing.Size(183, 33);
            this.txtDui.TabIndex = 56;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.Location = new System.Drawing.Point(307, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 34);
            this.label2.TabIndex = 57;
            this.label2.Text = "Vacunar";
            // 
            // btnVacunar
            // 
            this.btnVacunar.Location = new System.Drawing.Point(322, 290);
            this.btnVacunar.Name = "btnVacunar";
            this.btnVacunar.Size = new System.Drawing.Size(96, 42);
            this.btnVacunar.TabIndex = 58;
            this.btnVacunar.Text = "Aplicar";
            this.btnVacunar.UseVisualStyleBackColor = true;
            this.btnVacunar.Click += new System.EventHandler(this.btnVacunar_Click);
            // 
            // Step3Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 402);
            this.Controls.Add(this.btnVacunar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDui);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.prbVacunando);
            this.Controls.Add(this.label1);
            this.Name = "Step3Form";
            this.Text = "Primera dosis";
            ((System.ComponentModel.ISupportInitialize) (this.timer)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnVacunar;

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.TextBox txtDui;
        

        private System.Windows.Forms.DataGridView dataGridView;

        private System.Timers.Timer timer;

        private System.Windows.Forms.ProgressBar prbVacunando;


        private System.Windows.Forms.Label label1;

        #endregion
    }
}