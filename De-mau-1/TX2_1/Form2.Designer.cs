
namespace TX2_1
{
    partial class Form2
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
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(254, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý nhân viên";
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "dd-MM-yyyy";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(254, 233);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(127, 27);
            this.dtpDate.TabIndex = 29;
            this.dtpDate.Value = new System.DateTime(2023, 8, 24, 0, 0, 0, 0);
            // 
            // radNu
            // 
            this.radNu.AutoSize = true;
            this.radNu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.radNu.Location = new System.Drawing.Point(466, 203);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(50, 24);
            this.radNu.TabIndex = 28;
            this.radNu.Text = "Nữ";
            this.radNu.UseVisualStyleBackColor = true;
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Checked = true;
            this.radNam.Location = new System.Drawing.Point(328, 203);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(62, 24);
            this.radNam.TabIndex = 27;
            this.radNam.TabStop = true;
            this.radNam.Text = "Nam";
            this.radNam.UseVisualStyleBackColor = true;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(254, 166);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(460, 27);
            this.txtHoTen.TabIndex = 26;
            // 
            // txtNgay
            // 
            this.txtNgay.Location = new System.Drawing.Point(254, 300);
            this.txtNgay.Name = "txtNgay";
            this.txtNgay.Size = new System.Drawing.Size(460, 27);
            this.txtNgay.TabIndex = 25;
            // 
            // txtLuong
            // 
            this.txtLuong.Location = new System.Drawing.Point(254, 266);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(460, 27);
            this.txtLuong.TabIndex = 24;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(254, 123);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(460, 27);
            this.txtMaNV.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(87, 303);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "Số ngày làm việc";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(87, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "Lương Ngày";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(87, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Ngày tháng năm sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Giới tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Họ tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Mã NV";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(324, 372);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(184, 35);
            this.btnExit.TabIndex = 30;
            this.btnExit.Text = "Đóng form";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form2
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
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.Button btnExit;
    }
}