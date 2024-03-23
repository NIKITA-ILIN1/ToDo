using MaterialSkin.Controls;
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

            taskDao = new TaskDataBase();

            TaskEntity taskEntity = new TaskEntity();
            taskEntity.UserId = AuthUser.Id;

            List<TaskEntity> tasks = taskDao.ReadTask(taskEntity);

            foreach (TaskEntity task in tasks)
            {
                flowLayoutPanel1.Controls.Add(new CurrentTask(task.Id, task.Name, task.Status, task.TimeStart, task.TimeStop));
            }
        }

        private void SaveTask_Click(object sender, EventArgs e)
        {
            TaskEntity task = new TaskEntity();
            task.UserId = AuthUser.Id;
            task.Name = NameTask.Text;
            task.Description = DescriptionTask.Text;
            task.TimeStart = TimeStart.Value;
            task.TimeStop = TimeStop.Value;

            try
            {
                taskDao.CreateTask(task);

                flowLayoutPanel1.Controls.Add(new CurrentTask(task.Id, task.Name, task.Status, task.TimeStart, task.TimeStop));

                MessageBox.Show("OK");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Tasks_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
