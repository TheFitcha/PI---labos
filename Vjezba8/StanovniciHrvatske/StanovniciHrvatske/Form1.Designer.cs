namespace StanovniciHrvatske
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAddSensor = new System.Windows.Forms.Button();
            this.btnAssign = new System.Windows.Forms.Button();
            this.btnDeleteSensor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(661, 329);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnAddSensor
            // 
            this.btnAddSensor.Location = new System.Drawing.Point(363, 347);
            this.btnAddSensor.Name = "btnAddSensor";
            this.btnAddSensor.Size = new System.Drawing.Size(75, 23);
            this.btnAddSensor.TabIndex = 1;
            this.btnAddSensor.Text = "Add sensor";
            this.btnAddSensor.UseVisualStyleBackColor = true;
            this.btnAddSensor.Click += new System.EventHandler(this.btnAddSensor_Click);
            // 
            // btnAssign
            // 
            this.btnAssign.Location = new System.Drawing.Point(444, 347);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(136, 23);
            this.btnAssign.TabIndex = 2;
            this.btnAssign.Text = "Assign measurement unit";
            this.btnAssign.UseVisualStyleBackColor = true;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // btnDeleteSensor
            // 
            this.btnDeleteSensor.Location = new System.Drawing.Point(586, 347);
            this.btnDeleteSensor.Name = "btnDeleteSensor";
            this.btnDeleteSensor.Size = new System.Drawing.Size(87, 23);
            this.btnDeleteSensor.TabIndex = 3;
            this.btnDeleteSensor.Text = "Delete sensor";
            this.btnDeleteSensor.UseVisualStyleBackColor = true;
            this.btnDeleteSensor.Click += new System.EventHandler(this.btnDeleteSensor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 392);
            this.Controls.Add(this.btnDeleteSensor);
            this.Controls.Add(this.btnAssign);
            this.Controls.Add(this.btnAddSensor);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAddSensor;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.Button btnDeleteSensor;
    }
}

