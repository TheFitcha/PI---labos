using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NorthWnd_LINQ
{
    public partial class FrmProducts : Form
    {
        public FrmProducts()
        {
            InitializeComponent();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            Filter(cmbFilterOption.SelectedIndex);
        }

        private void Filter(int optionIndex)
        {
            switch (optionIndex)
            {
                case 0: ShowAllProducts(); break;
                case 1: ShowProductsWithInsufficientStock(); break;
                case 2: SortProductsByNameAscending();break;
                case 3: SortProductsByUnitPriceDescending(); break;
                case 4: ShowAllProducts_LessColumns(); break;
                case 5: ShowAllProducts_LessColumns2(); break;
                default:
                    break;
            }
        }

        private void ShowAllProducts_LessColumns2()
        {
            using (var context = new NORTHWNDEntities())
            {
                var query = from p in context.Products
                            where p.Discontinued == false
                            orderby p.ProductName ascending
                            select new ProductView
                            {
                                Id = p.ProductID,
                                Name = p.ProductName,
                                Category = p.Category.CategoryName,
                                Supplier = p.Supplier.CompanyName,
                                UnitPrice = p.UnitPrice,
                                InStock = p.UnitsInStock
                            };

                dgvProducts.DataSource = query.ToList();
            }
        }

        private void ShowAllProducts_LessColumns()
        {
            using (var context = new NORTHWNDEntities())
            {
                var query = from p in context.Products
                            where p.Discontinued == false
                            orderby p.ProductName ascending
                            select new
                            {
                                p.ProductID,
                                p.ProductName,
                                p.Category.CategoryName,
                                p.Supplier.CompanyName,
                                p.Supplier.Country,
                                p.UnitPrice,
                                p.UnitsInStock
                            };

                dgvProducts.DataSource = query.ToList();
            }
        }

        private void SortProductsByUnitPriceDescending()
        {
            using (var context = new NORTHWNDEntities())
            {
                var query = from p in context.Products.Include("Category").Include("Supplier")
                            where p.Discontinued == false
                            orderby p.UnitPrice descending
                            select p;

                dgvProducts.DataSource = query.ToList();
            }
        }

        private void SortProductsByNameAscending()
        {
            using (var context = new NORTHWNDEntities())
            {
                var query = from p in context.Products.Include("Category").Include("Supplier")
                            where p.Discontinued == false
                            orderby p.ProductName
                            select p;

                dgvProducts.DataSource = query.ToList();
            }
        }

        private void ShowProductsWithInsufficientStock()
        {
            using (var context = new NORTHWNDEntities())
            {
                var query = from p in context.Products.Include("Category").Include("Supplier")
                            where p.UnitsInStock < p.ReorderLevel && p.Discontinued == false
                            select p;

                dgvProducts.DataSource = query.ToList();
            }
        }

        private void ShowAllProducts()
        {
            using (var context = new NORTHWNDEntities())
            {
                var query = from p in context.Products.Include("Category").Include("Supplier")
                            select p;

                dgvProducts.DataSource = query.ToList();
            }
        }

        private void btnGetSelected_Click(object sender, EventArgs e)
        {
            var selected = dgvProducts.CurrentRow.DataBoundItem;
            ProductView pw = selected as ProductView;
            
        }

        private void btnSearchByProductName_Click(object sender, EventArgs e)
        {
            string name = txtProductName.Text;

            using (var context = new NORTHWNDEntities())
            {
                var query = from p in context.Products
                            where p.ProductName.Contains(name)
                            select new { p.ProductName, p.Category.CategoryName, p.UnitPrice };

                dgvProducts.DataSource = query.ToList();
            }
        }

        private void FrmProducts_Load(object sender, EventArgs e)
        {
            FillSuppliers();
        }

        private void FillSuppliers()
        {
            using (var context = new NORTHWNDEntities())
            {
                var query = from s in context.Suppliers
                            select s;

                cmbSuppliers.DataSource = query.ToList();
            }
        }

        private void btnSearchBySupplierCountry_Click(object sender, EventArgs e)
        {
            Supplier selectedSupplier = cmbSuppliers.SelectedItem as Supplier;
            using (var context = new NORTHWNDEntities())
            {
                var query = from p in context.Products
                            where p.SupplierID == selectedSupplier.SupplierID
                            select new { p.ProductID, p.ProductName, p.Category.CategoryName, p.Supplier.CompanyName};

                dgvProducts.DataSource = query.ToList();
            }
        }
    }
}
