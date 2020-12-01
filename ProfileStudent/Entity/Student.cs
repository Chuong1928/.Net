using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProfileStudent.Entity
{
   public class Student
    {


        public string ID { get; set; }
        public string FistName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        public string POB { get; set; }
        //public int sexual { get; set; }
        public string PathAVT { get; set; }
        public Sexual sexual { get; set; }
        public List<LeaningHistory> ListLearningHistory { get; set; }
        /// <summary>
        /// Tao 1 sinh vien gia?
        /// </summary>
        /// <returns></returns>
        public static Student createFakeStuden()
        {
            Student studen = new Student
            {
                ID = "17T1021293",
                FistName = "Ngo",
                LastName = "Truong",
                DOB = new DateTime(1999, 3, 17),
                POB = "TH",
                sexual = Sexual.Male,
                PathAVT = Application.StartupPath+"\\img\\haha.jpg",
            };
            List<LeaningHistory> history = new List<LeaningHistory> ();
            for(int i = 0; i < 12; i++)
            {
                LeaningHistory histories = new LeaningHistory
                {
                    ID = i.ToString(),
                    Lop = i.ToString(),
                    Truong = "Truong Quoc Hoc",
                    HocLuc = "Gioi",
                    Address = "TP Huế"
                };
                history.Add(histories);
            }
            studen.ListLearningHistory = history;
            return studen;
        }
        public enum Sexual
        {
            Male, Female, Other
        }
    }
}
