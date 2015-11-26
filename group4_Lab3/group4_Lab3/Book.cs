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
    public partial class Book : Form
    {
        int add = 0;
        public void load()
        {
            DataSet ds = DAL.BookDAO.SelectDS();
            dataGridView1.DataSource = ds.Tables[0];
            tbBauthor.Enabled = false;
            tbBpublisher.Enabled = false;
            tbBtitle.Enabled = false;
            
        }
        public Book()
        {
            InitializeComponent();
            load();
            CEditable(false);
            dataGridView1.ReadOnly = true;
        }
        private bool verification()
        {
            if (tbBauthor.Text == "") return false;
            if (tbBBno.Text == "") return false;
            if (tbBpublisher.Text == "") return false;
            if (tbBtitle.Text == "") return false;
            return true;
        }
        private void btnBadd_Click(object sender, EventArgs e)
        {
            
            if (btnBadd.Text == "Add")
            {
                btnBadd.Text = "Save";
                btnBEdit.Enabled = false;
                btnBdelete.Enabled = false;
                tbBauthor.Enabled = true;
                tbBpublisher.Enabled = true;
                tbBtitle.Enabled = true;
                tbBBno.Enabled = false;
                tbBBno.Text = "";
                tbBpublisher.Text = "";
                tbBtitle.Text = "";
                tbBauthor.Text = "";
                tbBBno.Text = (DAL.BookDAO.MaxBno() + 1) + "";
                return;
            }
             btnBadd.Text = "Add";
             try
             {
                 if (!verification()) { MessageBox.Show("Check verification"); return; }
                 int run = DAL.BookDAO.InsertBook(int.Parse(tbBBno.Text), tbBtitle.Text, tbBauthor.Text, tbBpublisher.Text);
                 if (run <= 0) MessageBox.Show("Information of Book is not added to DB");
                 else { load(); }
                 add = 1;
                 btnBEdit.Enabled = true;
                 btnBdelete.Enabled = true;
                 tbBBno.Enabled = true;
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message);
             }
        }

        private void btnfliter_Click(object sender, EventArgs e)
        {
            string bno = tbBBno.Text.Trim();
           // MessageBox.Show(bno + "");
            int xBno = int.Parse(bno);
            
            string sql = "select * from book where booknumber = '"+xBno+"'";
            SqlDataAdapter sda = new SqlDataAdapter(sql,DAL.BookDAO.connectionString);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void CEditable(bool enable)
        {
            tbCbno.Enabled = enable;
            tbCcno.Enabled = enable;
            tbCsno.Enabled = enable;
            tbCtype.Enabled = enable;
            tbCprice.Enabled = enable;
        }
        
        private void btnCadd_Click(object sender, EventArgs e)
        {
            if (btnCadd.Text == "Add")
            {
                btnCadd.Text = "Save";
                CEditable(true);
                return;
            }
            else
            {
                CEditable(false);
                btnCadd.Text = "Add";
            }

            DAL.Copy.InsertCopy(int.Parse(tbCcno.Text.Trim()), tbCbno.Text, tbCsno.Text, tbCtype.Text, double.Parse(tbCprice.Text));
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CEditable(false);
            int rowIndex = dataGridView2.CurrentCell.RowIndex;
            tbCbno.Text = dataGridView2.Rows[rowIndex].Cells[1].Value.ToString();
            tbCcno.Text = dataGridView2.Rows[rowIndex].Cells[0].Value.ToString();
            tbCsno.Text = dataGridView2.Rows[rowIndex].Cells[2].Value.ToString();
            tbCtype.Text = dataGridView2.Rows[rowIndex].Cells[3].Value.ToString();
            tbCprice.Text = dataGridView2.Rows[rowIndex].Cells[4].Value.ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowIndex = dataGridView1.CurrentCell.RowIndex;
                int bno = int.Parse(dataGridView1.Rows[rowIndex].Cells[0].Value.ToString());
                tbBBno.Text = bno + "";
                tbBtitle.Text = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
                tbBauthor.Text = dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
                tbBpublisher.Text = dataGridView1.Rows[rowIndex].Cells[3].Value.ToString();
                SqlDataAdapter sda = new SqlDataAdapter("select * from copy where booknumber = '" + bno + "'", DAL.BookDAO.connectionString);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView2.DataSource = dt;
                tbCbno.Text = bno + "";
            }
            catch {
                MessageBox.Show("Select a Row", "Selction Error");
            }

        }

        private void btnBdelete_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            int bno = int.Parse(dataGridView1.Rows[rowIndex].Cells[0].Value.ToString());
            string sql = "delete from book where booknumber = @bno";
            SqlConnection conn = new SqlConnection(DAL.BookDAO.connectionString);
            if ((MessageBox.Show("Are you sure you want to delete book with number " + bno, "Confirm delete", MessageBoxButtons.YesNo)) == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@bno", bno);
                conn.Open();
                cmd.ExecuteNonQuery();
                load();
            }
            else return;
        }
        int edit = 0;
        private void btnBEdit_Click(object sender, EventArgs e)
        {
            if (edit == 0)
            {
                edit = 1;
                btnBEdit.Text = "Update";
                btnBdelete.Enabled = false;
                btnBadd.Enabled = false;
                tbBauthor.Enabled = true;
                tbBpublisher.Enabled = true;
                tbBtitle.Enabled = true;

                return;
            }
            else
            {
                DAL.BookDAO.EditBook(int.Parse(tbBBno.Text), tbBtitle.Text, tbBauthor.Text, tbBpublisher.Text);
                tbBauthor.Enabled = false;
                tbBpublisher.Enabled = false;
                tbBtitle.Enabled = false;
                btnBdelete.Enabled = true;
                btnBadd.Enabled = true;
                edit = 0;
                btnBEdit.Text = "Edit";
                load();
            }
        }
    }
}
