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
    public partial class UserProfile : Form
    {
        public UserProfile()
        {
            InitializeComponent();
        }

        private void UserProfile_Load(object sender, EventArgs e)
        {
            firstnameBox.Text = Autentificator.LoggedUser.FirstName;
            lastnameBox.Text = Autentificator.LoggedUser.LastName;
            usernameBox.Text = Autentificator.LoggedUser.UserName;
            passwordBox.Text = Autentificator.LoggedUser.Password;
            switch (Autentificator.LoggedUser.UserType)
            {
                case UserType.Administrator:
                    adminRadio.Checked = true;
                    break;
                case UserType.Guest:
                    guestRadio.Checked = true;
                    break;
                case UserType.Employee:
                    employeeRadio.Checked = true;
                    break;
            }
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            Autentificator.LogOut();
            Close();
        }
    }
}
