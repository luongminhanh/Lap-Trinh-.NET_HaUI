
namespace TX2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lvNhanVien = new System.Windows.Forms.ListView();
            this.colMaNV = new System.Windows.Forms.ColumnHeader();
            this.colHoTen = new System.Windows.Forms.ColumnHeader();
            this.colGioiTinh = new System.Windows.Forms.ColumnHeader();
            this.colNgaySinh = new System.Windows.Forms.ColumnHeader();
            this.colLuongNgay = new System.Windows.Forms.ColumnHeader();
            this.colSoNgay = new System.Windows.Forms.ColumnHeader();
            this.colTienLuong = new System.Windows.Forms.ColumnHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQLNV = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hiểnThịToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtLuongNgay = new System.Windows.Forms.TextBox();
            this.txtSoNgay = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvNhanVien
            // 
            this.lvNhanVien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaNV,
            this.colHoTen,
            this.colGioiTinh,
            this.colNgaySinh,
            this.colLuongNgay,
            this.colSoNgay,
            this.colTienLuong});
            this.lvNhanVien.HideSelection = false;
            this.lvNhanVien.Location = new System.Drawing.Point(26, 280);
            this.lvNhanVien.Name = "lvNhanVien";
            this.lvNhanVien.Size = new System.Drawing.Size(743, 125);
            this.lvNhanVien.TabIndex = 1;
            this.lvNhanVien.UseCompatibleStateImageBehavior = false;
            this.lvNhanVien.View = System.Windows.Forms.View.Details;
            this.lvNhanVien.SelectedIndexChanged += new System.EventHandler(this.lvNhanVien_SelectedIndexChanged);
            // 
            // colMaNV
            // 
            this.colMaNV.Text = "Mã NV";
            // 
            // colHoTen
            // 
            this.colHoTen.Text = "Họ tên";
            this.colHoTen.Width = 150;
            // 
            // colGioiTinh
            // 
            this.colGioiTinh.Text = "Giới tính";
            this.colGioiTinh.Width = 70;
            // 
            // colNgaySinh
            // 
            this.colNgaySinh.Text = "Ngày sinh";
            this.colNgaySinh.Width = 80;
            // 
            // colLuongNgay
            // 
            this.colLuongNgay.Text = "Lương Ngày";
            this.colLuongNgay.Width = 100;
            // 
            // colSoNgay
            // 
            this.colSoNgay.Text = "Số ngày làm việc";
            this.colSoNgay.Width = 140;
            // 
            // colTienLuong
            // 
            this.colTienLuong.Text = "Tiền Lương";
            this.colTienLuong.Width = 120;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(310, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quản lý nhân viên";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHeThong,
            this.menuQLNV});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuHeThong
            // 
            this.menuHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thoátToolStripMenuItem});
            this.menuHeThong.Name = "menuHeThong";
            this.menuHeThong.Size = new System.Drawing.Size(85, 24);
            this.menuHeThong.Text = "Hệ thống";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(130, 26);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // menuQLNV
            // 
            this.menuQLNV.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmToolStripMenuItem,
            this.hiểnThịToolStripMenuItem,
            this.xóaToolStripMenuItem});
            this.menuQLNV.Name = "menuQLNV";
            this.menuQLNV.Size = new System.Drawing.Size(140, 24);
            this.menuQLNV.Text = "Quản lý nhân viên";
            // 
            // thêmToolStripMenuItem
            // 
            this.thêmToolStripMenuItem.Name = "thêmToolStripMenuItem";
            this.thêmToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.thêmToolStripMenuItem.Text = "Thêm";
            this.thêmToolStripMenuItem.Click += new System.EventHandler(this.thêmToolStripMenuItem_Click);
            // 
            // hiểnThịToolStripMenuItem
            // 
            this.hiểnThịToolStripMenuItem.Name = "hiểnThịToolStripMenuItem";
            this.hiểnThịToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.hiểnThịToolStripMenuItem.Text = "Hiển thị";
            this.hiểnThịToolStripMenuItem.Click += new System.EventHandler(this.hiểnThịToolStripMenuItem_Click);
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.xóaToolStripMenuItem.Text = "Xóa";
            this.xóaToolStripMenuItem.Click += new System.EventHandler(this.xóaToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mã NV";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(236, 64);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(444, 27);
            this.txtMaNV.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Họ tên";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(236, 106);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(444, 27);
            this.txtHoTen.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Giới tính";
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Checked = true;
            this.radNam.Location = new System.Drawing.Point(252, 149);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(62, 24);
            this.radNam.TabIndex = 9;
            this.radNam.TabStop = true;
            this.radNam.Text = "Nam";
            this.radNam.UseVisualStyleBackColor = true;
            this.radNam.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radNu
            // 
            this.radNu.AutoSize = true;
            this.radNu.Location = new System.Drawing.Point(465, 148);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(50, 24);
            this.radNu.TabIndex = 10;
            this.radNu.Text = "Nữ";
            this.radNu.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Ngày tháng năm sinh";
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "dd-MM-yyyy";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(236, 180);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(161, 27);
            this.dtpDate.TabIndex = 13;
            this.dtpDate.Value = new System.DateTime(2023, 8, 17, 9, 4, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(244, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 20);
            this.label7.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(50, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Lương ngày";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(47, 249);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Số ngày làm việc";
            // 
            // txtLuongNgay
            // 
            this.txtLuongNgay.Location = new System.Drawing.Point(236, 215);
            this.txtLuongNgay.Name = "txtLuongNgay";
            this.txtLuongNgay.Size = new System.Drawing.Size(444, 27);
            this.txtLuongNgay.TabIndex = 17;
            // 
            // txtSoNgay
            // 
            this.txtSoNgay.Location = new System.Drawing.Point(236, 248);
            this.txtSoNgay.Name = "txtSoNgay";
            this.txtSoNgay.Size = new System.Drawing.Size(444, 27);
            this.txtSoNgay.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSoNgay);
            this.Controls.Add(this.txtLuongNgay);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.radNu);
            this.Controls.Add(this.radNam);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvNhanVien);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView lvNhanVien;
        private System.Windows.Forms.ColumnHeader colMaNV;
        private System.Windows.Forms.ColumnHeader colHoTen;
        private System.Windows.Forms.ColumnHeader colGioiTinh;
        private System.Windows.Forms.ColumnHeader colNgaySinh;
        private System.Windows.Forms.ColumnHeader colLuongNgay;
        private System.Windows.Forms.ColumnHeader colSoNgay;
        private System.Windows.Forms.ColumnHeader colTienLuong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuHeThong;
        private System.Windows.Forms.ToolStripMenuItem menuQLNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.RadioButton radNu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtLuongNgay;
        private System.Windows.Forms.TextBox txtSoNgay;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hiểnThịToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
    }
}

