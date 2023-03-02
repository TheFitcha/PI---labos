namespace BankarstvoGui
{
    partial class FrmUplata
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
            this.txtPlatitelj = new System.Windows.Forms.TextBox();
            this.txtPrimatelj = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIznos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnProvedi = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Račun platitelj:";
            // 
            // txtPlatitelj
            // 
            this.txtPlatitelj.Location = new System.Drawing.Point(106, 12);
            this.txtPlatitelj.Name = "txtPlatitelj";
            this.txtPlatitelj.Size = new System.Drawing.Size(146, 20);
            this.txtPlatitelj.TabIndex = 1;
            // 
            // txtPrimatelj
            // 
            this.txtPrimatelj.Enabled = false;
            this.txtPrimatelj.Location = new System.Drawing.Point(106, 38);
            this.txtPrimatelj.Name = "txtPrimatelj";
            this.txtPrimatelj.Size = new System.Drawing.Size(146, 20);
            this.txtPrimatelj.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Račun primatelj:";
            // 
            // txtIznos
            // 
            this.txtIznos.Location = new System.Drawing.Point(162, 64);
            this.txtIznos.Name = "txtIznos";
            this.txtIznos.Size = new System.Drawing.Size(90, 20);
            this.txtIznos.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Iznos:";
            // 
            // btnProvedi
            // 
            this.btnProvedi.Location = new System.Drawing.Point(95, 90);
            this.btnProvedi.Name = "btnProvedi";
            this.btnProvedi.Size = new System.Drawing.Size(75, 23);
            this.btnProvedi.TabIndex = 6;
            this.btnProvedi.Text = "Provedi";
            this.btnProvedi.UseVisualStyleBackColor = true;
            this.btnProvedi.Click += new System.EventHandler(this.btnProvedi_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(176, 90);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 7;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // FrmUplata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 132);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnProvedi);
            this.Controls.Add(this.txtIznos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrimatelj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPlatitelj);
            this.Controls.Add(this.label1);
            this.Name = "FrmUplata";
            this.Text = "Uplata";
            this.Load += new System.EventHandler(this.FrmUplata_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPlatitelj;
        private System.Windows.Forms.TextBox txtPrimatelj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIznos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnProvedi;
        private System.Windows.Forms.Button btnOdustani;
    }
}