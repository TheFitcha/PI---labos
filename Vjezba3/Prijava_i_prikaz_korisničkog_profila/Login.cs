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

namespace Prijava_i_prikaz_korisničkog_profila
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if(usernameBox.Text == String.Empty && passwordBox.Text == String.Empty)
            {
                MessageBox.Show("Username and password must be entered!");
                return;
            }
            Autentificator.LogIn(usernameBox.Text, passwordBox.Text);
            if(Autentificator.LoggedUser == null)
            {
                MessageBox.Show("Entered credentials are not valid!");
                return;
            }
            UserProfile userProfile = new UserProfile();
            userProfile.FormClosing += showLogin;
            Hide();
            userProfile.ShowDialog();
        }
        private void showLogin(object sender, FormClosingEventArgs e)
        {
            Show();
        }
    }
}
