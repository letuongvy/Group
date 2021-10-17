using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormBasicTime
{
    public partial class FrmTimer : Form
    {
        public FrmTimer()
        {
            InitializeComponent();
        }

        private void FrmTimer_Load(object sender, EventArgs e)
        {

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (seconds == 0)
            {
                timer1.Stop();
                MessageBox.Show("Happy New Year!!!");
            }
                

            else
            {
                seconds--;
                lblgio.Text = $"{seconds / 60}:{seconds % 60}";
            }
        }
        int seconds = 0;
        private void btnBatdau_Click(object sender, EventArgs e)
        {
            seconds = (int)numTimer.Value * 60;
            timer1.Start();
        }

        private void btnDung_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void numTimer_ValueChanged(object sender, EventArgs e)
        {
           
        }
    }
}
