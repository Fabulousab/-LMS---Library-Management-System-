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
        public static DTL.Copy copyExist(int cno)
        {
            string sql = "select * from copy where type = 'A' and copynumber = " + cno;
            SqlConnection conn = new SqlConnection(DAL.BookDAO.connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader sdr = cmd.ExecuteReader();
            if (!sdr.Read()) return null;
            DTL.Copy cp = new DTL.Copy();
            cp.CopyNumber = sdr.GetInt32(0);
            cp.BookNumber = sdr.GetInt32(1);
            cp.SequenceNumber = sdr.GetInt32(2);
            cp.Type = sdr.GetString(3)[0];
            cp.Price = sdr.GetDouble(4);
            return cp;
        }
    }
}
