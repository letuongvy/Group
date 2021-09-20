using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1
{
    public partial class frmMathBasic : Form
    {
        public frmMathBasic()
        {
            InitializeComponent();//khoi tao form
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            try
            {
                var soThu1 = txtSo1.Text;
                long nSoThu1 = Convert.ToInt64(soThu1); //chuyển từ string sang số
                var soThu2 = txtSo2.Text;
                long nSoThu2 = long.Parse(soThu2);//chuyển từ string sang số cách 2
                var Ketqua = nSoThu1 + nSoThu2;

                lblKq.Text = Ketqua.ToString();
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Lỗi định dạng. Vui lòng nhập số.Chi tiết lỗi : {ex.Message}");
            }
            catch (OverflowException ex)
            {
                MessageBox.Show($"Lỗi số quá lớn.Chi tiết lỗi : {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi!!!Chi tiết lỗi : {ex.Message}");
            }
        }

        private void frmMathBasic_Load(object sender, EventArgs e)
        {

        }
    }
}
