using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PopisZadataka
{
    public partial class Form1 : Form
    {
        private List<Zadatak> ListaZadataka;
        public Form1()
        {
            InitializeComponent();
            ListaZadataka = new List<Zadatak>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(zadatakText.Text == "")
            {
                MessageBox.Show("Unesite zadatak!");
            }
            ListaZadataka.Add(new Zadatak(zadatakText.Text, datumPicker.Value));
            ListaZadataka.Sort();
            RefreshForm();
        }

        private void RefreshForm()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ListaZadataka;
            foreach(DataGridViewRow red in dataGridView1.Rows)
            {
                DateTime datum = Convert.ToDateTime(red.Cells[1].Value);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshForm();
        }
    }
}
