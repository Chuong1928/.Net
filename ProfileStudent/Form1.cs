using ProfileStudent.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ProfileStudent.Entity.Student;

namespace ProfileStudent
{
    public partial class ThongTinSV : Form
    {
        Student student;
        public ThongTinSV()
        {
            InitializeComponent();
            student = Student.createFakeStuden();
            IDStudent.Text = student.ID;
            txtFirstName.Text = student.FistName;
            txtLastName.Text = student.LastName;
            txtPOB.Text = student.POB;
            txtBirthday.Value = student.DOB;
            switch (student.sexual)
            {
                case Sexual.Male:
                    rdbMale.Checked = true; break;
                case Sexual.Female:
                    rdbFeMale.Checked = true; break;
                case Sexual.Other:
                    rdbOthersexual.Checked = true; break;
            }
            if (string.IsNullOrEmpty(student.PathAVT))
                pickavt.ImageLocation = student.PathAVT;

            girdHistory.AutoGenerateColumns = false;
            girdHistory.DataSource = student.ListLearningHistory;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "File ảnh|*.jpg;*.png";
            dialog.Title = "Chọn ảnh sinh viên";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                //MessageBox.Show($"Đường dẫn file :");
                pickavt.ImageLocation= dialog.FileName;

            }
        }

    }
}
