namespace group4_Lab3
{
    partial class Return
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.count = new System.Windows.Forms.Label();
            this.ReturnedDate = new System.Windows.Forms.Label();
            this.tbrd = new System.Windows.Forms.TextBox();
            this.tbfine = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnconfirm = new System.Windows.Forms.Button();
            this.btnreturn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnckMemeber
            // 
            this.btnckMemeber.Location = new System.Drawing.Point(387, 34);
            this.btnckMemeber.Name = "btnckMemeber";
            this.btnckMemeber.Size = new System.Drawing.Size(162, 23);
            this.btnckMemeber.TabIndex = 10;
            this.btnckMemeber.Text = "Check Member";
            this.btnckMemeber.UseVisualStyleBackColor = true;
            this.btnckMemeber.Click += new System.EventHandler(this.btnckMemeber_Click);
            // 
            // tbname
            // 
            this.tbname.Location = new System.Drawing.Point(153, 87);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(162, 20);
            this.tbname.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Name";
            // 
            // tbmco
            // 
            this.tbmco.Location = new System.Drawing.Point(153, 34);
            this.tbmco.Name = "tbmco";
            this.tbmco.Size = new System.Drawing.Size(162, 20);
            this.tbmco.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Member Code";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(52, 156);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(736, 183);
            this.dataGridView1.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(52, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(736, 122);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Member";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // count
            // 
            this.count.AutoSize = true;
            this.count.Location = new System.Drawing.Point(57, 136);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(0, 13);
            this.count.TabIndex = 13;
            // 
            // ReturnedDate
            // 
            this.ReturnedDate.AutoSize = true;
            this.ReturnedDate.Location = new System.Drawing.Point(51, 360);
            this.ReturnedDate.Name = "ReturnedDate";
            this.ReturnedDate.Size = new System.Drawing.Size(77, 13);
            this.ReturnedDate.TabIndex = 14;
            this.ReturnedDate.Text = "Returned Date";
            // 
            // tbrd
            // 
            this.tbrd.Location = new System.Drawing.Point(134, 360);
            this.tbrd.Name = "tbrd";
            this.tbrd.Size = new System.Drawing.Size(106, 20);
            this.tbrd.TabIndex = 15;
            // 
            // tbfine
            // 
            this.tbfine.Location = new System.Drawing.Point(652, 364);
            this.tbfine.Name = "tbfine";
            this.tbfine.Size = new System.Drawing.Size(135, 20);
            this.tbfine.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(569, 364);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Fine Amount";
            // 
            // btnconfirm
            // 
            this.btnconfirm.Location = new System.Drawing.Point(54, 402);
            this.btnconfirm.Name = "btnconfirm";
            this.btnconfirm.Size = new System.Drawing.Size(74, 23);
            this.btnconfirm.TabIndex = 18;
            this.btnconfirm.Text = "Confirm Fine";
            this.btnconfirm.UseVisualStyleBackColor = true;
            this.btnconfirm.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnreturn
            // 
            this.btnreturn.Location = new System.Drawing.Point(166, 402);
            this.btnreturn.Name = "btnreturn";
            this.btnreturn.Size = new System.Drawing.Size(74, 23);
            this.btnreturn.TabIndex = 19;
            this.btnreturn.Text = "Return";
            this.btnreturn.UseVisualStyleBackColor = true;
            this.btnreturn.Click += new System.EventHandler(this.btnreturn_Click);
            // 
            // Return
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 505);
            this.Controls.Add(this.btnreturn);
            this.Controls.Add(this.btnconfirm);
            this.Controls.Add(this.tbfine);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbrd);
            this.Controls.Add(this.ReturnedDate);
            this.Controls.Add(this.count);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnckMemeber);
            this.Controls.Add(this.tbname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbmco);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Return";
            this.Text = "Return";
            this.Load += new System.EventHandler(this.Return_Load);
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label count;
        private System.Windows.Forms.Label ReturnedDate;
        private System.Windows.Forms.TextBox tbrd;
        private System.Windows.Forms.TextBox tbfine;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnconfirm;
        private System.Windows.Forms.Button btnreturn;
    }
}