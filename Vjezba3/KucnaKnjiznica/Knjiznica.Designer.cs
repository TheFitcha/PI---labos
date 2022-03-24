namespace KucnaKnjiznica
{
    partial class Knjige
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
            this.dostupnoDataGrid = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.posudenoDataGrid = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dostupnoDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posudenoDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dostupne knjige:";
            // 
            // dostupnoDataGrid
            // 
            this.dostupnoDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dostupnoDataGrid.Location = new System.Drawing.Point(21, 37);
            this.dostupnoDataGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dostupnoDataGrid.Name = "dostupnoDataGrid";
            this.dostupnoDataGrid.RowHeadersWidth = 51;
            this.dostupnoDataGrid.Size = new System.Drawing.Size(523, 185);
            this.dostupnoDataGrid.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(443, 230);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "Posudi knjigu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // posudenoDataGrid
            // 
            this.posudenoDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.posudenoDataGrid.Location = new System.Drawing.Point(21, 277);
            this.posudenoDataGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.posudenoDataGrid.Name = "posudenoDataGrid";
            this.posudenoDataGrid.RowHeadersWidth = 51;
            this.posudenoDataGrid.Size = new System.Drawing.Size(523, 185);
            this.posudenoDataGrid.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(444, 469);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 4;
            this.button2.Text = "Vrati knjigu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Knjige
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 527);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.posudenoDataGrid);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dostupnoDataGrid);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Knjige";
            this.Text = "Knjige";
            this.Load += new System.EventHandler(this.Knjige_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dostupnoDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posudenoDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dostupnoDataGrid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView posudenoDataGrid;
        private System.Windows.Forms.Button button2;
    }
}

