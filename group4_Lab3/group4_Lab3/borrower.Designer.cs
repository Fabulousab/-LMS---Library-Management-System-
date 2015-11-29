namespace group4_Lab3
{
    partial class borrower
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbmco = new System.Windows.Forms.TextBox();
            this.tbname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnckMemeber = new System.Windows.Forms.Button();
            this.btnckcondition = new System.Windows.Forms.Button();
            this.tbcno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbbd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbdd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnborrow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(312, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(520, 283);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Member Code";
            // 
            // tbmco
            // 
            this.tbmco.Location = new System.Drawing.Point(126, 43);
            this.tbmco.Name = "tbmco";
            this.tbmco.Size = new System.Drawing.Size(162, 20);
            this.tbmco.TabIndex = 2;
            // 
            // tbname
            // 
            this.tbname.Location = new System.Drawing.Point(126, 96);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(162, 20);
            this.tbname.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            // 
            // btnckMemeber
            // 
            this.btnckMemeber.Location = new System.Drawing.Point(126, 146);
            this.btnckMemeber.Name = "btnckMemeber";
            this.btnckMemeber.Size = new System.Drawing.Size(162, 23);
            this.btnckMemeber.TabIndex = 5;
            this.btnckMemeber.Text = "Check Member";
            this.btnckMemeber.UseVisualStyleBackColor = true;
            this.btnckMemeber.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnckcondition
            // 
            this.btnckcondition.Location = new System.Drawing.Point(312, 325);
            this.btnckcondition.Name = "btnckcondition";
            this.btnckcondition.Size = new System.Drawing.Size(148, 23);
            this.btnckcondition.TabIndex = 6;
            this.btnckcondition.Text = "Check Borrow Condition";
            this.btnckcondition.UseVisualStyleBackColor = true;
            this.btnckcondition.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbcno
            // 
            this.tbcno.Location = new System.Drawing.Point(126, 325);
            this.tbcno.Name = "tbcno";
            this.tbcno.Size = new System.Drawing.Size(114, 20);
            this.tbcno.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Copy Number";
            // 
            // tbbd
            // 
            this.tbbd.Location = new System.Drawing.Point(126, 375);
            this.tbbd.Name = "tbbd";
            this.tbbd.Size = new System.Drawing.Size(114, 20);
            this.tbbd.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 380);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Borrowed date";
            // 
            // tbdd
            // 
            this.tbdd.Location = new System.Drawing.Point(126, 415);
            this.tbdd.Name = "tbdd";
            this.tbdd.Size = new System.Drawing.Size(114, 20);
            this.tbdd.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 422);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Due Date";
            // 
            // btnborrow
            // 
            this.btnborrow.Location = new System.Drawing.Point(312, 412);
            this.btnborrow.Name = "btnborrow";
            this.btnborrow.Size = new System.Drawing.Size(148, 23);
            this.btnborrow.TabIndex = 13;
            this.btnborrow.Text = "Borrow";
            this.btnborrow.UseVisualStyleBackColor = true;
            this.btnborrow.Click += new System.EventHandler(this.button3_Click);
            // 
            // borrower
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 454);
            this.Controls.Add(this.btnborrow);
            this.Controls.Add(this.tbdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbbd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbcno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnckcondition);
            this.Controls.Add(this.btnckMemeber);
            this.Controls.Add(this.tbname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbmco);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "borrower";
            this.Text = "borrower";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbmco;
        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnckMemeber;
        private System.Windows.Forms.Button btnckcondition;
        private System.Windows.Forms.TextBox tbcno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbbd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnborrow;
    }
}