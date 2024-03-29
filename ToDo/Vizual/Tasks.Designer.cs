﻿namespace ToDo.Vizual
{
    partial class Tasks
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.SaveTask = new System.Windows.Forms.Button();
            this.TimeStop = new System.Windows.Forms.DateTimePicker();
            this.TimeStart = new System.Windows.Forms.DateTimePicker();
            this.NameTask = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.DescriptionTask = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.DescriptionTask);
            this.splitContainer1.Panel1.Controls.Add(this.SaveTask);
            this.splitContainer1.Panel1.Controls.Add(this.TimeStop);
            this.splitContainer1.Panel1.Controls.Add(this.TimeStart);
            this.splitContainer1.Panel1.Controls.Add(this.NameTask);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 0;
            // 
            // SaveTask
            // 
            this.SaveTask.Location = new System.Drawing.Point(66, 357);
            this.SaveTask.Name = "SaveTask";
            this.SaveTask.Size = new System.Drawing.Size(75, 23);
            this.SaveTask.TabIndex = 5;
            this.SaveTask.Text = "Сохранить";
            this.SaveTask.UseVisualStyleBackColor = true;
            this.SaveTask.Click += new System.EventHandler(this.SaveTask_Click);
            // 
            // TimeStop
            // 
            this.TimeStop.Location = new System.Drawing.Point(12, 271);
            this.TimeStop.Name = "TimeStop";
            this.TimeStop.Size = new System.Drawing.Size(239, 20);
            this.TimeStop.TabIndex = 4;
            // 
            // TimeStart
            // 
            this.TimeStart.Location = new System.Drawing.Point(12, 226);
            this.TimeStart.Name = "TimeStart";
            this.TimeStart.Size = new System.Drawing.Size(239, 20);
            this.TimeStart.TabIndex = 3;
            // 
            // NameTask
            // 
            this.NameTask.Location = new System.Drawing.Point(12, 12);
            this.NameTask.Name = "NameTask";
            this.NameTask.Size = new System.Drawing.Size(239, 20);
            this.NameTask.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(530, 450);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // DescriptionTask
            // 
            this.DescriptionTask.Location = new System.Drawing.Point(12, 51);
            this.DescriptionTask.Multiline = true;
            this.DescriptionTask.Name = "DescriptionTask";
            this.DescriptionTask.Size = new System.Drawing.Size(239, 158);
            this.DescriptionTask.TabIndex = 6;
            // 
            // Tasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Tasks";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tasks";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Tasks_FormClosing);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox NameTask;
        private System.Windows.Forms.Button SaveTask;
        private System.Windows.Forms.DateTimePicker TimeStop;
        private System.Windows.Forms.DateTimePicker TimeStart;
        private System.Windows.Forms.TextBox DescriptionTask;
    }
}