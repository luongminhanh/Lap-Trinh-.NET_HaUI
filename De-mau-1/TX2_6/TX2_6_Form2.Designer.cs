
namespace TX2_6
{
    partial class TX2_6_Form2
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
            this.btnExit = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtNgay = new System.Windows.Forms.TextBox();
            this.txtLuong = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(324, 375);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(184, 35);
            this.btnExit.TabIndex = 90;
            this.btnExit.Text = "Đóng form";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "dd-MM-yyyy";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(254, 236);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(127, 27);
            this.dtpDate.TabIndex = 89;
            this.dtpDate.Value = new System.DateTime(2023, 8, 24, 0, 0, 0, 0);
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // radNu
            // 
            this.radNu.AutoSize = true;
            this.radNu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.radNu.Location = new System.Drawing.Point(466, 206);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(50, 24);
            this.radNu.TabIndex = 88;
            this.radNu.Text = "Nữ";
            this.radNu.UseVisualStyleBackColor = true;
            this.radNu.CheckedChanged += new System.EventHandler(this.radNu_CheckedChanged);
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Checked = true;
            this.radNam.Location = new System.Drawing.Point(328, 206);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(62, 24);
            this.radNam.TabIndex = 87;
            this.radNam.TabStop = true;
            this.radNam.Text = "Nam";
            this.radNam.UseVisualStyleBackColor = true;
            this.radNam.CheckedChanged += new System.EventHandler(this.radNam_CheckedChanged);
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(254, 169);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(460, 27);
            this.txtHoTen.TabIndex = 86;
            this.txtHoTen.TextChanged += new System.EventHandler(this.txtHoTen_TextChanged);
            // 
            // txtNgay
            // 
            this.txtNgay.Location = new System.Drawing.Point(254, 303);
            this.txtNgay.Name = "txtNgay";
            this.txtNgay.Size = new System.Drawing.Size(460, 27);
            this.txtNgay.TabIndex = 85;
            this.txtNgay.TextChanged += new System.EventHandler(this.txtNgay_TextChanged);
            // 
            // txtLuong
            // 
            this.txtLuong.Location = new System.Drawing.Point(254, 269);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(460, 27);
            this.txtLuong.TabIndex = 84;
            this.txtLuong.TextChanged += new System.EventHandler(this.txtLuong_TextChanged);
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(254, 126);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(460, 27);
            this.txtMaNV.TabIndex = 83;
            this.txtMaNV.TextChanged += new System.EventHandler(this.txtMaNV_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(87, 306);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 20);
            this.label7.TabIndex = 82;
            this.label7.Text = "Số ngày làm việc";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(87, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 20);
            this.label6.TabIndex = 81;
            this.label6.Text = "Lương Ngày";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(87, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 20);
            this.label5.TabIndex = 80;
            this.label5.Text = "Ngày tháng năm sinh";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 79;
            this.label4.Text = "Giới tính";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 78;
            this.label3.Text = "Họ tên";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 77;
            this.label2.Text = "Mã NV";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(254, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 38);
            this.label1.TabIndex = 76;
            this.label1.Text = "Quản lý nhân viên";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TX2_6_Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.radNu);
            this.Controls.Add(this.radNam);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.txtNgay);
            this.Controls.Add(this.txtLuong);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TX2_6_Form2";
            this.Text = "TX2_6_Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.RadioButton radNu;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtNgay;
        private System.Windows.Forms.TextBox txtLuong;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}