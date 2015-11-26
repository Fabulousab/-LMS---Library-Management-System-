using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace group4_Lab3.DAL
{
    class Sqlconn
    {
        static string connectionString = "server=starblaz; database=library; integrated security=true";
        SqlConnection conn = new SqlConnection(connectionString);

        public Sqlconn()
        {
            conn.Open();
        }
       
    }
}
