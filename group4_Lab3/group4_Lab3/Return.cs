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
    public partial class Return : Form
    {
        public Return()
        {
            InitializeComponent();
            tbrd.Text = DateTime.Now.ToString("MM/dd/yyyy");
            tbrd.Enabled = false;
            btnreturn.Enabled = false; btnconfirm.Enabled = false;
            
        }

        private void Return_Load(object sender, EventArgs e)
        {

        }

        private void LoadGridView()
        {
            int bno = (int.Parse(tbmco.Text));
            DTL.Borrower b = DAL.BorrowerDAO.getBorrower(bno);
            if (b == null) { MessageBox.Show("This Member does Not Exist"); return; }
            tbname.Text = b.Name;
            DataTable dt = DAL.BorrowerDAO.SelectDS(bno);
            dataGridView1.DataSource = dt;
            count.Text = "Number of Books Borrowed " + (dataGridView1.RowCount - 1);
        }

        private void btnckMemeber_Click(object sender, EventArgs e)
        {
            try { LoadGridView(); btnconfirm.Enabled = true; }
            catch (Exception ex)  { MessageBox.Show(ex.Message); }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            btnckMemeber.PerformClick();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double Fineamount = 0;
                int index = dataGridView1.CurrentCell.RowIndex;
                string dt = dataGridView1.Rows[index].Cells[4].Value.ToString();
                DateTime dueDate = DateTime.Parse(dt);
                DateTime now = DateTime.Now;
                TimeSpan sp = now.Subtract(dueDate);
                int day = sp.Days;
                Fineamount = day * 1;
                if (Fineamount < 0) Fineamount = 0;
                tbfine.Text = Fineamount + "";
                tbfine.Enabled = false;
                btnreturn.Enabled = true;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        public void UpdateCopy(string sql)
        {
            System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(DAL.BookDAO.connectionString);
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@rd", tbrd.Text);
            cmd.Parameters.AddWithValue("@amount", tbfine.Text);
            int index = dataGridView1.CurrentCell.RowIndex;
            string dt = dataGridView1.Rows[index].Cells[1].Value.ToString();
            cmd.Parameters.AddWithValue("@cno", dt);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        private void updateCopy(int cno)
        {
            string sql = "update copy set type = 'A' where copynumber = " + cno;
            SqlConnection conn = new SqlConnection(DAL.BookDAO.connectionString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        private void btnreturn_Click(object sender, EventArgs e)
        {
            string sql = "update circulatedcopy set returneddate = @rd, fineamount = @amount where copynumber=@cno";
            UpdateCopy(sql);
            sql = "update copy set type='A' where copynumber=@cno";
            UpdateCopy(sql);
            LoadGridView();
        }
    }
}
