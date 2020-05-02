namespace WinAppSchoolCanteen
{
    partial class FormTheReportOfTheSchoolCafeteria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTheReportOfTheSchoolCafeteria));
            this.buttonRefresh4 = new System.Windows.Forms.Button();
            this.buttonDisplayAll3 = new System.Windows.Forms.Button();
            this.buttonToFind3 = new System.Windows.Forms.Button();
            this.textBoxSearch3 = new System.Windows.Forms.TextBox();
            this.buttonDelete4 = new System.Windows.Forms.Button();
            this.buttonSave4 = new System.Windows.Forms.Button();
            this.buttonBack6 = new System.Windows.Forms.Button();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.schoolCanteenDataSet = new WinAppSchoolCanteen.SchoolCanteenDataSet();
            this.theReportOfTheSchoolCafeteriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.the_report_of_the_school_cafeteriaTableAdapter = new WinAppSchoolCanteen.SchoolCanteenDataSetTableAdapters.The_report_of_the_school_cafeteriaTableAdapter();
            this.idreportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоПосещаемыхУчениковDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBoxSchoolCanteen7 = new System.Windows.Forms.PictureBox();
            this.printDocumentReport = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolCanteenDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.theReportOfTheSchoolCafeteriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSchoolCanteen7)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRefresh4
            // 
            this.buttonRefresh4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRefresh4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRefresh4.Location = new System.Drawing.Point(485, 254);
            this.buttonRefresh4.Name = "buttonRefresh4";
            this.buttonRefresh4.Size = new System.Drawing.Size(180, 40);
            this.buttonRefresh4.TabIndex = 33;
            this.buttonRefresh4.Text = "Обновить";
            this.buttonRefresh4.UseVisualStyleBackColor = true;
            this.buttonRefresh4.Click += new System.EventHandler(this.buttonRefresh4_Click);
            // 
            // buttonDisplayAll3
            // 
            this.buttonDisplayAll3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDisplayAll3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDisplayAll3.Location = new System.Drawing.Point(485, 208);
            this.buttonDisplayAll3.Name = "buttonDisplayAll3";
            this.buttonDisplayAll3.Size = new System.Drawing.Size(180, 40);
            this.buttonDisplayAll3.TabIndex = 32;
            this.buttonDisplayAll3.Text = "Отобразить всё";
            this.buttonDisplayAll3.UseVisualStyleBackColor = true;
            this.buttonDisplayAll3.Click += new System.EventHandler(this.buttonDisplayAll3_Click);
            // 
            // buttonToFind3
            // 
            this.buttonToFind3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonToFind3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonToFind3.Location = new System.Drawing.Point(506, 162);
            this.buttonToFind3.Name = "buttonToFind3";
            this.buttonToFind3.Size = new System.Drawing.Size(140, 40);
            this.buttonToFind3.TabIndex = 31;
            this.buttonToFind3.Text = "Найти";
            this.buttonToFind3.UseVisualStyleBackColor = true;
            this.buttonToFind3.Click += new System.EventHandler(this.buttonToFind3_Click);
            // 
            // textBoxSearch3
            // 
            this.textBoxSearch3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearch3.Location = new System.Drawing.Point(485, 134);
            this.textBoxSearch3.Name = "textBoxSearch3";
            this.textBoxSearch3.Size = new System.Drawing.Size(180, 22);
            this.textBoxSearch3.TabIndex = 30;
            // 
            // buttonDelete4
            // 
            this.buttonDelete4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonDelete4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete4.Location = new System.Drawing.Point(224, 343);
            this.buttonDelete4.Name = "buttonDelete4";
            this.buttonDelete4.Size = new System.Drawing.Size(206, 40);
            this.buttonDelete4.TabIndex = 29;
            this.buttonDelete4.Text = "Удалить запись";
            this.buttonDelete4.UseVisualStyleBackColor = true;
            this.buttonDelete4.Click += new System.EventHandler(this.buttonDelete4_Click);
            // 
            // buttonSave4
            // 
            this.buttonSave4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonSave4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave4.Location = new System.Drawing.Point(12, 343);
            this.buttonSave4.Name = "buttonSave4";
            this.buttonSave4.Size = new System.Drawing.Size(206, 40);
            this.buttonSave4.TabIndex = 28;
            this.buttonSave4.Text = "Сохранить запись";
            this.buttonSave4.UseVisualStyleBackColor = true;
            this.buttonSave4.Click += new System.EventHandler(this.buttonSave4_Click);
            // 
            // buttonBack6
            // 
            this.buttonBack6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBack6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack6.Location = new System.Drawing.Point(534, 343);
            this.buttonBack6.Name = "buttonBack6";
            this.buttonBack6.Size = new System.Drawing.Size(140, 40);
            this.buttonBack6.TabIndex = 27;
            this.buttonBack6.Text = "Назад";
            this.buttonBack6.UseVisualStyleBackColor = true;
            this.buttonBack6.Click += new System.EventHandler(this.buttonBack6_Click);
            // 
            // buttonPrint
            // 
            this.buttonPrint.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonPrint.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPrint.Location = new System.Drawing.Point(151, 297);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(140, 40);
            this.buttonPrint.TabIndex = 34;
            this.buttonPrint.Text = "Печать";
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
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
            this.idreportDataGridViewTextBoxColumn,
            this.датаDataGridViewTextBoxColumn,
            this.количествоПосещаемыхУчениковDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.theReportOfTheSchoolCafeteriaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 133);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(453, 150);
            this.dataGridView1.TabIndex = 35;
            // 
            // schoolCanteenDataSet
            // 
            this.schoolCanteenDataSet.DataSetName = "SchoolCanteenDataSet";
            this.schoolCanteenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // theReportOfTheSchoolCafeteriaBindingSource
            // 
            this.theReportOfTheSchoolCafeteriaBindingSource.DataMember = "The report of the school cafeteria";
            this.theReportOfTheSchoolCafeteriaBindingSource.DataSource = this.schoolCanteenDataSet;
            // 
            // the_report_of_the_school_cafeteriaTableAdapter
            // 
            this.the_report_of_the_school_cafeteriaTableAdapter.ClearBeforeFill = true;
            // 
            // idreportDataGridViewTextBoxColumn
            // 
            this.idreportDataGridViewTextBoxColumn.DataPropertyName = "id_report";
            this.idreportDataGridViewTextBoxColumn.HeaderText = "id_report";
            this.idreportDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idreportDataGridViewTextBoxColumn.Name = "idreportDataGridViewTextBoxColumn";
            // 
            // датаDataGridViewTextBoxColumn
            // 
            this.датаDataGridViewTextBoxColumn.DataPropertyName = "Дата";
            this.датаDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.датаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.датаDataGridViewTextBoxColumn.Name = "датаDataGridViewTextBoxColumn";
            // 
            // количествоПосещаемыхУчениковDataGridViewTextBoxColumn
            // 
            this.количествоПосещаемыхУчениковDataGridViewTextBoxColumn.DataPropertyName = "Количество посещаемых учеников";
            this.количествоПосещаемыхУчениковDataGridViewTextBoxColumn.HeaderText = "Количество посещаемых учеников";
            this.количествоПосещаемыхУчениковDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.количествоПосещаемыхУчениковDataGridViewTextBoxColumn.Name = "количествоПосещаемыхУчениковDataGridViewTextBoxColumn";
            // 
            // pictureBoxSchoolCanteen7
            // 
            this.pictureBoxSchoolCanteen7.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBoxSchoolCanteen7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSchoolCanteen7.Image")));
            this.pictureBoxSchoolCanteen7.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxSchoolCanteen7.Name = "pictureBoxSchoolCanteen7";
            this.pictureBoxSchoolCanteen7.Size = new System.Drawing.Size(686, 127);
            this.pictureBoxSchoolCanteen7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSchoolCanteen7.TabIndex = 36;
            this.pictureBoxSchoolCanteen7.TabStop = false;
            // 
            // printDocumentReport
            // 
            this.printDocumentReport.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // FormTheReportOfTheSchoolCafeteria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(686, 395);
            this.Controls.Add(this.pictureBoxSchoolCanteen7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.buttonRefresh4);
            this.Controls.Add(this.buttonDisplayAll3);
            this.Controls.Add(this.buttonToFind3);
            this.Controls.Add(this.textBoxSearch3);
            this.Controls.Add(this.buttonDelete4);
            this.Controls.Add(this.buttonSave4);
            this.Controls.Add(this.buttonBack6);
            this.Name = "FormTheReportOfTheSchoolCafeteria";
            this.Text = "Отчет работы школьной столовой";
            this.Load += new System.EventHandler(this.FormTheReportOfTheSchoolCafeteria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolCanteenDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.theReportOfTheSchoolCafeteriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSchoolCanteen7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRefresh4;
        private System.Windows.Forms.Button buttonDisplayAll3;
        private System.Windows.Forms.Button buttonToFind3;
        private System.Windows.Forms.TextBox textBoxSearch3;
        private System.Windows.Forms.Button buttonDelete4;
        private System.Windows.Forms.Button buttonSave4;
        private System.Windows.Forms.Button buttonBack6;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.DataGridView dataGridView1;
        private SchoolCanteenDataSet schoolCanteenDataSet;
        private System.Windows.Forms.BindingSource theReportOfTheSchoolCafeteriaBindingSource;
        private SchoolCanteenDataSetTableAdapters.The_report_of_the_school_cafeteriaTableAdapter the_report_of_the_school_cafeteriaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idreportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоПосещаемыхУчениковDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBoxSchoolCanteen7;
        private System.Drawing.Printing.PrintDocument printDocumentReport;
    }
}