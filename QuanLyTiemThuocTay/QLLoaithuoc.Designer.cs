namespace QuanLyTiemThuocTay
{
    partial class frmQLLoaiThuoc
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiThem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmKiếmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvLoaithuoc = new System.Windows.Forms.DataGridView();
            this.malt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenloaithuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLuunhap = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaithuoc)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiThem,
            this.tsmiXoa,
            this.tìmKiếmToolStripMenuItem,
            this.reToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(158, 132);
            // 
            // tsmiThem
            // 
            this.tsmiThem.Name = "tsmiThem";
            this.tsmiThem.Size = new System.Drawing.Size(240, 32);
            this.tsmiThem.Text = "Thêm";
            this.tsmiThem.Click += new System.EventHandler(this.tsmiThem_Click);
            // 
            // tsmiXoa
            // 
            this.tsmiXoa.Name = "tsmiXoa";
            this.tsmiXoa.Size = new System.Drawing.Size(240, 32);
            this.tsmiXoa.Text = "Xóa";
            this.tsmiXoa.Click += new System.EventHandler(this.tsmiXoa_Click);
            // 
            // tìmKiếmToolStripMenuItem
            // 
            this.tìmKiếmToolStripMenuItem.Name = "tìmKiếmToolStripMenuItem";
            this.tìmKiếmToolStripMenuItem.Size = new System.Drawing.Size(240, 32);
            this.tìmKiếmToolStripMenuItem.Text = "Tìm Kiếm";
            // 
            // reToolStripMenuItem
            // 
            this.reToolStripMenuItem.Name = "reToolStripMenuItem";
            this.reToolStripMenuItem.Size = new System.Drawing.Size(240, 32);
            this.reToolStripMenuItem.Text = "Re";
            // 
            // dgvLoaithuoc
            // 
            this.dgvLoaithuoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLoaithuoc.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvLoaithuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaithuoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.malt,
            this.tenloaithuoc,
            this.mota});
            this.dgvLoaithuoc.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvLoaithuoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvLoaithuoc.Location = new System.Drawing.Point(0, 0);
            this.dgvLoaithuoc.Margin = new System.Windows.Forms.Padding(4);
            this.dgvLoaithuoc.Name = "dgvLoaithuoc";
            this.dgvLoaithuoc.RowHeadersWidth = 62;
            this.dgvLoaithuoc.RowTemplate.Height = 28;
            this.dgvLoaithuoc.Size = new System.Drawing.Size(1178, 679);
            this.dgvLoaithuoc.TabIndex = 1;
            this.dgvLoaithuoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoaithuoc_CellClick);
            // 
            // malt
            // 
            this.malt.DataPropertyName = "malt";
            this.malt.HeaderText = "Mã loại";
            this.malt.MinimumWidth = 8;
            this.malt.Name = "malt";
            // 
            // tenloaithuoc
            // 
            this.tenloaithuoc.DataPropertyName = "tenlt";
            this.tenloaithuoc.HeaderText = "Tên loại thuốc";
            this.tenloaithuoc.MinimumWidth = 8;
            this.tenloaithuoc.Name = "tenloaithuoc";
            // 
            // mota
            // 
            this.mota.DataPropertyName = "mota";
            this.mota.HeaderText = "Mô tả";
            this.mota.MinimumWidth = 8;
            this.mota.Name = "mota";
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThoat.BackColor = System.Drawing.Color.Red;
            this.btnThoat.ForeColor = System.Drawing.Color.Black;
            this.btnThoat.Location = new System.Drawing.Point(1044, 685);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 41);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            // 
            // btnLuunhap
            // 
            this.btnLuunhap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuunhap.BackColor = System.Drawing.Color.Yellow;
            this.btnLuunhap.Location = new System.Drawing.Point(922, 685);
            this.btnLuunhap.Name = "btnLuunhap";
            this.btnLuunhap.Size = new System.Drawing.Size(75, 41);
            this.btnLuunhap.TabIndex = 8;
            this.btnLuunhap.Text = "Lưu";
            this.btnLuunhap.UseVisualStyleBackColor = false;
            this.btnLuunhap.Click += new System.EventHandler(this.btnLuunhap_Click);
            // 
            // frmQLLoaiThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 735);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLuunhap);
            this.Controls.Add(this.dgvLoaithuoc);
            this.Name = "frmQLLoaiThuoc";
            this.Text = "Quản lý loại thuốc";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmQLLoaiThuoc_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaithuoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiThem;
        private System.Windows.Forms.ToolStripMenuItem tsmiXoa;
        private System.Windows.Forms.ToolStripMenuItem tìmKiếmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvLoaithuoc;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLuunhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn malt;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenloaithuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn mota;
    }
}