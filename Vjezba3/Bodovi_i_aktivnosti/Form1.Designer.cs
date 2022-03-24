namespace Bodovi_i_aktivnosti
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.popisStudDataGrid = new System.Windows.Forms.DataGridView();
            this.provjereCombo = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dodajBtn = new System.Windows.Forms.Button();
            this.imePrezimeStudBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dodajProvjeruBtn = new System.Windows.Forms.Button();
            this.moguciBodoviBox = new System.Windows.Forms.TextBox();
            this.nazivProvjereBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ocijeniStudentaBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.popisStudDataGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(496, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Popis provjera (ComboBox)";
            // 
            // popisStudDataGrid
            // 
            this.popisStudDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.popisStudDataGrid.Location = new System.Drawing.Point(15, 28);
            this.popisStudDataGrid.Name = "popisStudDataGrid";
            this.popisStudDataGrid.RowTemplate.Height = 24;
            this.popisStudDataGrid.Size = new System.Drawing.Size(444, 197);
            this.popisStudDataGrid.TabIndex = 2;
            this.popisStudDataGrid.SelectionChanged += new System.EventHandler(this.popisStudDataGrid_SelectionChanged);
            // 
            // provjereCombo
            // 
            this.provjereCombo.FormattingEnabled = true;
            this.provjereCombo.Location = new System.Drawing.Point(499, 28);
            this.provjereCombo.Name = "provjereCombo";
            this.provjereCombo.Size = new System.Drawing.Size(209, 24);
            this.provjereCombo.TabIndex = 3;
            this.provjereCombo.SelectedIndexChanged += new System.EventHandler(this.provjereCombo_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dodajBtn);
            this.groupBox1.Controls.Add(this.imePrezimeStudBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(15, 232);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 74);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodavanje novog studenta";
            // 
            // dodajBtn
            // 
            this.dodajBtn.Location = new System.Drawing.Point(334, 26);
            this.dodajBtn.Name = "dodajBtn";
            this.dodajBtn.Size = new System.Drawing.Size(92, 34);
            this.dodajBtn.TabIndex = 2;
            this.dodajBtn.Text = "Dodaj";
            this.dodajBtn.UseVisualStyleBackColor = true;
            this.dodajBtn.Click += new System.EventHandler(this.dodajBtn_Click);
            // 
            // imePrezimeStudBox
            // 
            this.imePrezimeStudBox.Location = new System.Drawing.Point(108, 32);
            this.imePrezimeStudBox.Name = "imePrezimeStudBox";
            this.imePrezimeStudBox.Size = new System.Drawing.Size(220, 22);
            this.imePrezimeStudBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ime i prezime";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dodajProvjeruBtn);
            this.groupBox2.Controls.Add(this.moguciBodoviBox);
            this.groupBox2.Controls.Add(this.nazivProvjereBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(499, 107);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 199);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dodavanje nove provjere";
            // 
            // dodajProvjeruBtn
            // 
            this.dodajProvjeruBtn.Location = new System.Drawing.Point(84, 157);
            this.dodajProvjeruBtn.Name = "dodajProvjeruBtn";
            this.dodajProvjeruBtn.Size = new System.Drawing.Size(110, 36);
            this.dodajProvjeruBtn.TabIndex = 4;
            this.dodajProvjeruBtn.Text = "Dodaj provjeru";
            this.dodajProvjeruBtn.UseVisualStyleBackColor = true;
            this.dodajProvjeruBtn.Click += new System.EventHandler(this.dodajProvjeruBtn_Click);
            // 
            // moguciBodoviBox
            // 
            this.moguciBodoviBox.Location = new System.Drawing.Point(9, 111);
            this.moguciBodoviBox.Name = "moguciBodoviBox";
            this.moguciBodoviBox.Size = new System.Drawing.Size(172, 22);
            this.moguciBodoviBox.TabIndex = 3;
            // 
            // nazivProvjereBox
            // 
            this.nazivProvjereBox.Location = new System.Drawing.Point(9, 51);
            this.nazivProvjereBox.Name = "nazivProvjereBox";
            this.nazivProvjereBox.Size = new System.Drawing.Size(172, 22);
            this.nazivProvjereBox.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Mogući bodovi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Naziv provjere";
            // 
            // ocijeniStudentaBtn
            // 
            this.ocijeniStudentaBtn.Location = new System.Drawing.Point(559, 346);
            this.ocijeniStudentaBtn.Name = "ocijeniStudentaBtn";
            this.ocijeniStudentaBtn.Size = new System.Drawing.Size(140, 23);
            this.ocijeniStudentaBtn.TabIndex = 6;
            this.ocijeniStudentaBtn.Text = "Ocijeni studenta";
            this.ocijeniStudentaBtn.UseVisualStyleBackColor = true;
            this.ocijeniStudentaBtn.Click += new System.EventHandler(this.ocijeniStudentaBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 381);
            this.Controls.Add(this.ocijeniStudentaBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.provjereCombo);
            this.Controls.Add(this.popisStudDataGrid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.popisStudDataGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView popisStudDataGrid;
        private System.Windows.Forms.ComboBox provjereCombo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button dodajBtn;
        private System.Windows.Forms.TextBox imePrezimeStudBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button dodajProvjeruBtn;
        private System.Windows.Forms.TextBox moguciBodoviBox;
        private System.Windows.Forms.TextBox nazivProvjereBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ocijeniStudentaBtn;
    }
}

