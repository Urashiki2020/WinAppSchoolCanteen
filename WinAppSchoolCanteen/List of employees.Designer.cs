namespace WinAppSchoolCanteen
{
    partial class FormListOfEmployees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListOfEmployees));
            this.pictureBoxSchoolCanteen4 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idemployeesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаРожденияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерТелефонаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.местоПроживанияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адресЭлектроннойПочтыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.должностьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listOfEmployeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schoolCanteenDataSet = new WinAppSchoolCanteen.SchoolCanteenDataSet();
            this.list_of_employeesTableAdapter = new WinAppSchoolCanteen.SchoolCanteenDataSetTableAdapters.List_of_employeesTableAdapter();
            this.buttonBack3 = new System.Windows.Forms.Button();
            this.buttonDelete1 = new System.Windows.Forms.Button();
            this.buttonSave1 = new System.Windows.Forms.Button();
            this.buttonRefresh1 = new System.Windows.Forms.Button();
            this.buttonDisplayAll1 = new System.Windows.Forms.Button();
            this.buttonToFind1 = new System.Windows.Forms.Button();
            this.textBoxSearch1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSchoolCanteen4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listOfEmployeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolCanteenDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxSchoolCanteen4
            // 
            this.pictureBoxSchoolCanteen4.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBoxSchoolCanteen4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSchoolCanteen4.Image")));
            this.pictureBoxSchoolCanteen4.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxSchoolCanteen4.Name = "pictureBoxSchoolCanteen4";
            this.pictureBoxSchoolCanteen4.Size = new System.Drawing.Size(800, 127);
            this.pictureBoxSchoolCanteen4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSchoolCanteen4.TabIndex = 2;
            this.pictureBoxSchoolCanteen4.TabStop = false;
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
            this.idemployeesDataGridViewTextBoxColumn,
            this.фИОDataGridViewTextBoxColumn,
            this.датаРожденияDataGridViewTextBoxColumn,
            this.номерТелефонаDataGridViewTextBoxColumn,
            this.местоПроживанияDataGridViewTextBoxColumn,
            this.адресЭлектроннойПочтыDataGridViewTextBoxColumn,
            this.должностьDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.listOfEmployeesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 133);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 167);
            this.dataGridView1.TabIndex = 3;
            // 
            // idemployeesDataGridViewTextBoxColumn
            // 
            this.idemployeesDataGridViewTextBoxColumn.DataPropertyName = "id_employees";
            this.idemployeesDataGridViewTextBoxColumn.HeaderText = "id_employees";
            this.idemployeesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idemployeesDataGridViewTextBoxColumn.Name = "idemployeesDataGridViewTextBoxColumn";
            // 
            // фИОDataGridViewTextBoxColumn
            // 
            this.фИОDataGridViewTextBoxColumn.DataPropertyName = "ФИО";
            this.фИОDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.фИОDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.фИОDataGridViewTextBoxColumn.Name = "фИОDataGridViewTextBoxColumn";
            // 
            // датаРожденияDataGridViewTextBoxColumn
            // 
            this.датаРожденияDataGridViewTextBoxColumn.DataPropertyName = "Дата рождения";
            this.датаРожденияDataGridViewTextBoxColumn.HeaderText = "Дата рождения";
            this.датаРожденияDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.датаРожденияDataGridViewTextBoxColumn.Name = "датаРожденияDataGridViewTextBoxColumn";
            // 
            // номерТелефонаDataGridViewTextBoxColumn
            // 
            this.номерТелефонаDataGridViewTextBoxColumn.DataPropertyName = "Номер телефона";
            this.номерТелефонаDataGridViewTextBoxColumn.HeaderText = "Номер телефона";
            this.номерТелефонаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.номерТелефонаDataGridViewTextBoxColumn.Name = "номерТелефонаDataGridViewTextBoxColumn";
            // 
            // местоПроживанияDataGridViewTextBoxColumn
            // 
            this.местоПроживанияDataGridViewTextBoxColumn.DataPropertyName = "Место проживания";
            this.местоПроживанияDataGridViewTextBoxColumn.HeaderText = "Место проживания";
            this.местоПроживанияDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.местоПроживанияDataGridViewTextBoxColumn.Name = "местоПроживанияDataGridViewTextBoxColumn";
            // 
            // адресЭлектроннойПочтыDataGridViewTextBoxColumn
            // 
            this.адресЭлектроннойПочтыDataGridViewTextBoxColumn.DataPropertyName = "Адрес электронной почты";
            this.адресЭлектроннойПочтыDataGridViewTextBoxColumn.HeaderText = "Адрес электронной почты";
            this.адресЭлектроннойПочтыDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.адресЭлектроннойПочтыDataGridViewTextBoxColumn.Name = "адресЭлектроннойПочтыDataGridViewTextBoxColumn";
            // 
            // должностьDataGridViewTextBoxColumn
            // 
            this.должностьDataGridViewTextBoxColumn.DataPropertyName = "Должность";
            this.должностьDataGridViewTextBoxColumn.HeaderText = "Должность";
            this.должностьDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.должностьDataGridViewTextBoxColumn.Name = "должностьDataGridViewTextBoxColumn";
            // 
            // listOfEmployeesBindingSource
            // 
            this.listOfEmployeesBindingSource.DataMember = "List of employees";
            this.listOfEmployeesBindingSource.DataSource = this.schoolCanteenDataSet;
            // 
            // schoolCanteenDataSet
            // 
            this.schoolCanteenDataSet.DataSetName = "SchoolCanteenDataSet";
            this.schoolCanteenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // list_of_employeesTableAdapter
            // 
            this.list_of_employeesTableAdapter.ClearBeforeFill = true;
            // 
            // buttonBack3
            // 
            this.buttonBack3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBack3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack3.Location = new System.Drawing.Point(648, 433);
            this.buttonBack3.Name = "buttonBack3";
            this.buttonBack3.Size = new System.Drawing.Size(140, 40);
            this.buttonBack3.TabIndex = 8;
            this.buttonBack3.Text = "Назад";
            this.buttonBack3.UseVisualStyleBackColor = true;
            this.buttonBack3.Click += new System.EventHandler(this.buttonBack3_Click);
            // 
            // buttonDelete1
            // 
            this.buttonDelete1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDelete1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete1.Location = new System.Drawing.Point(582, 313);
            this.buttonDelete1.Name = "buttonDelete1";
            this.buttonDelete1.Size = new System.Drawing.Size(206, 40);
            this.buttonDelete1.TabIndex = 10;
            this.buttonDelete1.Text = "Удалить запись";
            this.buttonDelete1.UseVisualStyleBackColor = true;
            this.buttonDelete1.Click += new System.EventHandler(this.buttonDelete1_Click);
            // 
            // buttonSave1
            // 
            this.buttonSave1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave1.Location = new System.Drawing.Point(370, 313);
            this.buttonSave1.Name = "buttonSave1";
            this.buttonSave1.Size = new System.Drawing.Size(206, 40);
            this.buttonSave1.TabIndex = 9;
            this.buttonSave1.Text = "Сохранить запись";
            this.buttonSave1.UseVisualStyleBackColor = true;
            this.buttonSave1.Click += new System.EventHandler(this.buttonSave1_Click);
            // 
            // buttonRefresh1
            // 
            this.buttonRefresh1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonRefresh1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRefresh1.Location = new System.Drawing.Point(12, 433);
            this.buttonRefresh1.Name = "buttonRefresh1";
            this.buttonRefresh1.Size = new System.Drawing.Size(180, 40);
            this.buttonRefresh1.TabIndex = 16;
            this.buttonRefresh1.Text = "Обновить";
            this.buttonRefresh1.UseVisualStyleBackColor = true;
            this.buttonRefresh1.Click += new System.EventHandler(this.buttonRefresh1_Click);
            // 
            // buttonDisplayAll1
            // 
            this.buttonDisplayAll1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDisplayAll1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDisplayAll1.Location = new System.Drawing.Point(12, 387);
            this.buttonDisplayAll1.Name = "buttonDisplayAll1";
            this.buttonDisplayAll1.Size = new System.Drawing.Size(180, 40);
            this.buttonDisplayAll1.TabIndex = 15;
            this.buttonDisplayAll1.Text = "Отобразить всё";
            this.buttonDisplayAll1.UseVisualStyleBackColor = true;
            this.buttonDisplayAll1.Click += new System.EventHandler(this.buttonDisplayAll1_Click);
            // 
            // buttonToFind1
            // 
            this.buttonToFind1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonToFind1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonToFind1.Location = new System.Drawing.Point(33, 341);
            this.buttonToFind1.Name = "buttonToFind1";
            this.buttonToFind1.Size = new System.Drawing.Size(140, 40);
            this.buttonToFind1.TabIndex = 14;
            this.buttonToFind1.Text = "Найти";
            this.buttonToFind1.UseVisualStyleBackColor = true;
            this.buttonToFind1.Click += new System.EventHandler(this.buttonToFind1_Click);
            // 
            // textBoxSearch1
            // 
            this.textBoxSearch1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxSearch1.Location = new System.Drawing.Point(12, 313);
            this.textBoxSearch1.Name = "textBoxSearch1";
            this.textBoxSearch1.Size = new System.Drawing.Size(180, 22);
            this.textBoxSearch1.TabIndex = 13;
            // 
            // FormListOfEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 485);
            this.Controls.Add(this.buttonRefresh1);
            this.Controls.Add(this.buttonDisplayAll1);
            this.Controls.Add(this.buttonToFind1);
            this.Controls.Add(this.textBoxSearch1);
            this.Controls.Add(this.buttonDelete1);
            this.Controls.Add(this.buttonSave1);
            this.Controls.Add(this.buttonBack3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBoxSchoolCanteen4);
            this.Name = "FormListOfEmployees";
            this.Text = "Список сотрудников";
            this.Load += new System.EventHandler(this.FormListOfEmployees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSchoolCanteen4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listOfEmployeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolCanteenDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxSchoolCanteen4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private SchoolCanteenDataSet schoolCanteenDataSet;
        private System.Windows.Forms.BindingSource listOfEmployeesBindingSource;
        private SchoolCanteenDataSetTableAdapters.List_of_employeesTableAdapter list_of_employeesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idemployeesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаРожденияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерТелефонаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn местоПроживанияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn адресЭлектроннойПочтыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn должностьDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonBack3;
        private System.Windows.Forms.Button buttonDelete1;
        private System.Windows.Forms.Button buttonSave1;
        private System.Windows.Forms.Button buttonRefresh1;
        private System.Windows.Forms.Button buttonDisplayAll1;
        private System.Windows.Forms.Button buttonToFind1;
        private System.Windows.Forms.TextBox textBoxSearch1;
    }
}