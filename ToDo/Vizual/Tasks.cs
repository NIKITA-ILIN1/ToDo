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


namespace ToDo.Vizual
{
    public partial class Tasks : Form
    {
        private User AuthUser = ImplementationAuthorizationAndLogOut.GetAuthUser();
        private ITaskDao taskDao;

        public Tasks()
        {
            InitializeComponent();

            User AuthUser = ImplementationAuthorizationAndLogOut.GetAuthUser();

            for (int i = 1; i < 11; i++) {
                flowLayoutPanel1.Controls.Add(new CurrentTask("Задача " + i.ToString()));
            }

            taskDao = new TaskDataBase();
        }

        private void Tasks_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void SaveTask_Click(object sender, EventArgs e)
        {
            TaskEntity task = new TaskEntity();
            task.UserId = AuthUser.Id;
            task.Description = NameTask.Text;
            task.Status = StatusTask.Text;
            task.TimeStart = TimeStart.Value;
            task.TimeStop = TimeStop.Value;

            try
            {
                taskDao.CreateTask(task);

                flowLayoutPanel1.Controls.Add(new CurrentTask(task.Description));

                MessageBox.Show("OK");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
