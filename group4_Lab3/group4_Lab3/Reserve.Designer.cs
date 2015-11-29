namespace group4_Lab3
{
    partial class Reserve
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
            this.btnckMemeber = new System.Windows.Forms.Button();
            this.tbname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbmco = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbbno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbdate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnckMemeber
            // 
            this.btnckMemeber.Location = new System.Drawing.Point(513, 23);
            this.btnckMemeber.Name = "btnckMemeber";
            this.btnckMemeber.Size = new System.Drawing.Size(162, 23);
            this.btnckMemeber.TabIndex = 17;
            this.btnckMemeber.Text = "Check Member";
            this.btnckMemeber.UseVisualStyleBackColor = true;
            this.btnckMemeber.Click += new System.EventHandler(this.btnckMemeber_Click);
            // 
            // tbname
            // 
            this.tbname.Location = new System.Drawing.Point(335, 23);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(162, 20);
            this.tbname.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(294, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Name";
            // 
            // tbmco
            // 
            this.tbmco.Location = new System.Drawing.Point(150, 54);
            this.tbmco.Name = "tbmco";
            this.tbmco.Size = new System.Drawing.Size(162, 20);
            this.tbmco.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Member Code";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbbno);
            this.groupBox1.Controls.Add(this.btnckMemeber);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.tbname);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(49, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(736, 122);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Member";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(432, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(243, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Check Reserve Condition";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(49, 184);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(736, 195);
            this.dataGridView1.TabIndex = 19;
            // 
            // tbbno
            // 
            this.tbbno.Location = new System.Drawing.Point(101, 78);
            this.tbbno.Name = "tbbno";
            this.tbbno.Size = new System.Drawing.Size(162, 20);
            this.tbbno.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Book Number";
            // 
            // tbdate
            // 
            this.tbdate.Location = new System.Drawing.Point(401, 395);
            this.tbdate.Name = "tbdate";
            this.tbdate.Size = new System.Drawing.Size(122, 20);
            this.tbdate.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(365, 398);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Date";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(623, 398);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "Reserve";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Reserve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 505);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tbdate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tbmco);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Reserve";
            this.Text = "Reserve";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnckMemeber;
        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbmco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tbbno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
    }
}