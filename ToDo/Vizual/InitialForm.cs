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
        }

        private void Authorization_Click(object sender, EventArgs e)
        {
            User AuthUser = new User(0, "", LoginUser.Text, PasswordUser.Text);

            try
            {
                AuthUser = new ImplementationAuthorizationAndLogOut().Authorization(AuthUser);
                Tasks tasks = new Tasks();
                this.Hide();
                if(tasks.ShowDialog() == DialogResult.Cancel)
                {
                    this.Show();
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show("Check data");
            }





        }
    }
}
