namespace BankAdvanced
{
    partial class FrmIzmjenaTecaja
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
            this.txtReferentnaValuta = new System.Windows.Forms.TextBox();
            this.txtValuta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVrijednost = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Referentna valuta:";
            // 
            // txtReferentnaValuta
            // 
            this.txtReferentnaValuta.Enabled = false;
            this.txtReferentnaValuta.Location = new System.Drawing.Point(117, 22);
            this.txtReferentnaValuta.Name = "txtReferentnaValuta";
            this.txtReferentnaValuta.Size = new System.Drawing.Size(171, 20);
            this.txtReferentnaValuta.TabIndex = 1;
            this.txtReferentnaValuta.TextChanged += new System.EventHandler(this.txtValuta_TextChanged);
            // 
            // txtValuta
            // 
            this.txtValuta.Enabled = false;
            this.txtValuta.Location = new System.Drawing.Point(117, 48);
            this.txtValuta.Name = "txtValuta";
            this.txtValuta.Size = new System.Drawing.Size(171, 20);
            this.txtValuta.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Valuta:";
            // 
            // txtVrijednost
            // 
            this.txtVrijednost.Location = new System.Drawing.Point(213, 74);
            this.txtVrijednost.Name = "txtVrijednost";
            this.txtVrijednost.Size = new System.Drawing.Size(75, 20);
            this.txtVrijednost.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Vrijednost:";
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(132, 110);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(75, 23);
            this.btnSpremi.TabIndex = 6;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(213, 110);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 7;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // FrmIzmjenaTecaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 150);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.txtVrijednost);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtValuta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtReferentnaValuta);
            this.Controls.Add(this.label1);
            this.Name = "FrmIzmjenaTecaja";
            this.Text = "Izmjena tečaja";
            this.Load += new System.EventHandler(this.FrmIzmjenaTecaja_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtReferentnaValuta;
        private System.Windows.Forms.TextBox txtValuta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVrijednost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button btnOdustani;
    }
}