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
    public partial class frmTaikhoan : Form
    {
        public frmTaikhoan()
        {
            InitializeComponent();
        }
        frmMain m;
        public frmTaikhoan(frmMain m)
        {
            InitializeComponent();
            this.m = m;
        }
        public void LoadData()
        {
            try
            {
                txtUsername.Text = Data.userName;
                string query = @"select * from nhanvien where username=@username";
                var dt = SQL.GetData(query, CommandType.Text, new SqlParameter("@username", Data.userName));
                txtPassword.Text = dt.Rows[0]["password"].ToString();
                txtHoten.Text = dt.Rows[0]["hoten"].ToString();
                if (dt.Rows[0]["ngaysinh"].ToString() != "")
                {
                    dtpNgaysinh.Value = DateTime.Parse(dt.Rows[0]["ngaysinh"].ToString());
                }
                txtDiachi.Text = dt.Rows[0]["diachi"].ToString();
                List<string> lst_gioitinh = new List<string>() { "Nam", "Nữ" };
                cboGioitinh.Items.Add(lst_gioitinh);
                cboGioitinh.Text = dt.Rows[0]["gioitinh"].ToString();
               
            }
            catch (Exception ex)
            {
                m.Status(TypeStatus.Error, ex.Message);
            }
        }

        private void frmTaikhoan_Load(object sender, EventArgs e)
        {
            LoadData();
        }


        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            try
            {
               
                 txtPassword.Text = Data.MaHoaMD5(txtPassword.Text);
                
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

        private void btnLuunhap_Click(object sender, EventArgs e)
        {
            try
            {
                string query = @"update nhanvien set hoten=@hoten,ngaysinh=@ngaysinh,password=@password,hinhanh=@hinhanh,gioitinh=@gioitinh,diachi=@diachi where username=@username";
                List<SqlParameter> lst = new List<SqlParameter>();
                lst.Add(new SqlParameter("@username", Data.userName));
                lst.Add(new SqlParameter("@password", txtPassword.Text));
                lst.Add(new SqlParameter("@hoten", txtHoten.Text));
                if (dtpNgaysinh.Value != null)
                {
                    lst.Add(new SqlParameter("@ngaysinh", dtpNgaysinh.Value));

           }
                else
                {
                    lst.Add(new SqlParameter("@ngaysinh", DBNull.Value));
                }
                lst.Add(new SqlParameter("@gioitinh", cboGioitinh.Text));
               
                lst.Add(new SqlParameter("@diachi", txtDiachi.Text));
                var result = SQL.ExcuteNonquery(query, CommandType.Text, lst.ToArray());
                if (result == "")
                {
                    m.Status(TypeStatus.Success, "Thành Công");
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

     
       
    }
}
