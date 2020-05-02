using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppSchoolCanteen
{
    public partial class FormListOfClasses : Form
    {
        public FormListOfClasses()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;//Что бы форма отображалась в центре экрана при запуске
            this.BackColor = Color.FromArgb(255, 255, 255);//Цвет фона белый
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolCanteenDataSet.List_of_classes". При необходимости она может быть перемещена или удалена.
            this.list_of_classesTableAdapter.Fill(this.schoolCanteenDataSet.List_of_classes);

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            list_of_classesTableAdapter.Update(schoolCanteenDataSet);
            MessageBox.Show("Изменения сохранены в базе данных");
        }

        private void buttonBack2_Click(object sender, EventArgs e)
        {
            Form formWorkingWindowOfTheAdministrator = new FormWorkingWindowOfTheAdministrator();
            formWorkingWindowOfTheAdministrator.ShowDialog();
            this.Hide();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);//Удаление записи
            list_of_classesTableAdapter.Update(schoolCanteenDataSet);//Обновление данных в базе
            MessageBox.Show("Запись удалена из базы данных");
        }

        private void buttonToFind_Click(object sender, EventArgs e)
        {
            //Устанавливаем фильтр в listOfClassesBindingSource
            listOfClassesBindingSource.Filter = "id_classes =\'" + textBoxSearch.Text + "\'";
        }

        private void buttonDisplayAll_Click(object sender, EventArgs e)
        {
            //Сбрасываем фильтр
            listOfClassesBindingSource.Filter = null;
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }
    }
}
