using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VjezbaLINQ
{
    public partial class Form1 : Form
    {
        private string selectedSupplier;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadComboBox();
            LoadStandard();
        }
        
        private void LoadComboBox()
        {
            cmbDobavljac.Items.Clear();
            using(var context = new NorthwindEntities())
            {
                var suppliers = from p in context.Suppliers select p.CompanyName;
                foreach (var supplier in suppliers)
                {
                    cmbDobavljac.Items.Add(supplier);
                }
            }
            cmbDobavljac.SelectedIndex = 0;
        }
        private void LoadStandard()
        {
            using(var context = new NorthwindEntities())
            {
                var _query = from p in context.Products 
                            where p.Supplier.CompanyName == selectedSupplier
                            orderby p.ProductName ascending
                            select p;
                dataGridView1.DataSource = _query.ToList();
            }
        }

        private void cmbDobavljac_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedSupplier = cmbDobavljac.SelectedItem.ToString(); 
            LoadStandard();
        }


        private void txtMinCijena_TextChanged(object sender, EventArgs e)
        {
            if(txtMinCijena.Text != string.Empty)
            {
                txtMinCijena.Text = txtMinCijena.Text.Trim();
                using (var context = new NorthwindEntities())
                {
                    decimal price = decimal.Parse(txtMinCijena.Text);
                    var _query = from p in context.Products
                                 where p.Supplier.CompanyName == selectedSupplier
                                 where p.UnitPrice > price
                                 orderby p.ProductName ascending
                                 select p;
                    dataGridView1.DataSource = _query.ToList();
                }
            }
            else
            {
                LoadStandard();
            }
        }

        private void txtMaxCijena_TextChanged(object sender, EventArgs e)
        {
            if(txtMaxCijena.Text != string.Empty)
            {
                txtMaxCijena.Text = txtMaxCijena.Text.Trim();
                using (var context = new NorthwindEntities())
                {
                    var price = decimal.Parse(txtMaxCijena.Text);
                    var _query = from p in context.Products
                                 where p.Supplier.CompanyName == selectedSupplier
                                 where p.UnitPrice < price
                                 orderby p.ProductName ascending
                                 select p;
                    dataGridView1.DataSource = _query.ToList();
                }   
            }
            else
            {
                LoadStandard();
            }
        }

        private void txtNaziv_TextChanged(object sender, EventArgs e)
        {
            if(txtNaziv.Text != string.Empty)
            {
                using (var context = new NorthwindEntities())
                {
                    var _query = from p in context.Products
                                 where p.Supplier.CompanyName == selectedSupplier
                                 where p.ProductName.Equals(txtNaziv.Text)
                                 orderby p.ProductName ascending
                                 select p;
                    dataGridView1.DataSource = _query.ToList();
                }      
            }
            else
            {
                LoadStandard();
            }
        }
    }
}
