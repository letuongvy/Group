using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapLogin
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void btDongy_Click(object sender, EventArgs e)
        {
            string id = "ndungithue";
            string Password = "ABC@123";
            if (id.Equals(txtten.Text) && Password.Equals(txtmatkhau.Text))
            {
                MessageBox.Show("Đăng nhập thành công");
            }
            else
                MessageBox.Show("Đăng nhập thất bại");
        }
    }
    }
