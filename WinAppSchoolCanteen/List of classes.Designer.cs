namespace WinAppSchoolCanteen
{
    partial class FormListOfClasses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListOfClasses));
            this.pictureBoxSchoolCanteen3 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idclassesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерКлассаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listOfClassesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schoolCanteenDataSet = new WinAppSchoolCanteen.SchoolCanteenDataSet();
            this.list_of_classesTableAdapter = new WinAppSchoolCanteen.SchoolCanteenDataSetTableAdapters.List_of_classesTableAdapter();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonBack2 = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonToFind = new System.Windows.Forms.Button();
            this.buttonDisplayAll = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.listOfClassesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSchoolCanteen3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listOfClassesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolCanteenDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listOfClassesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxSchoolCanteen3
            // 
            this.pictureBoxSchoolCanteen3.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBoxSchoolCanteen3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSchoolCanteen3.Image")));
            this.pictureBoxSchoolCanteen3.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxSchoolCanteen3.Name = "pictureBoxSchoolCanteen3";
            this.pictureBoxSchoolCanteen3.Size = new System.Drawing.Size(702, 127);
            this.pictureBoxSchoolCanteen3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSchoolCanteen3.TabIndex = 1;
            this.pictureBoxSchoolCanteen3.TabStop = false;
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
            this.idclassesDataGridViewTextBoxColumn,
            this.номерКлассаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.listOfClassesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 144);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(418, 196);
            this.dataGridView1.TabIndex = 2;
            // 
            // idclassesDataGridViewTextBoxColumn
            // 
            this.idclassesDataGridViewTextBoxColumn.DataPropertyName = "id_classes";
            this.idclassesDataGridViewTextBoxColumn.HeaderText = "id_classes";
            this.idclassesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idclassesDataGridViewTextBoxColumn.Name = "idclassesDataGridViewTextBoxColumn";
            // 
            // номерКлассаDataGridViewTextBoxColumn
            // 
            this.номерКлассаDataGridViewTextBoxColumn.DataPropertyName = "Номер класса";
            this.номерКлассаDataGridViewTextBoxColumn.HeaderText = "Номер класса";
            this.номерКлассаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.номерКлассаDataGridViewTextBoxColumn.Name = "номерКлассаDataGridViewTextBoxColumn";
            // 
            // listOfClassesBindingSource
            // 
            this.listOfClassesBindingSource.DataMember = "List of classes";
            this.listOfClassesBindingSource.DataSource = this.schoolCanteenDataSet;
            // 
            // schoolCanteenDataSet
            // 
            this.schoolCanteenDataSet.DataSetName = "SchoolCanteenDataSet";
            this.schoolCanteenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // list_of_classesTableAdapter
            // 
            this.list_of_classesTableAdapter.ClearBeforeFill = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonSave.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.Location = new System.Drawing.Point(12, 346);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(206, 40);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "Сохранить запись";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonBack2
            // 
            this.buttonBack2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBack2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack2.Location = new System.Drawing.Point(550, 346);
            this.buttonBack2.Name = "buttonBack2";
            this.buttonBack2.Size = new System.Drawing.Size(140, 40);
            this.buttonBack2.TabIndex = 7;
            this.buttonBack2.Text = "Назад";
            this.buttonBack2.UseVisualStyleBackColor = true;
            this.buttonBack2.Click += new System.EventHandler(this.buttonBack2_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonDelete.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.Location = new System.Drawing.Point(224, 346);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(206, 40);
            this.buttonDelete.TabIndex = 8;
            this.buttonDelete.Text = "Удалить запись";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearch.Location = new System.Drawing.Point(477, 146);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(180, 22);
            this.textBoxSearch.TabIndex = 9;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // buttonToFind
            // 
            this.buttonToFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonToFind.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonToFind.Location = new System.Drawing.Point(498, 174);
            this.buttonToFind.Name = "buttonToFind";
            this.buttonToFind.Size = new System.Drawing.Size(140, 40);
            this.buttonToFind.TabIndex = 10;
            this.buttonToFind.Text = "Найти";
            this.buttonToFind.UseVisualStyleBackColor = true;
            this.buttonToFind.Click += new System.EventHandler(this.buttonToFind_Click);
            // 
            // buttonDisplayAll
            // 
            this.buttonDisplayAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDisplayAll.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDisplayAll.Location = new System.Drawing.Point(477, 220);
            this.buttonDisplayAll.Name = "buttonDisplayAll";
            this.buttonDisplayAll.Size = new System.Drawing.Size(180, 40);
            this.buttonDisplayAll.TabIndex = 11;
            this.buttonDisplayAll.Text = "Отобразить всё";
            this.buttonDisplayAll.UseVisualStyleBackColor = true;
            this.buttonDisplayAll.Click += new System.EventHandler(this.buttonDisplayAll_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRefresh.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRefresh.Location = new System.Drawing.Point(477, 266);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(180, 40);
            this.buttonRefresh.TabIndex = 12;
            this.buttonRefresh.Text = "Обновить";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // listOfClassesBindingSource1
            // 
            this.listOfClassesBindingSource1.DataMember = "List of classes";
            this.listOfClassesBindingSource1.DataSource = this.schoolCanteenDataSet;
            // 
            // FormListOfClasses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(702, 398);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonDisplayAll);
            this.Controls.Add(this.buttonToFind);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonBack2);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBoxSchoolCanteen3);
            this.Name = "FormListOfClasses";
            this.Text = "Список классов";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSchoolCanteen3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listOfClassesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolCanteenDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listOfClassesBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxSchoolCanteen3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private SchoolCanteenDataSet schoolCanteenDataSet;
        private System.Windows.Forms.BindingSource listOfClassesBindingSource;
        private SchoolCanteenDataSetTableAdapters.List_of_classesTableAdapter list_of_classesTableAdapter;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonBack2;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonToFind;
        private System.Windows.Forms.Button buttonDisplayAll;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn idclassesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерКлассаDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource listOfClassesBindingSource1;
    }
}