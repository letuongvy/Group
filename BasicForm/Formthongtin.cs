using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BasicForm.Entities;

namespace BasicForm
{
    public partial class Formthongtin : Form
    {
        Student student;
        public Formthongtin(string idStudent = "1" )
        {
            InitializeComponent();
            student = Student.Get(idStudent);
            if(student == null)
            {
                MessageBox.Show($"Không tìm thấy student có mã là {idStudent}", "");
                return;
            }
            else
            {
                //C1
                txtHoTen.Text = $"{student.LastName}{student.FirstName}";
                //C2
                txtHoTen.Text = student.FullName;
                txtNoiSinh.Text = student.POB;
                txtQueQuan.Text = student.HomeTown;
                dtpNgaySinh.Value = student.DOB;
                if (student.Gender == EGender.Nam)
                    radioNam.Checked = true;
                else if (student.Gender == EGender.Nu)
                    radioNu.Checked = false;
                else
                    radioKhac.Checked = true;
            }
        }

        private void Formthongtin_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
