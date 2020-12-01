using QLSV.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class FrmThemLop : Form
    {
        public FrmThemLop()
        {
            InitializeComponent();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            var tenlop = txtTenLop.Text;
            var room = txtPhongHoc.Text;   
  
                Classroom classroom = new Classroom()
                {
                    ID = Guid.NewGuid().ToString(),
                    Name = tenlop,
                    Room = room
                };
                var db = new QLSVDBContext();
                var obj = db.Classrooms.Where(t => t.Name == classroom.Name).FirstOrDefault();
                if (obj == null)
                {


                    db.Classrooms.Add(classroom);
                    db.SaveChanges();
                MessageBox.Show("Bạn đã thêm thành công");
                DialogResult = DialogResult.OK;
            }
                else
                {
                    MessageBox.Show("Bạn không thể thêm lớp này được");
                }
            }
        
    }
}
