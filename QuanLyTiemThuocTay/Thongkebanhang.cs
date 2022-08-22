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
    public partial class frmThongkebanhang : Form
    {
        public frmThongkebanhang()
        {
            InitializeComponent();
        }
        frmMain m;
        public frmThongkebanhang(frmMain m)
        {
            InitializeComponent();
            this.m = m;
        }
        public void LoadData()
        {
            try
            {
                string query = @"select b.mahd,b.trangthai,b.username,b.giothanhtoan,a.mathuoc,a.tenthuoc,a.hamluong,a.hangsx,c.macthd,c.donvi,c.soluong,c.giabantheodonvi,c.thanhtien from thuoc a,HoaDon b,ChiTietHD c where a.mathuoc=c.mathuoc and b.mahd=c.mahd";
                var dt = SQL.GetData(query, CommandType.Text);
                dgvThongkebanhang.DataSource = dt;
            }
            catch (Exception ex)
            {
                m.Status(TypeStatus.Error, ex.Message);
            }
        }
        private void Thongkebanhang_Load(object sender, EventArgs e)
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
