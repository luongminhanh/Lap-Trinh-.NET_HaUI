
namespace TX2_3_Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hIểnThịToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.listView1 = new System.Windows.Forms.ListView();
            this.colMaNV = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
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
            this.radNu = new System.Windows.Forms.RadioButton();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.menuStrip1.TabIndex = 33;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thoátToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // quảnLýNhânViênToolStripMenuItem
            // 
            this.quảnLýNhânViênToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmToolStripMenuItem,
            this.hIểnThịToolStripMenuItem,
            this.xóaToolStripMenuItem});
            this.quảnLýNhânViênToolStripMenuItem.Name = "quảnLýNhânViênToolStripMenuItem";
            this.quảnLýNhânViênToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.quảnLýNhânViênToolStripMenuItem.Text = "Quản lý nhân viên";
            // 
            // thêmToolStripMenuItem
            // 
            this.thêmToolStripMenuItem.Name = "thêmToolStripMenuItem";
            this.thêmToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.thêmToolStripMenuItem.Text = "Thêm";
            this.thêmToolStripMenuItem.Click += new System.EventHandler(this.thêmToolStripMenuItem_Click);
            // 
            // hIểnThịToolStripMenuItem
            // 
            this.hIểnThịToolStripMenuItem.Name = "hIểnThịToolStripMenuItem";
            this.hIểnThịToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.hIểnThịToolStripMenuItem.Text = "HIển Thị";
            this.hIểnThịToolStripMenuItem.Click += new System.EventHandler(this.hIểnThịToolStripMenuItem_Click);
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.xóaToolStripMenuItem.Text = "Xóa";
            this.xóaToolStripMenuItem.Click += new System.EventHandler(this.xóaToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(270, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 38);
            this.label1.TabIndex = 34;
            this.label1.Text = "Quản lý nhân viên";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Lương Ngày";
            this.columnHeader5.Width = 110;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaNV,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 300);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(776, 147);
            this.listView1.TabIndex = 35;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // colMaNV
            // 
            this.colMaNV.Text = "Mã NV";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Họ tên";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Giới tính";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ngày sinh";
            this.columnHeader4.Width = 80;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Số ngày làm";
            this.columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Tiền lương";
            this.columnHeader7.Width = 120;
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "dd-MM-yyyy";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(196, 188);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(127, 27);
            this.dtpDate.TabIndex = 48;
            this.dtpDate.Value = new System.DateTime(2023, 8, 24, 0, 0, 0, 0);
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Checked = true;
            this.radNam.Location = new System.Drawing.Point(270, 158);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(62, 24);
            this.radNam.TabIndex = 46;
            this.radNam.TabStop = true;
            this.radNam.Text = "Nam";
            this.radNam.UseVisualStyleBackColor = true;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(196, 121);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(460, 27);
            this.txtHoTen.TabIndex = 45;
            // 
            // txtNgay
            // 
            this.txtNgay.Location = new System.Drawing.Point(196, 255);
            this.txtNgay.Name = "txtNgay";
            this.txtNgay.Size = new System.Drawing.Size(460, 27);
            this.txtNgay.TabIndex = 44;
            // 
            // txtLuong
            // 
            this.txtLuong.Location = new System.Drawing.Point(196, 221);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(460, 27);
            this.txtLuong.TabIndex = 43;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(196, 78);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(460, 27);
            this.txtMaNV.TabIndex = 42;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 20);
            this.label7.TabIndex = 41;
            this.label7.Text = "Số ngày làm việc";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 20);
            this.label6.TabIndex = 40;
            this.label6.Text = "Lương Ngày";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 20);
            this.label5.TabIndex = 39;
            this.label5.Text = "Ngày tháng năm sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 38;
            this.label4.Text = "Giới tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 37;
            this.label3.Text = "Họ tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 36;
            this.label2.Text = "Mã NV";
            // 
            // radNu
            // 
            this.radNu.AutoSize = true;
            this.radNu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.radNu.Location = new System.Drawing.Point(408, 158);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(50, 24);
            this.radNu.TabIndex = 47;
            this.radNu.Text = "Nữ";
            this.radNu.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.dtpDate);
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
            this.Controls.Add(this.radNu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hIểnThịToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader colMaNV;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.DateTimePicker dtpDate;
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
        private System.Windows.Forms.RadioButton radNu;
    }
}

