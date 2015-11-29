using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace group4_Lab3
{
    public partial class borrower : Form
    {
        private DTL.Copy copy = null;
        public borrower()
        {
            InitializeComponent();
            tbname.Enabled = false;
            tbdd.Enabled = false;
            tbbd.Enabled = false;
            btnborrow.Enabled = false;
        }

        private void MemberEnable(bool value)
        {
            tbname.Enabled = value;
            tbmco.Enabled = value;
            btnckMemeber.Enabled = value;
        }
        private void LoadGridView()
        {
            int bno = (int.Parse(tbmco.Text));
            DTL.Borrower b = DAL.BorrowerDAO.getBorrower(bno);
            if (b == null) { MessageBox.Show("This Member does Not Exist"); return; }
            MemberEnable(false);
            tbname.Text = b.Name;
            DataTable dt = DAL.BorrowerDAO.SelectDS(bno);
            dataGridView1.DataSource = dt;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try { LoadGridView(); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count - 1 >= 5) { MessageBox.Show("You have reach the maximum borrow limit"); return; }
                DTL.Copy cp = null;
                if ((cp = DAL.Copy.copyExist(int.Parse(tbcno.Text.Trim()))) == null)
                {
                    MessageBox.Show("This copy is not avaliable or does not exist"); return;
                }
                btnckcondition.Enabled = false;
                DateTime dt = new DateTime();
                dt = DateTime.Now;
                tbbd.Text = dt.ToString("MM/dd/yyyy");
                tbdd.Text = dt.Date.AddDays(13).ToString("MM/dd/yyyy");
                btnborrow.Enabled = true;
                copy = cp;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void updateCopy(int cno)
        {
            string sql = "update copy set type = 'R' where copynumber = "+cno;
            SqlConnection conn = new SqlConnection(DAL.BookDAO.connectionString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                // id , copynumber , borrowernumber , borroweddate, duedate,retuneddate, fineamount
                string sql = "insert into circulatedcopy(copynumber,borrowernumber, borroweddate, duedate)" +
                            " values(@cno, @bno, @bbd,@bdd)";
                SqlConnection conn = new SqlConnection(DAL.BookDAO.connectionString);
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@cno", tbcno.Text);
                cmd.Parameters.AddWithValue("@bno", tbmco.Text);
                cmd.Parameters.AddWithValue("@bbd", tbbd.Text.Trim());
                cmd.Parameters.AddWithValue("@bdd", tbdd.Text.Trim());
                conn.Open();
                cmd.ExecuteNonQuery();
                updateCopy(copy.CopyNumber);
                conn.Close();
                btnborrow.Enabled = false;
                LoadGridView();
                btnckMemeber.Enabled = true;
                btnckcondition.Enabled = true;
                MemberEnable(true);
                tbname.Enabled = false;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
