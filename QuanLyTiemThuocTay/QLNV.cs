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
    public partial class frmQLNV : Form
    {
        private string temp;
        frmMain m;
        private SqlDbType username;

        public frmQLNV()
        {
            InitializeComponent();
        }
        public frmQLNV(frmMain m)
        {
            InitializeComponent();
            this.m = m;
        }

        private void frmQLNV_Load(object sender, EventArgs e)
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
        public void LoadData()
        {
            try
            {


                var dt = SQL.GetData(@"select * from NhanVien", CommandType.Text);
                dgvQLNV.AutoGenerateColumns = true;
                dgvQLNV.DataSource = dt;


            }
            catch (Exception ex)
            {
                m.Status(TypeStatus.Error, ex.Message);
            }
        }


       

        public void Them()
        {
            var dt = dgvQLNV.DataSource as DataTable;
            var row = dt.NewRow();


           
            row["password"] = txtPassword.Text;
            row["username"] = txtUsername.Text;
            row["chucvu"] = cboChucvu.Text;
            row["gioitinh"] =cboGioitinh.Text;
            row["hoten"] = txtHoten.Text;
            row["ngaysinh"] = dtpkNgaysinh.Text;

            row["diachi"] = txtDiachi.Text;
            
            dt.Rows.Add(row);
            dgvQLNV.DataSource = dt;


        }
        private void btnLuunhap_Click(object sender, EventArgs e)
        {
            try
            {
                var dt = dgvQLNV.DataSource as DataTable;
                const string tempTB = @"#NhanVien";
                SQL.CreateTempTable3(dt.Copy(), "NhanVien", tempTB);
                
                const string sql = @"delete from NhanVien insert into NhanVien select * from #NhanVien";
                var result = SQL.ExcuteNonquery(sql, CommandType.Text);
                if (result == "")
                {
                    m.Status(TypeStatus.Success, "Thành Công");
                    LoadData();
                }
                else
                {
                    m.Status(TypeStatus.Error, "That bai");
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

                var dlResult = MessageBox.Show("Bạn có muốn xóa nhân viên " + temp + " ?", "Xóa", MessageBoxButtons.YesNo);
                if (dlResult == DialogResult.Yes)
                {
                    try
                    {

                        var query = "delete from nhanvien where username=@username";
                        string result = SQL.ExcuteNonquery(query, CommandType.Text, new SqlParameter(@"username", temp));
                        LoadData();
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

        private void dgvQLNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //Lưu lại dòng dữ liệu vừa kích chọn
                DataGridViewRow row = this.dgvQLNV.Rows[e.RowIndex];
                //Đưa dữ liệu vào textbox
                temp = row.Cells[0].Value.ToString();
                
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            
            txtPassword.Text = Data.MaHoaMD5(txtPassword.Text);
        }

        private void tsmiThem_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Them();
        }

       
        private void tsmTimkiem_Click(object sender, EventArgs e)
        {
            try
            {
                Control control = dgvQLNV.Parent;
                // Set the text and backcolor of the parent control.
                control.Text = "My Groupbox";
                control.BackColor = Color.Blue;
                // Get the form that the Button control is contained within.
                Form myForm = dgvQLNV.FindForm();
                // Set the text and color of the form containing the Button.
                myForm.Text = "The Form of My Control";
                myForm.BackColor = Color.Red;
            }
            catch (Exception ex)
            {
                m.Status(TypeStatus.Error, ex.Message);
            }
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {

        }
    }
}
