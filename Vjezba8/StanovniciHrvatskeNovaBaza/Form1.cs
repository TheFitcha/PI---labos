using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StanovniciHrvatskeNovaBaza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshUI();
        }

        private object GetUsers()
        {
            using(var context = new LabsEntities())
            {
                return context.Stanovnicis.ToList();
            }
        }

        private void RefreshUI()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = GetUsers();
            dataGridView1.Columns["Adrese"].Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DodajStanovnika dodajStanovnika = new DodajStanovnika();
            dodajStanovnika.ShowDialog();
            RefreshUI();
        }

        private void btnAdresa_Click(object sender, EventArgs e)
        {

        }
    }
}
