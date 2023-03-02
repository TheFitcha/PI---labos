namespace NorthWnd_LINQ
{
    partial class FrmProducts
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
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.btnFilter = new System.Windows.Forms.Button();
            this.cmbFilterOption = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGetSelected = new System.Windows.Forms.Button();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearchByProductName = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbSuppliers = new System.Windows.Forms.ComboBox();
            this.btnSearchBySupplierCountry = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProducts
            // 
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(12, 43);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.Size = new System.Drawing.Size(839, 529);
            this.dgvProducts.TabIndex = 0;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(776, 12);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 23);
            this.btnFilter.TabIndex = 2;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // cmbFilterOption
            // 
            this.cmbFilterOption.FormattingEnabled = true;
            this.cmbFilterOption.Items.AddRange(new object[] {
            "Show all products",
            "Show products with insufficient stock",
            "Sort products by Name",
            "Sort product by Unit price descending",
            "Show all products (less columns) - Anonymous object",
            "Show all products (less columns) - Explicit type"});
            this.cmbFilterOption.Location = new System.Drawing.Point(458, 14);
            this.cmbFilterOption.Name = "cmbFilterOption";
            this.cmbFilterOption.Size = new System.Drawing.Size(312, 21);
            this.cmbFilterOption.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(411, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Option:";
            // 
            // btnGetSelected
            // 
            this.btnGetSelected.Location = new System.Drawing.Point(776, 578);
            this.btnGetSelected.Name = "btnGetSelected";
            this.btnGetSelected.Size = new System.Drawing.Size(75, 23);
            this.btnGetSelected.TabIndex = 5;
            this.btnGetSelected.Text = "Get selected";
            this.btnGetSelected.UseVisualStyleBackColor = true;
            this.btnGetSelected.Click += new System.EventHandler(this.btnGetSelected_Click);
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(12, 599);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(144, 20);
            this.txtProductName.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 583);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Search by Product name:";
            // 
            // btnSearchByProductName
            // 
            this.btnSearchByProductName.Location = new System.Drawing.Point(162, 596);
            this.btnSearchByProductName.Name = "btnSearchByProductName";
            this.btnSearchByProductName.Size = new System.Drawing.Size(159, 23);
            this.btnSearchByProductName.TabIndex = 8;
            this.btnSearchByProductName.Text = "Search by product name";
            this.btnSearchByProductName.UseVisualStyleBackColor = true;
            this.btnSearchByProductName.Click += new System.EventHandler(this.btnSearchByProductName_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 647);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Search by Supplier Country:";
            // 
            // cmbSuppliers
            // 
            this.cmbSuppliers.FormattingEnabled = true;
            this.cmbSuppliers.Location = new System.Drawing.Point(12, 663);
            this.cmbSuppliers.Name = "cmbSuppliers";
            this.cmbSuppliers.Size = new System.Drawing.Size(144, 21);
            this.cmbSuppliers.TabIndex = 10;
            // 
            // btnSearchBySupplierCountry
            // 
            this.btnSearchBySupplierCountry.Location = new System.Drawing.Point(162, 663);
            this.btnSearchBySupplierCountry.Name = "btnSearchBySupplierCountry";
            this.btnSearchBySupplierCountry.Size = new System.Drawing.Size(159, 23);
            this.btnSearchBySupplierCountry.TabIndex = 11;
            this.btnSearchBySupplierCountry.Text = "Search by supplier country";
            this.btnSearchBySupplierCountry.UseVisualStyleBackColor = true;
            this.btnSearchBySupplierCountry.Click += new System.EventHandler(this.btnSearchBySupplierCountry_Click);
            // 
            // FrmProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 728);
            this.Controls.Add(this.btnSearchBySupplierCountry);
            this.Controls.Add(this.cmbSuppliers);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSearchByProductName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.btnGetSelected);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbFilterOption);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.dgvProducts);
            this.Name = "FrmProducts";
            this.Text = "Products:";
            this.Load += new System.EventHandler(this.FrmProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.ComboBox cmbFilterOption;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGetSelected;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearchByProductName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbSuppliers;
        private System.Windows.Forms.Button btnSearchBySupplierCountry;
    }
}

