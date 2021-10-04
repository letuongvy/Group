using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicForm.Entities
{
    class Student
    {
        /// <summary>
        /// Khóa chính
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// Tên
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Họ
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Ngày sinh Date of Birth
        /// </summary>
        public DateTime DOB { get; set; }
        /// <summary>
        /// Nơi sinh POB Pace of Birth
        /// </summary>
        public string POB { get; set; }
        /// <summary>
        /// Giới tính
        /// </summary>
        public EGender Gender { get; set; }
        /// <summary>
        /// Quê quán
        /// </summary>
        public string HomeTown { get; set; }
        public string FullName
        {
            get { return $"{LastName} {FirstName}"; }
        }
        public List<HistoryLeaning> ListHistoryLeaning { get; set; }
        /// <summary>
        /// Lấy toàn bộ ds sv có trong CSDL (Mock Data)
        /// </summary>
        /// <returns></returns>
        public static List<Student> GetList()
        {
            var ls = new List<Student>();
            ls.Add(new Student()
            {
                LastName = "Nguyễn",
                Id = "1",
                FirstName = "Dũng",
                DOB = new DateTime(2000, 2, 5),
                POB = "Phú Vang",
                HomeTown= "Thừa Thiên Huế",
                Gender = EGender.Nam
            }) ;
            ls.Add(new Student()
            {
                LastName = "Nguyễn",
                Id = "2",
                FirstName = "Thị Thơm",
                DOB = new DateTime(2000, 2, 5),
                POB = "Phú Vang",
                HomeTown = "Thừa Thiên Huế",
                Gender = EGender.Nu
            });
            return ls;
        }
        /// <summary>
        /// Lấy 1 sv với id
        /// </summary>
        /// <param name="id">Mã sinh viên</param>
        /// <returns>
        /// Sv có mã tương ứng là id
        /// Ngượi lại return null
        /// </returns>
        public static Student Get(string id)
        {
            var dbStudent = GetList();
            //Linq to SQL
            //cách truyền thống
            //for(int i = 0; i < dbStudent.Count; i++)
            //{
            //    if (dbStudent[i].Id == id)
            //         return dbStudent[i];
            //}
            //return null;
            //cách Linq to SQL
            //SQL: Select * form Student where Id = '1'
           
 
            var student = dbStudent.Where(s => s.Id == id).FirstOrDefault();
            student.ListHistoryLeaning = HistoryLeaning.GetList(student.Id);
            return student;
        }
    }
    public enum EGender
    {
        Nam, Nu, Khac
    }
}
