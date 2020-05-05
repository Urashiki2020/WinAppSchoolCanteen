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
    public partial class FormInformationAboutTheDeveloper : Form
    {
        public FormInformationAboutTheDeveloper()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;//Что бы форма отображалась в центре экрана при запуске
            this.BackColor = Color.FromArgb(255, 255, 255);//Цвет фона белый
        }

        private void buttonBack6_Click(object sender, EventArgs e)
        {
            Form formAuthorization = new FormAuthorization();
            formAuthorization.ShowDialog();
            this.Hide();
        }

        private void FormInformationAboutTheDeveloper_Load(object sender, EventArgs e)
        {

        }
    }
}
