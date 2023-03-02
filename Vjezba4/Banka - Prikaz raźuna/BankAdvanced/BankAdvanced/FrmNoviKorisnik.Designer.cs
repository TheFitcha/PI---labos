namespace BankAdvanced
{
    partial class FrmNoviKorisnik
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.prezimeTextBox = new System.Windows.Forms.TextBox();
            this.imeTextBox = new System.Windows.Forms.TextBox();
            this.spremiButton = new System.Windows.Forms.Button();
            this.izlazButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.poduzeceTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.oibTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbVrstaKorisnika = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Prezime:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Ime:";
            // 
            // prezimeTextBox
            // 
            this.prezimeTextBox.Location = new System.Drawing.Point(81, 55);
            this.prezimeTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.prezimeTextBox.Name = "prezimeTextBox";
            this.prezimeTextBox.Size = new System.Drawing.Size(128, 20);
            this.prezimeTextBox.TabIndex = 12;
            // 
            // imeTextBox
            // 
            this.imeTextBox.Location = new System.Drawing.Point(81, 32);
            this.imeTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.imeTextBox.Name = "imeTextBox";
            this.imeTextBox.Size = new System.Drawing.Size(128, 20);
            this.imeTextBox.TabIndex = 11;
            // 
            // spremiButton
            // 
            this.spremiButton.Location = new System.Drawing.Point(92, 130);
            this.spremiButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.spremiButton.Name = "spremiButton";
            this.spremiButton.Size = new System.Drawing.Size(56, 28);
            this.spremiButton.TabIndex = 19;
            this.spremiButton.Text = "Spremi";
            this.spremiButton.UseVisualStyleBackColor = true;
            this.spremiButton.Click += new System.EventHandler(this.spremiButton_Click);
            // 
            // izlazButton
            // 
            this.izlazButton.Location = new System.Drawing.Point(152, 130);
            this.izlazButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.izlazButton.Name = "izlazButton";
            this.izlazButton.Size = new System.Drawing.Size(56, 28);
            this.izlazButton.TabIndex = 18;
            this.izlazButton.Text = "Izlaz";
            this.izlazButton.UseVisualStyleBackColor = true;
            this.izlazButton.Click += new System.EventHandler(this.izlazButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 108);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Poduzeće:";
            // 
            // poduzeceTextBox
            // 
            this.poduzeceTextBox.Enabled = false;
            this.poduzeceTextBox.Location = new System.Drawing.Point(81, 106);
            this.poduzeceTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.poduzeceTextBox.Name = "poduzeceTextBox";
            this.poduzeceTextBox.Size = new System.Drawing.Size(128, 20);
            this.poduzeceTextBox.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "OIB:";
            // 
            // oibTextBox
            // 
            this.oibTextBox.Location = new System.Drawing.Point(81, 8);
            this.oibTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.oibTextBox.Name = "oibTextBox";
            this.oibTextBox.Size = new System.Drawing.Size(128, 20);
            this.oibTextBox.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 83);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Vrsta:";
            // 
            // cmbVrstaKorisnika
            // 
            this.cmbVrstaKorisnika.FormattingEnabled = true;
            this.cmbVrstaKorisnika.Items.AddRange(new object[] {
            "Obični korisnik",
            "Premium korisnik"});
            this.cmbVrstaKorisnika.Location = new System.Drawing.Point(81, 80);
            this.cmbVrstaKorisnika.Name = "cmbVrstaKorisnika";
            this.cmbVrstaKorisnika.Size = new System.Drawing.Size(127, 21);
            this.cmbVrstaKorisnika.TabIndex = 22;
            this.cmbVrstaKorisnika.SelectedIndexChanged += new System.EventHandler(this.cmbVrstaKorisnika_SelectedIndexChanged);
            // 
            // FrmNoviKorisnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 173);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbVrstaKorisnika);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.oibTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prezimeTextBox);
            this.Controls.Add(this.imeTextBox);
            this.Controls.Add(this.spremiButton);
            this.Controls.Add(this.izlazButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.poduzeceTextBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmNoviKorisnik";
            this.Text = "Novi korisnik";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox prezimeTextBox;
        private System.Windows.Forms.TextBox imeTextBox;
        private System.Windows.Forms.Button spremiButton;
        private System.Windows.Forms.Button izlazButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox poduzeceTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox oibTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbVrstaKorisnika;
    }
}