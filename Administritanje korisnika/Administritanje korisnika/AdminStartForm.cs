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
    public partial class AdminStartForm : Form
    {
        public AdminStartForm()
        {
            InitializeComponent();
        }

        private void AdminStartForm_Load(object sender, EventArgs e)
        {
            OsvjeziListu();
        }

        private void ActivateUserBtn_Click(object sender, EventArgs e)
        {
            User user = DohvatiSelektiraniRedak();
            user.Status = UserStatus.Activated;
            OsvjeziListu();
        }

        private void DeactivateUserBtn_Click(object sender, EventArgs e)
        {
            User user = DohvatiSelektiraniRedak();
            user.Status = UserStatus.Deactivated;
            OsvjeziListu();
        }

        private User DohvatiSelektiraniRedak()
        {
            User user = null;

            if(usersDataGridView.CurrentRow != null)
            {
                user = usersDataGridView.CurrentRow.DataBoundItem as User;
            }

            return user;
        }

        private void usersDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            User user = null;

            user = DohvatiSelektiraniRedak();

            if (user.Status == UserStatus.Activated)
            {
                ActivateUserBtn.Enabled = false;
                DeactivateUserBtn.Enabled = true;
            }
            else if (user.Status == UserStatus.Deactivated)
            {
                ActivateUserBtn.Enabled = true;
                DeactivateUserBtn.Enabled = false;
            }
        }

        private void OsvjeziListu()
        {
            List<User> users = UsersRepository.GetUsers();
            usersDataGridView.DataSource = null;
            usersDataGridView.DataSource = users;
        }
    }
}
