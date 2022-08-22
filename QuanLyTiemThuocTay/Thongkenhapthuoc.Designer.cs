namespace QuanLyTiemThuocTay
{
    partial class frmThongkenhapthuoc
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
            this.dgvBaocaonhapthuoc = new System.Windows.Forms.DataGridView();
            this.manhaphang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenthuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donvinhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giatriquydoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluongnhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gianhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaynhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hamluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hangsx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaocaonhapthuoc)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBaocaonhapthuoc
            // 
            this.dgvBaocaonhapthuoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBaocaonhapthuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBaocaonhapthuoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.manhaphang,
            this.tenthuoc,
            this.donvinhap,
            this.giatriquydoi,
            this.soluongnhap,
            this.gianhap,
            this.mota,
            this.ngaynhap,
            this.thanhtien,
            this.username,
            this.hamluong,
            this.hangsx});
            this.dgvBaocaonhapthuoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvBaocaonhapthuoc.Location = new System.Drawing.Point(0, 0);
            this.dgvBaocaonhapthuoc.Name = "dgvBaocaonhapthuoc";
            this.dgvBaocaonhapthuoc.RowHeadersWidth = 62;
            this.dgvBaocaonhapthuoc.RowTemplate.Height = 28;
            this.dgvBaocaonhapthuoc.Size = new System.Drawing.Size(800, 391);
            this.dgvBaocaonhapthuoc.TabIndex = 0;
            // 
            // manhaphang
            // 
            this.manhaphang.DataPropertyName = "manhaphang";
            this.manhaphang.HeaderText = "Mã nhập hàng";
            this.manhaphang.MinimumWidth = 8;
            this.manhaphang.Name = "manhaphang";
            // 
            // tenthuoc
            // 
            this.tenthuoc.DataPropertyName = "tenthuoc";
            this.tenthuoc.HeaderText = "Tên thuốc";
            this.tenthuoc.MinimumWidth = 8;
            this.tenthuoc.Name = "tenthuoc";
            // 
            // donvinhap
            // 
            this.donvinhap.DataPropertyName = "donvinhap";
            this.donvinhap.HeaderText = "Đơn vị nhập";
            this.donvinhap.MinimumWidth = 8;
            this.donvinhap.Name = "donvinhap";
            // 
            // giatriquydoi
            // 
            this.giatriquydoi.DataPropertyName = "giatriquydoi";
            this.giatriquydoi.HeaderText = "Giá trị quy đổi";
            this.giatriquydoi.MinimumWidth = 8;
            this.giatriquydoi.Name = "giatriquydoi";
            // 
            // soluongnhap
            // 
            this.soluongnhap.DataPropertyName = "soluongnhap";
            this.soluongnhap.HeaderText = "Số lượng nhập";
            this.soluongnhap.MinimumWidth = 8;
            this.soluongnhap.Name = "soluongnhap";
            // 
            // gianhap
            // 
            this.gianhap.DataPropertyName = "gianhap";
            this.gianhap.HeaderText = "Giá nhập";
            this.gianhap.MinimumWidth = 8;
            this.gianhap.Name = "gianhap";
            // 
            // mota
            // 
            this.mota.DataPropertyName = "mota";
            this.mota.HeaderText = "Mô tả";
            this.mota.MinimumWidth = 8;
            this.mota.Name = "mota";
            // 
            // ngaynhap
            // 
            this.ngaynhap.DataPropertyName = "ngaynhap";
            this.ngaynhap.HeaderText = "Ngày nhập";
            this.ngaynhap.MinimumWidth = 8;
            this.ngaynhap.Name = "ngaynhap";
            // 
            // thanhtien
            // 
            this.thanhtien.DataPropertyName = "thanhtien";
            this.thanhtien.HeaderText = "Thành tiền";
            this.thanhtien.MinimumWidth = 8;
            this.thanhtien.Name = "thanhtien";
            // 
            // username
            // 
            this.username.DataPropertyName = "username";
            this.username.HeaderText = "User name";
            this.username.MinimumWidth = 8;
            this.username.Name = "username";
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
            // btnThoat
            // 
            this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThoat.BackColor = System.Drawing.Color.Red;
            this.btnThoat.ForeColor = System.Drawing.Color.Black;
            this.btnThoat.Location = new System.Drawing.Point(704, 397);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 41);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmThongkenhapthuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.dgvBaocaonhapthuoc);
            this.Name = "frmThongkenhapthuoc";
            this.Text = "Báo cáo thống kê nhập thuốc";
            this.Load += new System.EventHandler(this.frmThongkenhapthuoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaocaonhapthuoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBaocaonhapthuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn manhaphang;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenthuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn donvinhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn giatriquydoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluongnhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn gianhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn mota;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaynhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhtien;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn hamluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn hangsx;
        private System.Windows.Forms.Button btnThoat;
    }
}