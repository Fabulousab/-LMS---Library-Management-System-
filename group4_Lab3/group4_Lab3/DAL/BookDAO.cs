using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace group4_Lab3.DAL
{
    class BookDAO
    {
        public static string connectionString = "server=starblaz; database=library; integrated security=true";
        public static Form Loadframe()
        {
            Book bk = new Book();
            bk.TopLevel = false;
            bk.Dock = DockStyle.Fill;
            bk.FormBorderStyle = FormBorderStyle.None;
            bk.Visible = true;
            bk.BringToFront();
            return bk;
        }
        public static int InsertBook(int bno, string title, string author, string publisher)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connectionString);
                string query = "insert into book(booknumber , title, authors ,publisher) values (@bno, @title,@author,@pub)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@bno", bno);
                cmd.Parameters.AddWithValue("@title", title);
                cmd.Parameters.AddWithValue("@author", author);
                cmd.Parameters.AddWithValue("@pub", publisher);
                conn.Open();
                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex){
                MessageBox.Show(""+ex.Message);
                return 0;
            }
        }

        public static int EditBook(int bno, string title, string author, string publisher)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            string query = "update book set booknumber = @bno , title=@title, authors=@author ,publisher=@pub where booknumber = @bno";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@bno", bno);
            cmd.Parameters.AddWithValue("@title", title);
            cmd.Parameters.AddWithValue("@author", author);
            cmd.Parameters.AddWithValue("@pub", publisher);
            conn.Open();
            return cmd.ExecuteNonQuery();
        }

        static public DataSet SelectDS()
        {
            try
            {
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select * from book", conn);
                DataSet ds = new DataSet();
                sda.Fill(ds);

                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public static int MaxBno()
        {
            string sql = "select booknumber from book where booknumber = (select max(booknumber) from book)";
            SqlDataAdapter sda = new SqlDataAdapter(sql, DAL.BookDAO.connectionString);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count == 0) { return 0; }
            else
                return int.Parse(dt.Rows[0][0].ToString());
        }
    }
}
