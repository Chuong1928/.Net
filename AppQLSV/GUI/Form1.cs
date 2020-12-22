using AppQLSV.DAL;
using AppQLSV.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppQLSV
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
            girdlophoc.AutoGenerateColumns = false;
            girdsinhvien.AutoGenerateColumns = false;
            LoadDanhSachLopHoc();
        }

        void LoadDanhSachLopHoc()
        {
            APPQLSVDBContext db = new APPQLSVDBContext();
            var ls = db.Classrooms.Select(e => new ClassRoomViewModel
            {
                ID = e.ID,
                Name= e.Name,
                Room = e.Room,
                TotalStudent = e.Students.Count,
                TotalFemale = e.Students.Where(t=>t.Gender == 1).Count(),
                TotalMale = e.Students.Where(t => t.Gender == 0).Count(),



            }).OrderBy(e=>e.Name).ToList();
            bdslophoc.DataSource = ls;
            girdlophoc.DataSource = bdslophoc;
            
        }
        private void btnThemLop_Click(object sender, EventArgs e)
        {
            var f = new ThemLop();
            if (f.ShowDialog() == DialogResult.OK)
            {
                LoadDanhSachLopHoc();
            }

        }

        private void btnxoalop_Click(object sender, EventArgs e)
        {
            var lopdangchon = bdslophoc.Current as Classroom;
            if (lopdangchon != null)
            {
               var rs= MessageBox.Show("Bạn có thật sự muốn xóa không ?", "Chú ý", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (rs == DialogResult.OK)
                {
                    //xóa lớp đang chọn
                    APPQLSVDBContext db = new APPQLSVDBContext();
                    var lop = db.Classrooms.Where(t => t.ID == lopdangchon.ID).FirstOrDefault();

                    if (lop != null)
                    {
                        db.Classrooms.Remove(lop);
                        db.SaveChanges();
                        LoadDanhSachLopHoc();
                    }
                    
                }
            }
        }

        private void btnsualop_Click(object sender, EventArgs e)
        {
            var lopdangchon = bdslophoc.Current as Classroom;
            if (lopdangchon != null)
            {
                var f = new ThemLop(lopdangchon);
                if (f.ShowDialog() == DialogResult.OK)
                {
                    LoadDanhSachLopHoc();
                }
                    
            }
        }

        private void bdslophoc_CurrentChanged(object sender, EventArgs e)
        {
            var lopdangchon = bdslophoc.Current as ClassRoomViewModel;
            if (lopdangchon != null)
            {
                var db = new APPQLSVDBContext();
                var dssv = db.Students.Where(t => t.IDClassRoom == lopdangchon.ID).ToList();
                bdssinhvien.DataSource = dssv;
                girdsinhvien.DataSource = bdssinhvien;
            }
        }

        private void btnthemsinhvien_Click(object sender, EventArgs e)
        {
            var f = new ThemSinhVien();
            if (f.ShowDialog() == DialogResult.OK)
            {
                LoadDanhSachLopHoc();
            }
        }

        private void btnsuasinhvien_Click(object sender, EventArgs e)
        {
            var sinhviendangchon = bdssinhvien.Current as Student;
            if (sinhviendangchon != null)
            {
                var f = new ThemSinhVien(sinhviendangchon);
                if (f.ShowDialog() == DialogResult.OK)
               {
                   LoadDanhSachLopHoc();
                }

            }
        }

        private void bdssinhvien_CurrentChanged(object sender, EventArgs e)
        {
            
        }

        private void btnxoasinhvien_Click(object sender, EventArgs e)
        {
            var sinhviendangchon = bdssinhvien.Current as Student;
            if (sinhviendangchon != null)
            {
                var rs = MessageBox.Show("Bạn có thật sự muốn xóa không ?", "Chú ý", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (rs == DialogResult.OK)
                {
                    //xóa lớp đang chọn
                    APPQLSVDBContext db = new APPQLSVDBContext();
                    var sv = db.Students.Where(t => t.ID == sinhviendangchon.ID).FirstOrDefault();

                    if (sv != null)
                    {
                        db.Students.Remove(sv);
                        db.SaveChanges();
                        LoadDanhSachLopHoc();
                    }

                }
            }
        }

        private void girdlophoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
