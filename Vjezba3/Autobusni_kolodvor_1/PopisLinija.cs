using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutobusniKolodvorLib;

namespace Autobusni_kolodvor_1
{
    public partial class PopisLinija : Form
    {
        public PopisLinija()
        {
            InitializeComponent();
        }

        private void PopisLinija_Load(object sender, EventArgs e)
        {
            linijeDataGrid.DataSource = AutobusniKolodvorLib.AutobusniKolodvor.DohvatiLinije().ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AutobusniKolodvor.odabranaLinija = linijeDataGrid.SelectedRows[0];
            Close();
        }
    }
}
