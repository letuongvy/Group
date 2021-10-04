using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicForm.Entities
{
    class DangNhapTT
    {
        public string Id { get; set; }
        public string Password { get; set; }
        public static List<DangNhapTT> GetList()
        {
            var ls = new List<DangNhapTT>();
            ls.Add(new DangNhapTT()
            {
                Id = "ndungithue",
                Password = "ABC@123",
            }) ;
            return ls;
        }
        public static DangNhapTT Get(string id)
        {
            var dbDangNhap = GetList();

            var DN = dbDangNhap.Where(s => s.Id == id).FirstOrDefault();
            return DN;
        }
    }
}
