using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBMS
{
    public static class Database
    {

        public static SqlConnection Connect()
        {
            string connectionString = @"Server=DESKTOP-MB5PO9A; Database=SBMS; Integrated Security=true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            return sqlConnection;
        }
    }
}
