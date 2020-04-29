using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Odbc;
using System.Windows.Forms;

namespace WinAppSchoolCanteen.Classes
{
    class ClassIniDataBase
    {
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-TVLAIMU\SQLEXPRESS;Initial Catalog=SchoolCanteen;Integrated Security=True");//Строка подключения базы данных
        public void OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }
        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }
        public SqlConnection GetConnection()
        {
            return connection;
        }
    }
}
