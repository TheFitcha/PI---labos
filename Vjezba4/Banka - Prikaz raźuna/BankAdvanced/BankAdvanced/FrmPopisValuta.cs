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
    public partial class FrmPopisValuta : Form
    {
        public FrmPopisValuta()
        {
            InitializeComponent();
        }

        private void FrmPopisValuta_Load(object sender, EventArgs e)
        {
            OsvjeziValute();
        }

        private void OsvjeziValute()
        {
            ValuteDataGridView.DataSource = null;
            ValuteDataGridView.DataSource = MjenjacnicaDB.Valute;
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDodajValutu_Click(object sender, EventArgs e)
        {
            MjenjacnicaDB.DodajNovuValutu(txtOznakaValute.Text, txtZemljaValute.Text);
            OsvjeziValute();
        }
    }
}
