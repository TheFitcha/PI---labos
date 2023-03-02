namespace BankAdvanced
{
    partial class FrmKorisnici
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
            this.dgvKorisnici = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnProfilKorisnika = new System.Windows.Forms.Button();
            this.btnPrikaziRacune = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisnici)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKorisnici
            // 
            this.dgvKorisnici.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvKorisnici.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvKorisnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKorisnici.Location = new System.Drawing.Point(9, 26);
            this.dgvKorisnici.Margin = new System.Windows.Forms.Padding(2);
            this.dgvKorisnici.Name = "dgvKorisnici";
            this.dgvKorisnici.RowHeadersVisible = false;
            this.dgvKorisnici.RowTemplate.Height = 24;
            this.dgvKorisnici.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKorisnici.Size = new System.Drawing.Size(582, 282);
            this.dgvKorisnici.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Popis korisnika:";
            // 
            // btnProfilKorisnika
            // 
            this.btnProfilKorisnika.Location = new System.Drawing.Point(493, 319);
            this.btnProfilKorisnika.Margin = new System.Windows.Forms.Padding(2);
            this.btnProfilKorisnika.Name = "btnProfilKorisnika";
            this.btnProfilKorisnika.Size = new System.Drawing.Size(98, 27);
            this.btnProfilKorisnika.TabIndex = 4;
            this.btnProfilKorisnika.Text = "Profil korisnika";
            this.btnProfilKorisnika.UseVisualStyleBackColor = true;
            this.btnProfilKorisnika.Click += new System.EventHandler(this.detaljiButton_Click);
            // 
            // btnPrikaziRacune
            // 
            this.btnPrikaziRacune.Location = new System.Drawing.Point(9, 319);
            this.btnPrikaziRacune.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrikaziRacune.Name = "btnPrikaziRacune";
            this.btnPrikaziRacune.Size = new System.Drawing.Size(98, 27);
            this.btnPrikaziRacune.TabIndex = 5;
            this.btnPrikaziRacune.Text = "Prikaži račune";
            this.btnPrikaziRacune.UseVisualStyleBackColor = true;
            this.btnPrikaziRacune.Click += new System.EventHandler(this.btnPrikaziRacune_Click);
            // 
            // FrmKorisnici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 360);
            this.Controls.Add(this.btnPrikaziRacune);
            this.Controls.Add(this.btnProfilKorisnika);
            this.Controls.Add(this.dgvKorisnici);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmKorisnici";
            this.Text = "Korisnici";
            this.Load += new System.EventHandler(this.FrmKorisnici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisnici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKorisnici;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProfilKorisnika;
        private System.Windows.Forms.Button btnPrikaziRacune;
    }
}