namespace BankAdvanced
{
    partial class FrmTransakcije
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
            this.transakcijeDataGridView = new System.Windows.Forms.DataGridView();
            this.zatvoriButton = new System.Windows.Forms.Button();
            this.btnNovaTransakcija = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.transakcijeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Popis transakcija:";
            // 
            // transakcijeDataGridView
            // 
            this.transakcijeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transakcijeDataGridView.Location = new System.Drawing.Point(11, 24);
            this.transakcijeDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.transakcijeDataGridView.Name = "transakcijeDataGridView";
            this.transakcijeDataGridView.RowTemplate.Height = 24;
            this.transakcijeDataGridView.Size = new System.Drawing.Size(843, 283);
            this.transakcijeDataGridView.TabIndex = 1;
            // 
            // zatvoriButton
            // 
            this.zatvoriButton.Location = new System.Drawing.Point(779, 311);
            this.zatvoriButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.zatvoriButton.Name = "zatvoriButton";
            this.zatvoriButton.Size = new System.Drawing.Size(75, 28);
            this.zatvoriButton.TabIndex = 2;
            this.zatvoriButton.Text = "Zatvori";
            this.zatvoriButton.UseVisualStyleBackColor = true;
            this.zatvoriButton.Click += new System.EventHandler(this.zatvoriButton_Click);
            // 
            // btnNovaTransakcija
            // 
            this.btnNovaTransakcija.Location = new System.Drawing.Point(12, 314);
            this.btnNovaTransakcija.Margin = new System.Windows.Forms.Padding(2);
            this.btnNovaTransakcija.Name = "btnNovaTransakcija";
            this.btnNovaTransakcija.Size = new System.Drawing.Size(129, 28);
            this.btnNovaTransakcija.TabIndex = 3;
            this.btnNovaTransakcija.Text = "Nova transakcija";
            this.btnNovaTransakcija.UseVisualStyleBackColor = true;
            this.btnNovaTransakcija.Click += new System.EventHandler(this.btnNovaTransakcija_Click);
            // 
            // FrmTransakcije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 353);
            this.Controls.Add(this.btnNovaTransakcija);
            this.Controls.Add(this.zatvoriButton);
            this.Controls.Add(this.transakcijeDataGridView);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmTransakcije";
            this.Text = "Transakcije";
            this.Load += new System.EventHandler(this.FrmTransakcije_Load);
            ((System.ComponentModel.ISupportInitialize)(this.transakcijeDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView transakcijeDataGridView;
        private System.Windows.Forms.Button zatvoriButton;
        private System.Windows.Forms.Button btnNovaTransakcija;
    }
}