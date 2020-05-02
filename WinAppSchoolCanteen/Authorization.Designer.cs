namespace WinAppSchoolCanteen
{
    partial class FormAuthorization
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAuthorization));
            this.pictureBoxSchoolCanteen = new System.Windows.Forms.PictureBox();
            this.labelGreeting = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.buttonInput = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonInformationAboutTheDeveloper = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSchoolCanteen)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxSchoolCanteen
            // 
            this.pictureBoxSchoolCanteen.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBoxSchoolCanteen.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSchoolCanteen.Image")));
            this.pictureBoxSchoolCanteen.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxSchoolCanteen.Name = "pictureBoxSchoolCanteen";
            this.pictureBoxSchoolCanteen.Size = new System.Drawing.Size(886, 127);
            this.pictureBoxSchoolCanteen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSchoolCanteen.TabIndex = 0;
            this.pictureBoxSchoolCanteen.TabStop = false;
            // 
            // labelGreeting
            // 
            this.labelGreeting.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelGreeting.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGreeting.Location = new System.Drawing.Point(0, 130);
            this.labelGreeting.Name = "labelGreeting";
            this.labelGreeting.Size = new System.Drawing.Size(886, 99);
            this.labelGreeting.TabIndex = 1;
            this.labelGreeting.Text = "Добро пожаловать в программную систему для ведения учета работы школьной столовой" +
    "\r\nПожалуйста введите логин и пароль для входа в систему";
            this.labelGreeting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelLogin
            // 
            this.labelLogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogin.Location = new System.Drawing.Point(262, 253);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(141, 24);
            this.labelLogin.TabIndex = 2;
            this.labelLogin.Text = "Введите логин:";
            // 
            // labelPassword
            // 
            this.labelPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPassword.Location = new System.Drawing.Point(252, 293);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(152, 24);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "Введите пароль:";
            // 
            // buttonInput
            // 
            this.buttonInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonInput.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonInput.Location = new System.Drawing.Point(256, 352);
            this.buttonInput.Name = "buttonInput";
            this.buttonInput.Size = new System.Drawing.Size(140, 40);
            this.buttonInput.TabIndex = 4;
            this.buttonInput.Text = "Вход";
            this.buttonInput.UseVisualStyleBackColor = true;
            this.buttonInput.Click += new System.EventHandler(this.buttonInput_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.Location = new System.Drawing.Point(538, 352);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(140, 40);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxLogin.Location = new System.Drawing.Point(420, 256);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(194, 22);
            this.textBoxLogin.TabIndex = 6;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxPassword.Location = new System.Drawing.Point(420, 296);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(194, 22);
            this.textBoxPassword.TabIndex = 7;
            // 
            // buttonInformationAboutTheDeveloper
            // 
            this.buttonInformationAboutTheDeveloper.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonInformationAboutTheDeveloper.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonInformationAboutTheDeveloper.Location = new System.Drawing.Point(12, 398);
            this.buttonInformationAboutTheDeveloper.Name = "buttonInformationAboutTheDeveloper";
            this.buttonInformationAboutTheDeveloper.Size = new System.Drawing.Size(335, 40);
            this.buttonInformationAboutTheDeveloper.TabIndex = 8;
            this.buttonInformationAboutTheDeveloper.Text = "Информация о разработчике";
            this.buttonInformationAboutTheDeveloper.UseVisualStyleBackColor = true;
            // 
            // FormAuthorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(886, 450);
            this.Controls.Add(this.buttonInformationAboutTheDeveloper);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonInput);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.labelGreeting);
            this.Controls.Add(this.pictureBoxSchoolCanteen);
            this.Name = "FormAuthorization";
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.FormAuthorization_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSchoolCanteen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxSchoolCanteen;
        private System.Windows.Forms.Label labelGreeting;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Button buttonInput;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonInformationAboutTheDeveloper;
    }
}

