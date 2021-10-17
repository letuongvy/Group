
namespace FormBasicTime
{
    partial class FrmTimer
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
            this.components = new System.ComponentModel.Container();
            this.lblgio = new System.Windows.Forms.Label();
            this.btnDung = new System.Windows.Forms.Button();
            this.btnBatdau = new System.Windows.Forms.Button();
            this.numTimer = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numTimer)).BeginInit();
            this.SuspendLayout();
            // 
            // lblgio
            // 
            this.lblgio.AutoSize = true;
            this.lblgio.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblgio.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgio.ForeColor = System.Drawing.Color.Red;
            this.lblgio.Location = new System.Drawing.Point(270, 11);
            this.lblgio.Name = "lblgio";
            this.lblgio.Size = new System.Drawing.Size(74, 36);
            this.lblgio.TabIndex = 15;
            this.lblgio.Text = "0:00";
            // 
            // btnDung
            // 
            this.btnDung.Location = new System.Drawing.Point(42, 82);
            this.btnDung.Name = "btnDung";
            this.btnDung.Size = new System.Drawing.Size(75, 23);
            this.btnDung.TabIndex = 14;
            this.btnDung.Text = "Dừng";
            this.btnDung.UseVisualStyleBackColor = true;
            this.btnDung.Click += new System.EventHandler(this.btnDung_Click);
            // 
            // btnBatdau
            // 
            this.btnBatdau.Location = new System.Drawing.Point(42, 53);
            this.btnBatdau.Name = "btnBatdau";
            this.btnBatdau.Size = new System.Drawing.Size(75, 23);
            this.btnBatdau.TabIndex = 13;
            this.btnBatdau.Text = "Bắt đầu";
            this.btnBatdau.UseVisualStyleBackColor = true;
            this.btnBatdau.Click += new System.EventHandler(this.btnBatdau_Click);
            // 
            // numTimer
            // 
            this.numTimer.Location = new System.Drawing.Point(127, 25);
            this.numTimer.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTimer.Name = "numTimer";
            this.numTimer.Size = new System.Drawing.Size(104, 22);
            this.numTimer.TabIndex = 12;
            this.numTimer.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTimer.ValueChanged += new System.EventHandler(this.numTimer_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Thoi gian(m)";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 278);
            this.Controls.Add(this.lblgio);
            this.Controls.Add(this.btnDung);
            this.Controls.Add(this.btnBatdau);
            this.Controls.Add(this.numTimer);
            this.Controls.Add(this.label1);
            this.Name = "FrmTimer";
            this.Text = "FrmTimer";
            this.Load += new System.EventHandler(this.FrmTimer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numTimer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblgio;
        private System.Windows.Forms.Button btnDung;
        private System.Windows.Forms.Button btnBatdau;
        private System.Windows.Forms.NumericUpDown numTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}