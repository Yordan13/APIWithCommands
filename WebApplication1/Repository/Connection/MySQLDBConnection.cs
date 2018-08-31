using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApplicationAPI.Repository.Connection
{
    public class MySQLDBConnection : IDBConnection
    {
        public MySqlConnection Connection;

        public MySQLDBConnection(string url, string databaseName, string userName, string password) {
            Url = url;
            DatabaseName = databaseName;
            UserName = userName;
            Password = password;            
        }

        public string Url { get; }
        public string DatabaseName { get; }
        public string UserName { get; }
        public string Password { get; }

        public void Initialize()
        {
            string connectionString = "SERVER=" + this.Url + ";" + "DATABASE=" + this.DatabaseName + ";" 
                                    + "UID=" + this.UserName + ";" + "PASSWORD=" + this.Password + ";SslMode=none";
            this.Connection = new MySqlConnection(connectionString);
        }
    }
}
