namespace Prijevodi
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
            this.ishodisniJezici = new System.Windows.Forms.DataGridView();
            this.odredisniJezici = new System.Windows.Forms.DataGridView();
            this.recenicaZaPrijevodText = new System.Windows.Forms.TextBox();
            this.prevediBtn = new System.Windows.Forms.Button();
            this.prijevodTextBox = new System.Windows.Forms.TextBox();
            this.novaRijecText = new System.Windows.Forms.TextBox();
            this.dodajRijecBtn = new System.Windows.Forms.Button();
            this.popisRijecBtn = new System.Windows.Forms.Button();
            this.prijevodNoveRijeciText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ishodisniJezici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.odredisniJezici)).BeginInit();
            this.SuspendLayout();
            // 
            // ishodisniJezici
            // 
            this.ishodisniJezici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ishodisniJezici.Location = new System.Drawing.Point(13, 13);
            this.ishodisniJezici.Name = "ishodisniJezici";
            this.ishodisniJezici.RowHeadersWidth = 51;
            this.ishodisniJezici.RowTemplate.Height = 24;
            this.ishodisniJezici.Size = new System.Drawing.Size(240, 265);
            this.ishodisniJezici.TabIndex = 0;
            // 
            // odredisniJezici
            // 
            this.odredisniJezici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.odredisniJezici.Location = new System.Drawing.Point(279, 13);
            this.odredisniJezici.Name = "odredisniJezici";
            this.odredisniJezici.RowHeadersWidth = 51;
            this.odredisniJezici.RowTemplate.Height = 24;
            this.odredisniJezici.Size = new System.Drawing.Size(240, 265);
            this.odredisniJezici.TabIndex = 1;
            // 
            // recenicaZaPrijevodText
            // 
            this.recenicaZaPrijevodText.Location = new System.Drawing.Point(13, 285);
            this.recenicaZaPrijevodText.Name = "recenicaZaPrijevodText";
            this.recenicaZaPrijevodText.Size = new System.Drawing.Size(506, 22);
            this.recenicaZaPrijevodText.TabIndex = 2;
            // 
            // prevediBtn
            // 
            this.prevediBtn.Location = new System.Drawing.Point(525, 285);
            this.prevediBtn.Name = "prevediBtn";
            this.prevediBtn.Size = new System.Drawing.Size(156, 23);
            this.prevediBtn.TabIndex = 3;
            this.prevediBtn.Text = "Prevedi";
            this.prevediBtn.UseVisualStyleBackColor = true;
            this.prevediBtn.Click += new System.EventHandler(this.prevediBtn_Click);
            // 
            // prijevodTextBox
            // 
            this.prijevodTextBox.Enabled = false;
            this.prijevodTextBox.Location = new System.Drawing.Point(12, 329);
            this.prijevodTextBox.Name = "prijevodTextBox";
            this.prijevodTextBox.Size = new System.Drawing.Size(669, 22);
            this.prijevodTextBox.TabIndex = 4;
            // 
            // novaRijecText
            // 
            this.novaRijecText.Location = new System.Drawing.Point(526, 13);
            this.novaRijecText.Name = "novaRijecText";
            this.novaRijecText.Size = new System.Drawing.Size(155, 22);
            this.novaRijecText.TabIndex = 5;
            // 
            // dodajRijecBtn
            // 
            this.dodajRijecBtn.Location = new System.Drawing.Point(525, 84);
            this.dodajRijecBtn.Name = "dodajRijecBtn";
            this.dodajRijecBtn.Size = new System.Drawing.Size(155, 23);
            this.dodajRijecBtn.TabIndex = 6;
            this.dodajRijecBtn.Text = "Dodaj novu rijec";
            this.dodajRijecBtn.UseVisualStyleBackColor = true;
            this.dodajRijecBtn.Click += new System.EventHandler(this.dodajRijecBtn_Click);
            // 
            // popisRijecBtn
            // 
            this.popisRijecBtn.Location = new System.Drawing.Point(525, 113);
            this.popisRijecBtn.Name = "popisRijecBtn";
            this.popisRijecBtn.Size = new System.Drawing.Size(155, 23);
            this.popisRijecBtn.TabIndex = 7;
            this.popisRijecBtn.Text = "Popis rijeci";
            this.popisRijecBtn.UseVisualStyleBackColor = true;
            this.popisRijecBtn.Click += new System.EventHandler(this.popisRijecBtn_Click);
            // 
            // prijevodNoveRijeciText
            // 
            this.prijevodNoveRijeciText.Location = new System.Drawing.Point(525, 56);
            this.prijevodNoveRijeciText.Name = "prijevodNoveRijeciText";
            this.prijevodNoveRijeciText.Size = new System.Drawing.Size(155, 22);
            this.prijevodNoveRijeciText.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 363);
            this.Controls.Add(this.prijevodNoveRijeciText);
            this.Controls.Add(this.popisRijecBtn);
            this.Controls.Add(this.dodajRijecBtn);
            this.Controls.Add(this.novaRijecText);
            this.Controls.Add(this.prijevodTextBox);
            this.Controls.Add(this.prevediBtn);
            this.Controls.Add(this.recenicaZaPrijevodText);
            this.Controls.Add(this.odredisniJezici);
            this.Controls.Add(this.ishodisniJezici);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ishodisniJezici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.odredisniJezici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ishodisniJezici;
        private System.Windows.Forms.DataGridView odredisniJezici;
        private System.Windows.Forms.TextBox recenicaZaPrijevodText;
        private System.Windows.Forms.Button prevediBtn;
        private System.Windows.Forms.TextBox prijevodTextBox;
        private System.Windows.Forms.TextBox novaRijecText;
        private System.Windows.Forms.Button dodajRijecBtn;
        private System.Windows.Forms.Button popisRijecBtn;
        private System.Windows.Forms.TextBox prijevodNoveRijeciText;
    }
}

