using MaterialSkin.Controls;
using System;
using System.Windows.Forms;
using ToDo.Dao.Implementation_interfaces;
using ToDo.Entity;
using ToDo.Vizual;

namespace ToDo
{
    public partial class InitialForm : MaterialForm
    {
        public InitialForm()
        {
            InitializeComponent();

            buttonShowHidePassword.BackgroundImage = Properties.Resources.ShowPasswordIcon;
        }

        private void Authorization_Click(object sender, EventArgs e)
        {
            try {
                User AuthUser = new User();
                AuthUser.Login = LoginUser.Text;
                AuthUser.Password = PasswordUser.Text;

                AuthUser = new ImplementationAuthorizationAndLogOut().Authorization(AuthUser);

                Tasks tasks = new Tasks();    
                this.Hide();

                if (tasks.ShowDialog() == DialogResult.Cancel) {
                    this.Show();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
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
