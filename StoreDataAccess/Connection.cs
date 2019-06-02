using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace StoreDataAccess
{
    public class Connection
    {
        public SqlConnection oSqlConnection = new SqlConnection(@"Data Source=LAPTOP-9M25MP0T;Initial Catalog=StoreDB;Integrated Security=True");
    }
}
