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

namespace ToDo
{
    public partial class CurrentTask : MaterialForm
    {
        private long Id {  get; set; }
        private ITaskDao taskDao;

        public CurrentTask(long id, string name, string status, DateTime timeStart, DateTime timeStop)
        {
            InitializeComponent();

            taskDao = new TaskDataBase();
            this.Id = id;
            NameTask.Text = name;
            StatusTask.Text = status;
            TimeStartTask.Text = timeStart.ToString();
            TimeStopTask.Text = timeStop.ToString();
        }
    }
}
