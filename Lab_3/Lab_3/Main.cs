using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_3
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form fm = new Book();
            fm.Show();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            Form fm = new Book();
            fm.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Form fm = new Member();
            fm.Show();
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            Form fm = new Member();
            fm.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Form fm = new Borrow();
            fm.Show();
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            Form fm = new Borrow();
            fm.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Form fm = new Return();
            fm.Show();
        }

        private void toolStripLabel4_Click(object sender, EventArgs e)
        {
            Form fm = new Return();
            fm.Show();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Form fm = new Reserve();
            fm.Show();
        }

        private void toolStripLabel5_Click(object sender, EventArgs e)
        {
            Form fm = new Reserve();
            fm.Show();
        }
    }
}
