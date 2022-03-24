namespace Filtriranje_transakcija
{
    partial class PopisTransakcija
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.uplateRadio = new System.Windows.Forms.RadioButton();
            this.isplateRadio = new System.Windows.Forms.RadioButton();
            this.sveCheck = new System.Windows.Forms.RadioButton();
            this.racunCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.racuniDataGrid = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.racuniDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.uplateRadio);
            this.groupBox1.Controls.Add(this.isplateRadio);
            this.groupBox1.Controls.Add(this.sveCheck);
            this.groupBox1.Controls.Add(this.racunCombo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 108);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tip transakcije:";
            // 
            // uplateRadio
            // 
            this.uplateRadio.AutoSize = true;
            this.uplateRadio.Location = new System.Drawing.Point(249, 66);
            this.uplateRadio.Name = "uplateRadio";
            this.uplateRadio.Size = new System.Drawing.Size(65, 20);
            this.uplateRadio.TabIndex = 5;
            this.uplateRadio.Text = "Uplate";
            this.uplateRadio.UseVisualStyleBackColor = true;
            this.uplateRadio.MouseDown += new System.Windows.Forms.MouseEventHandler(this.uplateRadio_MouseDown);
            // 
            // isplateRadio
            // 
            this.isplateRadio.AutoSize = true;
            this.isplateRadio.Location = new System.Drawing.Point(178, 66);
            this.isplateRadio.Name = "isplateRadio";
            this.isplateRadio.Size = new System.Drawing.Size(65, 20);
            this.isplateRadio.TabIndex = 4;
            this.isplateRadio.Text = "Isplate";
            this.isplateRadio.UseVisualStyleBackColor = true;
            this.isplateRadio.MouseDown += new System.Windows.Forms.MouseEventHandler(this.isplateRadio_MouseDown);
            // 
            // sveCheck
            // 
            this.sveCheck.AutoSize = true;
            this.sveCheck.Checked = true;
            this.sveCheck.Location = new System.Drawing.Point(123, 66);
            this.sveCheck.Name = "sveCheck";
            this.sveCheck.Size = new System.Drawing.Size(49, 20);
            this.sveCheck.TabIndex = 3;
            this.sveCheck.TabStop = true;
            this.sveCheck.Text = "Sve";
            this.sveCheck.UseVisualStyleBackColor = true;
            this.sveCheck.MouseDown += new System.Windows.Forms.MouseEventHandler(this.sveCheck_MouseDown);
            // 
            // racunCombo
            // 
            this.racunCombo.FormattingEnabled = true;
            this.racunCombo.Location = new System.Drawing.Point(73, 25);
            this.racunCombo.Name = "racunCombo";
            this.racunCombo.Size = new System.Drawing.Size(121, 24);
            this.racunCombo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Račun:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(333, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 49);
            this.button1.TabIndex = 1;
            this.button1.Text = "Filtriraj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(414, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 49);
            this.button2.TabIndex = 2;
            this.button2.Text = "Očisti";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // racuniDataGrid
            // 
            this.racuniDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.racuniDataGrid.Location = new System.Drawing.Point(12, 127);
            this.racuniDataGrid.Name = "racuniDataGrid";
            this.racuniDataGrid.RowTemplate.Height = 24;
            this.racuniDataGrid.Size = new System.Drawing.Size(498, 113);
            this.racuniDataGrid.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(435, 246);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 49);
            this.button3.TabIndex = 4;
            this.button3.Text = "Detalji računa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // PopisTransakcija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 306);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.racuniDataGrid);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "PopisTransakcija";
            this.Text = "Popis transakcija";
            this.Load += new System.EventHandler(this.PopisTransakcija_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.racuniDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton uplateRadio;
        private System.Windows.Forms.RadioButton isplateRadio;
        private System.Windows.Forms.RadioButton sveCheck;
        private System.Windows.Forms.ComboBox racunCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView racuniDataGrid;
        private System.Windows.Forms.Button button3;
    }
}

