namespace BankAdvanced
{
    partial class FrmPocetna
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
            this.izbornik = new System.Windows.Forms.MenuStrip();
            this.korisniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prikazKorisnikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noviKorisnikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transakcijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.popisTransakcijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mjenjačnicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledTečajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.popisValutaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izbornik.SuspendLayout();
            this.SuspendLayout();
            // 
            // izbornik
            // 
            this.izbornik.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.izbornik.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.korisniciToolStripMenuItem,
            this.transakcijeToolStripMenuItem,
            this.mjenjačnicaToolStripMenuItem});
            this.izbornik.Location = new System.Drawing.Point(0, 0);
            this.izbornik.Name = "izbornik";
            this.izbornik.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.izbornik.Size = new System.Drawing.Size(600, 24);
            this.izbornik.TabIndex = 1;
            this.izbornik.Text = "menuStrip1";
            // 
            // korisniciToolStripMenuItem
            // 
            this.korisniciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prikazKorisnikaToolStripMenuItem,
            this.noviKorisnikToolStripMenuItem});
            this.korisniciToolStripMenuItem.Name = "korisniciToolStripMenuItem";
            this.korisniciToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.korisniciToolStripMenuItem.Text = "Korisnici";
            // 
            // prikazKorisnikaToolStripMenuItem
            // 
            this.prikazKorisnikaToolStripMenuItem.Name = "prikazKorisnikaToolStripMenuItem";
            this.prikazKorisnikaToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.prikazKorisnikaToolStripMenuItem.Text = "Prikaz korisnika";
            this.prikazKorisnikaToolStripMenuItem.Click += new System.EventHandler(this.prikazKorisnikaToolStripMenuItem_Click);
            // 
            // noviKorisnikToolStripMenuItem
            // 
            this.noviKorisnikToolStripMenuItem.Name = "noviKorisnikToolStripMenuItem";
            this.noviKorisnikToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.noviKorisnikToolStripMenuItem.Text = "Novi korisnik";
            this.noviKorisnikToolStripMenuItem.Click += new System.EventHandler(this.noviKorisnikToolStripMenuItem_Click);
            // 
            // transakcijeToolStripMenuItem
            // 
            this.transakcijeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.popisTransakcijaToolStripMenuItem});
            this.transakcijeToolStripMenuItem.Name = "transakcijeToolStripMenuItem";
            this.transakcijeToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.transakcijeToolStripMenuItem.Text = "Transakcije";
            // 
            // popisTransakcijaToolStripMenuItem
            // 
            this.popisTransakcijaToolStripMenuItem.Name = "popisTransakcijaToolStripMenuItem";
            this.popisTransakcijaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.popisTransakcijaToolStripMenuItem.Text = "Popis transakcija";
            this.popisTransakcijaToolStripMenuItem.Click += new System.EventHandler(this.popisTransakcijaToolStripMenuItem_Click);
            // 
            // mjenjačnicaToolStripMenuItem
            // 
            this.mjenjačnicaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledTečajaToolStripMenuItem,
            this.popisValutaToolStripMenuItem});
            this.mjenjačnicaToolStripMenuItem.Name = "mjenjačnicaToolStripMenuItem";
            this.mjenjačnicaToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.mjenjačnicaToolStripMenuItem.Text = "Mjenjačnica";
            // 
            // pregledTečajaToolStripMenuItem
            // 
            this.pregledTečajaToolStripMenuItem.Name = "pregledTečajaToolStripMenuItem";
            this.pregledTečajaToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.pregledTečajaToolStripMenuItem.Text = "Pregled tečaja";
            this.pregledTečajaToolStripMenuItem.Click += new System.EventHandler(this.pregledTečajaToolStripMenuItem_Click);
            // 
            // popisValutaToolStripMenuItem
            // 
            this.popisValutaToolStripMenuItem.Name = "popisValutaToolStripMenuItem";
            this.popisValutaToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.popisValutaToolStripMenuItem.Text = "Popis valuta";
            this.popisValutaToolStripMenuItem.Click += new System.EventHandler(this.popisValutaToolStripMenuItem_Click);
            // 
            // PocetnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.izbornik);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.izbornik;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PocetnaForm";
            this.Text = "Početna forma";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPocetna_Load);
            this.izbornik.ResumeLayout(false);
            this.izbornik.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip izbornik;
        private System.Windows.Forms.ToolStripMenuItem transakcijeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem popisTransakcijaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mjenjačnicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledTečajaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem popisValutaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem korisniciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prikazKorisnikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noviKorisnikToolStripMenuItem;
    }
}

