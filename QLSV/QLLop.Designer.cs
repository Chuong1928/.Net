namespace QLSV
{
    partial class QLLop
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
            this.txtKeyWord = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hocSinhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lopHocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.thêmHọcSinhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaHọcSinhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaHọcSinhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmLớpHọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaLớpHọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaLớpHọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(505, 207);
            this.dataGridView1.TabIndex = 0;
            // 
            // txtKeyWord
            // 
            this.txtKeyWord.Location = new System.Drawing.Point(79, 65);
            this.txtKeyWord.Name = "txtKeyWord";
            this.txtKeyWord.Size = new System.Drawing.Size(386, 20);
            this.txtKeyWord.TabIndex = 1;
            this.txtKeyWord.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKeyWord_KeyPress);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hocSinhToolStripMenuItem,
            this.lopHocToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(529, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hocSinhToolStripMenuItem
            // 
            this.hocSinhToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmHọcSinhToolStripMenuItem,
            this.sửaHọcSinhToolStripMenuItem,
            this.xóaHọcSinhToolStripMenuItem});
            this.hocSinhToolStripMenuItem.Name = "hocSinhToolStripMenuItem";
            this.hocSinhToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.hocSinhToolStripMenuItem.Text = "HocSinh";
            this.hocSinhToolStripMenuItem.Click += new System.EventHandler(this.hocSinhToolStripMenuItem_Click);
            // 
            // lopHocToolStripMenuItem
            // 
            this.lopHocToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmLớpHọcToolStripMenuItem,
            this.sửaLớpHọcToolStripMenuItem,
            this.xóaLớpHọcToolStripMenuItem});
            this.lopHocToolStripMenuItem.Name = "lopHocToolStripMenuItem";
            this.lopHocToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.lopHocToolStripMenuItem.Text = "LopHoc";
            this.lopHocToolStripMenuItem.Click += new System.EventHandler(this.lopHocToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nhập từ khóa để Tìm Kiếm";
            // 
            // thêmHọcSinhToolStripMenuItem
            // 
            this.thêmHọcSinhToolStripMenuItem.Name = "thêmHọcSinhToolStripMenuItem";
            this.thêmHọcSinhToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.thêmHọcSinhToolStripMenuItem.Text = "Thêm Học Sinh";
            // 
            // sửaHọcSinhToolStripMenuItem
            // 
            this.sửaHọcSinhToolStripMenuItem.Name = "sửaHọcSinhToolStripMenuItem";
            this.sửaHọcSinhToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.sửaHọcSinhToolStripMenuItem.Text = "Sửa Học Sinh";
            // 
            // xóaHọcSinhToolStripMenuItem
            // 
            this.xóaHọcSinhToolStripMenuItem.Name = "xóaHọcSinhToolStripMenuItem";
            this.xóaHọcSinhToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.xóaHọcSinhToolStripMenuItem.Text = "Xóa Học Sinh";
            // 
            // thêmLớpHọcToolStripMenuItem
            // 
            this.thêmLớpHọcToolStripMenuItem.Name = "thêmLớpHọcToolStripMenuItem";
            this.thêmLớpHọcToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.thêmLớpHọcToolStripMenuItem.Text = "Thêm Lớp Học";
            this.thêmLớpHọcToolStripMenuItem.Click += new System.EventHandler(this.thêmLớpHọcToolStripMenuItem_Click);
            // 
            // sửaLớpHọcToolStripMenuItem
            // 
            this.sửaLớpHọcToolStripMenuItem.Name = "sửaLớpHọcToolStripMenuItem";
            this.sửaLớpHọcToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.sửaLớpHọcToolStripMenuItem.Text = "Sửa Lớp Học";
            // 
            // xóaLớpHọcToolStripMenuItem
            // 
            this.xóaLớpHọcToolStripMenuItem.Name = "xóaLớpHọcToolStripMenuItem";
            this.xóaLớpHọcToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.xóaLớpHọcToolStripMenuItem.Text = "Xóa Lớp Học";
            // 
            // QLLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 319);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKeyWord);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "QLLop";
            this.Text = "HUSC";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtKeyWord;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hocSinhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lopHocToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem thêmHọcSinhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sửaHọcSinhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaHọcSinhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmLớpHọcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sửaLớpHọcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaLớpHọcToolStripMenuItem;
    }
}

