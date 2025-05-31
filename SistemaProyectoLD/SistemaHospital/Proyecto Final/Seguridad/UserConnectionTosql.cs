using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final
{
    internal class UserConnectionTosql
    {

        public abstract class UserConnectionToSql
        {
            private readonly string connectionString;
            public UserConnectionToSql()
            {
                connectionString = "Server=LFLOREST3\\SQLEXPRESS;DataBase= db_Hospital; integrated security= true";
            }
            protected SqlConnection GetConnection()
            {
                return new SqlConnection(connectionString);
            }
        }
    }
}
