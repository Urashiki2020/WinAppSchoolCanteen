namespace WinAppSchoolCanteen
{
    partial class FormDiningRoomMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDiningRoomMenu));
            this.buttonDelete3 = new System.Windows.Forms.Button();
            this.buttonSave3 = new System.Windows.Forms.Button();
            this.buttonBack5 = new System.Windows.Forms.Button();
            this.buttonRefresh3 = new System.Windows.Forms.Button();
            this.buttonDisplayAll2 = new System.Windows.Forms.Button();
            this.buttonToFind2 = new System.Windows.Forms.Button();
            this.textBoxSearch2 = new System.Windows.Forms.TextBox();
            this.pictureBoxSchoolCanteen6 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.schoolCanteenDataSet = new WinAppSchoolCanteen.SchoolCanteenDataSet();
            this.diningRoomMenuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dining_room_menuTableAdapter = new WinAppSchoolCanteen.SchoolCanteenDataSetTableAdapters.Dining_room_menuTableAdapter();
            this.idmenuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеБлюдаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSchoolCanteen6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolCanteenDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diningRoomMenuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDelete3
            // 
            this.buttonDelete3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonDelete3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete3.Location = new System.Drawing.Point(238, 375);
            this.buttonDelete3.Name = "buttonDelete3";
            this.buttonDelete3.Size = new System.Drawing.Size(206, 40);
            this.buttonDelete3.TabIndex = 22;
            this.buttonDelete3.Text = "Удалить запись";
            this.buttonDelete3.UseVisualStyleBackColor = true;
            this.buttonDelete3.Click += new System.EventHandler(this.buttonDelete3_Click);
            // 
            // buttonSave3
            // 
            this.buttonSave3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonSave3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave3.Location = new System.Drawing.Point(26, 375);
            this.buttonSave3.Name = "buttonSave3";
            this.buttonSave3.Size = new System.Drawing.Size(206, 40);
            this.buttonSave3.TabIndex = 21;
            this.buttonSave3.Text = "Сохранить запись";
            this.buttonSave3.UseVisualStyleBackColor = true;
            this.buttonSave3.Click += new System.EventHandler(this.buttonSave3_Click);
            // 
            // buttonBack5
            // 
            this.buttonBack5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBack5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack5.Location = new System.Drawing.Point(556, 375);
            this.buttonBack5.Name = "buttonBack5";
            this.buttonBack5.Size = new System.Drawing.Size(140, 40);
            this.buttonBack5.TabIndex = 20;
            this.buttonBack5.Text = "Назад";
            this.buttonBack5.UseVisualStyleBackColor = true;
            this.buttonBack5.Click += new System.EventHandler(this.buttonBack5_Click);
            // 
            // buttonRefresh3
            // 
            this.buttonRefresh3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRefresh3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRefresh3.Location = new System.Drawing.Point(500, 254);
            this.buttonRefresh3.Name = "buttonRefresh3";
            this.buttonRefresh3.Size = new System.Drawing.Size(180, 40);
            this.buttonRefresh3.TabIndex = 26;
            this.buttonRefresh3.Text = "Обновить";
            this.buttonRefresh3.UseVisualStyleBackColor = true;
            this.buttonRefresh3.Click += new System.EventHandler(this.buttonRefresh3_Click);
            // 
            // buttonDisplayAll2
            // 
            this.buttonDisplayAll2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDisplayAll2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDisplayAll2.Location = new System.Drawing.Point(500, 208);
            this.buttonDisplayAll2.Name = "buttonDisplayAll2";
            this.buttonDisplayAll2.Size = new System.Drawing.Size(180, 40);
            this.buttonDisplayAll2.TabIndex = 25;
            this.buttonDisplayAll2.Text = "Отобразить всё";
            this.buttonDisplayAll2.UseVisualStyleBackColor = true;
            this.buttonDisplayAll2.Click += new System.EventHandler(this.buttonDisplayAll2_Click);
            // 
            // buttonToFind2
            // 
            this.buttonToFind2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonToFind2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonToFind2.Location = new System.Drawing.Point(521, 162);
            this.buttonToFind2.Name = "buttonToFind2";
            this.buttonToFind2.Size = new System.Drawing.Size(140, 40);
            this.buttonToFind2.TabIndex = 24;
            this.buttonToFind2.Text = "Найти";
            this.buttonToFind2.UseVisualStyleBackColor = true;
            this.buttonToFind2.Click += new System.EventHandler(this.buttonToFind2_Click);
            // 
            // textBoxSearch2
            // 
            this.textBoxSearch2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearch2.Location = new System.Drawing.Point(500, 134);
            this.textBoxSearch2.Name = "textBoxSearch2";
            this.textBoxSearch2.Size = new System.Drawing.Size(180, 22);
            this.textBoxSearch2.TabIndex = 23;
            // 
            // pictureBoxSchoolCanteen6
            // 
            this.pictureBoxSchoolCanteen6.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBoxSchoolCanteen6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSchoolCanteen6.Image")));
            this.pictureBoxSchoolCanteen6.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxSchoolCanteen6.Name = "pictureBoxSchoolCanteen6";
            this.pictureBoxSchoolCanteen6.Size = new System.Drawing.Size(708, 127);
            this.pictureBoxSchoolCanteen6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSchoolCanteen6.TabIndex = 27;
            this.pictureBoxSchoolCanteen6.TabStop = false;
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
            this.idmenuDataGridViewTextBoxColumn,
            this.наименованиеБлюдаDataGridViewTextBoxColumn,
            this.ценаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.diningRoomMenuBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 133);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(457, 236);
            this.dataGridView1.TabIndex = 28;
            // 
            // schoolCanteenDataSet
            // 
            this.schoolCanteenDataSet.DataSetName = "SchoolCanteenDataSet";
            this.schoolCanteenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // diningRoomMenuBindingSource
            // 
            this.diningRoomMenuBindingSource.DataMember = "Dining room menu";
            this.diningRoomMenuBindingSource.DataSource = this.schoolCanteenDataSet;
            // 
            // dining_room_menuTableAdapter
            // 
            this.dining_room_menuTableAdapter.ClearBeforeFill = true;
            // 
            // idmenuDataGridViewTextBoxColumn
            // 
            this.idmenuDataGridViewTextBoxColumn.DataPropertyName = "id_menu";
            this.idmenuDataGridViewTextBoxColumn.HeaderText = "id_menu";
            this.idmenuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idmenuDataGridViewTextBoxColumn.Name = "idmenuDataGridViewTextBoxColumn";
            // 
            // наименованиеБлюдаDataGridViewTextBoxColumn
            // 
            this.наименованиеБлюдаDataGridViewTextBoxColumn.DataPropertyName = "Наименование блюда";
            this.наименованиеБлюдаDataGridViewTextBoxColumn.HeaderText = "Наименование блюда";
            this.наименованиеБлюдаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.наименованиеБлюдаDataGridViewTextBoxColumn.Name = "наименованиеБлюдаDataGridViewTextBoxColumn";
            // 
            // ценаDataGridViewTextBoxColumn
            // 
            this.ценаDataGridViewTextBoxColumn.DataPropertyName = "Цена";
            this.ценаDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.ценаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ценаDataGridViewTextBoxColumn.Name = "ценаDataGridViewTextBoxColumn";
            // 
            // FormDiningRoomMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(708, 427);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBoxSchoolCanteen6);
            this.Controls.Add(this.buttonRefresh3);
            this.Controls.Add(this.buttonDisplayAll2);
            this.Controls.Add(this.buttonToFind2);
            this.Controls.Add(this.textBoxSearch2);
            this.Controls.Add(this.buttonDelete3);
            this.Controls.Add(this.buttonSave3);
            this.Controls.Add(this.buttonBack5);
            this.Name = "FormDiningRoomMenu";
            this.Text = "Меню столовой";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSchoolCanteen6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolCanteenDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diningRoomMenuBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDelete3;
        private System.Windows.Forms.Button buttonSave3;
        private System.Windows.Forms.Button buttonBack5;
        private System.Windows.Forms.Button buttonRefresh3;
        private System.Windows.Forms.Button buttonDisplayAll2;
        private System.Windows.Forms.Button buttonToFind2;
        private System.Windows.Forms.TextBox textBoxSearch2;
        private System.Windows.Forms.PictureBox pictureBoxSchoolCanteen6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private SchoolCanteenDataSet schoolCanteenDataSet;
        private System.Windows.Forms.BindingSource diningRoomMenuBindingSource;
        private SchoolCanteenDataSetTableAdapters.Dining_room_menuTableAdapter dining_room_menuTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmenuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеБлюдаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаDataGridViewTextBoxColumn;
    }
}