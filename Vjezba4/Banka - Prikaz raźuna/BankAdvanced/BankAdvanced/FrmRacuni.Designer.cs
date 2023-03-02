namespace BankAdvanced
{
    partial class FrmRacuni
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
            this.racuniDataGridView = new System.Windows.Forms.DataGridView();
            this.btnPrikaziTransakcije = new System.Windows.Forms.Button();
            this.btnNoviTekuciRacun = new System.Windows.Forms.Button();
            this.btnNoviDevizniRacun = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.racuniDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Popis računa:";
            // 
            // racuniDataGridView
            // 
            this.racuniDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.racuniDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.racuniDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.racuniDataGridView.Location = new System.Drawing.Point(9, 24);
            this.racuniDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.racuniDataGridView.Name = "racuniDataGridView";
            this.racuniDataGridView.RowHeadersVisible = false;
            this.racuniDataGridView.RowTemplate.Height = 24;
            this.racuniDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.racuniDataGridView.Size = new System.Drawing.Size(773, 318);
            this.racuniDataGridView.TabIndex = 1;
            // 
            // btnPrikaziTransakcije
            // 
            this.btnPrikaziTransakcije.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrikaziTransakcije.Location = new System.Drawing.Point(662, 346);
            this.btnPrikaziTransakcije.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrikaziTransakcije.Name = "btnPrikaziTransakcije";
            this.btnPrikaziTransakcije.Size = new System.Drawing.Size(121, 28);
            this.btnPrikaziTransakcije.TabIndex = 2;
            this.btnPrikaziTransakcije.Text = "Prikaži transakcije";
            this.btnPrikaziTransakcije.UseVisualStyleBackColor = true;
            this.btnPrikaziTransakcije.Click += new System.EventHandler(this.btnPrikaziTransakcije_Click);
            // 
            // btnNoviTekuciRacun
            // 
            this.btnNoviTekuciRacun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNoviTekuciRacun.Location = new System.Drawing.Point(9, 346);
            this.btnNoviTekuciRacun.Margin = new System.Windows.Forms.Padding(2);
            this.btnNoviTekuciRacun.Name = "btnNoviTekuciRacun";
            this.btnNoviTekuciRacun.Size = new System.Drawing.Size(121, 28);
            this.btnNoviTekuciRacun.TabIndex = 3;
            this.btnNoviTekuciRacun.Text = "Novi tekući račun";
            this.btnNoviTekuciRacun.UseVisualStyleBackColor = true;
            this.btnNoviTekuciRacun.Click += new System.EventHandler(this.btnNoviTekuciRacun_Click);
            // 
            // btnNoviDevizniRacun
            // 
            this.btnNoviDevizniRacun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNoviDevizniRacun.Location = new System.Drawing.Point(134, 346);
            this.btnNoviDevizniRacun.Margin = new System.Windows.Forms.Padding(2);
            this.btnNoviDevizniRacun.Name = "btnNoviDevizniRacun";
            this.btnNoviDevizniRacun.Size = new System.Drawing.Size(121, 28);
            this.btnNoviDevizniRacun.TabIndex = 4;
            this.btnNoviDevizniRacun.Text = "Novi devizni račun";
            this.btnNoviDevizniRacun.UseVisualStyleBackColor = true;
            this.btnNoviDevizniRacun.Click += new System.EventHandler(this.btnNoviDevizniRacun_Click);
            // 
            // FrmRacuni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 384);
            this.Controls.Add(this.btnNoviDevizniRacun);
            this.Controls.Add(this.btnNoviTekuciRacun);
            this.Controls.Add(this.btnPrikaziTransakcije);
            this.Controls.Add(this.racuniDataGridView);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmRacuni";
            this.Text = "Računi";
            this.Load += new System.EventHandler(this.RacuniForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.racuniDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView racuniDataGridView;
        private System.Windows.Forms.Button btnPrikaziTransakcije;
        private System.Windows.Forms.Button btnNoviTekuciRacun;
        private System.Windows.Forms.Button btnNoviDevizniRacun;
    }
}