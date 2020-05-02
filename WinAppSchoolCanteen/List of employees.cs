using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppSchoolCanteen
{
    public partial class FormListOfEmployees : Form
    {
        public FormListOfEmployees()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;//Что бы форма отображалась в центре экрана при запуске
            this.BackColor = Color.FromArgb(255, 255, 255);//Цвет фона белый
        }

        private void FormListOfEmployees_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolCanteenDataSet.List_of_employees". При необходимости она может быть перемещена или удалена.
            this.list_of_employeesTableAdapter.Fill(this.schoolCanteenDataSet.List_of_employees);

        }

        private void buttonBack3_Click(object sender, EventArgs e)
        {
            Form formWorkingWindowOfTheAdministrator = new FormWorkingWindowOfTheAdministrator();
            formWorkingWindowOfTheAdministrator.ShowDialog();
            this.Hide();
        }

        private void buttonSave1_Click(object sender, EventArgs e)
        {
            list_of_employeesTableAdapter.Update(schoolCanteenDataSet);//Обновление данных в базе
            MessageBox.Show("Изменения сохранены в базе данных");
        }

        private void buttonDelete1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);//Удаление записи
            list_of_employeesTableAdapter.Update(schoolCanteenDataSet);//Обновление данных в базе
            MessageBox.Show("Запись удалена, изменения сохранены в базе данных");
        }

        private void buttonRefresh1_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void buttonToFind1_Click(object sender, EventArgs e)
        {
            listOfEmployeesBindingSource.Filter = "ФИО =\'" + textBoxSearch1.Text + "\'";
        }

        private void buttonDisplayAll1_Click(object sender, EventArgs e)
        {
            listOfEmployeesBindingSource.Filter = null;
        }
    }
}
