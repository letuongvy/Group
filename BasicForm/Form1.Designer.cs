
namespace Frorm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.btcong = new System.Windows.Forms.Button();
            this.bttru = new System.Windows.Forms.Button();
            this.btnhan = new System.Windows.Forms.Button();
            this.btchia = new System.Windows.Forms.Button();
            this.lblketqua = new System.Windows.Forms.Label();
            this.lblso = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(102, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(419, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chương trình toán học cơ bản";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(52, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số thứ nhất:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(52, 174);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số thứ hai:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(188, 111);
            this.txt1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(333, 22);
            this.txt1.TabIndex = 3;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(188, 170);
            this.txt2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(333, 22);
            this.txt2.TabIndex = 4;
            // 
            // btcong
            // 
            this.btcong.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btcong.Location = new System.Drawing.Point(188, 227);
            this.btcong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btcong.Name = "btcong";
            this.btcong.Size = new System.Drawing.Size(66, 35);
            this.btcong.TabIndex = 5;
            this.btcong.Text = "+";
            this.btcong.UseVisualStyleBackColor = true;
            this.btcong.Click += new System.EventHandler(this.btcong_Click);
            // 
            // bttru
            // 
            this.bttru.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.bttru.Location = new System.Drawing.Point(272, 227);
            this.bttru.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bttru.Name = "bttru";
            this.bttru.Size = new System.Drawing.Size(62, 35);
            this.bttru.TabIndex = 6;
            this.bttru.Text = "-";
            this.bttru.UseVisualStyleBackColor = true;
            this.bttru.Click += new System.EventHandler(this.bttru_Click);
            // 
            // btnhan
            // 
            this.btnhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnhan.Location = new System.Drawing.Point(351, 227);
            this.btnhan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnhan.Name = "btnhan";
            this.btnhan.Size = new System.Drawing.Size(69, 35);
            this.btnhan.TabIndex = 7;
            this.btnhan.Text = "*";
            this.btnhan.UseVisualStyleBackColor = true;
            this.btnhan.Click += new System.EventHandler(this.btnhan_Click);
            // 
            // btchia
            // 
            this.btchia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btchia.Location = new System.Drawing.Point(451, 227);
            this.btchia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btchia.Name = "btchia";
            this.btchia.Size = new System.Drawing.Size(70, 35);
            this.btchia.TabIndex = 8;
            this.btchia.Text = "/";
            this.btchia.UseVisualStyleBackColor = true;
            // 
            // lblketqua
            // 
            this.lblketqua.AutoSize = true;
            this.lblketqua.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblketqua.Location = new System.Drawing.Point(51, 286);
            this.lblketqua.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblketqua.Name = "lblketqua";
            this.lblketqua.Size = new System.Drawing.Size(107, 29);
            this.lblketqua.TabIndex = 9;
            this.lblketqua.Text = "Kết quả:";
            // 
            // lblso
            // 
            this.lblso.AutoSize = true;
            this.lblso.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblso.Location = new System.Drawing.Point(192, 286);
            this.lblso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblso.Name = "lblso";
            this.lblso.Size = new System.Drawing.Size(27, 29);
            this.lblso.TabIndex = 10;
            this.lblso.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(629, 380);
            this.Controls.Add(this.lblso);
            this.Controls.Add(this.lblketqua);
            this.Controls.Add(this.btchia);
            this.Controls.Add(this.btnhan);
            this.Controls.Add(this.bttru);
            this.Controls.Add(this.btcong);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "FormMathBasic";
            this.Click += new System.EventHandler(this.Form1_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Button btcong;
        private System.Windows.Forms.Button bttru;
        private System.Windows.Forms.Button btnhan;
        private System.Windows.Forms.Button btchia;
        private System.Windows.Forms.Label lblketqua;
        private System.Windows.Forms.Label lblso;
    }
}

