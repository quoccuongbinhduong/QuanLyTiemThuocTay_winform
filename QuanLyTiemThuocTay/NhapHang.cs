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
    public partial class frmNhapthuoc : Form
    {
        public frmNhapthuoc()
        {
            InitializeComponent();
        }
        frmMain m;
        public frmNhapthuoc(frmMain m)
        {
            InitializeComponent();
            this.m = m;
        }
        public void LoadData()
        {
            try
            {
                var query = @"select mathuoc,tenthuoc,hamluong,hangsx,soluongtheodvban from Thuoc";
                var dt = SQL.GetData(query, CommandType.Text);
                cboThuoctrongkho.DataSource = dt;
            }
            catch (Exception ex)
            {
                m.Status(TypeStatus.Error, ex.Message);
            }
        }
        private void frmNhapthuoc_Load(object sender, EventArgs e)
        {
            LoadData();
            var dtlt = SQL.GetData("select malt,tenlt from loaithuoc", CommandType.Text);
            cboLoaithuocmoi.DataSource = dtlt;
            var dtncc = SQL.GetData("select mancc,tenncc from nhacungcap", CommandType.Text);
            cboNhaccmoi.DataSource = dtncc;
        }

        private void cboThuoctrongkho_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                
                var query = @"select * from thuoc where mathuoc=@mathuoc";
                var dt = SQL.GetData(query, CommandType.Text, new SqlParameter("@mathuoc", int.Parse(cboThuoctrongkho.SelectedIndex.ToString())));
                txtHamluong.Text = dt.Rows[0]["hamluong"].ToString();
                txtHangsudung.Text = dt.Rows[0]["hansd"].ToString();
                txtHangsanxuat.Text = dt.Rows[0]["hangsx"].ToString();
                txtQuycachdonggoiK.Text = dt.Rows[0]["quycachdonggoi"].ToString();
                txtDonvicobanK.Text = dt.Rows[0]["donvicoban"].ToString();
                txtGiabantheodonK.Text = dt.Rows[0]["giaban"].ToString();
                var query2 = @"select tenlt from loaithuoc where malt=@malt";
                var dtlt = SQL.GetData(query2, CommandType.Text, new SqlParameter("@malt", int.Parse(dt.Rows[0]["malt"].ToString())));
                txtLoaithuocK.Text = dtlt.Rows[0][0].ToString();
                
            }
            catch (Exception ex)
            {
                m.Status(TypeStatus.Error, ex.Message);
            }
        }
        private void txtGianhap_TextChanged(object sender, EventArgs e)
       
        {
            try
            {
                if ( txtTilequydoi.SelectedText == null || txtSoluongnhap.SelectedText == null || txtGianhap.SelectedText == null)
                {
                    m.Status(TypeStatus.Error, "Bạn Chưa Nhập Đầy Đủ Thông Tin");
                    return;
                }
                txtThanhtien.Text = Convert.ToString((int.Parse(txtGianhap.Text)) * (int.Parse(txtSoluongnhap.Text)) * (int.Parse(txtTilequydoi.Text)));
            }
            catch (Exception ex)
            {
                m.Status(TypeStatus.Error, ex.Message);
            }
        }
        private void btnLuuK_Click(object sender, EventArgs e)

        {
            try
            {
                if (cboThuoctrongkho.SelectedIndex == null || txtDonvinhap.SelectedText == null || txtTilequydoi.SelectedText == null || txtSoluongnhap.SelectedText == null || txtGianhap.SelectedText == null)
                {
                    m.Status(TypeStatus.Error, "Bạn Chưa Nhập Đầy Đủ Thông Tin");
                    return;
                }
                int maxMaNhapHang;
                var dt = SQL.GetData("select ISNULL(max(manhaphang),0) from nhaphang", CommandType.Text);
                if (dt.Rows.Count > 0)
                {
                    maxMaNhapHang = int.Parse(dt.Rows[0][0].ToString());
                }
                else
                {
                    maxMaNhapHang = 0;
                }

                int maThuoc = int.Parse(cboThuoctrongkho.SelectedText.ToString());
                int giaTriQuyDoi = int.Parse(txtTilequydoi.SelectedText.ToString());
                int soLuongNhap = int.Parse(txtSoluongnhap.SelectedText.ToString());
                int giaNhap = int.Parse(txtGianhap.SelectedText.ToString());
                string donViNhap = txtDonvinhapmoi.Text;
                string mota = txtMota.Text;
                int thanhTien = int.Parse(txtThanhtien.SelectedText.ToString());
                string query = @"insert into nhaphang values(@manhaphang,@mathuoc,@donvinhap,@giatriquydoi,@soluongnhap,@gianhap,@mota,GETDATE(),@thanhtien,@username)";
                var lst = new List<SqlParameter>();
                lst.Add(new SqlParameter("@manhaphang", maxMaNhapHang + 1));
                lst.Add(new SqlParameter("@mathuoc", maThuoc));
                lst.Add(new SqlParameter("@donvinhap", donViNhap));
                lst.Add(new SqlParameter("@giatriquydoi", giaTriQuyDoi));
                lst.Add(new SqlParameter("@soluongnhap", soLuongNhap));
                lst.Add(new SqlParameter("@gianhap", giaNhap));
                lst.Add(new SqlParameter("@mota", mota));
                lst.Add(new SqlParameter("@thanhtien", thanhTien));
                lst.Add(new SqlParameter("@username", Data.userName));
                var resultNhapHang = SQL.ExcuteNonquery(query, CommandType.Text, lst.ToArray());
                if (resultNhapHang != "")
                {
                    m.Status(TypeStatus.Error, resultNhapHang);
                    return;
                }
                int soLuongCu = int.Parse(SQL.GetData(@"select soluong from thuoc where mathuoc=@mathuoc", CommandType.Text, new SqlParameter("@mathuoc", maThuoc)).Rows[0][0].ToString());

                int soLuongMoi = soLuongNhap * giaTriQuyDoi + soLuongCu;
                int soluongTheoDvBanMoi = soLuongMoi / giaTriQuyDoi;
                string queryUpdateThuoc = @"update thuoc set soluong=@soluong,soluongtheodvban=@soluongtheodvban where mathuoc=@mathuoc";
                var result = SQL.ExcuteNonquery(queryUpdateThuoc, CommandType.Text, new SqlParameter("@soluong", soLuongMoi), new SqlParameter("@mathuoc", maThuoc), new SqlParameter("@soluongtheodvban", soluongTheoDvBanMoi));

                if (result == "")
                {
                    m.Status(TypeStatus.Success, "Thành Công");
                }
                else
                {
                    m.Status(TypeStatus.Error, result);
                    return;
                }

            }
            catch (Exception ex)
            {
                m.Status(TypeStatus.Error, ex.Message);
            }
        }
        private void btnLuuN_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTenthuocmoi.SelectedText == null || cboNhaccmoi.SelectedIndex == null || cboLoaithuocmoi.SelectedIndex == null || txtDonvicobanmoi.SelectedText == null || txtQuycacsdonggoimoi.SelectedText == null || txtGiabanmoi.SelectedText == null || txtHangsxmoi.SelectedText == null || txtDonvibanmoi.SelectedText == null || txtGiatriquydoimoi.SelectedText == null || txtSoluongnhapmoi.SelectedText == null || txtDonvinhapmoi.SelectedText == null || txtTilequydoimoi.SelectedText == null || txtGiabanmoi.SelectedText == null || txtThanhtienmoi.SelectedText == null)
                {
                    m.Status(TypeStatus.Error, "Bạn Chưa Nhập Đầy Đủ Thông Tin");
                    return;
                }
                int maxMaNhapHang;
                var dt = SQL.GetData("select ISNULL(max(manhaphang),0) from nhaphang", CommandType.Text);
                if (dt.Rows.Count > 0)
                {
                    maxMaNhapHang = int.Parse(dt.Rows[0][0].ToString());
                }
                else
                {
                    maxMaNhapHang = 0;
                }
                int maxMaThuoc;
                var dtThuoc = SQL.GetData("select ISNULL(max(mathuoc),0) from thuoc", CommandType.Text);
                if (dtThuoc.Rows.Count > 0)
                {
                    maxMaThuoc = int.Parse(dtThuoc.Rows[0][0].ToString());
                }
                else
                {
                    maxMaThuoc = 0;
                }

                string tenThuoc = txtTenthuocmoi.Text;
                int malt = int.Parse(cboLoaithuocmoi.SelectedIndex.ToString());
                int mancc = int.Parse(cboNhaccmoi.SelectedIndex.ToString());
                string hamLuong = txtHamluongmoi.Text;
                string quyCachDongGoi = txtQuycacsdonggoimoi.Text;
                string hangSX = txtHangsxmoi.Text;
                string dvCoBan = txtDonvicobanmoi.Text;
                int soLuong = int.Parse(txtSoluongnhapmoi.Text);
                int giaBan = int.Parse(txtGiabanmoi.Text);
                string mota = dmudMotamoi.Text;
                string donViBan = txtDonvibanmoi.Text;
                int giaTriQuyDoi = int.Parse(txtGiatriquydoimoi.Text);
                string donViNhap = txtDonvinhapmoi.Text;
                int tiLe = int.Parse(txtTilequydoimoi.Text);
                int giaNhap = int.Parse(txtGianhapmoi.Text);
                string ghiChu = txtGhichuN.Text;
                var hsd = dtpHansudungmoi.Text;
              
                int thanhTien = int.Parse(txtThanhtienmoi.Text);
                int giaBanTheoDVBan = giaBan * giaTriQuyDoi;
                int soluongtheodvban = (soLuong * tiLe) / giaTriQuyDoi;
                string queryInsertThuoc = @"insert into Thuoc values(@mathuoc,@malt,@mancc,@tenthuoc,@hamluong,@quycachdonggoi,@hangsx,@donvicoban,@soluong,@giaban,@mota,@hinhanh,@hansd,@donviban,@giatriquydoi,@giabantheodvban,@soluongtheodvban)";
                var lst = new List<SqlParameter>();
                lst.Add(new SqlParameter("@mathuoc", maxMaThuoc + 1));
                lst.Add(new SqlParameter("@malt", malt));
                lst.Add(new SqlParameter("@mancc", mancc));
                lst.Add(new SqlParameter("@tenthuoc", tenThuoc));
                lst.Add(new SqlParameter("@hamluong", hamLuong));
                lst.Add(new SqlParameter("@quycachdonggoi", quyCachDongGoi));

                lst.Add(new SqlParameter("@hangsx", hangSX));
                lst.Add(new SqlParameter("@donvicoban", dvCoBan));
                lst.Add(new SqlParameter("@soluong", soLuong * tiLe));
                lst.Add(new SqlParameter("@giaban", giaBan));
                lst.Add(new SqlParameter("@mota", mota));
                
                lst.Add(new SqlParameter("@hansd", hsd));
                lst.Add(new SqlParameter("@donviban", donViBan));
                lst.Add(new SqlParameter("@giatriquydoi", giaTriQuyDoi));
                lst.Add(new SqlParameter("@giabantheodvban", giaBanTheoDVBan));
                lst.Add(new SqlParameter("@soluongtheodvban", soluongtheodvban));
                var resultThemThuoc = SQL.ExcuteNonquery(queryInsertThuoc, CommandType.Text, lst.ToArray());
                if (resultThemThuoc != "")
                {
                    m.Status(TypeStatus.Error, resultThemThuoc);
                    return;
                }

                string queryInsertNhapHang = @"insert into NhapHang values(@manhaphang,@mathuoc,@donvinhap,@giatriquydoi,@soluongnhap,@gianhap,@mota,GETDATE(),@thanhtien,@username)";
                var lstNhap = new List<SqlParameter>();
                lstNhap.Add(new SqlParameter("@manhaphang", maxMaNhapHang + 1));
                lstNhap.Add(new SqlParameter("@mathuoc", maxMaThuoc + 1));
                lstNhap.Add(new SqlParameter("@donvinhap", donViNhap));
                lstNhap.Add(new SqlParameter("@giatriquydoi", giaTriQuyDoi));
                lstNhap.Add(new SqlParameter("@soluongnhap", soLuong));
                lstNhap.Add(new SqlParameter("@gianhap", giaNhap));
                lstNhap.Add(new SqlParameter("@mota", ghiChu));
                lstNhap.Add(new SqlParameter("@thanhtien", thanhTien));
                lstNhap.Add(new SqlParameter("@username", Data.userName));
                var result = SQL.ExcuteNonquery(queryInsertNhapHang, CommandType.Text, lstNhap.ToArray());
                if (result == "")
                {
                    m.Status(TypeStatus.Success, "Thành Công");
                }
                else
                {
                    m.Status(TypeStatus.Error, result);
                    return;
                }
            }
            catch (Exception ex)
            {
                m.Status(TypeStatus.Error, ex.Message);
            }
        }

        private void txtGianhapmoi_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtTilequydoimoi.SelectedText == null || txtSoluongnhapmoi.SelectedText == null || txtGiabanmoi.SelectedText == null)
                {
                    m.Status(TypeStatus.Error, "Bạn Chưa Nhập Đầy Đủ Thông Tin");
                    return;
                }
                txtThanhtienmoi.Text = Convert.ToString((int.Parse(txtGiabanmoi.Text)) * (int.Parse(txtSoluongnhapmoi.Text)) * (int.Parse(txtTilequydoimoi.Text)));
            }
            catch (Exception ex)
            {
                m.Status(TypeStatus.Error, ex.Message);
            }
        }

        private void btnThoatN_Click(object sender, EventArgs e)
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

        private void btnThoatK_Click(object sender, EventArgs e)
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
