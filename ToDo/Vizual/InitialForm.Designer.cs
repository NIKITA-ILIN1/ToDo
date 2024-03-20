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
            this.Registration = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonShowHidePassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LoginUser
            // 
            this.LoginUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LoginUser.BackColor = System.Drawing.SystemColors.HighlightText;
            this.LoginUser.Location = new System.Drawing.Point(101, 37);
            this.LoginUser.Name = "LoginUser";
            this.LoginUser.Size = new System.Drawing.Size(178, 20);
            this.LoginUser.TabIndex = 0;
            this.LoginUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PasswordUser
            // 
            this.PasswordUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PasswordUser.BackColor = System.Drawing.SystemColors.HighlightText;
            this.PasswordUser.HideSelection = false;
            this.PasswordUser.Location = new System.Drawing.Point(101, 92);
            this.PasswordUser.Name = "PasswordUser";
            this.PasswordUser.Size = new System.Drawing.Size(178, 20);
            this.PasswordUser.TabIndex = 1;
            this.PasswordUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PasswordUser.UseSystemPasswordChar = true;
            // 
            // Authorization
            // 
            this.Authorization.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Authorization.Location = new System.Drawing.Point(120, 155);
            this.Authorization.Name = "Authorization";
            this.Authorization.Size = new System.Drawing.Size(137, 23);
            this.Authorization.TabIndex = 2;
            this.Authorization.Text = "Авторизация";
            this.Authorization.UseVisualStyleBackColor = false;
            this.Authorization.Click += new System.EventHandler(this.Authorization_Click);
            // 
            // Registration
            // 
            this.Registration.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Registration.Cursor = System.Windows.Forms.Cursors.Default;
            this.Registration.Location = new System.Drawing.Point(120, 213);
            this.Registration.Name = "Registration";
            this.Registration.Size = new System.Drawing.Size(137, 23);
            this.Registration.TabIndex = 3;
            this.Registration.Text = "Регистрация";
            this.Registration.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Пароль";
            // 
            // buttonShowHidePassword
            // 
            this.buttonShowHidePassword.BackColor = System.Drawing.SystemColors.HighlightText;
            this.buttonShowHidePassword.Location = new System.Drawing.Point(275, 92);
            this.buttonShowHidePassword.Name = "buttonShowHidePassword";
            this.buttonShowHidePassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonShowHidePassword.Size = new System.Drawing.Size(20, 20);
            this.buttonShowHidePassword.TabIndex = 6;
            this.buttonShowHidePassword.UseVisualStyleBackColor = false;
            this.buttonShowHidePassword.Click += new System.EventHandler(this.buttonShowHidePassword_Click);
            // 
            // InitialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(371, 330);
            this.Controls.Add(this.buttonShowHidePassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Registration);
            this.Controls.Add(this.Authorization);
            this.Controls.Add(this.PasswordUser);
            this.Controls.Add(this.LoginUser);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "InitialForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Начальная форма";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LoginUser;
        private System.Windows.Forms.TextBox PasswordUser;
        private System.Windows.Forms.Button Authorization;
        private System.Windows.Forms.Button Registration;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonShowHidePassword;
    }
}

