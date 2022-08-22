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
    public partial class frmBanThuoc : Form
    {
       
      
        public frmBanThuoc()
        {
            InitializeComponent();
        }
        frmMain m;
        public frmBanThuoc(frmMain m)
        {
            this.m = m; 
            InitializeComponent();
        }
        private void frmBanThuoc_Load(object sender, EventArgs e)
        {

            try
            {
                var dt = SQL.GetData("select mathuoc,tenthuoc,hamluong,hangsx from thuoc", CommandType.Text);
                cbChonthuoc.DataSource = dt;
                LoadGridView();
                

            }
            catch (Exception ex)
            {
                m.Status(TypeStatus.Error, ex.Message);
            }

        }

        private void cckDonvicoban_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                var dt = SQL.GetData("select * from thuoc where mathuoc=@mathuoc", CommandType.Text, new SqlParameter("@mathuoc", int.Parse(cbChonthuoc.ToString()))); ;

                if (cckDonvicoban.Checked == true)
                {
                    txtSoluongton.Text = dt.Rows[0]["soluong"].ToString();
                    txtGiaban.Text = dt.Rows[0]["giaban"].ToString();
                }
                else
                {
                    txtSoluongton.Text = dt.Rows[0]["soluongtheodvban"].ToString();
                    txtGiaban.Text = dt.Rows[0]["giabantheodvban"].ToString();
                }
            }
            catch (Exception ex)
            {
                m.Status(TypeStatus.Error, ex.Message);
            }

        }

        private void cckDonviban_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                var dt = SQL.GetData("select * from thuoc where mathuoc=@mathuoc", CommandType.Text, new SqlParameter("@mathuoc", int.Parse(cbChonthuoc.ToString())));

            if (cckDonviban.Checked == true)
            {
                txtSoluongton.Text = dt.Rows[0]["soluong"].ToString();
                txtGiaban.Text = dt.Rows[0]["giaban"].ToString();
            }
            else
            {
                txtSoluongton.Text = dt.Rows[0]["soluongtheodvban"].ToString();
                txtGiaban.Text = dt.Rows[0]["giabantheodvban"].ToString();
            }
            }
            catch (Exception ex)
            {
                m.Status(TypeStatus.Error, ex.Message);
            }
        }

        private void txtSoluong_TextChanged(object sender, EventArgs e)
        {

            try
            {
                if (txtGiaban.Text == null || txtSoluong.Text == null)
                {
                    return;
                }
                int soluongmua = int.Parse(txtSoluong.Text);
                int giaban = int.Parse(txtGiaban.Text);
                txtThanhtien.Text = (soluongmua * giaban).ToString();
            }
            catch (Exception ex)
            {
                m.Status(TypeStatus.Error, ex.Message);
            }
        }
     
        private void txtGiaban_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtGiaban.Text == null || txtSoluong.Text == null)
                {
                    return;
                }
                int soluongmua = int.Parse(txtSoluong.Text);
                int giaban = int.Parse(txtGiaban.Text);
                txtThanhtien.Text = (soluongmua * giaban).ToString();
            }
            catch (Exception ex)
            {
                m.Status(TypeStatus.Error, ex.Message);
            }
        }
        public void LoadGridView()
        {
            try
            {
                var dt = SQL.GetData("select a.mathuoc,a.tenthuoc,a.hangsx,a.hamluong,b.soluong,b.donvi,b.giabantheodonvi,b.thanhtien from thuoc a,ChiTietHD b,Hoadon c where a.mathuoc=b.mathuoc and b.mahd=c.mahd and trangthai='unpaid' ", CommandType.Text);
                dgvBanthuoc.DataSource = dt;
                
                int sc = dgvBanthuoc.Rows.Count;
                float tong = 0;
                for (int i = 0; i < sc - 1; i++)
                    tong += float.Parse(dgvBanthuoc.Rows[i].Cells["ThanhTien"].Value.ToString());
                txtTongthanhtien.Text = tong.ToString();
            }
            catch (Exception ex)
            {
                m.Status(TypeStatus.Error, ex.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
               
                //Chưa có hóa đơn
                if (SQL.GetData("select * from hoadon where trangthai='unpaid'", CommandType.Text).Rows.Count <= 0)
                {
                    int maxMaHD;
                    if (SQL.GetData("select ISNULL(max(mahd),0) from hoadon", CommandType.Text).Rows[0][0].ToString() != "")
                    {
                        var dtrowcout = SQL.GetData("select ISNULL(max(mahd),0) from hoadon", CommandType.Text);
                        maxMaHD = int.Parse(dtrowcout.Rows[0][0].ToString());
                    }
                    else
                    {
                        maxMaHD = 0;
                    }
                    //them vao hoa don
                    string queryHoaDon = "insert into hoadon values(@mahd,'unpaid',@username,null)";
                    var resulthd = SQL.ExcuteNonquery(queryHoaDon, CommandType.Text, new SqlParameter("@mahd", maxMaHD + 1), new SqlParameter("username", Data.userName));
                    if (resulthd != "")
                    {
                        m.Status(TypeStatus.Error, resulthd);
                        return;
                    }
                    int maxMaCTHD;
                    if (SQL.GetData("select ISNULL(max(macthd),0) from chitiethd", CommandType.Text).Rows[0][0].ToString() != "")
                    {
                        maxMaCTHD = int.Parse(SQL.GetData("select ISNULL(max(macthd),0) from chitiethd", CommandType.Text).Rows[0][0].ToString());
                    }
                    else
                    {
                        maxMaCTHD = 0;
                    }
                    //them vao chi tiet hoa don
                    string queryCTHD = "insert into chitiethd values(@macthd,@mahd,@mathuoc,@soluong,@thanhtien,@donvi,@giabantheodonvi)";
                    var lst = new List<SqlParameter>();
                    lst.Add(new SqlParameter("@macthd", maxMaCTHD + 1));
                    lst.Add(new SqlParameter("@mahd", maxMaHD + 1));
                    lst.Add(new SqlParameter("@mathuoc", int.Parse(cbChonthuoc.SelectedValue.ToString())));
                    lst.Add(new SqlParameter("@soluong", int.Parse(txtSoluong.Text)));
                    lst.Add(new SqlParameter("@thanhtien", int.Parse(txtThanhtien.Text)));
                    string donvi;
                    if (cckDonviban.Checked)
                    {
                        donvi = cckDonviban.Text;
                    }
                    else
                    {
                        donvi = cckDonvicoban.Text;
                    }
                    lst.Add(new SqlParameter("@donvi", donvi));
                    lst.Add(new SqlParameter("@giabantheodonvi", int.Parse(txtGiaban.Text)));
                    var resultInsertThuoc = SQL.ExcuteNonquery(queryCTHD, CommandType.Text, lst.ToArray());
                    if (resultInsertThuoc != "")
                    {

                        m.Status(TypeStatus.Error, resultInsertThuoc);
                        return;
                    }

                    if (cckDonviban.Checked)
                    {
                        var dt = SQL.GetData("select * from thuoc where mathuoc=@mathuoc", CommandType.Text, new SqlParameter("mathuoc", int.Parse(cbChonthuoc.SelectedValue.ToString())));
                        int gtqd = int.Parse(dt.Rows[0]["giatriquydoi"].ToString());
                        int soluongtheodvbanmoi = int.Parse(txtSoluongton.Text) - int.Parse(txtSoluong.Text);
                        int soluongtheodonvicobanmoi = int.Parse(dt.Rows[0]["soluong"].ToString()) - gtqd * int.Parse(txtSoluong.Text);
                        string query = "update thuoc set soluong=@soluong,soluongtheodvban=@soluongtheodvban where mathuoc=@mathuoc";
                        var list = new List<SqlParameter>();
                        list.Add(new SqlParameter("@soluong", soluongtheodonvicobanmoi));
                        list.Add(new SqlParameter("@soluongtheodvban", soluongtheodvbanmoi));
                        lst.Add(new SqlParameter("@mathuoc", int.Parse(cbChonthuoc.SelectedValue.ToString())));
                        var result = SQL.ExcuteNonquery(query, CommandType.Text, list.ToArray());
                        LoadGridView();
                        if (result == "")
                        {
                            m.Status(TypeStatus.Success, "Thành Công");
                            LoadGridView();
                        }
                        else
                        {
                            m.Status(TypeStatus.Error, result);
                        }


                    }
                    else
                    {
                        var dt = SQL.GetData("select * from thuoc where mathuoc=@mathuoc", CommandType.Text, new SqlParameter("mathuoc", int.Parse(cbChonthuoc.SelectedValue.ToString())));
                        int gtqd = int.Parse(dt.Rows[0]["giatriquydoi"].ToString());
                        int soluongtheodvcobanmoi = int.Parse(txtSoluongton.Text) - int.Parse(txtSoluong.Text);
                        int soluongtheodvbanmoi = soluongtheodvcobanmoi / gtqd;
                        string query = "update thuoc set soluong=@soluong,soluongtheodvban=@soluongtheodvban where mathuoc=@mathuoc";
                        var list = new List<SqlParameter>();
                        lst.Add(new SqlParameter("@soluong", soluongtheodvcobanmoi));
                        lst.Add(new SqlParameter("@soluongtheodvban", soluongtheodvcobanmoi));
                        lst.Add(new SqlParameter("@mathuoc", int.Parse(cbChonthuoc.SelectedValue.ToString())));
                        var result = SQL.ExcuteNonquery(query, CommandType.Text, list.ToArray());
                        LoadGridView();
                        if (result == "")
                        {
                            m.Status(TypeStatus.Success, "Thành Công");
                            LoadGridView();
                        }
                        else
                        {
                            m.Status(TypeStatus.Error, result);
                        }
                    }
                }
                else
                {
                    int mahd = int.Parse(SQL.GetData("select ISNULL(max(mahd),0) from hoadon", CommandType.Text).Rows[0][0].ToString());
                    int maxMaCTHD;
                    if (SQL.GetData("select ISNULL(max(macthd),0) from chitiethd", CommandType.Text).Rows[0][0].ToString() != "")
                    {
                        maxMaCTHD = int.Parse(SQL.GetData("select ISNULL(max(macthd),0) from chitiethd", CommandType.Text).Rows[0][0].ToString());
                    }
                    else
                    {
                        maxMaCTHD = 0;
                    }
                    string queryCTHD = "insert into chitiethd values(@macthd,@mahd,@mathuoc,@soluong,@thanhtien,@donvi,@giabantheodonvi)";
                    var lst = new List<SqlParameter>();
                    lst.Add(new SqlParameter("@macthd", maxMaCTHD + 1));
                    lst.Add(new SqlParameter("@mahd", mahd));
                    lst.Add(new SqlParameter("@mathuoc", int.Parse(cbChonthuoc.SelectedValue.ToString())));
                    lst.Add(new SqlParameter("@soluong", int.Parse(txtSoluong.Text)));
                    lst.Add(new SqlParameter("@thanhtien", int.Parse(txtThanhtien.Text)));
                    string donvi;
                    if (cckDonviban.Checked)
                    {
                        donvi = cckDonviban.Text;
                    }
                    else
                    {
                        donvi = cckDonvicoban.Text;
                    }
                    lst.Add(new SqlParameter("@donvi", donvi));
                    lst.Add(new SqlParameter("@giabantheodonvi", int.Parse(txtGiaban.Text)));
                    var resultInsertThuoc = SQL.ExcuteNonquery(queryCTHD, CommandType.Text, lst.ToArray());
                    if (resultInsertThuoc != "")
                    {
                        m.Status(TypeStatus.Error, resultInsertThuoc);
                        return;
                    }
                    if (cckDonviban.Checked)
                    {
                        var dt = SQL.GetData("select * from thuoc where mathuoc=@mathuoc", CommandType.Text, new SqlParameter("mathuoc", int.Parse(cbChonthuoc.SelectedValue.ToString())));
                        int gtqd = int.Parse(dt.Rows[0]["giatriquydoi"].ToString());
                        int soluongtheodvbanmoi = int.Parse(txtSoluongton.Text) - int.Parse(txtSoluong.Text);
                        int soluongtheodonvicobanmoi = int.Parse(dt.Rows[0]["soluong"].ToString()) - gtqd * int.Parse(txtSoluong.Text);
                        string query = "update thuoc set soluong=@soluong,soluongtheodvban=@soluongtheodvban where mathuoc=@mathuoc";
                        var list = new List<SqlParameter>();
                        list.Add(new SqlParameter("@soluong", soluongtheodonvicobanmoi));
                        list.Add(new SqlParameter("@soluongtheodvban", soluongtheodvbanmoi));
                        lst.Add(new SqlParameter("@mathuoc", int.Parse(cbChonthuoc.SelectedValue.ToString())));
                        var result = SQL.ExcuteNonquery(query, CommandType.Text, list.ToArray());
                        LoadGridView();
                        if (result == "")
                        {
                            m.Status(TypeStatus.Success, "Thành Công");
                            LoadGridView();
                        }
                        else
                        {
                            m.Status(TypeStatus.Error, result);
                        }


                    }
                    else
                    {
                        var dt = SQL.GetData("select * from thuoc where mathuoc=@mathuoc", CommandType.Text, new SqlParameter("mathuoc", int.Parse(cbChonthuoc.SelectedValue.ToString())));
                        int gtqd = int.Parse(dt.Rows[0]["giatriquydoi"].ToString());
                        int soluongtheodvcobanmoi = int.Parse(txtSoluongton.Text) - int.Parse(txtSoluong.Text);
                        int soluongtheodvbanmoi = soluongtheodvcobanmoi / gtqd;
                        string query = "update thuoc set soluong=@soluong,soluongtheodvban=@soluongtheodvban where mathuoc=@mathuoc";
                        var list = new List<SqlParameter>();
                        lst.Add(new SqlParameter("@soluong", soluongtheodvcobanmoi));
                        lst.Add(new SqlParameter("@soluongtheodvban", soluongtheodvcobanmoi));
                        lst.Add(new SqlParameter("@mathuoc", int.Parse(cbChonthuoc.SelectedValue.ToString())));
                        var result = SQL.ExcuteNonquery(query, CommandType.Text, list.ToArray());
                        LoadGridView();
                        if (result == "")
                        {
                            m.Status(TypeStatus.Success, "Thành Công");
                            LoadGridView();
                        }
                        else
                        {
                            m.Status(TypeStatus.Error, result);
                        }
                    }
                }


                }
            catch (Exception ex)
            {
                m.Status(TypeStatus.Error, ex.Message);
            }
        }

        private void btnThanhtoan_Click(object sender, EventArgs e)

        {
            try
            {
                var dlResult = MessageBox.Show("Bạn có muốn thanh toán ?", "Thanh Toán", MessageBoxButtons.YesNo);
                if (dlResult == DialogResult.Yes)
                {
                    ThanhToan();
                }
            }
            catch (Exception ex)
            {
                m.Status(TypeStatus.Error, ex.Message);
            }
        }
        public void ThanhToan()
        {
            int mahd = int.Parse(SQL.GetData("select mahd from hoadon where trangthai='unpaid'", CommandType.Text).Rows[0][0].ToString());
            string query = "update hoadon set trangthai='paid',giothanhtoan=GETDATE() where mahd=@mahd";
            var resultUpdate = SQL.ExcuteNonquery(query, CommandType.Text, new SqlParameter("@mahd", mahd));
            if (resultUpdate == "")
            {
                m.Status(TypeStatus.Success, "Thành Công");
                LoadGridView();
                txtSoluong = null;
                txtThanhtien = null;
            }
            else
            {
                m.Status(TypeStatus.Error, resultUpdate);
                return;
            }



        }

        private void cbChonthuoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var dt = SQL.GetData("select * from thuoc where mathuoc=@mathuoc", CommandType.Text, new SqlParameter("@mathuoc", int.Parse(cbChonthuoc.SelectedValue.ToString())));
                cckDonviban.Text = dt.Rows[0]["donviban"].ToString();
                cckDonvicoban.Text = dt.Rows[0]["donvicoban"].ToString();
                cckDonviban.Checked = true;
                txtSoluongton.Text = dt.Rows[0]["soluongtheodvban"].ToString();
                txtGiaban.Text = dt.Rows[0]["giabantheodvban"].ToString();
                
            }
            catch (Exception ex)
            {
                m.Status(TypeStatus.Error, ex.Message);
            }
        }
    }
}