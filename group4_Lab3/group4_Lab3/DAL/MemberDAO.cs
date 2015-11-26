using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace group4_Lab3.DAL
{
    class MemberDAO
    {
        public static Form LoadMemberForm()
        {
            Member mb = new Member();
            mb.Visible = true;
            mb.TopLevel = false;
            mb.Dock = DockStyle.Fill;
            mb.FormBorderStyle = FormBorderStyle.None;
            return mb;
        }
        public static DataTable getMembers()
        {
            string sql = "select * from borrower";
            SqlDataAdapter sda = new SqlDataAdapter(sql, DAL.BookDAO.connectionString);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
        public static void AddMember(string mco,string name, string sex,string address,string telephone, string email)
        {
            string sql = "insert into borrower values (@mco, @name, @sex, @address, @telephone,@email)";
            SqlConnection conn = (new SqlConnection(DAL.BookDAO.connectionString));
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@mco" , mco);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@sex", sex);
            cmd.Parameters.AddWithValue("@address", address);
            cmd.Parameters.AddWithValue("@telephone", telephone);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.ExecuteNonQuery();
        }
        public static void EditMember(string mco, string name, string sex, string address, string telephone, string email)
        {
            string sql = "update borrower set borrowernumber = @mco,name = @name,sex = @sex, address = @address,telephone = @telephone,email = @email where borrowernumber = @mco";
            SqlConnection conn = (new SqlConnection(DAL.BookDAO.connectionString));
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@mco", mco);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@sex", sex);
            cmd.Parameters.AddWithValue("@address", address);
            cmd.Parameters.AddWithValue("@telephone", telephone);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.ExecuteNonQuery();
        }

        public static int MaxBorrowerNo()
        {
            string sql = "select borrowernumber from borrower where borrowernumber = (select max(borrowernumber) from borrower)";
            SqlDataAdapter sda = new SqlDataAdapter(sql, DAL.BookDAO.connectionString);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count == 0) { return 0; }
            else
                return int.Parse(dt.Rows[0][0].ToString());
        }
    }
}
