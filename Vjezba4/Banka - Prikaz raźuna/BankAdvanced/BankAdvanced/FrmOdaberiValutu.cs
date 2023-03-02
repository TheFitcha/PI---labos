using BankaLib;
using MjenjacnicaLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankAdvanced
{
    public partial class FrmOdaberiValutu : Form
    {
        public Valuta OdabranaValuta { get; set; }
        public FrmOdaberiValutu()
        {
            InitializeComponent();
        }

        private void izlazButton_Click(object sender, EventArgs e)
        {
            OdabranaValuta = null;
            Close();
        }

        private void FrmOdaberiValutu_Load(object sender, EventArgs e)
        {
            valuteDataGridView.DataSource = MjenjacnicaDB.Valute;
        }

        private void odaberiButton_Click(object sender, EventArgs e)
        {
            OdabranaValuta = DohvatiOdabranuValutu();
            Close();
        }

        private Valuta DohvatiOdabranuValutu()
        {
            if (valuteDataGridView.CurrentRow != null)
            {
                return valuteDataGridView.CurrentRow.DataBoundItem as Valuta;
            }
            return null;
        }
    }
}
