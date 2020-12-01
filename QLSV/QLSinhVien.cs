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
    public partial class QLSV : Form
    {
        public QLSV()
        {
            InitializeComponent();
            LoadListStudent();
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
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void QLSV_Load(object sender, EventArgs e)
        {

        }
    }
}
