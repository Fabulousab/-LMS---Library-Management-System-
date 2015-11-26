using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace group4_Lab3.DAL
{
    class BorrowerDAO
    {
        static string connectionString = "server=starblaz; database=library; integrated security=true";
        static public DataSet SelectDS()
        {
            try
            {
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select * from borrower", conn);
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
        public static borrower getBorrower(int bno)
        {
          /*  DataSet ds = SelectDS();
            if (ds == null) return null;
            DataTable dt = ds.Tables[0];
            DataRow[] result = dt.Select("borrowernumber = " + bno.ToString());
            if (result.Count() == 0) return null;
            DataRow dr = result[0];
            borrower b = new borrower(bno, dr.["name"].ToString(), dr["sex"].ToString());
            return b;
           */
            return null;
        }
        public static int BorrowerNumberMax()
        {
            return DAL.MemberDAO.MaxBorrowerNo();
        }

        public static Form LoadForm()
        {
            borrower bs = new borrower();
            bs.FormBorderStyle = FormBorderStyle.None;
            bs.Dock = DockStyle.Fill;
            bs.Visible = true;
            bs.TopLevel = false;
            bs.BringToFront ();
            return bs;

        }
    }
}
