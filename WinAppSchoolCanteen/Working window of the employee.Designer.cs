namespace WinAppSchoolCanteen
{
    partial class FormWorkingWindowOfTheEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWorkingWindowOfTheEmployee));
            this.pictureBoxSchoolCanteen2 = new System.Windows.Forms.PictureBox();
            this.buttonBack1 = new System.Windows.Forms.Button();
            this.buttonDiningRoomMenu = new System.Windows.Forms.Button();
            this.buttonEmployeeWorkSchedule1 = new System.Windows.Forms.Button();
            this.buttonTheReportOfTheSchoolCafeteria = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSchoolCanteen2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxSchoolCanteen2
            // 
            this.pictureBoxSchoolCanteen2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBoxSchoolCanteen2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSchoolCanteen2.Image")));
            this.pictureBoxSchoolCanteen2.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxSchoolCanteen2.Name = "pictureBoxSchoolCanteen2";
            this.pictureBoxSchoolCanteen2.Size = new System.Drawing.Size(512, 127);
            this.pictureBoxSchoolCanteen2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSchoolCanteen2.TabIndex = 1;
            this.pictureBoxSchoolCanteen2.TabStop = false;
            // 
            // buttonBack1
            // 
            this.buttonBack1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBack1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack1.Location = new System.Drawing.Point(360, 401);
            this.buttonBack1.Name = "buttonBack1";
            this.buttonBack1.Size = new System.Drawing.Size(140, 40);
            this.buttonBack1.TabIndex = 6;
            this.buttonBack1.Text = "Назад";
            this.buttonBack1.UseVisualStyleBackColor = true;
            this.buttonBack1.Click += new System.EventHandler(this.buttonBack1_Click);
            // 
            // buttonDiningRoomMenu
            // 
            this.buttonDiningRoomMenu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonDiningRoomMenu.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDiningRoomMenu.Location = new System.Drawing.Point(111, 208);
            this.buttonDiningRoomMenu.Name = "buttonDiningRoomMenu";
            this.buttonDiningRoomMenu.Size = new System.Drawing.Size(280, 40);
            this.buttonDiningRoomMenu.TabIndex = 9;
            this.buttonDiningRoomMenu.Text = "Меню столовой";
            this.buttonDiningRoomMenu.UseVisualStyleBackColor = true;
            this.buttonDiningRoomMenu.Click += new System.EventHandler(this.buttonDiningRoomMenu_Click);
            // 
            // buttonEmployeeWorkSchedule1
            // 
            this.buttonEmployeeWorkSchedule1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonEmployeeWorkSchedule1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEmployeeWorkSchedule1.Location = new System.Drawing.Point(111, 254);
            this.buttonEmployeeWorkSchedule1.Name = "buttonEmployeeWorkSchedule1";
            this.buttonEmployeeWorkSchedule1.Size = new System.Drawing.Size(280, 40);
            this.buttonEmployeeWorkSchedule1.TabIndex = 10;
            this.buttonEmployeeWorkSchedule1.Text = "График работы сотрудников";
            this.buttonEmployeeWorkSchedule1.UseVisualStyleBackColor = true;
            // 
            // buttonTheReportOfTheSchoolCafeteria
            // 
            this.buttonTheReportOfTheSchoolCafeteria.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonTheReportOfTheSchoolCafeteria.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTheReportOfTheSchoolCafeteria.Location = new System.Drawing.Point(66, 300);
            this.buttonTheReportOfTheSchoolCafeteria.Name = "buttonTheReportOfTheSchoolCafeteria";
            this.buttonTheReportOfTheSchoolCafeteria.Size = new System.Drawing.Size(371, 40);
            this.buttonTheReportOfTheSchoolCafeteria.TabIndex = 11;
            this.buttonTheReportOfTheSchoolCafeteria.Text = "Отчет работы школьной столовой";
            this.buttonTheReportOfTheSchoolCafeteria.UseVisualStyleBackColor = true;
            // 
            // FormWorkingWindowOfTheEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(512, 453);
            this.Controls.Add(this.buttonTheReportOfTheSchoolCafeteria);
            this.Controls.Add(this.buttonEmployeeWorkSchedule1);
            this.Controls.Add(this.buttonDiningRoomMenu);
            this.Controls.Add(this.buttonBack1);
            this.Controls.Add(this.pictureBoxSchoolCanteen2);
            this.Name = "FormWorkingWindowOfTheEmployee";
            this.Text = "Рабочее окно сотрудника";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSchoolCanteen2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxSchoolCanteen2;
        private System.Windows.Forms.Button buttonBack1;
        private System.Windows.Forms.Button buttonDiningRoomMenu;
        private System.Windows.Forms.Button buttonEmployeeWorkSchedule1;
        private System.Windows.Forms.Button buttonTheReportOfTheSchoolCafeteria;
    }
}