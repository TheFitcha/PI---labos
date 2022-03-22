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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void logInBtn_Click(object sender, EventArgs e)
        {
            if(usernameBox.Text == "admin" && passwordBox.Text == "admin")
            {
                AdministratorsStartForm asf = new AdministratorsStartForm();
                asf.Show();
            }
            else
            {        
                MessageBox.Show("You must be administrator to login!");
            }
        }
    }
}
