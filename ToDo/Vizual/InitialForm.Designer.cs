namespace ToDo
{
    partial class InitialForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.LoginUser = new System.Windows.Forms.TextBox();
            this.PasswordUser = new System.Windows.Forms.TextBox();
            this.Authorization = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LoginUser
            // 
            this.LoginUser.Location = new System.Drawing.Point(36, 31);
            this.LoginUser.Name = "LoginUser";
            this.LoginUser.Size = new System.Drawing.Size(100, 20);
            this.LoginUser.TabIndex = 0;
            this.LoginUser.Text = "Логин";
            // 
            // PasswordUser
            // 
            this.PasswordUser.Location = new System.Drawing.Point(36, 84);
            this.PasswordUser.Name = "PasswordUser";
            this.PasswordUser.Size = new System.Drawing.Size(100, 20);
            this.PasswordUser.TabIndex = 1;
            this.PasswordUser.Text = "Пароль";
            // 
            // Authorization
            // 
            this.Authorization.Location = new System.Drawing.Point(36, 155);
            this.Authorization.Name = "Authorization";
            this.Authorization.Size = new System.Drawing.Size(100, 23);
            this.Authorization.TabIndex = 2;
            this.Authorization.Text = "Авторизация";
            this.Authorization.UseVisualStyleBackColor = true;
            this.Authorization.Click += new System.EventHandler(this.Authorization_Click);
            // 
            // InitialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Authorization);
            this.Controls.Add(this.PasswordUser);
            this.Controls.Add(this.LoginUser);
            this.Name = "InitialForm";
            this.Text = "Начальная форма";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LoginUser;
        private System.Windows.Forms.TextBox PasswordUser;
        private System.Windows.Forms.Button Authorization;
    }
}

