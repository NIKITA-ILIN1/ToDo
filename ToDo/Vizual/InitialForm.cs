using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDo.Dao.Implementation_interfaces;
using ToDo.Dao.Interfaces;
using ToDo.Entity;
using ToDo.Vizual;

namespace ToDo
{
    public partial class InitialForm : Form
    {
        public InitialForm()
        {
            InitializeComponent();

            buttonShowHidePassword.BackgroundImage = Properties.Resources.ShowPasswordIcon;
        }

        private void Authorization_Click(object sender, EventArgs e)
        {
            try
            {
                User AuthUser = new User(0, "", LoginUser.Text, PasswordUser.Text);

                AuthUser = new ImplementationAuthorizationAndLogOut().Authorization(AuthUser);

                Vizual.Tasks tasks = new Vizual.Tasks();
                this.Hide();

                if (tasks.ShowDialog() == DialogResult.Cancel) {
                    this.Show();
                }
            }
            catch
            {
                MessageBox.Show("Incorrect data");
            }
        }

        private void buttonShowHidePassword_Click(object sender, EventArgs e)
        {
            if (PasswordUser.UseSystemPasswordChar) {
                PasswordUser.UseSystemPasswordChar = false;
                buttonShowHidePassword.BackgroundImage = Properties.Resources.HidePasswordIcon;
            }
            else {
                PasswordUser.UseSystemPasswordChar = true;
                buttonShowHidePassword.BackgroundImage = Properties.Resources.ShowPasswordIcon;
            }
        }
    }
}
