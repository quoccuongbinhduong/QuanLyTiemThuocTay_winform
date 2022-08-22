namespace QuanLyTiemThuocTay
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tbMain = new System.Windows.Forms.TabControl();
            this.tpQuanly = new System.Windows.Forms.TabPage();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsNhanvien = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsNhacungcap = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tsLoaithuoc = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.tsThuoc = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBaocaothongkebanhang = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbBaocaonhapthuoc = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsNhapthuoc = new System.Windows.Forms.ToolStripButton();
            this.tbBanhang = new System.Windows.Forms.TabPage();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tsBanthuoc = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsThongtinthuoc = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsTaikhoan = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tspDangxuat = new System.Windows.Forms.ToolStripButton();
            this.miniToolStrip = new System.Windows.Forms.ToolStrip();
            this.tbMain2 = new System.Windows.Forms.TabControl();
            this.timerStatus = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslUsername = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslStatus = new System.Windows.Forms.ToolStripProgressBar();
            this.timerDateTime = new System.Windows.Forms.Timer(this.components);
            this.tbMain.SuspendLayout();
            this.tpQuanly.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tbBanhang.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbMain
            // 
            this.tbMain.Controls.Add(this.tpQuanly);
            this.tbMain.Controls.Add(this.tbBanhang);
            this.tbMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbMain.Location = new System.Drawing.Point(0, 0);
            this.tbMain.Name = "tbMain";
            this.tbMain.Padding = new System.Drawing.Point(8, 5);
            this.tbMain.SelectedIndex = 0;
            this.tbMain.Size = new System.Drawing.Size(1378, 120);
            this.tbMain.TabIndex = 0;
            // 
            // tpQuanly
            // 
            this.tpQuanly.Controls.Add(this.toolStrip1);
            this.tpQuanly.Cursor = System.Windows.Forms.Cursors.Default;
            this.tpQuanly.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpQuanly.Location = new System.Drawing.Point(4, 33);
            this.tpQuanly.Name = "tpQuanly";
            this.tpQuanly.Padding = new System.Windows.Forms.Padding(3);
            this.tpQuanly.Size = new System.Drawing.Size(1370, 83);
            this.tpQuanly.TabIndex = 0;
            this.tpQuanly.Text = "Quản lý";
            this.tpQuanly.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsNhanvien,
            this.toolStripSeparator5,
            this.tsNhacungcap,
            this.toolStripSeparator6,
            this.tsLoaithuoc,
            this.toolStripSeparator8,
            this.tsThuoc,
            this.toolStripSeparator9,
            this.tsBaocaothongkebanhang,
            this.toolStripSeparator7,
            this.tsbBaocaonhapthuoc,
            this.toolStripSeparator1,
            this.tsNhapthuoc});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1364, 49);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsNhanvien
            // 
            this.tsNhanvien.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.tsNhanvien.Image = ((System.Drawing.Image)(resources.GetObject("tsNhanvien.Image")));
            this.tsNhanvien.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsNhanvien.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.tsNhanvien.Name = "tsNhanvien";
            this.tsNhanvien.Size = new System.Drawing.Size(119, 29);
            this.tsNhanvien.Text = "Nhân viên";
            this.tsNhanvien.Click += new System.EventHandler(this.tsNhanvien_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 49);
            // 
            // tsNhacungcap
            // 
            this.tsNhacungcap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tsNhacungcap.Image = ((System.Drawing.Image)(resources.GetObject("tsNhacungcap.Image")));
            this.tsNhacungcap.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsNhacungcap.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.tsNhacungcap.Name = "tsNhacungcap";
            this.tsNhacungcap.Size = new System.Drawing.Size(149, 29);
            this.tsNhacungcap.Text = "Nhà cung cấp";
            this.tsNhacungcap.Click += new System.EventHandler(this.tsNhacungcap_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 49);
            // 
            // tsLoaithuoc
            // 
            this.tsLoaithuoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tsLoaithuoc.Image = ((System.Drawing.Image)(resources.GetObject("tsLoaithuoc.Image")));
            this.tsLoaithuoc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsLoaithuoc.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.tsLoaithuoc.Name = "tsLoaithuoc";
            this.tsLoaithuoc.Size = new System.Drawing.Size(122, 29);
            this.tsLoaithuoc.Text = "Loại thuốc";
            this.tsLoaithuoc.Click += new System.EventHandler(this.tsLoaithuoc_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 49);
            // 
            // tsThuoc
            // 
            this.tsThuoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tsThuoc.Image = ((System.Drawing.Image)(resources.GetObject("tsThuoc.Image")));
            this.tsThuoc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsThuoc.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.tsThuoc.Name = "tsThuoc";
            this.tsThuoc.Size = new System.Drawing.Size(88, 29);
            this.tsThuoc.Text = "Thuốc";
            this.tsThuoc.Click += new System.EventHandler(this.tsThuoc_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 49);
            // 
            // tsBaocaothongkebanhang
            // 
            this.tsBaocaothongkebanhang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tsBaocaothongkebanhang.Image = ((System.Drawing.Image)(resources.GetObject("tsBaocaothongkebanhang.Image")));
            this.tsBaocaothongkebanhang.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBaocaothongkebanhang.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.tsBaocaothongkebanhang.Name = "tsBaocaothongkebanhang";
            this.tsBaocaothongkebanhang.Size = new System.Drawing.Size(183, 29);
            this.tsBaocaothongkebanhang.Text = "Báo cáo bán hàng";
            this.tsBaocaothongkebanhang.Click += new System.EventHandler(this.tsBaocaothongkebanhang_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 49);
            // 
            // tsbBaocaonhapthuoc
            // 
            this.tsbBaocaonhapthuoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tsbBaocaonhapthuoc.Image = ((System.Drawing.Image)(resources.GetObject("tsbBaocaonhapthuoc.Image")));
            this.tsbBaocaonhapthuoc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBaocaonhapthuoc.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.tsbBaocaonhapthuoc.Name = "tsbBaocaonhapthuoc";
            this.tsbBaocaonhapthuoc.Size = new System.Drawing.Size(198, 29);
            this.tsbBaocaonhapthuoc.Text = "Báo cáo nhập thuốc";
            this.tsbBaocaonhapthuoc.Click += new System.EventHandler(this.tsbBaocaonhapthuoc_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 49);
            // 
            // tsNhapthuoc
            // 
            this.tsNhapthuoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tsNhapthuoc.Image = ((System.Drawing.Image)(resources.GetObject("tsNhapthuoc.Image")));
            this.tsNhapthuoc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsNhapthuoc.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.tsNhapthuoc.Name = "tsNhapthuoc";
            this.tsNhapthuoc.Size = new System.Drawing.Size(133, 29);
            this.tsNhapthuoc.Text = "Nhập thuốc";
            this.tsNhapthuoc.Click += new System.EventHandler(this.tsNhapthuoc_Click);
            // 
            // tbBanhang
            // 
            this.tbBanhang.Controls.Add(this.toolStrip2);
            this.tbBanhang.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbBanhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBanhang.Location = new System.Drawing.Point(4, 33);
            this.tbBanhang.Name = "tbBanhang";
            this.tbBanhang.Padding = new System.Windows.Forms.Padding(3);
            this.tbBanhang.Size = new System.Drawing.Size(1370, 83);
            this.tbBanhang.TabIndex = 1;
            this.tbBanhang.Text = "Bán hàng";
            this.tbBanhang.UseVisualStyleBackColor = true;
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBanthuoc,
            this.toolStripSeparator2,
            this.tsThongtinthuoc,
            this.toolStripSeparator3,
            this.tsTaikhoan,
            this.toolStripSeparator4,
            this.tspDangxuat});
            this.toolStrip2.Location = new System.Drawing.Point(3, 3);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1364, 49);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "Bán thuốc";
            // 
            // tsBanthuoc
            // 
            this.tsBanthuoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.tsBanthuoc.Image = ((System.Drawing.Image)(resources.GetObject("tsBanthuoc.Image")));
            this.tsBanthuoc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBanthuoc.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.tsBanthuoc.Name = "tsBanthuoc";
            this.tsBanthuoc.Size = new System.Drawing.Size(119, 29);
            this.tsBanthuoc.Text = "Bán thuốc";
            this.tsBanthuoc.Click += new System.EventHandler(this.tsBanthuoc_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 49);
            // 
            // tsThongtinthuoc
            // 
            this.tsThongtinthuoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tsThongtinthuoc.Image = ((System.Drawing.Image)(resources.GetObject("tsThongtinthuoc.Image")));
            this.tsThongtinthuoc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsThongtinthuoc.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.tsThongtinthuoc.Name = "tsThongtinthuoc";
            this.tsThongtinthuoc.Size = new System.Drawing.Size(166, 29);
            this.tsThongtinthuoc.Text = "Thông tin thuốc";
            this.tsThongtinthuoc.Click += new System.EventHandler(this.tsThongtinthuoc_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 49);
            // 
            // tsTaikhoan
            // 
            this.tsTaikhoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tsTaikhoan.Image = ((System.Drawing.Image)(resources.GetObject("tsTaikhoan.Image")));
            this.tsTaikhoan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsTaikhoan.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.tsTaikhoan.Name = "tsTaikhoan";
            this.tsTaikhoan.Size = new System.Drawing.Size(114, 29);
            this.tsTaikhoan.Text = "Tài khoản";
            this.tsTaikhoan.Click += new System.EventHandler(this.tsTaikhoan_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 49);
            // 
            // tspDangxuat
            // 
            this.tspDangxuat.BackColor = System.Drawing.Color.Red;
            this.tspDangxuat.Image = ((System.Drawing.Image)(resources.GetObject("tspDangxuat.Image")));
            this.tspDangxuat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tspDangxuat.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.tspDangxuat.Name = "tspDangxuat";
            this.tspDangxuat.Size = new System.Drawing.Size(121, 29);
            this.tspDangxuat.Text = "Đăng xuất";
            this.tspDangxuat.Click += new System.EventHandler(this.tspDangxuat_Click);
            // 
            // miniToolStrip
            // 
            this.miniToolStrip.AccessibleName = "New item selection";
            this.miniToolStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDown;
            this.miniToolStrip.AutoSize = false;
            this.miniToolStrip.CanOverflow = false;
            this.miniToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.miniToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.miniToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.miniToolStrip.Location = new System.Drawing.Point(701, 10);
            this.miniToolStrip.Name = "miniToolStrip";
            this.miniToolStrip.Size = new System.Drawing.Size(1350, 49);
            this.miniToolStrip.TabIndex = 0;
            // 
            // tbMain2
            // 
            this.tbMain2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbMain2.Location = new System.Drawing.Point(0, 120);
            this.tbMain2.Name = "tbMain2";
            this.tbMain2.SelectedIndex = 0;
            this.tbMain2.Size = new System.Drawing.Size(1378, 37);
            this.tbMain2.TabIndex = 4;
            // 
            // timerStatus
            // 
            this.timerStatus.Tick += new System.EventHandler(this.timerStatus_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslUsername,
            this.tsslTime,
            this.tsslStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 811);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1378, 33);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslUsername
            // 
            this.tsslUsername.Name = "tsslUsername";
            this.tsslUsername.Size = new System.Drawing.Size(179, 26);
            this.tsslUsername.Text = "toolStripStatusLabel1";
            // 
            // tsslTime
            // 
            this.tsslTime.Name = "tsslTime";
            this.tsslTime.Size = new System.Drawing.Size(179, 26);
            this.tsslTime.Text = "toolStripStatusLabel3";
            // 
            // tsslStatus
            // 
            this.tsslStatus.Name = "tsslStatus";
            this.tsslStatus.Size = new System.Drawing.Size(179, 25);
            // 
            // timerDateTime
            // 
            this.timerDateTime.Tick += new System.EventHandler(this.timerDateTime_Tick_1);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1378, 844);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tbMain2);
            this.Controls.Add(this.tbMain);
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý tiệm thuốc tây";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tbMain.ResumeLayout(false);
            this.tpQuanly.ResumeLayout(false);
            this.tpQuanly.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tbBanhang.ResumeLayout(false);
            this.tbBanhang.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tbMain;
        private System.Windows.Forms.TabPage tpQuanly;
        private System.Windows.Forms.TabPage tbBanhang;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton tsBanthuoc;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsThongtinthuoc;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsTaikhoan;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tspDangxuat;
        private System.Windows.Forms.ToolStrip miniToolStrip;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsNhanvien;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton tsNhacungcap;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton tsLoaithuoc;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton tsThuoc;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripButton tsBaocaothongkebanhang;
        private System.Windows.Forms.TabControl tbMain2;
        private System.Windows.Forms.Timer timerStatus;
        private System.Windows.Forms.ToolStripButton tsNhapthuoc;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Timer timerDateTime;
        private System.Windows.Forms.ToolStripStatusLabel tsslTime;
        private System.Windows.Forms.ToolStripStatusLabel tsslUsername;
        private System.Windows.Forms.ToolStripProgressBar tsslStatus;
        private System.Windows.Forms.ToolStripButton tsbBaocaonhapthuoc;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

