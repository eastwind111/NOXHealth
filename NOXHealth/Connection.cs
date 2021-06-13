using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace NOXHealth
{
    class Connection
    {
        public SqlConnection GetConn()
        {
            SqlConnection Conn = new SqlConnection();
            Conn.ConnectionString = "Data Source=LAPTOP-OGFRNISR;Initial Catalog=UserData;Integrated Security=True";
            return Conn;
        }
    }
}
