using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cuoiky
{
    internal class dataconnection
    {
        string connectionString;
        public dataconnection()
        {
            connectionString = "Data Source=DESKTOP-59V0EER\\SQLEXPRESS;Initial Catalog=shopeemobile;User ID=sa;Password=2011;";
        }

        public SqlConnection getconnect()
        {
            return new SqlConnection(connectionString);
        }
    }
}
