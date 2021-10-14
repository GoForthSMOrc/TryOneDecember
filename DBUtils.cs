using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace TrainExam1
{
    class DBUtils
    {
        public static MySqlConnection GetDBConnection()
        {
            string host = "localhost";
            int port = 3306;
            string database = "TrainExam";
            string username = "root";
            string password = "root";

            return DBMySQLUtils.GetDBConnection(host, port, database, username, password);
        }
    }
}
