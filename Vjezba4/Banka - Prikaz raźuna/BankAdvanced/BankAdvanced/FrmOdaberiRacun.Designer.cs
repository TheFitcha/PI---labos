namespace BankAdvanced
{
    partial class FrmOdaberiRacun
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
            this.racunDataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.odaberiButton = new System.Windows.Forms.Button();
            this.izlazButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.racunDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // racunDataGridView
            // 
            this.racunDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.racunDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.racunDataGridView.Location = new System.Drawing.Point(15, 30);
            this.racunDataGridView.Name = "racunDataGridView";
            this.racunDataGridView.RowHeadersVisible = false;
            this.racunDataGridView.RowTemplate.Height = 24;
            this.racunDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.racunDataGridView.Size = new System.Drawing.Size(848, 174);
            this.racunDataGridView.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Popis računa:";
            // 
            // odaberiButton
            // 
            this.odaberiButton.Location = new System.Drawing.Point(677, 210);
            this.odaberiButton.Name = "odaberiButton";
            this.odaberiButton.Size = new System.Drawing.Size(90, 37);
            this.odaberiButton.TabIndex = 4;
            this.odaberiButton.Text = "Odaberi";
            this.odaberiButton.UseVisualStyleBackColor = true;
            this.odaberiButton.Click += new System.EventHandler(this.odaberiButton_Click);
            // 
            // izlazButton
            // 
            this.izlazButton.Location = new System.Drawing.Point(773, 210);
            this.izlazButton.Name = "izlazButton";
            this.izlazButton.Size = new System.Drawing.Size(90, 37);
            this.izlazButton.TabIndex = 5;
            this.izlazButton.Text = "Izlaz";
            this.izlazButton.UseVisualStyleBackColor = true;
            this.izlazButton.Click += new System.EventHandler(this.izlazButton_Click);
            // 
            // OdaberiRacunForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 256);
            this.Controls.Add(this.izlazButton);
            this.Controls.Add(this.odaberiButton);
            this.Controls.Add(this.racunDataGridView);
            this.Controls.Add(this.label2);
            this.Name = "OdaberiRacunForm";
            this.Text = "Odaberi račun:";
            this.Load += new System.EventHandler(this.FrmOdaberiRacun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.racunDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView racunDataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button odaberiButton;
        private System.Windows.Forms.Button izlazButton;
    }
}