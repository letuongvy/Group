
namespace BaiTap
{
    partial class FormDangNhap
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
            this.btBoqua = new System.Windows.Forms.Button();
            this.btDongy = new System.Windows.Forms.Button();
            this.txtmatkhau = new System.Windows.Forms.TextBox();
            this.txtten = new System.Windows.Forms.TextBox();
            this.lblMatkhau = new System.Windows.Forms.Label();
            this.lblTenDN = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btBoqua
            // 
            this.btBoqua.Location = new System.Drawing.Point(418, 138);
            this.btBoqua.Name = "btBoqua";
            this.btBoqua.Size = new System.Drawing.Size(75, 30);
            this.btBoqua.TabIndex = 20;
            this.btBoqua.Text = "Bỏ qua";
            this.btBoqua.UseVisualStyleBackColor = true;
            // 
            // btDongy
            // 
            this.btDongy.Location = new System.Drawing.Point(327, 138);
            this.btDongy.Name = "btDongy";
            this.btDongy.Size = new System.Drawing.Size(75, 30);
            this.btDongy.TabIndex = 19;
            this.btDongy.Text = "Đồng ý";
            this.btDongy.UseVisualStyleBackColor = true;
            this.btDongy.Click += new System.EventHandler(this.btDongy_Click);
            // 
            // txtmatkhau
            // 
            this.txtmatkhau.Location = new System.Drawing.Point(160, 89);
            this.txtmatkhau.Margin = new System.Windows.Forms.Padding(4);
            this.txtmatkhau.Name = "txtmatkhau";
            this.txtmatkhau.Size = new System.Drawing.Size(333, 22);
            this.txtmatkhau.TabIndex = 18;
            this.txtmatkhau.UseSystemPasswordChar = true;
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(160, 41);
            this.txtten.Margin = new System.Windows.Forms.Padding(4);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(333, 22);
            this.txtten.TabIndex = 17;
            // 
            // lblMatkhau
            // 
            this.lblMatkhau.AutoSize = true;
            this.lblMatkhau.Location = new System.Drawing.Point(32, 89);
            this.lblMatkhau.Name = "lblMatkhau";
            this.lblMatkhau.Size = new System.Drawing.Size(70, 17);
            this.lblMatkhau.TabIndex = 16;
            this.lblMatkhau.Text = "Mật khẩu:";
            // 
            // lblTenDN
            // 
            this.lblTenDN.AutoSize = true;
            this.lblTenDN.Location = new System.Drawing.Point(32, 41);
            this.lblTenDN.Name = "lblTenDN";
            this.lblTenDN.Size = new System.Drawing.Size(109, 17);
            this.lblTenDN.TabIndex = 15;
            this.lblTenDN.Text = "Tên đăng nhập:";
            // 
            // FormDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 199);
            this.Controls.Add(this.btBoqua);
            this.Controls.Add(this.btDongy);
            this.Controls.Add(this.txtmatkhau);
            this.Controls.Add(this.txtten);
            this.Controls.Add(this.lblMatkhau);
            this.Controls.Add(this.lblTenDN);
            this.Name = "FormDangNhap";
            this.Text = "FormDangNhap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btBoqua;
        private System.Windows.Forms.Button btDongy;
        private System.Windows.Forms.TextBox txtmatkhau;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.Label lblMatkhau;
        private System.Windows.Forms.Label lblTenDN;
    }
}