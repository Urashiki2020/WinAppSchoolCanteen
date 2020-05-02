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
    public partial class FormEmployeeWorkSchedule : Form
    {
        public FormEmployeeWorkSchedule()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;//Что бы форма отображалась в центре экрана при запуске
            this.BackColor = Color.FromArgb(255, 255, 255);//Цвет фона белый
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolCanteenDataSet.Employee_work_schedule". При необходимости она может быть перемещена или удалена.
            this.employee_work_scheduleTableAdapter.Fill(this.schoolCanteenDataSet.Employee_work_schedule);

        }

        private void buttonRefresh2_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void buttonBack4_Click(object sender, EventArgs e)
        {
            Form formWorkingWindowOfTheAdministrator = new FormWorkingWindowOfTheAdministrator();
            formWorkingWindowOfTheAdministrator.ShowDialog();
            this.Hide();
        }

        private void buttonSave2_Click(object sender, EventArgs e)
        {
            employee_work_scheduleTableAdapter.Update(schoolCanteenDataSet);//Обновление данных в базе
            MessageBox.Show("Изменения сохранены в базе данных");
        }

        private void buttonDelete2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);//Удаление записи
            employee_work_scheduleTableAdapter.Update(schoolCanteenDataSet);//Обновление данных в базе
            MessageBox.Show("Запись удалена, изменения сохранены в базе данных");
        }
    }
}
