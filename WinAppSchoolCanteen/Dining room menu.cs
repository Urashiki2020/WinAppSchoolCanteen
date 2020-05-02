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
    public partial class FormDiningRoomMenu : Form
    {
        public FormDiningRoomMenu()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;//Что бы форма отображалась в центре экрана при запуске
            this.BackColor = Color.FromArgb(255, 255, 255);//Цвет фона белый
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolCanteenDataSet.Dining_room_menu". При необходимости она может быть перемещена или удалена.
            this.dining_room_menuTableAdapter.Fill(this.schoolCanteenDataSet.Dining_room_menu);

        }

        private void buttonBack5_Click(object sender, EventArgs e)
        {
            Form formWorkingWindowOfTheEmployee = new FormWorkingWindowOfTheEmployee();
            formWorkingWindowOfTheEmployee.ShowDialog();
            this.Hide();
        }

        private void buttonSave3_Click(object sender, EventArgs e)
        {
            dining_room_menuTableAdapter.Update(schoolCanteenDataSet);//Обновление данных в базе
            MessageBox.Show("Изменения сохранены в базе данных");
        }

        private void buttonDelete3_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);//Удаление записи
            dining_room_menuTableAdapter.Update(schoolCanteenDataSet);//Обновление данных в базе
            MessageBox.Show("Запись удалена, изменения сохранены в базе данных");
        }

        private void buttonToFind2_Click(object sender, EventArgs e)
        {
            diningRoomMenuBindingSource.Filter = "Наименование блюда =\'" + textBoxSearch2.Text + "\'";
        }

        private void buttonDisplayAll2_Click(object sender, EventArgs e)
        {
            diningRoomMenuBindingSource.Filter = null;
        }

        private void buttonRefresh3_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }
    }
}
