
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyTiemThuocTay.Global;
namespace QuanLyTiemThuocTay
{
    public partial class frmThongkenhapthuoc : Form
    {
        public frmThongkenhapthuoc()
        {
            InitializeComponent();
        }
        frmMain m;
        public frmThongkenhapthuoc(frmMain m)
        {
            InitializeComponent();
            this.m = m;
        }
        public void LoadData()
        {
            try
            {
                var query = @"select a.manhaphang,a.donvinhap,a.giatriquydoi,a.soluongnhap,a.gianhap,a.mota,a.ngaynhap,a.thanhtien,a.username,b.tenthuoc,b.hamluong,b.hangsx from nhaphang a,thuoc b where a.mathuoc=b.mathuoc";
                var dt = SQL.GetData(query, CommandType.Text);
                dgvBaocaonhapthuoc.DataSource = dt;
            }
            catch (Exception ex)
            {
                m.Status(TypeStatus.Error, ex.Message);
            }
        }
        private void frmThongkenhapthuoc_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            try
            {
                var dlResult = MessageBox.Show("Bạn có muốn thoát ?", "Thoát", MessageBoxButtons.YesNo);
                if (dlResult == DialogResult.Yes)
                {
                    Close();
                }
            }
            catch (Exception ex)
            {
                m.Status(TypeStatus.Error, ex.Message);
            }
        }
    }
}
