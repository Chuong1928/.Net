namespace ProfileStudent
{
    partial class ThongTinSV
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
            this.pickavt = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbOthersexual = new System.Windows.Forms.RadioButton();
            this.rdbFeMale = new System.Windows.Forms.RadioButton();
            this.rdbMale = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPOB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBirthday = new System.Windows.Forms.DateTimePicker();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.IDStudent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.girdHistory = new System.Windows.Forms.DataGridView();
            this.Lớp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trường = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pickavt)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.girdHistory)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pickavt
            // 
            this.pickavt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pickavt.Location = new System.Drawing.Point(12, 12);
            this.pickavt.Name = "pickavt";
            this.pickavt.Size = new System.Drawing.Size(100, 117);
            this.pickavt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pickavt.TabIndex = 0;
            this.pickavt.TabStop = false;
            this.pickavt.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.rdbOthersexual);
            this.groupBox1.Controls.Add(this.rdbFeMale);
            this.groupBox1.Controls.Add(this.rdbMale);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtPOB);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtBirthday);
            this.groupBox1.Controls.Add(this.txtLastName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtFirstName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.IDStudent);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(136, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(540, 190);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ThongTinCoBan";
            // 
            // rdbOthersexual
            // 
            this.rdbOthersexual.AutoSize = true;
            this.rdbOthersexual.Location = new System.Drawing.Point(256, 164);
            this.rdbOthersexual.Name = "rdbOthersexual";
            this.rdbOthersexual.Size = new System.Drawing.Size(39, 17);
            this.rdbOthersexual.TabIndex = 13;
            this.rdbOthersexual.TabStop = true;
            this.rdbOthersexual.Text = "3D";
            this.rdbOthersexual.UseVisualStyleBackColor = true;
            // 
            // rdbFeMale
            // 
            this.rdbFeMale.AutoSize = true;
            this.rdbFeMale.Location = new System.Drawing.Point(172, 167);
            this.rdbFeMale.Name = "rdbFeMale";
            this.rdbFeMale.Size = new System.Drawing.Size(39, 17);
            this.rdbFeMale.TabIndex = 12;
            this.rdbFeMale.TabStop = true;
            this.rdbFeMale.Text = "Nu";
            this.rdbFeMale.UseVisualStyleBackColor = true;
            // 
            // rdbMale
            // 
            this.rdbMale.AutoSize = true;
            this.rdbMale.Location = new System.Drawing.Point(89, 164);
            this.rdbMale.Name = "rdbMale";
            this.rdbMale.Size = new System.Drawing.Size(47, 17);
            this.rdbMale.TabIndex = 11;
            this.rdbMale.TabStop = true;
            this.rdbMale.Text = "Nam";
            this.rdbMale.UseVisualStyleBackColor = true;
            this.rdbMale.CheckedChanged += new System.EventHandler(this.rdbMale_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "GioiTinh";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtPOB
            // 
            this.txtPOB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPOB.Location = new System.Drawing.Point(89, 105);
            this.txtPOB.Multiline = true;
            this.txtPOB.Name = "txtPOB";
            this.txtPOB.Size = new System.Drawing.Size(426, 46);
            this.txtPOB.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "NoiSinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "NgaySinh";
            // 
            // txtBirthday
            // 
            this.txtBirthday.CustomFormat = "dd/mm/yyyy";
            this.txtBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtBirthday.Location = new System.Drawing.Point(89, 70);
            this.txtBirthday.Name = "txtBirthday";
            this.txtBirthday.Size = new System.Drawing.Size(200, 20);
            this.txtBirthday.TabIndex = 6;
            // 
            // txtLastName
            // 
            this.txtLastName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLastName.Location = new System.Drawing.Point(370, 43);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(143, 20);
            this.txtLastName.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(313, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ten";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(89, 43);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(200, 20);
            this.txtFirstName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "HoDem";
            // 
            // IDStudent
            // 
            this.IDStudent.Location = new System.Drawing.Point(89, 17);
            this.IDStudent.Name = "IDStudent";
            this.IDStudent.Size = new System.Drawing.Size(200, 20);
            this.IDStudent.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "MaSinhVien";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.girdHistory);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Location = new System.Drawing.Point(21, 225);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(648, 227);
            this.panel1.TabIndex = 2;
            // 
            // girdHistory
            // 
            this.girdHistory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.girdHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.girdHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Lớp,
            this.Trường,
            this.Column1,
            this.Column2,
            this.Column3});
            this.girdHistory.Location = new System.Drawing.Point(3, 28);
            this.girdHistory.Name = "girdHistory";
            this.girdHistory.Size = new System.Drawing.Size(628, 150);
            this.girdHistory.TabIndex = 1;
            this.girdHistory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Lớp
            // 
            this.Lớp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Lớp.DataPropertyName = "Lop";
            this.Lớp.HeaderText = "Lớp";
            this.Lớp.Name = "Lớp";
            this.Lớp.Width = 50;
            // 
            // Trường
            // 
            this.Trường.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Trường.DataPropertyName = "Truong";
            this.Trường.HeaderText = "Trường";
            this.Trường.Name = "Trường";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Address";
            this.Column1.HeaderText = "Địa chỉ";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Học Lực";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Hạnh kiểm";
            this.Column3.Name = "Column3";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(648, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(99, 22);
            this.toolStripLabel1.Text = "QuaTrinhHocTap";
            // 
            // ThongTinSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 470);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pickavt);
            this.Name = "ThongTinSV";
            this.Text = "ThongTinSV";
            ((System.ComponentModel.ISupportInitialize)(this.pickavt)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.girdHistory)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pickavt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPOB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker txtBirthday;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IDStudent;
        private System.Windows.Forms.RadioButton rdbOthersexual;
        private System.Windows.Forms.RadioButton rdbFeMale;
        private System.Windows.Forms.RadioButton rdbMale;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.DataGridView girdHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lớp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trường;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}

