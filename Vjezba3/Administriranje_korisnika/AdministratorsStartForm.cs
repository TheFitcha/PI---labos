using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutentifikacijaLib;

namespace Administriranje_korisnika
{
    public partial class AdministratorsStartForm : Form
    {
        public AdministratorsStartForm()
        {
            InitializeComponent();
        }

        private void AdministratorsStartForm_Load(object sender, EventArgs e)
        {
            popuniDataGrid();
        }

        private void popuniDataGrid()
        {
            usersDataGrid.DataSource = UsersRepository.GetUsers().ToList();
            usersDataGrid.Rows[0].Selected = true;
        }

        private void usersDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                string status = usersDataGrid.SelectedRows[0].Cells["Status"].Value.ToString();
                if (status == "Activated")
                {
                    activateBtn.Enabled = false;
                    deactivateBtn.Enabled = true;
                }
                else
                {
                    deactivateBtn.Enabled = false;
                    activateBtn.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                activateBtn.Enabled = false;
                deactivateBtn.Enabled = false;
            }
            
        }

        private void deactivateBtn_Click(object sender, EventArgs e)
        {
            string ime = usersDataGrid.SelectedRows[0].Cells["UserName"].Value.ToString();
            UsersRepository.GetUser(ime).Status = UserStatus.Deactivated;
            activateBtn.Enabled = true;
            deactivateBtn.Enabled = false;
            popuniDataGrid();
        }

        private void activateBtn_Click(object sender, EventArgs e)
        {
            string ime = usersDataGrid.SelectedRows[0].Cells["UserName"].Value.ToString();
            UsersRepository.GetUser(ime).Status = UserStatus.Activated;
            activateBtn.Enabled = false;
            deactivateBtn.Enabled = true;
            popuniDataGrid();
        }
    }
}
