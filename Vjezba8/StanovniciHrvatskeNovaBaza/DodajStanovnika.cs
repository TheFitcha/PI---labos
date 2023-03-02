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
    public partial class DodajStanovnika : Form
    {
        public DodajStanovnika()
        {
            InitializeComponent();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            using (var context = new LabsEntities())
            {
                Stanovnici noviStanovnik = new Stanovnici()
                {
                    Ime = txtIme.Text,
                    Prezime = txtPrezime.Text,  
                    OIB = txtOIB.Text,
                    JMBG = txtJMBG.Text
                };
                context.Stanovnicis.Add(noviStanovnik);  
                context.SaveChanges();
            }
            Close();
        }
    }
}
