
namespace TX2_9
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
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.txtNgay = new System.Windows.Forms.TextBox();
            this.txtLuong = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sửaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hiểnThịToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "dd-MM-yyyy";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(202, 202);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(124, 27);
            this.dtpDate.TabIndex = 33;
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Checked = true;
            this.radNam.Location = new System.Drawing.Point(140, 172);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(62, 24);
            this.radNam.TabIndex = 31;
            this.radNam.TabStop = true;
            this.radNam.Text = "Nam";
            this.radNam.UseVisualStyleBackColor = true;
            // 
            // txtNgay
            // 
            this.txtNgay.Location = new System.Drawing.Point(134, 271);
            this.txtNgay.Name = "txtNgay";
            this.txtNgay.Size = new System.Drawing.Size(490, 27);
            this.txtNgay.TabIndex = 30;
            // 
            // txtLuong
            // 
            this.txtLuong.Location = new System.Drawing.Point(134, 235);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(490, 27);
            this.txtLuong.TabIndex = 29;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(134, 129);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(490, 27);
            this.txtHoTen.TabIndex = 28;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(134, 85);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(490, 27);
            this.txtMaNV.TabIndex = 27;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Tiền lương";
            this.columnHeader7.Width = 110;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Số ngày làm";
            this.columnHeader6.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Lương ngày";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ngày sinh";
            this.columnHeader4.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Giới tính";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Họ tên";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã NV";
            // 
            // radNu
            // 
            this.radNu.AutoSize = true;
            this.radNu.Location = new System.Drawing.Point(333, 169);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(50, 24);
            this.radNu.TabIndex = 32;
            this.radNu.Text = "Nữ";
            this.radNu.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(31, 310);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(739, 129);
            this.listView1.TabIndex = 26;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 278);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 20);
            this.label8.TabIndex = 25;
            this.label8.Text = "Số ngày làm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Ngày tháng năm sinh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Giới tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Họ tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Mã NV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(237, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(304, 38);
            this.label2.TabIndex = 19;
            this.label2.Text = "QUẢN LÝ NHÂN VIÊN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 18;
            // 
            // sửaToolStripMenuItem
            // 
            this.sửaToolStripMenuItem.Name = "sửaToolStripMenuItem";
            this.sửaToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.sửaToolStripMenuItem.Text = "Sửa";
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.xóaToolStripMenuItem.Text = "Xóa";
            this.xóaToolStripMenuItem.Click += new System.EventHandler(this.xóaToolStripMenuItem_Click);
            // 
            // hiểnThịToolStripMenuItem
            // 
            this.hiểnThịToolStripMenuItem.Name = "hiểnThịToolStripMenuItem";
            this.hiểnThịToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.hiểnThịToolStripMenuItem.Text = "Hiển Thị";
            this.hiểnThịToolStripMenuItem.Click += new System.EventHandler(this.hiểnThịToolStripMenuItem_Click);
            // 
            // thêmToolStripMenuItem
            // 
            this.thêmToolStripMenuItem.Name = "thêmToolStripMenuItem";
            this.thêmToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.thêmToolStripMenuItem.Text = "Thêm";
            this.thêmToolStripMenuItem.Click += new System.EventHandler(this.thêmToolStripMenuItem_Click);
            // 
            // quảnLýNhânViênToolStripMenuItem
            // 
            this.quảnLýNhânViênToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmToolStripMenuItem,
            this.hiểnThịToolStripMenuItem,
            this.xóaToolStripMenuItem,
            this.sửaToolStripMenuItem});
            this.quảnLýNhânViênToolStripMenuItem.Name = "quảnLýNhânViênToolStripMenuItem";
            this.quảnLýNhânViênToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.quảnLýNhânViênToolStripMenuItem.Text = "Quản lý nhân viên";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thoátToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 20);
            this.label7.TabIndex = 24;
            this.label7.Text = "Lương ngày";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.quảnLýNhânViênToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.radNam);
            this.Controls.Add(this.txtNgay);
            this.Controls.Add(this.txtLuong);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.radNu);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.TextBox txtNgay;
        private System.Windows.Forms.TextBox txtLuong;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.RadioButton radNu;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem sửaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hiểnThịToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}

