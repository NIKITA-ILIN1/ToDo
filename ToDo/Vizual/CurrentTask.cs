using MaterialSkin.Controls;
using System;

namespace ToDo
{
    public partial class CurrentTask : MaterialForm
    {
        public long Id {  get; set; }

        public CurrentTask(long id, string name, string status, DateTime timeStart, DateTime timeStop)
        {
            InitializeComponent();

            this.Id = id;
            NameTask.Text = name;
            StatusTask.Text = status;
            TimeStartTask.Text = timeStart.ToString();
            TimeStopTask.Text = timeStop.ToString();
        }
    }
}
