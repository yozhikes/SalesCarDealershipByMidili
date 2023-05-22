using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesCarDealershipByMidili
{
    class DataBase
    {
        SqlConnection _connection = new SqlConnection(@"Data Source=PC-EBLAN\SQLEXPRESS;Initial Catalog=BD_SalesCar;
Integrated Security=True");

        public void openConnection()
        {
            if (_connection.State == System.Data.ConnectionState.Closed)
            {
                _connection.Open();
            }
        }

        public void closeConnection()
        {
            if (_connection.State == System.Data.ConnectionState.Open)
            {
                _connection.Close();
            }
        }

        public SqlConnection GetConnection()
        {
            return _connection;
        }
    }
}
