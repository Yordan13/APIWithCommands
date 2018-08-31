using ApplicationAPI.Repository.CommandService.Attributes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Xml;

namespace ApplicationAPI.Repository.CommandService.MySQL
{
    public class MySQLCommandExecutor : ICommandExecutor
    {
        private MySqlConnection con;

        public MySQLCommandExecutor(MySqlConnection con) {
            this.con = con;
        }

        public DataTable Execute<T>(string name, T command) where T : Command, new()
        {
            con.Open();
            MySqlCommand sqlProcedure = new MySqlCommand(name, con);
            sqlProcedure.CommandType = System.Data.CommandType.StoredProcedure;
            var props = command.GetType().GetProperties().Where(p => p.GetCustomAttribute<ParameterAttribute>() != null);
            foreach (var prop in props) {
                sqlProcedure.Parameters.AddWithValue(prop.Name, prop.GetValue(command));
                sqlProcedure.Parameters[prop.Name].Direction = System.Data.ParameterDirection.Input;
            }
            var res = sqlProcedure.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(res);
            con.Close();
            return dt;
        }
    }
}
