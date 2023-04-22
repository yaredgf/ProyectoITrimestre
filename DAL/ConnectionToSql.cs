using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace DAL
{
    public class ConnectionToSql
    {
        private readonly string _connectionString;


        public ConnectionToSql()
        {
            _connectionString = "Data Source=DESKTOP-SHSMI0E;Initial Catalog=ProyectoBD;Integrated Security=True";

        }


        protected SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }

    }
}
