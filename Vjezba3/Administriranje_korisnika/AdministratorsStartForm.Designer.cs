namespace Administriranje_korisnika
{
    partial class AdministratorsStartForm
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
            this.usersDataGrid = new System.Windows.Forms.DataGridView();
            this.activateBtn = new System.Windows.Forms.Button();
            this.deactivateBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Users:";
            // 
            // usersDataGrid
            // 
            this.usersDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersDataGrid.Location = new System.Drawing.Point(15, 25);
            this.usersDataGrid.Name = "usersDataGrid";
            this.usersDataGrid.Size = new System.Drawing.Size(603, 233);
            this.usersDataGrid.TabIndex = 1;
            this.usersDataGrid.SelectionChanged += new System.EventHandler(this.usersDataGrid_SelectionChanged);
            // 
            // activateBtn
            // 
            this.activateBtn.Location = new System.Drawing.Point(15, 264);
            this.activateBtn.Name = "activateBtn";
            this.activateBtn.Size = new System.Drawing.Size(80, 50);
            this.activateBtn.TabIndex = 2;
            this.activateBtn.Text = "Activate User";
            this.activateBtn.UseVisualStyleBackColor = true;
            this.activateBtn.Click += new System.EventHandler(this.activateBtn_Click);
            // 
            // deactivateBtn
            // 
            this.deactivateBtn.Location = new System.Drawing.Point(101, 264);
            this.deactivateBtn.Name = "deactivateBtn";
            this.deactivateBtn.Size = new System.Drawing.Size(80, 50);
            this.deactivateBtn.TabIndex = 3;
            this.deactivateBtn.Text = "Deactivate User";
            this.deactivateBtn.UseVisualStyleBackColor = true;
            this.deactivateBtn.Click += new System.EventHandler(this.deactivateBtn_Click);
            // 
            // AdministratorsStartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 326);
            this.Controls.Add(this.deactivateBtn);
            this.Controls.Add(this.activateBtn);
            this.Controls.Add(this.usersDataGrid);
            this.Controls.Add(this.label1);
            this.Name = "AdministratorsStartForm";
            this.Text = "AdministratorsStartForm";
            this.Load += new System.EventHandler(this.AdministratorsStartForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView usersDataGrid;
        private System.Windows.Forms.Button activateBtn;
        private System.Windows.Forms.Button deactivateBtn;
    }
}