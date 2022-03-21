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

namespace Administritanje_korisnika
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Autentificator.LogIn(UsernameTxtBox.Text, PasswordTxtBox.Text);
            User user = new User();
            user = Autentificator.LoggedUser;

            if (user.UserType != UserType.Administrator)
            {
                MessageBox.Show("You must be administrator to login!");
            }
            else if (user.UserType == UserType.Administrator)
            {
                AdminStartForm form = new AdminStartForm();
                //this.Hide();
                form.Show();
            }
            else
            {
                MessageBox.Show("Credentials not valid!");
            }
        }
    }
}
