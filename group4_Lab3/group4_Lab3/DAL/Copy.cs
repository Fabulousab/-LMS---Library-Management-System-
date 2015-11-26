using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace group4_Lab3.DAL
{
    class Copy
    {
        public static int InsertCopy(int cno, string bno, string sno, string type, double price)
        {
            // copy number , book number , sequence number,type , price
            SqlConnection conn = new SqlConnection(DAL.BookDAO.connectionString);
            string query = "insert into copy  values (@cno, @bno ,@sno,@type,@price)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@cno", cno);
            cmd.Parameters.AddWithValue("@bno", bno);
            cmd.Parameters.AddWithValue("@sno", sno);
            cmd.Parameters.AddWithValue("@type", type);
            cmd.Parameters.AddWithValue("@price", price);
            conn.Open();
            return cmd.ExecuteNonQuery();
        }
    }
}
