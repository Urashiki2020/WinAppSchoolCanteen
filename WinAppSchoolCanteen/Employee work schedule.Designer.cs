namespace WinAppSchoolCanteen
{
    partial class FormEmployeeWorkSchedule
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmployeeWorkSchedule));
            this.buttonRefresh2 = new System.Windows.Forms.Button();
            this.buttonDelete2 = new System.Windows.Forms.Button();
            this.buttonSave2 = new System.Windows.Forms.Button();
            this.buttonBack4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.schoolCanteenDataSet = new WinAppSchoolCanteen.SchoolCanteenDataSet();
            this.employeeWorkScheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employee_work_scheduleTableAdapter = new WinAppSchoolCanteen.SchoolCanteenDataSetTableAdapters.Employee_work_scheduleTableAdapter();
            this.idworkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сотрудникDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.рабочееВремяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.рабочиеДниDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.дниОтпускаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBoxSchoolCanteen5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolCanteenDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeWorkScheduleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSchoolCanteen5)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRefresh2
            // 
            this.buttonRefresh2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonRefresh2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRefresh2.Location = new System.Drawing.Point(12, 351);
            this.buttonRefresh2.Name = "buttonRefresh2";
            this.buttonRefresh2.Size = new System.Drawing.Size(180, 40);
            this.buttonRefresh2.TabIndex = 20;
            this.buttonRefresh2.Text = "Обновить";
            this.buttonRefresh2.UseVisualStyleBackColor = true;
            this.buttonRefresh2.Click += new System.EventHandler(this.buttonRefresh2_Click);
            // 
            // buttonDelete2
            // 
            this.buttonDelete2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonDelete2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete2.Location = new System.Drawing.Point(391, 289);
            this.buttonDelete2.Name = "buttonDelete2";
            this.buttonDelete2.Size = new System.Drawing.Size(206, 40);
            this.buttonDelete2.TabIndex = 19;
            this.buttonDelete2.Text = "Удалить запись";
            this.buttonDelete2.UseVisualStyleBackColor = true;
            this.buttonDelete2.Click += new System.EventHandler(this.buttonDelete2_Click);
            // 
            // buttonSave2
            // 
            this.buttonSave2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonSave2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave2.Location = new System.Drawing.Point(179, 289);
            this.buttonSave2.Name = "buttonSave2";
            this.buttonSave2.Size = new System.Drawing.Size(206, 40);
            this.buttonSave2.TabIndex = 18;
            this.buttonSave2.Text = "Сохранить запись";
            this.buttonSave2.UseVisualStyleBackColor = true;
            this.buttonSave2.Click += new System.EventHandler(this.buttonSave2_Click);
            // 
            // buttonBack4
            // 
            this.buttonBack4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBack4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack4.Location = new System.Drawing.Point(648, 351);
            this.buttonBack4.Name = "buttonBack4";
            this.buttonBack4.Size = new System.Drawing.Size(140, 40);
            this.buttonBack4.TabIndex = 17;
            this.buttonBack4.Text = "Назад";
            this.buttonBack4.UseVisualStyleBackColor = true;
            this.buttonBack4.Click += new System.EventHandler(this.buttonBack4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idworkDataGridViewTextBoxColumn,
            this.сотрудникDataGridViewTextBoxColumn,
            this.рабочееВремяDataGridViewTextBoxColumn,
            this.рабочиеДниDataGridViewTextBoxColumn,
            this.дниОтпускаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.employeeWorkScheduleBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 133);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 150);
            this.dataGridView1.TabIndex = 21;
            // 
            // schoolCanteenDataSet
            // 
            this.schoolCanteenDataSet.DataSetName = "SchoolCanteenDataSet";
            this.schoolCanteenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeWorkScheduleBindingSource
            // 
            this.employeeWorkScheduleBindingSource.DataMember = "Employee work schedule";
            this.employeeWorkScheduleBindingSource.DataSource = this.schoolCanteenDataSet;
            // 
            // employee_work_scheduleTableAdapter
            // 
            this.employee_work_scheduleTableAdapter.ClearBeforeFill = true;
            // 
            // idworkDataGridViewTextBoxColumn
            // 
            this.idworkDataGridViewTextBoxColumn.DataPropertyName = "id_work";
            this.idworkDataGridViewTextBoxColumn.HeaderText = "id_work";
            this.idworkDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idworkDataGridViewTextBoxColumn.Name = "idworkDataGridViewTextBoxColumn";
            // 
            // сотрудникDataGridViewTextBoxColumn
            // 
            this.сотрудникDataGridViewTextBoxColumn.DataPropertyName = "Сотрудник";
            this.сотрудникDataGridViewTextBoxColumn.HeaderText = "Сотрудник";
            this.сотрудникDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.сотрудникDataGridViewTextBoxColumn.Name = "сотрудникDataGridViewTextBoxColumn";
            // 
            // рабочееВремяDataGridViewTextBoxColumn
            // 
            this.рабочееВремяDataGridViewTextBoxColumn.DataPropertyName = "Рабочее время";
            this.рабочееВремяDataGridViewTextBoxColumn.HeaderText = "Рабочее время";
            this.рабочееВремяDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.рабочееВремяDataGridViewTextBoxColumn.Name = "рабочееВремяDataGridViewTextBoxColumn";
            // 
            // рабочиеДниDataGridViewTextBoxColumn
            // 
            this.рабочиеДниDataGridViewTextBoxColumn.DataPropertyName = "Рабочие дни";
            this.рабочиеДниDataGridViewTextBoxColumn.HeaderText = "Рабочие дни";
            this.рабочиеДниDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.рабочиеДниDataGridViewTextBoxColumn.Name = "рабочиеДниDataGridViewTextBoxColumn";
            // 
            // дниОтпускаDataGridViewTextBoxColumn
            // 
            this.дниОтпускаDataGridViewTextBoxColumn.DataPropertyName = "Дни отпуска";
            this.дниОтпускаDataGridViewTextBoxColumn.HeaderText = "Дни отпуска";
            this.дниОтпускаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.дниОтпускаDataGridViewTextBoxColumn.Name = "дниОтпускаDataGridViewTextBoxColumn";
            // 
            // pictureBoxSchoolCanteen5
            // 
            this.pictureBoxSchoolCanteen5.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBoxSchoolCanteen5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSchoolCanteen5.Image")));
            this.pictureBoxSchoolCanteen5.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxSchoolCanteen5.Name = "pictureBoxSchoolCanteen5";
            this.pictureBoxSchoolCanteen5.Size = new System.Drawing.Size(800, 127);
            this.pictureBoxSchoolCanteen5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSchoolCanteen5.TabIndex = 22;
            this.pictureBoxSchoolCanteen5.TabStop = false;
            // 
            // FormEmployeeWorkSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 403);
            this.Controls.Add(this.pictureBoxSchoolCanteen5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonRefresh2);
            this.Controls.Add(this.buttonDelete2);
            this.Controls.Add(this.buttonSave2);
            this.Controls.Add(this.buttonBack4);
            this.Name = "FormEmployeeWorkSchedule";
            this.Text = "График работы сотрудников";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolCanteenDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeWorkScheduleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSchoolCanteen5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonRefresh2;
        private System.Windows.Forms.Button buttonDelete2;
        private System.Windows.Forms.Button buttonSave2;
        private System.Windows.Forms.Button buttonBack4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private SchoolCanteenDataSet schoolCanteenDataSet;
        private System.Windows.Forms.BindingSource employeeWorkScheduleBindingSource;
        private SchoolCanteenDataSetTableAdapters.Employee_work_scheduleTableAdapter employee_work_scheduleTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idworkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn сотрудникDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn рабочееВремяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn рабочиеДниDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn дниОтпускаDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBoxSchoolCanteen5;
    }
}