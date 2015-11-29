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
    public partial class Member : Form
    {
        private void load()
        {
            dataGridView1.DataSource = DAL.MemberDAO.getMembers();
            setEditable(false);
        }
        public Member()
        {
            InitializeComponent();
            load();
        }

        private void setEditable(bool value)
        {
            tbemail.Enabled = value;
            tbname.Enabled = value;
            tbsex.Enabled = value;
            tbtelephone.Enabled = value;
            tbaddress.Enabled = value;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (tbmco.Text == "" || tbname.Text == "" || tbsex.Text == "" || tbaddress.Text == "" || tbtelephone.Text == "" || tbemail.Text == "")
            {
                MessageBox.Show("Given space cannot be null");
                return;
            }
            if (btnAdd.Text == "Add")
            {
                tbmco.Enabled = false;
                tbmco.Text = (DAL.MemberDAO.MaxBorrowerNo() + 1) +"";
                btnAdd.Text = "Save";
                btndelete.Enabled = false;
                btnedit.Enabled = false;
                setEditable(true);
                return;
            }
            DAL.MemberDAO.AddMember(tbmco.Text, tbname.Text, tbsex.Text, tbaddress.Text, tbtelephone.Text, tbemail.Text);
            load();
            btnAdd.Text = "Add";
            tbmco.Enabled = true;
            btndelete.Enabled = true;
            btnedit.Enabled = true;
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (btnedit.Text == "Edit")
            {
                btnedit.Text = "Save";
                setEditable(true);
                return;
            }
            DAL.MemberDAO.EditMember(tbmco.Text, tbname.Text, tbsex.Text, tbaddress.Text, tbtelephone.Text, tbemail.Text);
            load();
            btnedit.Text = "Edit";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            if (index < 0) return;
            tbmco.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
            tbname.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
            tbsex.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
            tbaddress.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
            tbtelephone.Text = dataGridView1.Rows[index].Cells[4].Value.ToString();
            tbemail.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
        }
        private void btndelete_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            if (index < 0) return;
            string mco = dataGridView1.Rows[index].Cells[0].Value.ToString();
            if (MessageBox.Show("Are you sure you want to delete borrower with id " + mco, "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            
            string sql = "delete borrower where borrowernumber = @mco";
            SqlConnection conn = new SqlConnection(DAL.BookDAO.connectionString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@mco", mco);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            load();
        }

        private void btnfliter_Click(object sender, EventArgs e)
        {
            if (tbmco.Text.Trim() == "") { MessageBox.Show("Given Member code space cannot be null"); return; }
            string sql = "select * from borrower where borrowernumber = '" + int.Parse(tbmco.Text.Trim()) + "'";
            SqlDataAdapter sda = new SqlDataAdapter(sql, DAL.BookDAO.connectionString); 
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
