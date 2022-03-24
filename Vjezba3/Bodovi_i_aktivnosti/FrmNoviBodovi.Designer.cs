namespace Bodovi_i_aktivnosti
{
    partial class FrmNoviBodovi
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
            this.imeStudentaLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nazProvLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.brBodTextBox = new System.Windows.Forms.TextBox();
            this.maxBrBodLbl = new System.Windows.Forms.Label();
            this.odustaniBtn = new System.Windows.Forms.Button();
            this.pohraniBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student:";
            // 
            // imeStudentaLbl
            // 
            this.imeStudentaLbl.AutoSize = true;
            this.imeStudentaLbl.Location = new System.Drawing.Point(84, 9);
            this.imeStudentaLbl.Name = "imeStudentaLbl";
            this.imeStudentaLbl.Size = new System.Drawing.Size(84, 16);
            this.imeStudentaLbl.TabIndex = 1;
            this.imeStudentaLbl.Text = "ime_prezime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Provjera:";
            // 
            // nazProvLbl
            // 
            this.nazProvLbl.AutoSize = true;
            this.nazProvLbl.Location = new System.Drawing.Point(84, 42);
            this.nazProvLbl.Name = "nazProvLbl";
            this.nazProvLbl.Size = new System.Drawing.Size(94, 16);
            this.nazProvLbl.TabIndex = 3;
            this.nazProvLbl.Text = "Naziv provjere";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Bodovi:";
            // 
            // brBodTextBox
            // 
            this.brBodTextBox.Location = new System.Drawing.Point(87, 74);
            this.brBodTextBox.Name = "brBodTextBox";
            this.brBodTextBox.Size = new System.Drawing.Size(35, 22);
            this.brBodTextBox.TabIndex = 5;
            // 
            // maxBrBodLbl
            // 
            this.maxBrBodLbl.AutoSize = true;
            this.maxBrBodLbl.Location = new System.Drawing.Point(128, 77);
            this.maxBrBodLbl.Name = "maxBrBodLbl";
            this.maxBrBodLbl.Size = new System.Drawing.Size(57, 16);
            this.maxBrBodLbl.TabIndex = 6;
            this.maxBrBodLbl.Text = "/ br_bod";
            // 
            // odustaniBtn
            // 
            this.odustaniBtn.Location = new System.Drawing.Point(111, 161);
            this.odustaniBtn.Name = "odustaniBtn";
            this.odustaniBtn.Size = new System.Drawing.Size(103, 23);
            this.odustaniBtn.TabIndex = 7;
            this.odustaniBtn.Text = "Odustani";
            this.odustaniBtn.UseVisualStyleBackColor = true;
            this.odustaniBtn.Click += new System.EventHandler(this.odustaniBtn_Click);
            // 
            // pohraniBtn
            // 
            this.pohraniBtn.Location = new System.Drawing.Point(230, 161);
            this.pohraniBtn.Name = "pohraniBtn";
            this.pohraniBtn.Size = new System.Drawing.Size(103, 23);
            this.pohraniBtn.TabIndex = 8;
            this.pohraniBtn.Text = "Pohani";
            this.pohraniBtn.UseVisualStyleBackColor = true;
            this.pohraniBtn.Click += new System.EventHandler(this.pohraniBtn_Click);
            // 
            // FrmNoviBodovi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 196);
            this.Controls.Add(this.pohraniBtn);
            this.Controls.Add(this.odustaniBtn);
            this.Controls.Add(this.maxBrBodLbl);
            this.Controls.Add(this.brBodTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nazProvLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.imeStudentaLbl);
            this.Controls.Add(this.label1);
            this.Name = "FrmNoviBodovi";
            this.Text = "FrmNoviBodovi";
            this.Load += new System.EventHandler(this.FrmNoviBodovi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label imeStudentaLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label nazProvLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox brBodTextBox;
        private System.Windows.Forms.Label maxBrBodLbl;
        private System.Windows.Forms.Button odustaniBtn;
        private System.Windows.Forms.Button pohraniBtn;
    }
}