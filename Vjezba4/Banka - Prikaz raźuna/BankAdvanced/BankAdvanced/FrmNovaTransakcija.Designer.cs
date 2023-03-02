namespace BankAdvanced
{
    partial class FrmNovaTransakcija
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
            this.racunIzvorisniTextBox = new System.Windows.Forms.TextBox();
            this.racunIzvorisniButton = new System.Windows.Forms.Button();
            this.racunOdredisniButton = new System.Windows.Forms.Button();
            this.racunOdredisniTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.iznosTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.korisnikIzvorisniButton = new System.Windows.Forms.Button();
            this.korisnikIzvorisniTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.korisnikOdredisniButton = new System.Windows.Forms.Button();
            this.korisnikOdredisniTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.provediButton = new System.Windows.Forms.Button();
            this.izlazButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Račun:";
            // 
            // racunPlatiteljTextBox
            // 
            this.racunIzvorisniTextBox.Enabled = false;
            this.racunIzvorisniTextBox.Location = new System.Drawing.Point(68, 40);
            this.racunIzvorisniTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.racunIzvorisniTextBox.Name = "racunPlatiteljTextBox";
            this.racunIzvorisniTextBox.Size = new System.Drawing.Size(308, 20);
            this.racunIzvorisniTextBox.TabIndex = 1;
            // 
            // racunIzvorisniButton
            // 
            this.racunIzvorisniButton.Location = new System.Drawing.Point(379, 40);
            this.racunIzvorisniButton.Margin = new System.Windows.Forms.Padding(2);
            this.racunIzvorisniButton.Name = "racunIzvorisniButton";
            this.racunIzvorisniButton.Size = new System.Drawing.Size(26, 18);
            this.racunIzvorisniButton.TabIndex = 2;
            this.racunIzvorisniButton.Text = "...";
            this.racunIzvorisniButton.UseVisualStyleBackColor = true;
            this.racunIzvorisniButton.Click += new System.EventHandler(this.racunPlatiteljButton_Click);
            // 
            // racunOdredisniButton
            // 
            this.racunOdredisniButton.Location = new System.Drawing.Point(379, 43);
            this.racunOdredisniButton.Margin = new System.Windows.Forms.Padding(2);
            this.racunOdredisniButton.Name = "racunOdredisniButton";
            this.racunOdredisniButton.Size = new System.Drawing.Size(26, 19);
            this.racunOdredisniButton.TabIndex = 5;
            this.racunOdredisniButton.Text = "...";
            this.racunOdredisniButton.UseVisualStyleBackColor = true;
            this.racunOdredisniButton.Click += new System.EventHandler(this.racunPrimateljButton_Click);
            // 
            // racunPrimateljTextBox
            // 
            this.racunOdredisniTextBox.Enabled = false;
            this.racunOdredisniTextBox.Location = new System.Drawing.Point(68, 44);
            this.racunOdredisniTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.racunOdredisniTextBox.Name = "racunPrimateljTextBox";
            this.racunOdredisniTextBox.Size = new System.Drawing.Size(308, 20);
            this.racunOdredisniTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Račun:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 175);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Iznos:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // iznosTextBox
            // 
            this.iznosTextBox.Location = new System.Drawing.Point(76, 175);
            this.iznosTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.iznosTextBox.Name = "iznosTextBox";
            this.iznosTextBox.Size = new System.Drawing.Size(76, 20);
            this.iznosTextBox.TabIndex = 7;
            this.iznosTextBox.Text = "0,00";
            this.iznosTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.korisnikIzvorisniButton);
            this.groupBox1.Controls.Add(this.korisnikIzvorisniTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.racunIzvorisniTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.racunIzvorisniButton);
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(409, 76);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Izvorišni:";
            // 
            // korisnikIzvorisniButton
            // 
            this.korisnikIzvorisniButton.Location = new System.Drawing.Point(379, 17);
            this.korisnikIzvorisniButton.Margin = new System.Windows.Forms.Padding(2);
            this.korisnikIzvorisniButton.Name = "korisnikIzvorisniButton";
            this.korisnikIzvorisniButton.Size = new System.Drawing.Size(26, 18);
            this.korisnikIzvorisniButton.TabIndex = 4;
            this.korisnikIzvorisniButton.Text = "...";
            this.korisnikIzvorisniButton.UseVisualStyleBackColor = true;
            this.korisnikIzvorisniButton.Click += new System.EventHandler(this.korisnikIzvorisniButton_Click);
            // 
            // klijentPlatiteljTextBox
            // 
            this.korisnikIzvorisniTextBox.Enabled = false;
            this.korisnikIzvorisniTextBox.Location = new System.Drawing.Point(68, 17);
            this.korisnikIzvorisniTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.korisnikIzvorisniTextBox.Name = "korisnikIzvorisniTextBox";
            this.korisnikIzvorisniTextBox.Size = new System.Drawing.Size(308, 20);
            this.korisnikIzvorisniTextBox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Korisnik:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.korisnikOdredisniButton);
            this.groupBox2.Controls.Add(this.korisnikOdredisniTextBox);
            this.groupBox2.Controls.Add(this.racunOdredisniTextBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.racunOdredisniButton);
            this.groupBox2.Location = new System.Drawing.Point(9, 91);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(409, 79);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Odredišni:";
            // 
            // korisnikOdredisniButton
            // 
            this.korisnikOdredisniButton.Location = new System.Drawing.Point(379, 20);
            this.korisnikOdredisniButton.Margin = new System.Windows.Forms.Padding(2);
            this.korisnikOdredisniButton.Name = "korisnikOdredisniButton";
            this.korisnikOdredisniButton.Size = new System.Drawing.Size(26, 19);
            this.korisnikOdredisniButton.TabIndex = 12;
            this.korisnikOdredisniButton.Text = "...";
            this.korisnikOdredisniButton.UseVisualStyleBackColor = true;
            this.korisnikOdredisniButton.Click += new System.EventHandler(this.korisnikOdredisniButton_Click);
            // 
            // klijentPrimateljTextBox
            // 
            this.korisnikOdredisniTextBox.Enabled = false;
            this.korisnikOdredisniTextBox.Location = new System.Drawing.Point(68, 21);
            this.korisnikOdredisniTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.korisnikOdredisniTextBox.Name = "korisnikOdredisniTextBox";
            this.korisnikOdredisniTextBox.Size = new System.Drawing.Size(308, 20);
            this.korisnikOdredisniTextBox.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 24);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Korisnik:";
            // 
            // provediButton
            // 
            this.provediButton.Location = new System.Drawing.Point(283, 207);
            this.provediButton.Margin = new System.Windows.Forms.Padding(2);
            this.provediButton.Name = "provediButton";
            this.provediButton.Size = new System.Drawing.Size(63, 37);
            this.provediButton.TabIndex = 10;
            this.provediButton.Text = "Provedi";
            this.provediButton.UseVisualStyleBackColor = true;
            this.provediButton.Click += new System.EventHandler(this.provediButton_Click);
            // 
            // izlazButton
            // 
            this.izlazButton.Location = new System.Drawing.Point(350, 207);
            this.izlazButton.Margin = new System.Windows.Forms.Padding(2);
            this.izlazButton.Name = "izlazButton";
            this.izlazButton.Size = new System.Drawing.Size(63, 37);
            this.izlazButton.TabIndex = 11;
            this.izlazButton.Text = "Izlaz";
            this.izlazButton.UseVisualStyleBackColor = true;
            this.izlazButton.Click += new System.EventHandler(this.odustaniButton_Click);
            // 
            // FrmNovaTransakcija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 254);
            this.Controls.Add(this.izlazButton);
            this.Controls.Add(this.provediButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.iznosTextBox);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmNovaTransakcija";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nova transakcija";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox racunIzvorisniTextBox;
        private System.Windows.Forms.Button racunIzvorisniButton;
        private System.Windows.Forms.Button racunOdredisniButton;
        private System.Windows.Forms.TextBox racunOdredisniTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox iznosTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox korisnikIzvorisniTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox korisnikOdredisniTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button provediButton;
        private System.Windows.Forms.Button izlazButton;
        private System.Windows.Forms.Button korisnikIzvorisniButton;
        private System.Windows.Forms.Button korisnikOdredisniButton;
    }
}