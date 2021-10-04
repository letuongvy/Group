using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicForm.Entities
{
    class HistoryLeaning
    {
        public string SchoolName { get; set; }
        public string SchoolAddress { get; set; }
        public int YearBegin { get; set; }
        public int YearEnd { get; set; }
        public float Mark { get; set; }
        public string Rank { 
            get {
                if (Mark < 5)
                    return "Yếu";
                else if (Mark < 7)
                    return "Trung Bình";
                else if (Mark < 9)
                    return "Giỏi";
                else
                    return " Xuất sắc";
            }
        }
        public static List<HistoryLeaning> GetList(string idStudent)
        {
            List<HistoryLeaning> List = new List<HistoryLeaning>();
            List.Add(new HistoryLeaning
            {
                SchoolAddress = "Chi Lăng, Huế",
                SchoolName = "Tiểu học Chi Lăng",
                YearBegin = 2006,
                YearEnd = 2011,
                Mark = 8
            });
            List.Add(new HistoryLeaning
            {
                SchoolAddress = "Chi Lăng, Huế",
                SchoolName = "Tiểu học Chi Lăng",
                YearBegin = 2006,
                YearEnd = 2015,
                Mark = 8
            });
            List.Add(new HistoryLeaning
            {
                SchoolAddress = "Chi Lăng, Huế",
                SchoolName = "Trung học Chi Lăng",
                YearBegin = 2006,
                YearEnd = 2011,
                Mark = 8
            });
            return CLSCompliantAttribute
         }

    }
}
