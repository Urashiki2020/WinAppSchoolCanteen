namespace WinAppSchoolCanteen
{
    partial class FormWorkingWindowOfTheAdministrator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWorkingWindowOfTheAdministrator));
            this.pictureBoxSchoolCanteen1 = new System.Windows.Forms.PictureBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonListOfClasses = new System.Windows.Forms.Button();
            this.buttonListOfEmployees = new System.Windows.Forms.Button();
            this.buttonEmployeeWorkSchedule = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSchoolCanteen1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxSchoolCanteen1
            // 
            this.pictureBoxSchoolCanteen1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBoxSchoolCanteen1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSchoolCanteen1.Image")));
            this.pictureBoxSchoolCanteen1.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxSchoolCanteen1.Name = "pictureBoxSchoolCanteen1";
            this.pictureBoxSchoolCanteen1.Size = new System.Drawing.Size(512, 127);
            this.pictureBoxSchoolCanteen1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSchoolCanteen1.TabIndex = 1;
            this.pictureBoxSchoolCanteen1.TabStop = false;
            // 
            // buttonBack
            // 
            this.buttonBack.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonBack.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.Location = new System.Drawing.Point(360, 401);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(140, 40);
            this.buttonBack.TabIndex = 6;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonListOfClasses
            // 
            this.buttonListOfClasses.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonListOfClasses.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonListOfClasses.Location = new System.Drawing.Point(116, 208);
            this.buttonListOfClasses.Name = "buttonListOfClasses";
            this.buttonListOfClasses.Size = new System.Drawing.Size(280, 40);
            this.buttonListOfClasses.TabIndex = 9;
            this.buttonListOfClasses.Text = "Список классов";
            this.buttonListOfClasses.UseVisualStyleBackColor = true;
            // 
            // buttonListOfEmployees
            // 
            this.buttonListOfEmployees.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonListOfEmployees.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonListOfEmployees.Location = new System.Drawing.Point(116, 254);
            this.buttonListOfEmployees.Name = "buttonListOfEmployees";
            this.buttonListOfEmployees.Size = new System.Drawing.Size(280, 40);
            this.buttonListOfEmployees.TabIndex = 10;
            this.buttonListOfEmployees.Text = "Список сотрудников";
            this.buttonListOfEmployees.UseVisualStyleBackColor = true;
            // 
            // buttonEmployeeWorkSchedule
            // 
            this.buttonEmployeeWorkSchedule.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonEmployeeWorkSchedule.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEmployeeWorkSchedule.Location = new System.Drawing.Point(116, 300);
            this.buttonEmployeeWorkSchedule.Name = "buttonEmployeeWorkSchedule";
            this.buttonEmployeeWorkSchedule.Size = new System.Drawing.Size(280, 40);
            this.buttonEmployeeWorkSchedule.TabIndex = 11;
            this.buttonEmployeeWorkSchedule.Text = "График работы сотрудников";
            this.buttonEmployeeWorkSchedule.UseVisualStyleBackColor = true;
            // 
            // FormWorkingWindowOfTheAdministrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(512, 453);
            this.Controls.Add(this.buttonEmployeeWorkSchedule);
            this.Controls.Add(this.buttonListOfEmployees);
            this.Controls.Add(this.buttonListOfClasses);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.pictureBoxSchoolCanteen1);
            this.Name = "FormWorkingWindowOfTheAdministrator";
            this.Text = "Рабочее окно администратора";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSchoolCanteen1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxSchoolCanteen1;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonListOfClasses;
        private System.Windows.Forms.Button buttonListOfEmployees;
        private System.Windows.Forms.Button buttonEmployeeWorkSchedule;
    }
}