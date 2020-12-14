using AppQLSV.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppQLSV.GUI
{
    public partial class ThemLop : Form
    {
        Classroom lophoc;
        public ThemLop()
        {
            //thêm mới
            InitializeComponent();
            this.Text = "Thêm mới lớp học";
        }
        public ThemLop(Classroom lophoc)
        {
            //chỉnh sửa
            InitializeComponent();
            this.lophoc = lophoc;
            this.Text = "Chỉnh sửa lớp học";
            texttenlop.Text = this.lophoc.Name;
            textphonghoc.Text = this.lophoc.Room;
        }
        private void buttondongy_Click(object sender, EventArgs e)
        {
            var tenlop = texttenlop.Text;
            var phonghoc = textphonghoc.Text;
            if (lophoc == null)
            {

                var lop = new Classroom
                {
                    ID = Guid.NewGuid().ToString(),
                    Name = tenlop,
                    Room = phonghoc
                };
                var db = new APPQLSVDBContext();
                db.Classrooms.Add(lop);
                db.SaveChanges();
                DialogResult = DialogResult.OK;
            }
            else
            {
                var db = new APPQLSVDBContext();
                var lop = db.Classrooms.Where(t => t.ID == lophoc.ID).FirstOrDefault();
                lop.Name = tenlop;
                lop.Room = phonghoc;
                db.SaveChanges();
                DialogResult = DialogResult.OK;
            }
        }
    }
}
