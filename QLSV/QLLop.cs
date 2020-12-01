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
    public partial class QLLop : Form
    {
        public QLLop()
        {
            InitializeComponent();
           // AddClassRoom();
           
           
          

        }
        void LoadListStudent()
        {
            var db = new global::QLSV.DAL.QLSVDBContext();
            var ls = db.Students.ToList();
            /*   Where(e => e.Room == "Lab1").
                Select(e => new {
                    TenLop =e.Name,
                    PhongHoc =e.Room,
                    Siso=e.Students.Count(),
                    GVCV="ABC",

                }).*/
            dataGridView1.DataSource = ls;

        }
        void LoadClassRoom()
        {
            var db = new global::QLSV.DAL.QLSVDBContext();
            var ls = db.Classrooms.ToList();
            /*   Where(e => e.Room == "Lab1").
                Select(e => new {
                    TenLop =e.Name,
                    PhongHoc =e.Room,
                    Siso=e.Students.Count(),
                    GVCV="ABC",

                }).*/
            dataGridView1.DataSource = ls;

        }
    
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtKeyWord_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                var keyword = txtKeyWord.Text;
                var db = new QLSVDBContext();
                var ls=  db.Classrooms.
                    Where(
                    t => t.Name.Contains(keyword) || t.Room.Contains(keyword)
                    ).ToList();
                dataGridView1.DataSource=ls;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var f = new FrmThemLop();
            var rs=f.ShowDialog();
            if (rs == DialogResult.OK)
            {
                LoadClassRoom();
            }
        }

        private void hocSinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadListStudent();

        }

        private void lopHocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadClassRoom();

        }

        private void thêmLớpHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new FrmThemLop();
            var rs = f.ShowDialog();
            if (rs == DialogResult.OK)
            {
                LoadClassRoom();
            }
        }
    }
}
