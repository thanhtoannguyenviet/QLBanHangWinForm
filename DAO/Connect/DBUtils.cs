using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    class DBUtils
    {
        public static SqlConnection GetDBConnection()
        {
            string datasource = @"DESKTOP-Q5JSOHA\SQLEXPRESS";

            string database = "QUANLYBANHANG";
            string username = "sa";
            string password = "sa";

            return DBSQLServerUtils.GetDBConnection(datasource, database, username, password);
        }
    }
}
