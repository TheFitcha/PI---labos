using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prijevodi
{
    public partial class PopisRijeci : Form
    {
        private Rjecnik popisRijeci;
        public PopisRijeci(Rjecnik rjecnik)
        {
            InitializeComponent();
            popisRijeci = rjecnik;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PopisRijeci_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = popisRijeci.ListaRijeci;
        }
    }
}
