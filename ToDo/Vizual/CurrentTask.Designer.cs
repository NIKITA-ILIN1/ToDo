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
            this.SuspendLayout();
            // 
            // NameTask
            // 
            this.NameTask.AutoSize = true;
            this.NameTask.Location = new System.Drawing.Point(81, 35);
            this.NameTask.Name = "NameTask";
            this.NameTask.Size = new System.Drawing.Size(95, 13);
            this.NameTask.TabIndex = 0;
            this.NameTask.Text = "Название задачи";
            // 
            // CurrentTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.NameTask);
            this.Name = "CurrentTask";
            this.Size = new System.Drawing.Size(303, 112);
            this.Load += new System.EventHandler(this.CurrentTask_Load);
            this.Click += new System.EventHandler(this.CurrentTask_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameTask;
    }
}
