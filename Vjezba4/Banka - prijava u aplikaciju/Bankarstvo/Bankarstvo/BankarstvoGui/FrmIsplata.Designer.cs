namespace BankarstvoGui
{
    partial class FrmIsplata
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
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnProvedi = new System.Windows.Forms.Button();
            this.txtIznos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrimatelj = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPlatitelj = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(185, 90);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 15;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnProvedi
            // 
            this.btnProvedi.Location = new System.Drawing.Point(104, 90);
            this.btnProvedi.Name = "btnProvedi";
            this.btnProvedi.Size = new System.Drawing.Size(75, 23);
            this.btnProvedi.TabIndex = 14;
            this.btnProvedi.Text = "Provedi";
            this.btnProvedi.UseVisualStyleBackColor = true;
            this.btnProvedi.Click += new System.EventHandler(this.btnProvedi_Click);
            // 
            // txtIznos
            // 
            this.txtIznos.Location = new System.Drawing.Point(171, 64);
            this.txtIznos.Name = "txtIznos";
            this.txtIznos.Size = new System.Drawing.Size(90, 20);
            this.txtIznos.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Iznos:";
            // 
            // txtPrimatelj
            // 
            this.txtPrimatelj.Location = new System.Drawing.Point(115, 38);
            this.txtPrimatelj.Name = "txtPrimatelj";
            this.txtPrimatelj.Size = new System.Drawing.Size(146, 20);
            this.txtPrimatelj.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Račun primatelj:";
            // 
            // txtPlatitelj
            // 
            this.txtPlatitelj.Enabled = false;
            this.txtPlatitelj.Location = new System.Drawing.Point(115, 12);
            this.txtPlatitelj.Name = "txtPlatitelj";
            this.txtPlatitelj.Size = new System.Drawing.Size(146, 20);
            this.txtPlatitelj.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Račun platitelj:";
            // 
            // FrmIsplata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 129);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnProvedi);
            this.Controls.Add(this.txtIznos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrimatelj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPlatitelj);
            this.Controls.Add(this.label1);
            this.Name = "FrmIsplata";
            this.Text = "FrmIsplata";
            this.Load += new System.EventHandler(this.FrmIsplata_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnProvedi;
        private System.Windows.Forms.TextBox txtIznos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrimatelj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPlatitelj;
        private System.Windows.Forms.Label label1;
    }
}