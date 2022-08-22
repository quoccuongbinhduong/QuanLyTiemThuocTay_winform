using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyTiemThuocTay.Global;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace QuanLyTiemThuocTay
{
    public partial class frmQLLoaiThuoc : Form
    {

        frmMain m;
        string temp;
        public frmQLLoaiThuoc()
        {
            InitializeComponent();
        }

        public frmQLLoaiThuoc(frmMain m)
        {
            this.m = m;
            InitializeComponent();
        }
       
       
       
        public void LoadData()
        {
            try
            {
                var dt = SQL.GetData("select * from LoaiThuoc", CommandType.Text);
                dgvLoaithuoc.DataSource = dt;
               
            }
            catch (Exception ex)
            {
                m.Status(TypeStatus.Error, ex.Message);
            }
        }
        private void frmQLLoaiThuoc_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnLuunhap_Click(object sender, EventArgs e)
        {
            try
            {
                var dt = dgvLoaithuoc.DataSource as DataTable;
                const string tempTB = @"#LoaiThuoc";
                SQL.CreateTempTable3(dt.Copy(), "LoaiThuoc", tempTB);
                const string sql = @"delete from LoaiThuoc insert into LoaiThuoc select * from #LoaiThuoc";
                var result = SQL.ExcuteNonquery(sql, CommandType.Text);
                if (result == "")
                {
                    m.Status(TypeStatus.Success, "Thành Công");
                    LoadData();
                 }
                else
                {
                    m.Status(TypeStatus.Error, result);
                }
            }
            catch (Exception ex)
            {
                m.Status(TypeStatus.Error, ex.Message);
            }
        }
        public void Them()
        {
            try
            {
                var dt = dgvLoaithuoc.DataSource as DataTable;
                var row = dt.NewRow();
                if (dt.Rows.Count > 0)
                {
                    int maxID = dt.AsEnumerable().Max(nrow => Convert.ToInt32(nrow["malt"]));
                    row["malt"] = maxID + 1;
                }
                else
                {
                    row["malt"] = 1;
                }
                dt.Rows.Add(row);
                dgvLoaithuoc.DataSource = dt;
            }
            catch (Exception ex)
            {
                m.Status(TypeStatus.Error, ex.Message);
            }
        }
        private void tsmiThem_Click(object sender, EventArgs e)
        {
            Them();
        }


        public void Xoa()
        {
            try
            {
               
                var query = "delete from LoaiThuoc where malt=@malt";
                var result = SQL.ExcuteNonquery(query, CommandType.Text, new SqlParameter(@"malt", temp));
                if (result == "")
                {
                    m.Status(TypeStatus.Success, "Thành Công");
                    LoadData();
                }
                else
                {
                    m.Status(TypeStatus.Error, result);
                }
            }
            catch (Exception ex)
            {
                m.Status(TypeStatus.Error, ex.Message);
            }
        }

        private void tsmiXoa_Click(object sender, EventArgs e)
        {
            try
            {
                var dlResult =MessageBox.Show("Bạn có muốn xóa ?", "Xóa", MessageBoxButtons.YesNo);
                if (dlResult == DialogResult.Yes)
                {
                    Xoa();
                }
            }
            catch (Exception ex)
            {
                m.Status(TypeStatus.Error, ex.Message);
            }
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

        private void dgvLoaithuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //Lưu lại dòng dữ liệu vừa kích chọn
                DataGridViewRow row = this.dgvLoaithuoc.Rows[e.RowIndex];
                //Đưa dữ liệu vào textbox
                temp = row.Cells[0].Value.ToString();

            }
        }

      
        
    }
}
