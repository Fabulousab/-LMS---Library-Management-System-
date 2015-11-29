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
    public partial class Reserve : Form
    {
        public Reserve()
        {
            InitializeComponent();
            tbdate.Enabled = false;
            button2.Enabled = false;
        }


        private void LoadMember(DataGridView dgv)
        {
            int bno = (int.Parse(tbmco.Text));
            DTL.Borrower b = DAL.BorrowerDAO.getBorrower(bno);
            if (b == null) { MessageBox.Show("This Member does Not Exist"); return; }
            tbname.Text = b.Name;
            string sql = "select * from reservation where borrowernumber = " + bno;
            SqlDataAdapter sda = new SqlDataAdapter(sql, DAL.BookDAO.connectionString);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgv.DataSource = dt;
        }

        private void btnckMemeber_Click(object sender, EventArgs e)
        {
            LoadMember(dataGridView1);
        }

        public static bool CheckBook(int bno)
        {
            string sql = "select * from copy where type = 'A' and booknumber = " + bno;
            SqlDataAdapter sda = new SqlDataAdapter(sql, DAL.BookDAO.connectionString);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 1 ) return false;
            else return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try {
                if (tbbno.Text == "") { MessageBox.Show("Book Number Space Cannot be null and must be integer value"); return; }
                int bno = int.Parse(tbbno.Text);
                if (CheckBook(bno) && dataGridView1.Rows.Count == 1)
                {
                    MessageBox.Show("you are free to reserve this book");
                    tbdate.Text = DateTime.Now.ToString("MM/dd/yyyy");
                    button1.Enabled = false;
                    button2.Enabled = true;
                }
                else { MessageBox.Show("sorry you cannot reserve this book"); tbdate.Text = ""; }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 1) { MessageBox.Show("You cannot reserve more books"); return; }
            string sql = "insert into reservation(borrowernumber , booknumber, date, status) values(@brno, @bno, @date, @status)";
            SqlConnection conn = new SqlConnection(DAL.BookDAO.connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@brno", tbmco.Text);
            cmd.Parameters.AddWithValue("@bno", tbbno.Text);
            cmd.Parameters.AddWithValue("@date", tbdate.Text);
            cmd.Parameters.AddWithValue("@status", "R");
            cmd.ExecuteNonQuery();
            conn.Close();
            LoadMember(dataGridView1);
        }
    }
}
