namespace AppQLSV
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelleft = new System.Windows.Forms.Panel();
            this.girdlophoc = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnxoalop = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.btnsualop = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.btnThemLop = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.girdsinhvien = new System.Windows.Forms.DataGridView();
            this.MaSinhVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoiSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.btnxoasinhvien = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.btnsuasinhvien = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.btnthemsinhvien = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.bdslophoc = new System.Windows.Forms.BindingSource(this.components);
            this.bdssinhvien = new System.Windows.Forms.BindingSource(this.components);
            this.TenLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhongHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SinhVienNam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SinhVienNu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelleft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.girdlophoc)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.girdsinhvien)).BeginInit();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdslophoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdssinhvien)).BeginInit();
            this.SuspendLayout();
            // 
            // panelleft
            // 
            this.panelleft.Controls.Add(this.girdlophoc);
            this.panelleft.Controls.Add(this.toolStrip1);
            this.panelleft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelleft.Location = new System.Drawing.Point(0, 0);
            this.panelleft.Name = "panelleft";
            this.panelleft.Size = new System.Drawing.Size(522, 359);
            this.panelleft.TabIndex = 0;
            // 
            // girdlophoc
            // 
            this.girdlophoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.girdlophoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenLop,
            this.PhongHoc,
            this.TotalStudent,
            this.SinhVienNam,
            this.SinhVienNu});
            this.girdlophoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.girdlophoc.Location = new System.Drawing.Point(0, 25);
            this.girdlophoc.Name = "girdlophoc";
            this.girdlophoc.Size = new System.Drawing.Size(522, 334);
            this.girdlophoc.TabIndex = 0;
            this.girdlophoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.girdlophoc_CellContentClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.btnxoalop,
            this.toolStripButton1,
            this.btnsualop,
            this.toolStripButton2,
            this.btnThemLop,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(522, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(112, 22);
            this.toolStripLabel1.Text = "Danh sách sinh viên";
            // 
            // btnxoalop
            // 
            this.btnxoalop.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnxoalop.Name = "btnxoalop";
            this.btnxoalop.Size = new System.Drawing.Size(27, 22);
            this.btnxoalop.Text = "Xóa";
            this.btnxoalop.Click += new System.EventHandler(this.btnxoalop_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // btnsualop
            // 
            this.btnsualop.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnsualop.Name = "btnsualop";
            this.btnsualop.Size = new System.Drawing.Size(26, 22);
            this.btnsualop.Text = "Sửa";
            this.btnsualop.Click += new System.EventHandler(this.btnsualop_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // btnThemLop
            // 
            this.btnThemLop.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnThemLop.Name = "btnThemLop";
            this.btnThemLop.Size = new System.Drawing.Size(38, 22);
            this.btnThemLop.Text = "Thêm";
            this.btnThemLop.Click += new System.EventHandler(this.btnThemLop_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Xóa";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.girdsinhvien);
            this.panel1.Controls.Add(this.toolStrip2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(522, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(626, 359);
            this.panel1.TabIndex = 1;
            // 
            // girdsinhvien
            // 
            this.girdsinhvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.girdsinhvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSinhVien,
            this.Ho,
            this.Column1,
            this.NgaySinh,
            this.NoiSinh,
            this.GioiTinh});
            this.girdsinhvien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.girdsinhvien.Location = new System.Drawing.Point(0, 25);
            this.girdsinhvien.Name = "girdsinhvien";
            this.girdsinhvien.Size = new System.Drawing.Size(626, 334);
            this.girdsinhvien.TabIndex = 2;
            // 
            // MaSinhVien
            // 
            this.MaSinhVien.DataPropertyName = "ID";
            this.MaSinhVien.HeaderText = "Mã Sinh Viên";
            this.MaSinhVien.Name = "MaSinhVien";
            // 
            // Ho
            // 
            this.Ho.DataPropertyName = "FirstName";
            this.Ho.HeaderText = "Họ ";
            this.Ho.Name = "Ho";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "LastName";
            this.Column1.HeaderText = "Tên";
            this.Column1.Name = "Column1";
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "DateOfBirth";
            this.NgaySinh.HeaderText = "Ngày Sinh";
            this.NgaySinh.Name = "NgaySinh";
            // 
            // NoiSinh
            // 
            this.NoiSinh.DataPropertyName = "PlaceOfBirth";
            this.NoiSinh.HeaderText = "Nơi Sinh";
            this.NoiSinh.Name = "NoiSinh";
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "_g";
            this.GioiTinh.HeaderText = "giới tính";
            this.GioiTinh.Name = "GioiTinh";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel5,
            this.btnxoasinhvien,
            this.toolStripButton4,
            this.btnsuasinhvien,
            this.toolStripButton5,
            this.btnthemsinhvien,
            this.toolStripButton6});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(626, 25);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(112, 22);
            this.toolStripLabel5.Text = "Danh sách sinh viên";
            // 
            // btnxoasinhvien
            // 
            this.btnxoasinhvien.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnxoasinhvien.Name = "btnxoasinhvien";
            this.btnxoasinhvien.Size = new System.Drawing.Size(27, 22);
            this.btnxoasinhvien.Text = "Xóa";
            this.btnxoasinhvien.Click += new System.EventHandler(this.btnxoasinhvien_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "toolStripButton4";
            // 
            // btnsuasinhvien
            // 
            this.btnsuasinhvien.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnsuasinhvien.Name = "btnsuasinhvien";
            this.btnsuasinhvien.Size = new System.Drawing.Size(26, 22);
            this.btnsuasinhvien.Text = "Sửa";
            this.btnsuasinhvien.Click += new System.EventHandler(this.btnsuasinhvien_Click);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "toolStripButton5";
            // 
            // btnthemsinhvien
            // 
            this.btnthemsinhvien.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnthemsinhvien.Name = "btnthemsinhvien";
            this.btnthemsinhvien.Size = new System.Drawing.Size(38, 22);
            this.btnthemsinhvien.Text = "Thêm";
            this.btnthemsinhvien.Click += new System.EventHandler(this.btnthemsinhvien_Click);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "toolStripButton6";
            // 
            // bdslophoc
            // 
            this.bdslophoc.CurrentChanged += new System.EventHandler(this.bdslophoc_CurrentChanged);
            // 
            // bdssinhvien
            // 
            this.bdssinhvien.CurrentChanged += new System.EventHandler(this.bdssinhvien_CurrentChanged);
            // 
            // TenLop
            // 
            this.TenLop.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenLop.DataPropertyName = "Name";
            this.TenLop.HeaderText = "Tên Lớp";
            this.TenLop.Name = "TenLop";
            // 
            // PhongHoc
            // 
            this.PhongHoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PhongHoc.DataPropertyName = "Room";
            this.PhongHoc.HeaderText = "Phòng Học";
            this.PhongHoc.Name = "PhongHoc";
            // 
            // TotalStudent
            // 
            this.TotalStudent.DataPropertyName = "TotalStudent";
            this.TotalStudent.HeaderText = "Sĩ Số";
            this.TotalStudent.Name = "TotalStudent";
            // 
            // SinhVienNam
            // 
            this.SinhVienNam.DataPropertyName = "TotalMale";
            this.SinhVienNam.HeaderText = "Số SV Nam";
            this.SinhVienNam.Name = "SinhVienNam";
            // 
            // SinhVienNu
            // 
            this.SinhVienNu.DataPropertyName = "TotalFemale";
            this.SinhVienNu.HeaderText = "Số SV Nữ";
            this.SinhVienNu.Name = "SinhVienNu";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 359);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelleft);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelleft.ResumeLayout(false);
            this.panelleft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.girdlophoc)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.girdsinhvien)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdslophoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdssinhvien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelleft;
        private System.Windows.Forms.DataGridView girdlophoc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel btnThemLop;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripLabel btnsualop;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripLabel btnxoalop;
        private System.Windows.Forms.DataGridView girdsinhvien;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripLabel btnthemsinhvien;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripLabel btnsuasinhvien;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripLabel btnxoasinhvien;
        private System.Windows.Forms.BindingSource bdslophoc;
        private System.Windows.Forms.BindingSource bdssinhvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSinhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ho;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoiSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhongHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn SinhVienNam;
        private System.Windows.Forms.DataGridViewTextBoxColumn SinhVienNu;
    }
}

