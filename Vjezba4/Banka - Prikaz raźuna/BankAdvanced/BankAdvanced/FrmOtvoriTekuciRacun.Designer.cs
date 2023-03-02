namespace BankAdvanced
{
    partial class FrmOtvoriTekuciRacun
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
            this.korisnikTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ibanTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.valutaTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.stanjeTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dozvoljeniMinusTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.izlazButton = new System.Windows.Forms.Button();
            this.spremiButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // korisnikTextBox
            // 
            this.korisnikTextBox.Enabled = false;
            this.korisnikTextBox.Location = new System.Drawing.Point(118, 28);
            this.korisnikTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.korisnikTextBox.Name = "korisnikTextBox";
            this.korisnikTextBox.Size = new System.Drawing.Size(159, 20);
            this.korisnikTextBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 30);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Korisnik:";
            // 
            // ibanTextBox
            // 
            this.ibanTextBox.Enabled = false;
            this.ibanTextBox.Location = new System.Drawing.Point(118, 5);
            this.ibanTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.ibanTextBox.Name = "ibanTextBox";
            this.ibanTextBox.Size = new System.Drawing.Size(159, 20);
            this.ibanTextBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "IBAN:";
            // 
            // valutaTextBox
            // 
            this.valutaTextBox.Enabled = false;
            this.valutaTextBox.Location = new System.Drawing.Point(118, 49);
            this.valutaTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.valutaTextBox.Name = "valutaTextBox";
            this.valutaTextBox.Size = new System.Drawing.Size(159, 20);
            this.valutaTextBox.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Valuta:";
            // 
            // stanjeTextBox
            // 
            this.stanjeTextBox.Location = new System.Drawing.Point(174, 72);
            this.stanjeTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.stanjeTextBox.Name = "stanjeTextBox";
            this.stanjeTextBox.Size = new System.Drawing.Size(104, 20);
            this.stanjeTextBox.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Početno stanje:";
            // 
            // dozvoljeniMinusTextBox
            // 
            this.dozvoljeniMinusTextBox.Location = new System.Drawing.Point(174, 94);
            this.dozvoljeniMinusTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.dozvoljeniMinusTextBox.Name = "dozvoljeniMinusTextBox";
            this.dozvoljeniMinusTextBox.Size = new System.Drawing.Size(104, 20);
            this.dozvoljeniMinusTextBox.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 98);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Dozvoljeni minus:";
            // 
            // izlazButton
            // 
            this.izlazButton.Location = new System.Drawing.Point(214, 117);
            this.izlazButton.Margin = new System.Windows.Forms.Padding(2);
            this.izlazButton.Name = "izlazButton";
            this.izlazButton.Size = new System.Drawing.Size(63, 37);
            this.izlazButton.TabIndex = 20;
            this.izlazButton.Text = "Izlaz";
            this.izlazButton.UseVisualStyleBackColor = true;
            this.izlazButton.Click += new System.EventHandler(this.izlazButton_Click);
            // 
            // spremiButton
            // 
            this.spremiButton.Location = new System.Drawing.Point(146, 117);
            this.spremiButton.Margin = new System.Windows.Forms.Padding(2);
            this.spremiButton.Name = "spremiButton";
            this.spremiButton.Size = new System.Drawing.Size(63, 37);
            this.spremiButton.TabIndex = 19;
            this.spremiButton.Text = "Spremi";
            this.spremiButton.UseVisualStyleBackColor = true;
            this.spremiButton.Click += new System.EventHandler(this.spremiButton_Click);
            // 
            // OtvoriTekuciRacunForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 165);
            this.Controls.Add(this.izlazButton);
            this.Controls.Add(this.spremiButton);
            this.Controls.Add(this.dozvoljeniMinusTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.stanjeTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.valutaTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ibanTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.korisnikTextBox);
            this.Controls.Add(this.label4);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "OtvoriTekuciRacunForm";
            this.Text = "Otvori tekući račun";
            this.Load += new System.EventHandler(this.FrmOtvoriTekuciRacun_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox korisnikTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ibanTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox valutaTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox stanjeTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox dozvoljeniMinusTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button izlazButton;
        private System.Windows.Forms.Button spremiButton;
    }
}