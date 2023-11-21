
namespace TX2_9
{
    partial class TX2_9_Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.txtNgay = new System.Windows.Forms.TextBox();
            this.txtLuong = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(317, 362);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(243, 38);
            this.button1.TabIndex = 46;
            this.button1.Text = "Đóng form";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "dd-MM-yyyy";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(276, 214);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(124, 27);
            this.dtpDate.TabIndex = 45;
            // 
            // radNu
            // 
            this.radNu.AutoSize = true;
            this.radNu.Location = new System.Drawing.Point(407, 181);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(50, 24);
            this.radNu.TabIndex = 44;
            this.radNu.Text = "Nữ";
            this.radNu.UseVisualStyleBackColor = true;
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Checked = true;
            this.radNam.Location = new System.Drawing.Point(214, 184);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(62, 24);
            this.radNam.TabIndex = 43;
            this.radNam.TabStop = true;
            this.radNam.Text = "Nam";
            this.radNam.UseVisualStyleBackColor = true;
            // 
            // txtNgay
            // 
            this.txtNgay.Location = new System.Drawing.Point(208, 283);
            this.txtNgay.Name = "txtNgay";
            this.txtNgay.Size = new System.Drawing.Size(490, 27);
            this.txtNgay.TabIndex = 42;
            // 
            // txtLuong
            // 
            this.txtLuong.Location = new System.Drawing.Point(208, 247);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(490, 27);
            this.txtLuong.TabIndex = 41;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(208, 141);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(490, 27);
            this.txtHoTen.TabIndex = 40;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(208, 97);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(490, 27);
            this.txtMaNV.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(103, 290);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 20);
            this.label8.TabIndex = 38;
            this.label8.Text = "Số ngày làm";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(103, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 20);
            this.label7.TabIndex = 37;
            this.label7.Text = "Lương ngày";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(103, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 20);
            this.label6.TabIndex = 36;
            this.label6.Text = "Ngày tháng năm sinh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(103, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 35;
            this.label5.Text = "Giới tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 34;
            this.label4.Text = "Họ tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 33;
            this.label3.Text = "Mã NV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(311, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(304, 38);
            this.label2.TabIndex = 32;
            this.label2.Text = "QUẢN LÝ NHÂN VIÊN";
            // 
            // TX2_9_Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.radNu);
            this.Controls.Add(this.radNam);
            this.Controls.Add(this.txtNgay);
            this.Controls.Add(this.txtLuong);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "TX2_9_Form2";
            this.Text = "TX2_9_Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.RadioButton radNu;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.TextBox txtNgay;
        private System.Windows.Forms.TextBox txtLuong;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}