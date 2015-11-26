namespace group4_Lab3
{
    partial class Book
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBadd = new System.Windows.Forms.Button();
            this.btnBEdit = new System.Windows.Forms.Button();
            this.btnBdelete = new System.Windows.Forms.Button();
            this.btnCdelete = new System.Windows.Forms.Button();
            this.btnCedit = new System.Windows.Forms.Button();
            this.btnCadd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbBBno = new System.Windows.Forms.TextBox();
            this.tbBtitle = new System.Windows.Forms.TextBox();
            this.tbBauthor = new System.Windows.Forms.TextBox();
            this.tbBpublisher = new System.Windows.Forms.TextBox();
            this.btnfliter = new System.Windows.Forms.Button();
            this.tbCtype = new System.Windows.Forms.TextBox();
            this.tbCsno = new System.Windows.Forms.TextBox();
            this.tbCcno = new System.Windows.Forms.TextBox();
            this.tbCbno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbCprice = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(338, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(475, 169);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(350, 256);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(475, 188);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnfliter);
            this.groupBox1.Controls.Add(this.tbBpublisher);
            this.groupBox1.Controls.Add(this.tbBauthor);
            this.groupBox1.Controls.Add(this.tbBtitle);
            this.groupBox1.Controls.Add(this.tbBBno);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnBdelete);
            this.groupBox1.Controls.Add(this.btnBEdit);
            this.groupBox1.Controls.Add(this.btnBadd);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(829, 225);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Book";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbCprice);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.tbCtype);
            this.groupBox2.Controls.Add(this.btnCdelete);
            this.groupBox2.Controls.Add(this.tbCsno);
            this.groupBox2.Controls.Add(this.tbCcno);
            this.groupBox2.Controls.Add(this.btnCadd);
            this.groupBox2.Controls.Add(this.tbCbno);
            this.groupBox2.Controls.Add(this.btnCedit);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(12, 237);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(829, 256);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Copy";
            // 
            // btnBadd
            // 
            this.btnBadd.Location = new System.Drawing.Point(336, 194);
            this.btnBadd.Name = "btnBadd";
            this.btnBadd.Size = new System.Drawing.Size(75, 23);
            this.btnBadd.TabIndex = 1;
            this.btnBadd.Text = "Add";
            this.btnBadd.UseVisualStyleBackColor = true;
            this.btnBadd.Click += new System.EventHandler(this.btnBadd_Click);
            // 
            // btnBEdit
            // 
            this.btnBEdit.Location = new System.Drawing.Point(471, 194);
            this.btnBEdit.Name = "btnBEdit";
            this.btnBEdit.Size = new System.Drawing.Size(75, 23);
            this.btnBEdit.TabIndex = 2;
            this.btnBEdit.Text = "Edit";
            this.btnBEdit.UseVisualStyleBackColor = true;
            this.btnBEdit.Click += new System.EventHandler(this.btnBEdit_Click);
            // 
            // btnBdelete
            // 
            this.btnBdelete.Location = new System.Drawing.Point(597, 194);
            this.btnBdelete.Name = "btnBdelete";
            this.btnBdelete.Size = new System.Drawing.Size(75, 23);
            this.btnBdelete.TabIndex = 3;
            this.btnBdelete.Text = "Delete";
            this.btnBdelete.UseVisualStyleBackColor = true;
            this.btnBdelete.Click += new System.EventHandler(this.btnBdelete_Click);
            // 
            // btnCdelete
            // 
            this.btnCdelete.Location = new System.Drawing.Point(597, 220);
            this.btnCdelete.Name = "btnCdelete";
            this.btnCdelete.Size = new System.Drawing.Size(75, 23);
            this.btnCdelete.TabIndex = 6;
            this.btnCdelete.Text = "Delete";
            this.btnCdelete.UseVisualStyleBackColor = true;
            // 
            // btnCedit
            // 
            this.btnCedit.Location = new System.Drawing.Point(471, 220);
            this.btnCedit.Name = "btnCedit";
            this.btnCedit.Size = new System.Drawing.Size(75, 23);
            this.btnCedit.TabIndex = 5;
            this.btnCedit.Text = "Edit";
            this.btnCedit.UseVisualStyleBackColor = true;
            // 
            // btnCadd
            // 
            this.btnCadd.Location = new System.Drawing.Point(336, 220);
            this.btnCadd.Name = "btnCadd";
            this.btnCadd.Size = new System.Drawing.Size(75, 23);
            this.btnCadd.TabIndex = 4;
            this.btnCadd.Text = "Add";
            this.btnCadd.UseVisualStyleBackColor = true;
            this.btnCadd.Click += new System.EventHandler(this.btnCadd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Book Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Authors";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Publisher";
            // 
            // tbBBno
            // 
            this.tbBBno.Location = new System.Drawing.Point(134, 49);
            this.tbBBno.Name = "tbBBno";
            this.tbBBno.Size = new System.Drawing.Size(181, 20);
            this.tbBBno.TabIndex = 8;
            // 
            // tbBtitle
            // 
            this.tbBtitle.Location = new System.Drawing.Point(134, 79);
            this.tbBtitle.Name = "tbBtitle";
            this.tbBtitle.Size = new System.Drawing.Size(181, 20);
            this.tbBtitle.TabIndex = 9;
            // 
            // tbBauthor
            // 
            this.tbBauthor.Location = new System.Drawing.Point(134, 113);
            this.tbBauthor.Name = "tbBauthor";
            this.tbBauthor.Size = new System.Drawing.Size(181, 20);
            this.tbBauthor.TabIndex = 10;
            // 
            // tbBpublisher
            // 
            this.tbBpublisher.Location = new System.Drawing.Point(134, 144);
            this.tbBpublisher.Name = "tbBpublisher";
            this.tbBpublisher.Size = new System.Drawing.Size(181, 20);
            this.tbBpublisher.TabIndex = 11;
            // 
            // btnfliter
            // 
            this.btnfliter.Location = new System.Drawing.Point(41, 186);
            this.btnfliter.Name = "btnfliter";
            this.btnfliter.Size = new System.Drawing.Size(75, 23);
            this.btnfliter.TabIndex = 12;
            this.btnfliter.Text = "Fliter";
            this.btnfliter.UseVisualStyleBackColor = true;
            this.btnfliter.Click += new System.EventHandler(this.btnfliter_Click);
            // 
            // tbCtype
            // 
            this.tbCtype.Location = new System.Drawing.Point(134, 142);
            this.tbCtype.Name = "tbCtype";
            this.tbCtype.Size = new System.Drawing.Size(67, 20);
            this.tbCtype.TabIndex = 20;
            // 
            // tbCsno
            // 
            this.tbCsno.Location = new System.Drawing.Point(134, 108);
            this.tbCsno.Name = "tbCsno";
            this.tbCsno.Size = new System.Drawing.Size(181, 20);
            this.tbCsno.TabIndex = 19;
            // 
            // tbCcno
            // 
            this.tbCcno.Location = new System.Drawing.Point(134, 74);
            this.tbCcno.Name = "tbCcno";
            this.tbCcno.Size = new System.Drawing.Size(181, 20);
            this.tbCcno.TabIndex = 18;
            // 
            // tbCbno
            // 
            this.tbCbno.Location = new System.Drawing.Point(134, 44);
            this.tbCbno.Name = "tbCbno";
            this.tbCbno.Size = new System.Drawing.Size(181, 20);
            this.tbCbno.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Sequence Number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Copy Number";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Book Number";
            // 
            // tbCprice
            // 
            this.tbCprice.Location = new System.Drawing.Point(134, 180);
            this.tbCprice.Name = "tbCprice";
            this.tbCprice.Size = new System.Drawing.Size(84, 20);
            this.tbCprice.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Price";
            // 
            // Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 505);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Book";
            this.Text = "Book";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnfliter;
        private System.Windows.Forms.TextBox tbBpublisher;
        private System.Windows.Forms.TextBox tbBauthor;
        private System.Windows.Forms.TextBox tbBtitle;
        private System.Windows.Forms.TextBox tbBBno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBdelete;
        private System.Windows.Forms.Button btnBEdit;
        private System.Windows.Forms.Button btnBadd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbCprice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbCtype;
        private System.Windows.Forms.Button btnCdelete;
        private System.Windows.Forms.TextBox tbCsno;
        private System.Windows.Forms.TextBox tbCcno;
        private System.Windows.Forms.Button btnCadd;
        private System.Windows.Forms.TextBox tbCbno;
        private System.Windows.Forms.Button btnCedit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}