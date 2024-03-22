using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDo
{
    public partial class CurrentTask : UserControl
    {
        //public long 
        public string TaskName { get; set; }
        //public 

        public CurrentTask(long id, string name, string description, string status, DateTime timeStart, DateTime timeStop)
        {
            InitializeComponent();
        }

        private void CurrentTask_Click(object sender, EventArgs e)
        {
            MessageBox.Show(NameTask.Text);
        }
    }
}
