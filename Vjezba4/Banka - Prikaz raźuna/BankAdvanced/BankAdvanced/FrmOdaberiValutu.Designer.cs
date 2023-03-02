namespace BankAdvanced
{
    partial class FrmOdaberiValutu
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
            this.valuteDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.izlazButton = new System.Windows.Forms.Button();
            this.odaberiButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.valuteDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // valuteDataGridView
            // 
            this.valuteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.valuteDataGridView.Location = new System.Drawing.Point(15, 29);
            this.valuteDataGridView.Name = "valuteDataGridView";
            this.valuteDataGridView.RowTemplate.Height = 24;
            this.valuteDataGridView.Size = new System.Drawing.Size(390, 168);
            this.valuteDataGridView.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Popis valuta";
            // 
            // izlazButton
            // 
            this.izlazButton.Location = new System.Drawing.Point(316, 203);
            this.izlazButton.Name = "izlazButton";
            this.izlazButton.Size = new System.Drawing.Size(90, 37);
            this.izlazButton.TabIndex = 9;
            this.izlazButton.Text = "Izlaz";
            this.izlazButton.UseVisualStyleBackColor = true;
            this.izlazButton.Click += new System.EventHandler(this.izlazButton_Click);
            // 
            // odaberiButton
            // 
            this.odaberiButton.Location = new System.Drawing.Point(220, 203);
            this.odaberiButton.Name = "odaberiButton";
            this.odaberiButton.Size = new System.Drawing.Size(90, 37);
            this.odaberiButton.TabIndex = 8;
            this.odaberiButton.Text = "Odaberi";
            this.odaberiButton.UseVisualStyleBackColor = true;
            this.odaberiButton.Click += new System.EventHandler(this.odaberiButton_Click);
            // 
            // OdaberiValutuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 252);
            this.Controls.Add(this.izlazButton);
            this.Controls.Add(this.odaberiButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.valuteDataGridView);
            this.Name = "OdaberiValutuForm";
            this.Text = "Odaberi valutu";
            this.Load += new System.EventHandler(this.FrmOdaberiValutu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.valuteDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView valuteDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button izlazButton;
        private System.Windows.Forms.Button odaberiButton;
    }
}