
namespace BankAdvanced
{
    partial class FrmPopisValuta
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
            this.ValuteDataGridView = new System.Windows.Forms.DataGridView();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.btnDodajValutu = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtZemljaValute = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOznakaValute = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ValuteDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ValuteDataGridView
            // 
            this.ValuteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ValuteDataGridView.Location = new System.Drawing.Point(12, 12);
            this.ValuteDataGridView.Name = "ValuteDataGridView";
            this.ValuteDataGridView.Size = new System.Drawing.Size(264, 277);
            this.ValuteDataGridView.TabIndex = 0;
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.Location = new System.Drawing.Point(201, 295);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(75, 23);
            this.btnIzlaz.TabIndex = 1;
            this.btnIzlaz.Text = "Izlaz";
            this.btnIzlaz.UseVisualStyleBackColor = true;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // btnDodajValutu
            // 
            this.btnDodajValutu.Location = new System.Drawing.Point(90, 71);
            this.btnDodajValutu.Name = "btnDodajValutu";
            this.btnDodajValutu.Size = new System.Drawing.Size(75, 23);
            this.btnDodajValutu.TabIndex = 2;
            this.btnDodajValutu.Text = "Dodaj valutu";
            this.btnDodajValutu.UseVisualStyleBackColor = true;
            this.btnDodajValutu.Click += new System.EventHandler(this.btnDodajValutu_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnDodajValutu);
            this.groupBox1.Controls.Add(this.txtOznakaValute);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtZemljaValute);
            this.groupBox1.Location = new System.Drawing.Point(282, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(188, 105);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Podaci o valuti";
            // 
            // txtZemljaValute
            // 
            this.txtZemljaValute.Location = new System.Drawing.Point(65, 19);
            this.txtZemljaValute.Name = "txtZemljaValute";
            this.txtZemljaValute.Size = new System.Drawing.Size(100, 20);
            this.txtZemljaValute.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Zemlja:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Oznaka:";
            // 
            // txtOznakaValute
            // 
            this.txtOznakaValute.Location = new System.Drawing.Point(65, 45);
            this.txtOznakaValute.Name = "txtOznakaValute";
            this.txtOznakaValute.Size = new System.Drawing.Size(100, 20);
            this.txtOznakaValute.TabIndex = 6;
            // 
            // PopisValutaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 330);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.ValuteDataGridView);
            this.Name = "PopisValutaForm";
            this.Text = "Popis valuta";
            this.Load += new System.EventHandler(this.FrmPopisValuta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ValuteDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ValuteDataGridView;
        private System.Windows.Forms.Button btnIzlaz;
        private System.Windows.Forms.Button btnDodajValutu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtZemljaValute;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOznakaValute;
    }
}