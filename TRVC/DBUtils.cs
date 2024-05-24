using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRVC
{
    internal class DBUtils
    {
        public static MySqlConnection GetDBConnection()
        {
            string host = "localhost";
            int port = 3306;
            string database = "managerflowmonneytrad";
            string username = "root";
            string password = "Trad99999";

            return DBMySQLUtils.GetDBConnection(host, port, database, username, password);
        }
    }
}
