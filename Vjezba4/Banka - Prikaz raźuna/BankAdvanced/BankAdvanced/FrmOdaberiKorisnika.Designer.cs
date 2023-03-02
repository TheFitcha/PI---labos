namespace BankAdvanced
{
    partial class FrmOdaberiKorisnika
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
            this.korisniciDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.izlazButton = new System.Windows.Forms.Button();
            this.odaberiButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.korisniciDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // korisniciDataGridView
            // 
            this.korisniciDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.korisniciDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.korisniciDataGridView.Location = new System.Drawing.Point(9, 21);
            this.korisniciDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.korisniciDataGridView.Name = "korisniciDataGridView";
            this.korisniciDataGridView.RowHeadersVisible = false;
            this.korisniciDataGridView.RowTemplate.Height = 24;
            this.korisniciDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.korisniciDataGridView.Size = new System.Drawing.Size(367, 141);
            this.korisniciDataGridView.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Popis korisnika:";
            // 
            // izlazButton
            // 
            this.izlazButton.Location = new System.Drawing.Point(308, 167);
            this.izlazButton.Margin = new System.Windows.Forms.Padding(2);
            this.izlazButton.Name = "izlazButton";
            this.izlazButton.Size = new System.Drawing.Size(68, 30);
            this.izlazButton.TabIndex = 7;
            this.izlazButton.Text = "Izlaz";
            this.izlazButton.UseVisualStyleBackColor = true;
            this.izlazButton.Click += new System.EventHandler(this.izlazButton_Click);
            // 
            // odaberiButton
            // 
            this.odaberiButton.Location = new System.Drawing.Point(236, 167);
            this.odaberiButton.Margin = new System.Windows.Forms.Padding(2);
            this.odaberiButton.Name = "odaberiButton";
            this.odaberiButton.Size = new System.Drawing.Size(68, 30);
            this.odaberiButton.TabIndex = 6;
            this.odaberiButton.Text = "Odaberi";
            this.odaberiButton.UseVisualStyleBackColor = true;
            this.odaberiButton.Click += new System.EventHandler(this.odaberiButton_Click);
            // 
            // FrmOdaberiKorisnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 209);
            this.Controls.Add(this.izlazButton);
            this.Controls.Add(this.odaberiButton);
            this.Controls.Add(this.korisniciDataGridView);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmOdaberiKorisnika";
            this.Text = "Odaberi korisnika";
            this.Load += new System.EventHandler(this.FrmOdaberiKorisnika_Load);
            ((System.ComponentModel.ISupportInitialize)(this.korisniciDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView korisniciDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button izlazButton;
        private System.Windows.Forms.Button odaberiButton;
    }
}