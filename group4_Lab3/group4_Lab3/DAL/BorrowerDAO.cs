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
        static public DataTable SelectDS(int bno)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select cc.ID, cc.CopyNumber,cc.borrowernumber, cc.BorrowedDate, cc.DueDate from circulatedcopy cc,copy c "+
                    "where cc.copynumber = c.copynumber and type = 'R' and  borrowernumber = "+bno, conn);
                DataTable ds = new DataTable();
                sda.Fill(ds);

                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

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

        public static DTL.Borrower getBorrower(int bno)
        {
            DataSet ds = SelectDS();
            if (ds == null) return null;
            DataTable dt = ds.Tables[0];
            DataRow[] result = dt.Select("borrowernumber = " + bno.ToString());
            if (result.Count() == 0) return null;
            DataRow dr = result[0];
            DTL.Borrower bt = new DTL.Borrower();
            bt.BorrowerNumber = bno;
            bt.Name = dr["name"].ToString();
            return bt;

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
