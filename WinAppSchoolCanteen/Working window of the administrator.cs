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
    public partial class FormWorkingWindowOfTheAdministrator : System.Windows.Forms.Form
    {
        public FormWorkingWindowOfTheAdministrator()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;//Что бы форма отображалась в центре экрана при запуске
            this.BackColor = Color.FromArgb(255, 255, 255);//Цвет фона белый
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form formAuthorization = new FormAuthorization();
            formAuthorization.ShowDialog();
            this.Hide();
        }

        private void buttonListOfClasses_Click(object sender, EventArgs e)
        {
            Form formListOfClasses = new FormListOfClasses();
            formListOfClasses.ShowDialog();
            this.Hide();
        }

        private void buttonListOfEmployees_Click(object sender, EventArgs e)
        {
            Form formListOfEmployees = new FormListOfEmployees();
            formListOfEmployees.ShowDialog();
            this.Hide();

        }

        private void buttonEmployeeWorkSchedule_Click(object sender, EventArgs e)
        {
            Form formEmployeeWorkSchedule = new FormEmployeeWorkSchedule();
            formEmployeeWorkSchedule.ShowDialog();
            this.Hide();
        }
    }
}
