

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using QuanLyTiemThuocTay.Global;

namespace QuanLyTiemThuocTay
{
    public partial class frmLogin : Form
    {
       
        public frmLogin()
        {
            InitializeComponent();
        }
        frmMain Main = new frmMain();

        private void cbHienmatkhau_CheckedChanged(object sender, EventArgs e)

        {
            try
            {
                if (cbHienmatkhau.Checked == false)
                {
                    txtMatkhau.PasswordChar = '*';
                }
                else
                {
                    txtMatkhau.PasswordChar = (char)0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTendangnhap.Text == "")
                {
                    MessageBox.Show("Tên Đăng Nhập Trống");
                }
                else if (txtMatkhau.Text == "")
                {
                    MessageBox.Show("Mật Khẩu Trống");
                }
                string username = txtTendangnhap.Text;
                string password = Global.Data.MaHoaMD5(txtMatkhau.Text);
                string query = "select * from NhanVien where Username=@username and password=@password";
                var dtKQ = SQL.GetData(query, CommandType.Text, new SqlParameter("@username", username), new SqlParameter("@password", password));
                if (dtKQ.Rows.Count > 0)
                {
                    Data.userName = dtKQ.Rows[0]["username"].ToString();
                    Data.chucVu = dtKQ.Rows[0]["chucvu"].ToString();
                    Main.Show();
                    this.Hide();

                    
                }
                else
                {
                    MessageBox.Show("Đăng Nhập Thất Bại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtTendangnhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtMatkhau.Focus();
            }
        }

        private void txtMatkhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangnhap.Focus();
            }
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}