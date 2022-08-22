namespace QuanLyTiemThuocTay
{
    partial class frmBanThuoc
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
            this.dgvBanthuoc = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grpDonvi = new System.Windows.Forms.GroupBox();
            this.cckDonviban = new System.Windows.Forms.CheckBox();
            this.cckDonvicoban = new System.Windows.Forms.CheckBox();
            this.cbChonthuoc = new System.Windows.Forms.ComboBox();
            this.txtSoluong = new System.Windows.Forms.TextBox();
            this.txtThanhtien = new System.Windows.Forms.TextBox();
            this.txtSoluongton = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGiaban = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnInhoadon = new System.Windows.Forms.Button();
            this.btnThanhtoan = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtTongthanhtien = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.MaThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HangSanXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HamLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonVi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBanthuoc)).BeginInit();
            this.panel1.SuspendLayout();
            this.grpDonvi.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBanthuoc
            // 
            this.dgvBanthuoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvBanthuoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBanthuoc.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvBanthuoc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBanthuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBanthuoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaThuoc,
            this.TenThuoc,
            this.HangSanXuat,
            this.HamLuong,
            this.GiaBan,
            this.SoLuong,
            this.DonVi,
            this.ThanhTien});
            this.dgvBanthuoc.Location = new System.Drawing.Point(24, 212);
            this.dgvBanthuoc.Name = "dgvBanthuoc";
            this.dgvBanthuoc.RowHeadersWidth = 62;
            this.dgvBanthuoc.RowTemplate.Height = 28;
            this.dgvBanthuoc.Size = new System.Drawing.Size(1178, 520);
            this.dgvBanthuoc.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.grpDonvi);
            this.panel1.Controls.Add(this.cbChonthuoc);
            this.panel1.Controls.Add(this.txtSoluong);
            this.panel1.Controls.Add(this.txtThanhtien);
            this.panel1.Controls.Add(this.txtSoluongton);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtGiaban);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(25, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1179, 206);
            this.panel1.TabIndex = 9;
            // 
            // grpDonvi
            // 
            this.grpDonvi.Controls.Add(this.cckDonviban);
            this.grpDonvi.Controls.Add(this.cckDonvicoban);
            this.grpDonvi.Location = new System.Drawing.Point(453, 38);
            this.grpDonvi.Name = "grpDonvi";
            this.grpDonvi.Size = new System.Drawing.Size(322, 62);
            this.grpDonvi.TabIndex = 15;
            this.grpDonvi.TabStop = false;
            this.grpDonvi.Text = "Đơn vị";
            // 
            // cckDonviban
            // 
            this.cckDonviban.AutoSize = true;
            this.cckDonviban.Location = new System.Drawing.Point(177, 25);
            this.cckDonviban.Name = "cckDonviban";
            this.cckDonviban.Size = new System.Drawing.Size(110, 24);
            this.cckDonviban.TabIndex = 2;
            this.cckDonviban.Text = "Đơn vị bán";
            this.cckDonviban.UseVisualStyleBackColor = true;
            // 
            // cckDonvicoban
            // 
            this.cckDonvicoban.AutoSize = true;
            this.cckDonvicoban.Location = new System.Drawing.Point(20, 25);
            this.cckDonvicoban.Name = "cckDonvicoban";
            this.cckDonvicoban.Size = new System.Drawing.Size(131, 24);
            this.cckDonvicoban.TabIndex = 1;
            this.cckDonvicoban.Text = "Đơn vị cơ bản";
            this.cckDonvicoban.UseVisualStyleBackColor = true;
            // 
            // cbChonthuoc
            // 
            this.cbChonthuoc.DisplayMember = "tenthuoc";
            this.cbChonthuoc.FormattingEnabled = true;
            this.cbChonthuoc.Location = new System.Drawing.Point(18, 63);
            this.cbChonthuoc.Name = "cbChonthuoc";
            this.cbChonthuoc.Size = new System.Drawing.Size(347, 28);
            this.cbChonthuoc.TabIndex = 5;
            this.cbChonthuoc.ValueMember = "mathuoc";
            this.cbChonthuoc.SelectedIndexChanged += new System.EventHandler(this.cbChonthuoc_SelectedIndexChanged);
            // 
            // txtSoluong
            // 
            this.txtSoluong.Location = new System.Drawing.Point(817, 65);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(347, 26);
            this.txtSoluong.TabIndex = 11;
            this.txtSoluong.TextChanged += new System.EventHandler(this.txtSoluong_TextChanged);
            // 
            // txtThanhtien
            // 
            this.txtThanhtien.Location = new System.Drawing.Point(817, 151);
            this.txtThanhtien.Name = "txtThanhtien";
            this.txtThanhtien.Size = new System.Drawing.Size(347, 26);
            this.txtThanhtien.TabIndex = 11;
            // 
            // txtSoluongton
            // 
            this.txtSoluongton.Location = new System.Drawing.Point(453, 151);
            this.txtSoluongton.Name = "txtSoluongton";
            this.txtSoluongton.ReadOnly = true;
            this.txtSoluongton.Size = new System.Drawing.Size(322, 26);
            this.txtSoluongton.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.Location = new System.Drawing.Point(449, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Số lượng tồn";
            // 
            // txtGiaban
            // 
            this.txtGiaban.Location = new System.Drawing.Point(18, 153);
            this.txtGiaban.Name = "txtGiaban";
            this.txtGiaban.ReadOnly = true;
            this.txtGiaban.Size = new System.Drawing.Size(347, 26);
            this.txtGiaban.TabIndex = 13;
            this.txtGiaban.TextChanged += new System.EventHandler(this.txtGiaban_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(14, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Giá bán";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label5.Location = new System.Drawing.Point(813, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Thành tiền";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label4.Location = new System.Drawing.Point(813, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Số lượng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.Location = new System.Drawing.Point(14, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Chọn thuốc";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnInhoadon);
            this.panel2.Controls.Add(this.btnThanhtoan);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Controls.Add(this.txtTongthanhtien);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 738);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1226, 71);
            this.panel2.TabIndex = 10;
            // 
            // btnInhoadon
            // 
            this.btnInhoadon.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnInhoadon.Location = new System.Drawing.Point(1062, 21);
            this.btnInhoadon.Name = "btnInhoadon";
            this.btnInhoadon.Size = new System.Drawing.Size(107, 39);
            this.btnInhoadon.TabIndex = 13;
            this.btnInhoadon.Text = "In hóa đơn";
            this.btnInhoadon.UseVisualStyleBackColor = true;
            // 
            // btnThanhtoan
            // 
            this.btnThanhtoan.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnThanhtoan.Location = new System.Drawing.Point(918, 21);
            this.btnThanhtoan.Name = "btnThanhtoan";
            this.btnThanhtoan.Size = new System.Drawing.Size(106, 39);
            this.btnThanhtoan.TabIndex = 12;
            this.btnThanhtoan.Text = "Thanh toán";
            this.btnThanhtoan.UseVisualStyleBackColor = true;
            this.btnThanhtoan.Click += new System.EventHandler(this.btnThanhtoan_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnThem.Location = new System.Drawing.Point(795, 21);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 39);
            this.btnThem.TabIndex = 11;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtTongthanhtien
            // 
            this.txtTongthanhtien.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtTongthanhtien.Location = new System.Drawing.Point(61, 34);
            this.txtTongthanhtien.Name = "txtTongthanhtien";
            this.txtTongthanhtien.ReadOnly = true;
            this.txtTongthanhtien.Size = new System.Drawing.Size(347, 26);
            this.txtTongthanhtien.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label6.Location = new System.Drawing.Point(57, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Tổng thành tiền";
            // 
            // MaThuoc
            // 
            this.MaThuoc.DataPropertyName = "mathuoc";
            this.MaThuoc.HeaderText = "Mã thuốc";
            this.MaThuoc.MinimumWidth = 8;
            this.MaThuoc.Name = "MaThuoc";
            // 
            // TenThuoc
            // 
            this.TenThuoc.DataPropertyName = "tenthuoc";
            this.TenThuoc.HeaderText = "Tên thuốc";
            this.TenThuoc.MinimumWidth = 8;
            this.TenThuoc.Name = "TenThuoc";
            // 
            // HangSanXuat
            // 
            this.HangSanXuat.DataPropertyName = "hangsx";
            this.HangSanXuat.HeaderText = "Hãng sản xuất";
            this.HangSanXuat.MinimumWidth = 8;
            this.HangSanXuat.Name = "HangSanXuat";
            // 
            // HamLuong
            // 
            this.HamLuong.DataPropertyName = "hamluong";
            this.HamLuong.HeaderText = "Hàm lượng";
            this.HamLuong.MinimumWidth = 8;
            this.HamLuong.Name = "HamLuong";
            // 
            // GiaBan
            // 
            this.GiaBan.DataPropertyName = "giabantheodonvi";
            this.GiaBan.HeaderText = "Giá bán";
            this.GiaBan.MinimumWidth = 8;
            this.GiaBan.Name = "GiaBan";
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "soluong";
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.MinimumWidth = 8;
            this.SoLuong.Name = "SoLuong";
            // 
            // DonVi
            // 
            this.DonVi.DataPropertyName = "donvi";
            this.DonVi.HeaderText = "Đơn vị";
            this.DonVi.MinimumWidth = 8;
            this.DonVi.Name = "DonVi";
            // 
            // ThanhTien
            // 
            this.ThanhTien.DataPropertyName = "thanhtien";
            this.ThanhTien.HeaderText = "Thành tiền";
            this.ThanhTien.MinimumWidth = 8;
            this.ThanhTien.Name = "ThanhTien";
            // 
            // frmBanThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 809);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvBanthuoc);
            this.Name = "frmBanThuoc";
            this.Text = "BanHang";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmBanThuoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBanthuoc)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpDonvi.ResumeLayout(false);
            this.grpDonvi.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvBanthuoc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grpDonvi;
        private System.Windows.Forms.CheckBox cckDonviban;
        private System.Windows.Forms.CheckBox cckDonvicoban;
        private System.Windows.Forms.ComboBox cbChonthuoc;
        private System.Windows.Forms.TextBox txtThanhtien;
        private System.Windows.Forms.TextBox txtSoluongton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGiaban;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnInhoadon;
        private System.Windows.Forms.Button btnThanhtoan;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtTongthanhtien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSoluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn HangSanXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn HamLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonVi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
    }
}