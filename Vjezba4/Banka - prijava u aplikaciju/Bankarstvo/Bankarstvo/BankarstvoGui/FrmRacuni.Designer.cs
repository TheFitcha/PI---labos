namespace BankarstvoGui
{
    partial class FrmRacuni
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.dgvRacuni = new System.Windows.Forms.DataGridView();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.btnPregledTransakcija = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRacuni)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRacuni
            // 
            this.dgvRacuni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRacuni.Location = new System.Drawing.Point(12, 12);
            this.dgvRacuni.Name = "dgvRacuni";
            this.dgvRacuni.Size = new System.Drawing.Size(406, 159);
            this.dgvRacuni.TabIndex = 0;
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.Location = new System.Drawing.Point(343, 177);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(75, 23);
            this.btnIzlaz.TabIndex = 1;
            this.btnIzlaz.Text = "Izlaz";
            this.btnIzlaz.UseVisualStyleBackColor = true;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // btnPregledTransakcija
            // 
            this.btnPregledTransakcija.Location = new System.Drawing.Point(12, 175);
            this.btnPregledTransakcija.Name = "btnPregledTransakcija";
            this.btnPregledTransakcija.Size = new System.Drawing.Size(114, 23);
            this.btnPregledTransakcija.TabIndex = 2;
            this.btnPregledTransakcija.Text = "Pregled transakcija";
            this.btnPregledTransakcija.UseVisualStyleBackColor = true;
            this.btnPregledTransakcija.Click += new System.EventHandler(this.btnPregledTransakcija_Click);
            // 
            // FrmRacuni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 210);
            this.Controls.Add(this.btnPregledTransakcija);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.dgvRacuni);
            this.Name = "FrmRacuni";
            this.Text = "Računi";
            this.Load += new System.EventHandler(this.FrmRacuni_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRacuni)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRacuni;
        private System.Windows.Forms.Button btnIzlaz;
        private System.Windows.Forms.Button btnPregledTransakcija;
    }
}