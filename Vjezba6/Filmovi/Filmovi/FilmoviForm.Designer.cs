namespace Filmovi
{
    partial class FilmoviForm
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
            this.popisFilmovaGridView = new System.Windows.Forms.DataGridView();
            this.pogledaniFilmoviGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.popisFilmovaGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pogledaniFilmoviGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // popisFilmovaGridView
            // 
            this.popisFilmovaGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.popisFilmovaGridView.Location = new System.Drawing.Point(12, 12);
            this.popisFilmovaGridView.Name = "popisFilmovaGridView";
            this.popisFilmovaGridView.Size = new System.Drawing.Size(427, 426);
            this.popisFilmovaGridView.TabIndex = 0;
            // 
            // pogledaniFilmoviGridView
            // 
            this.pogledaniFilmoviGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pogledaniFilmoviGridView.Location = new System.Drawing.Point(446, 12);
            this.pogledaniFilmoviGridView.Name = "pogledaniFilmoviGridView";
            this.pogledaniFilmoviGridView.Size = new System.Drawing.Size(342, 305);
            this.pogledaniFilmoviGridView.TabIndex = 1;
            // 
            // FilmoviForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pogledaniFilmoviGridView);
            this.Controls.Add(this.popisFilmovaGridView);
            this.Name = "FilmoviForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.popisFilmovaGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pogledaniFilmoviGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView popisFilmovaGridView;
        private System.Windows.Forms.DataGridView pogledaniFilmoviGridView;
    }
}

