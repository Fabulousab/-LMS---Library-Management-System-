using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace group4_Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Image image = pictureBox1.Image;
            if(image.Width < pictureBox1.Width && image.Height < pictureBox1.Height){
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
            }else{
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
            pictureBox1.Image = image;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f = DAL.BookDAO.Loadframe();
            this.Controls.Clear();
            this.Controls.Add(f);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form f = DAL.BookDAO.Loadframe();
            panel1.Controls.Clear();
            panel1.Controls.Add(f);   
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            toolStripButton1.PerformClick();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(DAL.MemberDAO.LoadMemberForm());
            panel1.Focus();
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            toolStripButton2.PerformClick();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(DAL.BorrowerDAO.LoadForm());
            panel1.Focus();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(DTL.Return.LoadForm());
        }

        private void toolStripLabel4_Click(object sender, EventArgs e)
        {
            toolStripButton4.PerformClick();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Reserve rs = new Reserve();
            rs.TopLevel = false;
            rs.Dock = DockStyle.Fill;
            rs.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            rs.Visible = true;
            panel1.Controls.Clear();
            panel1.Controls.Add(rs);
        }

    }
}
