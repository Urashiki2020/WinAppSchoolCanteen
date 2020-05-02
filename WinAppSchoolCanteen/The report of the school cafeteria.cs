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
    public partial class FormTheReportOfTheSchoolCafeteria : Form
    {
        public FormTheReportOfTheSchoolCafeteria()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;//Что бы форма отображалась в центре экрана при запуске
            this.BackColor = Color.FromArgb(255, 255, 255);//Цвет фона белый
        }

        private void FormTheReportOfTheSchoolCafeteria_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolCanteenDataSet.The_report_of_the_school_cafeteria". При необходимости она может быть перемещена или удалена.
            this.the_report_of_the_school_cafeteriaTableAdapter.Fill(this.schoolCanteenDataSet.The_report_of_the_school_cafeteria);

        }

        private void buttonBack6_Click(object sender, EventArgs e)
        {
            Form formWorkingWindowOfTheEmployee = new FormWorkingWindowOfTheEmployee();
            formWorkingWindowOfTheEmployee.ShowDialog();
            this.Hide();
        }

        private void buttonSave4_Click(object sender, EventArgs e)
        {
            the_report_of_the_school_cafeteriaTableAdapter.Update(schoolCanteenDataSet);//Обновление данных в базе
            MessageBox.Show("Изменения сохранены в базе данных");
        }

        private void buttonDelete4_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);//Удаление записи
            the_report_of_the_school_cafeteriaTableAdapter.Update(schoolCanteenDataSet);//Обновление данных в базе
            MessageBox.Show("Запись удалена, изменения сохранены в базе данных");
        }

        private void buttonToFind3_Click(object sender, EventArgs e)
        {
            theReportOfTheSchoolCafeteriaBindingSource.Filter = "Количество посещаемых учеников =\'" + textBoxSearch3.Text + "\'";
        }

        private void buttonDisplayAll3_Click(object sender, EventArgs e)
        {
            theReportOfTheSchoolCafeteriaBindingSource.Filter = null;
        }

        private void buttonRefresh4_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(dataGridView1.Size.Width + 10, dataGridView1.Size.Height + 10);
            dataGridView1.DrawToBitmap(bmp, dataGridView1.Bounds);
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            printDocumentReport.Print();
        }
    }
}
