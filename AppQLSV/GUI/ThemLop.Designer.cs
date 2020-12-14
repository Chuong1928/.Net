namespace AppQLSV.GUI
{
    partial class ThemLop
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.texttenlop = new System.Windows.Forms.TextBox();
            this.textphonghoc = new System.Windows.Forms.TextBox();
            this.buttondongy = new System.Windows.Forms.Button();
            this.buttonboqua = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TenLop";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "PhongHoc";
            // 
            // texttenlop
            // 
            this.texttenlop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.texttenlop.Location = new System.Drawing.Point(124, 39);
            this.texttenlop.Name = "texttenlop";
            this.texttenlop.Size = new System.Drawing.Size(286, 20);
            this.texttenlop.TabIndex = 0;
            // 
            // textphonghoc
            // 
            this.textphonghoc.Location = new System.Drawing.Point(124, 87);
            this.textphonghoc.Name = "textphonghoc";
            this.textphonghoc.Size = new System.Drawing.Size(286, 20);
            this.textphonghoc.TabIndex = 1;
            // 
            // buttondongy
            // 
            this.buttondongy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttondongy.Location = new System.Drawing.Point(242, 125);
            this.buttondongy.Name = "buttondongy";
            this.buttondongy.Size = new System.Drawing.Size(75, 23);
            this.buttondongy.TabIndex = 2;
            this.buttondongy.Text = "Đồng ý";
            this.buttondongy.UseVisualStyleBackColor = true;
            this.buttondongy.Click += new System.EventHandler(this.buttondongy_Click);
            // 
            // buttonboqua
            // 
            this.buttonboqua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonboqua.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonboqua.Location = new System.Drawing.Point(335, 125);
            this.buttonboqua.Name = "buttonboqua";
            this.buttonboqua.Size = new System.Drawing.Size(75, 23);
            this.buttonboqua.TabIndex = 4;
            this.buttonboqua.Text = "Bỏ Qua";
            this.buttonboqua.UseVisualStyleBackColor = true;
            // 
            // ThemLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonboqua;
            this.ClientSize = new System.Drawing.Size(446, 217);
            this.ControlBox = false;
            this.Controls.Add(this.buttonboqua);
            this.Controls.Add(this.buttondongy);
            this.Controls.Add(this.textphonghoc);
            this.Controls.Add(this.texttenlop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ThemLop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThemLop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox texttenlop;
        private System.Windows.Forms.TextBox textphonghoc;
        private System.Windows.Forms.Button buttondongy;
        private System.Windows.Forms.Button buttonboqua;
    }
}