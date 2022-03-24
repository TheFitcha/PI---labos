namespace Filtriranje_transakcija
{
    partial class DetaljiRacuna
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.IBANBox = new System.Windows.Forms.TextBox();
            this.vlasnikBox = new System.Windows.Forms.TextBox();
            this.stanjeBox = new System.Windows.Forms.TextBox();
            this.ukPrometBox = new System.Windows.Forms.TextBox();
            this.closeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "IBAN:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vlasnik:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Stanje:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ukupni promet:";
            // 
            // IBANBox
            // 
            this.IBANBox.Location = new System.Drawing.Point(120, 38);
            this.IBANBox.Name = "IBANBox";
            this.IBANBox.Size = new System.Drawing.Size(145, 22);
            this.IBANBox.TabIndex = 4;
            // 
            // vlasnikBox
            // 
            this.vlasnikBox.Location = new System.Drawing.Point(120, 66);
            this.vlasnikBox.Name = "vlasnikBox";
            this.vlasnikBox.Size = new System.Drawing.Size(145, 22);
            this.vlasnikBox.TabIndex = 5;
            // 
            // stanjeBox
            // 
            this.stanjeBox.Location = new System.Drawing.Point(120, 135);
            this.stanjeBox.Name = "stanjeBox";
            this.stanjeBox.Size = new System.Drawing.Size(145, 22);
            this.stanjeBox.TabIndex = 6;
            // 
            // ukPrometBox
            // 
            this.ukPrometBox.Location = new System.Drawing.Point(120, 168);
            this.ukPrometBox.Name = "ukPrometBox";
            this.ukPrometBox.Size = new System.Drawing.Size(145, 22);
            this.ukPrometBox.TabIndex = 7;
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(190, 196);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 36);
            this.closeBtn.TabIndex = 8;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // DetaljiRacuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 244);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.ukPrometBox);
            this.Controls.Add(this.stanjeBox);
            this.Controls.Add(this.vlasnikBox);
            this.Controls.Add(this.IBANBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DetaljiRacuna";
            this.Text = "DetaljiRacuna";
            this.Load += new System.EventHandler(this.DetaljiRacuna_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox IBANBox;
        private System.Windows.Forms.TextBox vlasnikBox;
        private System.Windows.Forms.TextBox stanjeBox;
        private System.Windows.Forms.TextBox ukPrometBox;
        private System.Windows.Forms.Button closeBtn;
    }
}