namespace AutobusniKolodvor2
{
    partial class KupiKartu
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.vrstaKarteCombo = new System.Windows.Forms.ComboBox();
            this.povratnaCheck = new System.Windows.Forms.CheckBox();
            this.prtljagaCheck = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ispisBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.prtljagaCheck);
            this.groupBox1.Controls.Add(this.povratnaCheck);
            this.groupBox1.Controls.Add(this.vrstaKarteCombo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 131);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opcije karte:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vrsta karte:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dodatno:";
            // 
            // vrstaKarteCombo
            // 
            this.vrstaKarteCombo.FormattingEnabled = true;
            this.vrstaKarteCombo.Location = new System.Drawing.Point(110, 22);
            this.vrstaKarteCombo.Name = "vrstaKarteCombo";
            this.vrstaKarteCombo.Size = new System.Drawing.Size(121, 24);
            this.vrstaKarteCombo.TabIndex = 2;
            // 
            // povratnaCheck
            // 
            this.povratnaCheck.AutoSize = true;
            this.povratnaCheck.Location = new System.Drawing.Point(110, 67);
            this.povratnaCheck.Name = "povratnaCheck";
            this.povratnaCheck.Size = new System.Drawing.Size(120, 20);
            this.povratnaCheck.TabIndex = 3;
            this.povratnaCheck.Text = "Povratna karta?";
            this.povratnaCheck.UseVisualStyleBackColor = true;
            // 
            // prtljagaCheck
            // 
            this.prtljagaCheck.AutoSize = true;
            this.prtljagaCheck.Location = new System.Drawing.Point(110, 93);
            this.prtljagaCheck.Name = "prtljagaCheck";
            this.prtljagaCheck.Size = new System.Drawing.Size(79, 20);
            this.prtljagaCheck.TabIndex = 4;
            this.prtljagaCheck.Text = "Prtljaga?";
            this.prtljagaCheck.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(227, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ispisi kartu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ispisBox);
            this.groupBox2.Location = new System.Drawing.Point(13, 192);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(340, 173);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ispis karte:";
            // 
            // ispisBox
            // 
            this.ispisBox.Enabled = false;
            this.ispisBox.Location = new System.Drawing.Point(10, 22);
            this.ispisBox.Multiline = true;
            this.ispisBox.Name = "ispisBox";
            this.ispisBox.Size = new System.Drawing.Size(324, 146);
            this.ispisBox.TabIndex = 0;
            // 
            // KupiKartu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 372);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "KupiKartu";
            this.Text = "KupiKartu";
            this.Load += new System.EventHandler(this.KupiKartu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox prtljagaCheck;
        private System.Windows.Forms.CheckBox povratnaCheck;
        private System.Windows.Forms.ComboBox vrstaKarteCombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox ispisBox;
    }
}