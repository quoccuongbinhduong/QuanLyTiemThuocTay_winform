namespace QuanLyTiemThuocTay
{
    partial class frmQLNCC
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
            this.dgvNhaCC = new System.Windows.Forms.DataGridView();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLuunhap = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmTimkiem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiThem = new System.Windows.Forms.ToolStripMenuItem();
            this.mancc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhaCC)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvNhaCC
            // 
            this.dgvNhaCC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhaCC.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvNhaCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhaCC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mancc,
            this.TenNCC,
            this.LoaiNCC,
            this.MoTa});
            this.dgvNhaCC.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvNhaCC.Location = new System.Drawing.Point(0, 0);
            this.dgvNhaCC.Name = "dgvNhaCC";
            this.dgvNhaCC.RowHeadersWidth = 62;
            this.dgvNhaCC.RowTemplate.Height = 28;
            this.dgvNhaCC.Size = new System.Drawing.Size(1178, 607);
            this.dgvNhaCC.TabIndex = 0;
            this.dgvNhaCC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhaCC_CellClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThoat.BackColor = System.Drawing.Color.Red;
            this.btnThoat.ForeColor = System.Drawing.Color.Black;
            this.btnThoat.Location = new System.Drawing.Point(1025, 691);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 41);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            // 
            // btnLuunhap
            // 
            this.btnLuunhap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuunhap.BackColor = System.Drawing.Color.Yellow;
            this.btnLuunhap.Location = new System.Drawing.Point(903, 691);
            this.btnLuunhap.Name = "btnLuunhap";
            this.btnLuunhap.Size = new System.Drawing.Size(75, 41);
            this.btnLuunhap.TabIndex = 6;
            this.btnLuunhap.Text = "Lưu";
            this.btnLuunhap.UseVisualStyleBackColor = false;
            this.btnLuunhap.Click += new System.EventHandler(this.btnLuunhap_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmXoa,
            this.tsmTimkiem,
            this.tsmiThem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(157, 100);
            // 
            // tsmXoa
            // 
            this.tsmXoa.Name = "tsmXoa";
            this.tsmXoa.Size = new System.Drawing.Size(240, 32);
            this.tsmXoa.Text = "Xóa";
            this.tsmXoa.Click += new System.EventHandler(this.tsmXoa_Click);
            // 
            // tsmTimkiem
            // 
            this.tsmTimkiem.Name = "tsmTimkiem";
            this.tsmTimkiem.Size = new System.Drawing.Size(156, 32);
            this.tsmTimkiem.Text = "Tìm kiếm";
            // 
            // tsmiThem
            // 
            this.tsmiThem.Name = "tsmiThem";
            this.tsmiThem.Size = new System.Drawing.Size(240, 32);
            this.tsmiThem.Text = "Thêm";
            this.tsmiThem.Click += new System.EventHandler(this.tsmiThem_Click);
            // 
            // mancc
            // 
            this.mancc.DataPropertyName = "mancc";
            this.mancc.HeaderText = "MaNCC";
            this.mancc.MinimumWidth = 8;
            this.mancc.Name = "mancc";
            // 
            // TenNCC
            // 
            this.TenNCC.DataPropertyName = "tenncc";
            this.TenNCC.HeaderText = "Tên nhà cung cấp";
            this.TenNCC.MinimumWidth = 8;
            this.TenNCC.Name = "TenNCC";
            // 
            // LoaiNCC
            // 
            this.LoaiNCC.DataPropertyName = "loaincc";
            this.LoaiNCC.HeaderText = "Loại nhà cung cấp";
            this.LoaiNCC.MinimumWidth = 8;
            this.LoaiNCC.Name = "LoaiNCC";
            // 
            // MoTa
            // 
            this.MoTa.DataPropertyName = "mota";
            this.MoTa.HeaderText = "Mô tả";
            this.MoTa.MinimumWidth = 8;
            this.MoTa.Name = "MoTa";
            // 
            // frmQLNCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 744);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLuunhap);
            this.Controls.Add(this.dgvNhaCC);
            this.Name = "frmQLNCC";
            this.Text = "QLNCC";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmQLNCC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhaCC)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNhaCC;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLuunhap;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmXoa;
        private System.Windows.Forms.ToolStripMenuItem tsmTimkiem;
        private System.Windows.Forms.ToolStripMenuItem tsmiThem;
        private System.Windows.Forms.DataGridViewTextBoxColumn mancc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoTa;
    }
}