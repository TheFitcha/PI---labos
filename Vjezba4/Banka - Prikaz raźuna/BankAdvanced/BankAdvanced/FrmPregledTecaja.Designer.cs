﻿
namespace BankAdvanced
{
    partial class FrmPregledTecaja
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
            this.label1 = new System.Windows.Forms.Label();
            this.tecajiDataGridView = new System.Windows.Forms.DataGridView();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.btnDodajTecaj = new System.Windows.Forms.Button();
            this.btnIzmijeniTecaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tecajiDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Popis tečaja:";
            // 
            // tecajiDataGridView
            // 
            this.tecajiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tecajiDataGridView.Location = new System.Drawing.Point(14, 25);
            this.tecajiDataGridView.Name = "tecajiDataGridView";
            this.tecajiDataGridView.Size = new System.Drawing.Size(274, 256);
            this.tecajiDataGridView.TabIndex = 2;
            // 
            // btnZatvori
            // 
            this.btnZatvori.Location = new System.Drawing.Point(213, 287);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(75, 23);
            this.btnZatvori.TabIndex = 3;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // btnDodajTecaj
            // 
            this.btnDodajTecaj.Location = new System.Drawing.Point(14, 287);
            this.btnDodajTecaj.Name = "btnDodajTecaj";
            this.btnDodajTecaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodajTecaj.TabIndex = 5;
            this.btnDodajTecaj.Text = "Dodaj tečaj";
            this.btnDodajTecaj.UseVisualStyleBackColor = true;
            this.btnDodajTecaj.Click += new System.EventHandler(this.btnDodajTecaj_Click);
            // 
            // btnIzmijeniTecaj
            // 
            this.btnIzmijeniTecaj.Location = new System.Drawing.Point(95, 287);
            this.btnIzmijeniTecaj.Name = "btnIzmijeniTecaj";
            this.btnIzmijeniTecaj.Size = new System.Drawing.Size(75, 23);
            this.btnIzmijeniTecaj.TabIndex = 6;
            this.btnIzmijeniTecaj.Text = "Izmijeni tečaj";
            this.btnIzmijeniTecaj.UseVisualStyleBackColor = true;
            this.btnIzmijeniTecaj.Click += new System.EventHandler(this.btnIzmijeniTecaj_Click);
            // 
            // FrmPregledTecaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 331);
            this.Controls.Add(this.btnIzmijeniTecaj);
            this.Controls.Add(this.btnDodajTecaj);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.tecajiDataGridView);
            this.Controls.Add(this.label1);
            this.Name = "FrmPregledTecaja";
            this.Text = "Pregled tečaja";
            this.Load += new System.EventHandler(this.FrmPregledTecaja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tecajiDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tecajiDataGridView;
        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.Button btnDodajTecaj;
        private System.Windows.Forms.Button btnIzmijeniTecaj;
    }
}