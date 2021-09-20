using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frorm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Click(object sender, EventArgs e)
        {
            
        }

        private void btcong_Click(object sender, EventArgs e)
        {
            try
            {
                var soThuNhat = txt1.Text;
                long nSoThuNhat = Convert.ToInt64(soThuNhat);

                var soThuHai = txt2.Text;
                long nSoThuHai = long.Parse(soThuHai);

                var ketQua = nSoThuNhat + nSoThuHai;
                lblso.Text = ketQua.ToString("N2");
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

        private void bttru_Click(object sender, EventArgs e)
        {
            try
            {
                var soThuNhat = txt1.Text;
                long nSoThuNhat = Convert.ToInt64(soThuNhat);

                var soThuHai = txt2.Text;
                long nSoThuHai = long.Parse(soThuHai);

                var ketQua = nSoThuNhat - nSoThuHai;
                lblso.Text = ketQua.ToString();
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

        private void btnhan_Click(object sender, EventArgs e)
        {
            try
            {
                var soThuNhat = txt1.Text;
                long nSoThuNhat = Convert.ToInt64(soThuNhat);

                var soThuHai = txt2.Text;
                long nSoThuHai = long.Parse(soThuHai);

                var ketQua = nSoThuNhat * nSoThuHai;
                lblso.Text = ketQua.ToString();
            }
            catch(FormatException ex)
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

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
