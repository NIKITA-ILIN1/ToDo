namespace ToDo
{
    partial class CurrentTask
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.NameTask = new System.Windows.Forms.Label();
            this.StatusTask = new System.Windows.Forms.Label();
            this.TimeStartTask = new System.Windows.Forms.Label();
            this.TimeStopTask = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NameTask
            // 
            this.NameTask.AutoSize = true;
            this.NameTask.Location = new System.Drawing.Point(96, 15);
            this.NameTask.Name = "NameTask";
            this.NameTask.Size = new System.Drawing.Size(95, 13);
            this.NameTask.TabIndex = 0;
            this.NameTask.Text = "Название задачи";
            // 
            // StatusTask
            // 
            this.StatusTask.AutoSize = true;
            this.StatusTask.Location = new System.Drawing.Point(41, 61);
            this.StatusTask.Name = "StatusTask";
            this.StatusTask.Size = new System.Drawing.Size(35, 13);
            this.StatusTask.TabIndex = 1;
            this.StatusTask.Text = "label1";
            // 
            // TimeStartTask
            // 
            this.TimeStartTask.AutoSize = true;
            this.TimeStartTask.Location = new System.Drawing.Point(168, 48);
            this.TimeStartTask.Name = "TimeStartTask";
            this.TimeStartTask.Size = new System.Drawing.Size(35, 13);
            this.TimeStartTask.TabIndex = 2;
            this.TimeStartTask.Text = "label2";
            // 
            // TimeStopTask
            // 
            this.TimeStopTask.AutoSize = true;
            this.TimeStopTask.Location = new System.Drawing.Point(168, 80);
            this.TimeStopTask.Name = "TimeStopTask";
            this.TimeStopTask.Size = new System.Drawing.Size(35, 13);
            this.TimeStopTask.TabIndex = 3;
            this.TimeStopTask.Text = "label3";
            // 
            // CurrentTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.TimeStopTask);
            this.Controls.Add(this.TimeStartTask);
            this.Controls.Add(this.StatusTask);
            this.Controls.Add(this.NameTask);
            this.Name = "CurrentTask";
            this.Size = new System.Drawing.Size(303, 112);
            this.Click += new System.EventHandler(this.CurrentTask_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameTask;
        private System.Windows.Forms.Label StatusTask;
        private System.Windows.Forms.Label TimeStartTask;
        private System.Windows.Forms.Label TimeStopTask;
    }
}
