using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Odbc;

namespace WinAppSchoolCanteen
{
    public partial class FormAuthorization : System.Windows.Forms.Form
    {
        public FormAuthorization()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;//Что бы форма отображалась в центре экрана при запуске
            this.BackColor = Color.FromArgb(255, 255, 255);//Цвет фона белый
        }

        private void FormAuthorization_Load(object sender, EventArgs e)
        {
           
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonInput_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-TVLAIMU\SQLEXPRESS;Initial Catalog=SchoolCanteen;Integrated Security=True");//Строка подключения базы данных
            try
            {
                //Код проверки совпадения логин-пароль-роль для администратора
                string commandAdministrator = "SELECT*FROM Users WHERE login='" + textBoxLogin.Text + "' AND password='" + textBoxPassword.Text + "'AND role='administrator'";
                SqlCommand checkAdministrator = new SqlCommand(commandAdministrator, connection);

                //Код проверки совпадения логин-пароль-роль для сотрудника
                string commandEmployee = "SELECT*FROM Users WHERE login='" + textBoxLogin.Text + "' AND password='" + textBoxPassword.Text + "'AND role='employee'";
                SqlCommand checkEmployee = new SqlCommand(commandEmployee, connection);

                connection.Open();
                if (checkAdministrator.ExecuteScalar() != null)//Если логин-пароль администратора совпадают то переход на форму "Рабочее окно администратора"
                {
                    Form formWorkingWindowOfTheAdministrator = new FormWorkingWindowOfTheAdministrator();
                    formWorkingWindowOfTheAdministrator.ShowDialog();
                    this.Hide();
                }
                else
                {
                    if (checkEmployee.ExecuteScalar() != null)//Если логин-пароль сотрудника совпадают то переход на форму "Рабочее окно сотрудника"
                    {
                        Form formWorkingWindowOfTheEmployee = new FormWorkingWindowOfTheEmployee();
                        formWorkingWindowOfTheEmployee.ShowDialog();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Пожалуйста проверьте ещё раз введенные данные!", "Вы ввели неверный логин или пароль!");
                    }

                }
            }
            catch
            {
                MessageBox.Show("Возникло исключение");
                connection.Close();
            }
        }
    }
}
