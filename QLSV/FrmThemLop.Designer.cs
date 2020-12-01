namespace QLSV
{
    partial class FrmThemLop
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
            this.TenLop = new System.Windows.Forms.Label();
            this.txtTenLop = new System.Windows.Forms.TextBox();
            this.txtRoom = new System.Windows.Forms.Label();
            this.txtPhongHoc = new System.Windows.Forms.TextBox();
            this.OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TenLop
            // 
            this.TenLop.AutoSize = true;
            this.TenLop.Location = new System.Drawing.Point(51, 49);
            this.TenLop.Name = "TenLop";
            this.TenLop.Size = new System.Drawing.Size(44, 13);
            this.TenLop.TabIndex = 0;
            this.TenLop.Text = "TenLop";
            // 
            // txtTenLop
            // 
            this.txtTenLop.Location = new System.Drawing.Point(134, 49);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(100, 20);
            this.txtTenLop.TabIndex = 1;
            // 
            // txtRoom
            // 
            this.txtRoom.AutoSize = true;
            this.txtRoom.Location = new System.Drawing.Point(51, 84);
            this.txtRoom.Name = "txtRoom";
            this.txtRoom.Size = new System.Drawing.Size(58, 13);
            this.txtRoom.TabIndex = 2;
            this.txtRoom.Text = "PhongHoc";
            // 
            // txtPhongHoc
            // 
            this.txtPhongHoc.Location = new System.Drawing.Point(134, 81);
            this.txtPhongHoc.Name = "txtPhongHoc";
            this.txtPhongHoc.Size = new System.Drawing.Size(100, 20);
            this.txtPhongHoc.TabIndex = 3;
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(134, 126);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 4;
            this.OK.Text = "Dong Y";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // FrmThemLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 262);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.txtPhongHoc);
            this.Controls.Add(this.txtRoom);
            this.Controls.Add(this.txtTenLop);
            this.Controls.Add(this.TenLop);
            this.Name = "FrmThemLop";
            this.Text = "FrmThemLop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TenLop;
        private System.Windows.Forms.TextBox txtTenLop;
        private System.Windows.Forms.Label txtRoom;
        private System.Windows.Forms.TextBox txtPhongHoc;
        private System.Windows.Forms.Button OK;
    }
}