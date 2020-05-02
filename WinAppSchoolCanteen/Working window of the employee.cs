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
    public partial class FormWorkingWindowOfTheEmployee : System.Windows.Forms.Form
    {
        public FormWorkingWindowOfTheEmployee()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;//Что бы форма отображалась в центре экрана при запуске
            this.BackColor = Color.FromArgb(255, 255, 255);//Цвет фона белый
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void buttonBack1_Click(object sender, EventArgs e)
        {
            Form formAuthorization = new FormAuthorization();
            formAuthorization.ShowDialog();
            this.Hide();
        }

        private void buttonDiningRoomMenu_Click(object sender, EventArgs e)
        {
            Form formDiningRoomMenu = new FormDiningRoomMenu();
            formDiningRoomMenu.ShowDialog();
            this.Hide();
        }

        private void buttonTheReportOfTheSchoolCafeteria_Click(object sender, EventArgs e)
        {
            Form formTheReportOfTheSchoolCafeteria = new FormTheReportOfTheSchoolCafeteria();
            formTheReportOfTheSchoolCafeteria.ShowDialog();
            this.Hide();
        }
    }
}
