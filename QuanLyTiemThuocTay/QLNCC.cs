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
    public partial class frmQLNCC : Form
    {

        string temp;
        frmMain m;
        public frmQLNCC()
        {
            InitializeComponent();
        }
        public frmQLNCC(frmMain m)
        {
            InitializeComponent();
            this.m = m;
        }
        public void LoadData()
        {
            try
            {
                var dt = SQL.GetData("select * from NhaCungCap", CommandType.Text);
                dgvNhaCC.DataSource = dt;
               
            }
            catch (Exception ex)
            {
                m.Status(TypeStatus.Error, ex.Message);
            }
        }
        private void frmQLNCC_Load(object sender, EventArgs e)
        {
            try
            {
                LoadData();

            }
            catch (Exception ex)
            {
                m.Status(TypeStatus.Error, ex.Message);
            }
        }

        private void btnLuunhap_Click(object sender, EventArgs e)
        {
            try
            {
                var dt = dgvNhaCC.DataSource as DataTable;
                const string tempTB = @"#NhaCungCap";
                SQL.CreateTempTable3(dt.Copy(), "NhaCungCap", tempTB);
                const string sql = @"delete from NhaCungCap insert into NhaCungCap select * from #NhaCungCap";
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
                var dt = dgvNhaCC.DataSource as DataTable;
                var row = dt.NewRow();
                if (dt.Rows.Count > 0)
                {
                    int maxID = dt.AsEnumerable().Max(nrow => Convert.ToInt32(nrow["mancc"]));
                    row["mancc"] = maxID + 1;
                }
                else
                {
                    row["mancc"] = 1;
                }
                row["loaincc"] = "Đại Lý";
                dt.Rows.Add(row);
                dgvNhaCC.DataSource = dt;
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
                
                var query = "delete from NhaCungCap where mancc=@mancc";
                var result = SQL.ExcuteNonquery(query, CommandType.Text, new SqlParameter(@"mancc", temp));
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

        private void tsmXoa_Click(object sender, EventArgs e)
        {
            try
            {
                var dlResult = MessageBox.Show("Bạn có muốn xóa ?", "Xóa", MessageBoxButtons.YesNo);
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

        private void dgvNhaCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //Lưu lại dòng dữ liệu vừa kích chọn
                DataGridViewRow row = this.dgvNhaCC.Rows[e.RowIndex];
                //Đưa dữ liệu vào textbox
                temp = row.Cells[0].Value.ToString();

            }
        }
    }
}
