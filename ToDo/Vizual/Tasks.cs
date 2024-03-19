using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDo.Vizual
{
    public partial class Tasks : Form
    {
        public Tasks()
        {
            InitializeComponent();

            for (int i = 1; i < 11; i++) {
                flowLayoutPanel1.Controls.Add(new CurrentTask("Задача " + i.ToString()));
            }
        }

        private void Tasks_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
