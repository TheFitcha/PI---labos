namespace BankarstvoGui
{
    partial class FrmTransakcije
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
            this.dgvTransakcije = new System.Windows.Forms.DataGridView();
            this.btnUplati = new System.Windows.Forms.Button();
            this.btnIsplati = new System.Windows.Forms.Button();
            this.btnIzlaz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransakcije)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTransakcije
            // 
            this.dgvTransakcije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransakcije.Location = new System.Drawing.Point(12, 12);
            this.dgvTransakcije.Name = "dgvTransakcije";
            this.dgvTransakcije.Size = new System.Drawing.Size(674, 176);
            this.dgvTransakcije.TabIndex = 0;
            // 
            // btnUplati
            // 
            this.btnUplati.Location = new System.Drawing.Point(12, 194);
            this.btnUplati.Name = "btnUplati";
            this.btnUplati.Size = new System.Drawing.Size(75, 23);
            this.btnUplati.TabIndex = 1;
            this.btnUplati.Text = "Uplati";
            this.btnUplati.UseVisualStyleBackColor = true;
            this.btnUplati.Click += new System.EventHandler(this.btnUplati_Click);
            // 
            // btnIsplati
            // 
            this.btnIsplati.Location = new System.Drawing.Point(93, 194);
            this.btnIsplati.Name = "btnIsplati";
            this.btnIsplati.Size = new System.Drawing.Size(75, 23);
            this.btnIsplati.TabIndex = 2;
            this.btnIsplati.Text = "Isplati";
            this.btnIsplati.UseVisualStyleBackColor = true;
            this.btnIsplati.Click += new System.EventHandler(this.btnIsplati_Click);
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.Location = new System.Drawing.Point(611, 194);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(75, 23);
            this.btnIzlaz.TabIndex = 3;
            this.btnIzlaz.Text = "Izlaz";
            this.btnIzlaz.UseVisualStyleBackColor = true;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // FrmTransakcije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 231);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.btnIsplati);
            this.Controls.Add(this.btnUplati);
            this.Controls.Add(this.dgvTransakcije);
            this.Name = "FrmTransakcije";
            this.Text = "Transakcije";
            this.Load += new System.EventHandler(this.FrmTransakcije_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransakcije)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTransakcije;
        private System.Windows.Forms.Button btnUplati;
        private System.Windows.Forms.Button btnIsplati;
        private System.Windows.Forms.Button btnIzlaz;
    }
}