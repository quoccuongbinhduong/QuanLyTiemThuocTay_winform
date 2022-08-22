namespace QuanLyTiemThuocTay
{
    partial class frmThongkebanhang
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
            this.dgvThongkebanhang = new System.Windows.Forms.DataGridView();
            this.btnThoat = new System.Windows.Forms.Button();
            this.Mahd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giothanhtoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mathuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenthuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hamluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hangsx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.macthd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donvi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giabantheodonvi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongkebanhang)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvThongkebanhang
            // 
            this.dgvThongkebanhang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongkebanhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongkebanhang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Mahd,
            this.trangthai,
            this.username,
            this.giothanhtoan,
            this.mathuoc,
            this.tenthuoc,
            this.hamluong,
            this.hangsx,
            this.macthd,
            this.donvi,
            this.soluong,
            this.giabantheodonvi,
            this.thanhtien});
            this.dgvThongkebanhang.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvThongkebanhang.Location = new System.Drawing.Point(0, 0);
            this.dgvThongkebanhang.Name = "dgvThongkebanhang";
            this.dgvThongkebanhang.RowHeadersWidth = 62;
            this.dgvThongkebanhang.RowTemplate.Height = 28;
            this.dgvThongkebanhang.Size = new System.Drawing.Size(1285, 627);
            this.dgvThongkebanhang.TabIndex = 0;
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThoat.BackColor = System.Drawing.Color.Red;
            this.btnThoat.ForeColor = System.Drawing.Color.Black;
            this.btnThoat.Location = new System.Drawing.Point(1174, 633);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 41);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Mahd
            // 
            this.Mahd.DataPropertyName = "mahd";
            this.Mahd.HeaderText = "Mã hóa đơn";
            this.Mahd.MinimumWidth = 8;
            this.Mahd.Name = "Mahd";
            // 
            // trangthai
            // 
            this.trangthai.DataPropertyName = "trangthai";
            this.trangthai.HeaderText = "Trạng thái";
            this.trangthai.MinimumWidth = 8;
            this.trangthai.Name = "trangthai";
            // 
            // username
            // 
            this.username.DataPropertyName = "username";
            this.username.HeaderText = "User name";
            this.username.MinimumWidth = 8;
            this.username.Name = "username";
            // 
            // giothanhtoan
            // 
            this.giothanhtoan.DataPropertyName = "giothanhtoan";
            this.giothanhtoan.HeaderText = "Giờ thanh toán";
            this.giothanhtoan.MinimumWidth = 8;
            this.giothanhtoan.Name = "giothanhtoan";
            // 
            // mathuoc
            // 
            this.mathuoc.DataPropertyName = "mathuoc";
            this.mathuoc.HeaderText = "Mã thuốc";
            this.mathuoc.MinimumWidth = 8;
            this.mathuoc.Name = "mathuoc";
            // 
            // tenthuoc
            // 
            this.tenthuoc.DataPropertyName = "tenthuoc";
            this.tenthuoc.HeaderText = "Tên thuốc";
            this.tenthuoc.MinimumWidth = 8;
            this.tenthuoc.Name = "tenthuoc";
            // 
            // hamluong
            // 
            this.hamluong.DataPropertyName = "hamluong";
            this.hamluong.HeaderText = "Hàm lượng";
            this.hamluong.MinimumWidth = 8;
            this.hamluong.Name = "hamluong";
            // 
            // hangsx
            // 
            this.hangsx.DataPropertyName = "hangsx";
            this.hangsx.HeaderText = "Hãng sản xuất";
            this.hangsx.MinimumWidth = 8;
            this.hangsx.Name = "hangsx";
            // 
            // macthd
            // 
            this.macthd.DataPropertyName = "macthd";
            this.macthd.HeaderText = "Mã chi tiết hóa đơn";
            this.macthd.MinimumWidth = 8;
            this.macthd.Name = "macthd";
            // 
            // donvi
            // 
            this.donvi.DataPropertyName = "donvi";
            this.donvi.HeaderText = "Đơn vị";
            this.donvi.MinimumWidth = 8;
            this.donvi.Name = "donvi";
            // 
            // soluong
            // 
            this.soluong.DataPropertyName = "soluong";
            this.soluong.HeaderText = "Số lượng";
            this.soluong.MinimumWidth = 8;
            this.soluong.Name = "soluong";
            // 
            // giabantheodonvi
            // 
            this.giabantheodonvi.DataPropertyName = "giabantheodonvi";
            this.giabantheodonvi.HeaderText = "Giá bán theo đơn vị";
            this.giabantheodonvi.MinimumWidth = 8;
            this.giabantheodonvi.Name = "giabantheodonvi";
            // 
            // thanhtien
            // 
            this.thanhtien.DataPropertyName = "thanhtien";
            this.thanhtien.HeaderText = "Thành tiền";
            this.thanhtien.MinimumWidth = 8;
            this.thanhtien.Name = "thanhtien";
            // 
            // frmThongkebanhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 680);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.dgvThongkebanhang);
            this.Name = "frmThongkebanhang";
            this.Text = "Thongkebanhang";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Thongkebanhang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongkebanhang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvThongkebanhang;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mahd;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangthai;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn giothanhtoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn mathuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenthuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn hamluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn hangsx;
        private System.Windows.Forms.DataGridViewTextBoxColumn macthd;
        private System.Windows.Forms.DataGridViewTextBoxColumn donvi;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn giabantheodonvi;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhtien;
    }
}