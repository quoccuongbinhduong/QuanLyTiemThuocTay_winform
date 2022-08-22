
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyTiemThuocTay.Global;


namespace QuanLyTiemThuocTay
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            try
            {

                if (Data.chucVu != "admin")
                {
                    tbMain.TabPages.Remove(tpQuanly);
                }
                timerDateTime.Start();
                tsslUsername.Text = "User : " + Data.userName;
            }
            catch (Exception ex)
            {
                Status(TypeStatus.Error, ex.Message);
            }
        }
        public void Status(TypeStatus type, string message)
        {
            timerStatus.Interval = 10000;
            
            tsslStatus.Text = message;
            
            timerStatus.Start();
        }

        private void timerDateTime_Tick_1(object sender, EventArgs e)
        {

            timerDateTime.Interval = 1000;
            tsslTime.Text = DateTime.Now.ToString();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                LoadData();
            }
            catch (Exception ex)
            {
                Status(TypeStatus.Error, ex.Message);
            }
        }

        private void timerStatus_Tick(object sender, EventArgs e)
        {
            try
            {
                tsslStatus.Text = statusStrip1.Text;
                timerStatus.Stop();
            }
            catch (Exception ex)
            {
                Status(TypeStatus.Error, ex.Message);
            }
        }
        private void CreateForm(Form form)
        {
            try
            {
                for (int i = 0; i < tbMain2.TabPages.Count; i++)
                {
                    if (tbMain2.TabPages[i].Name == form.Name)
                    {
                        tbMain2.SelectedTab = tbMain2.TabPages[i];

                        return;
                    }
                }
                form.MdiParent = this;
                form.WindowState = FormWindowState.Maximized;
                if (AddNewTabPage(form))
                {
                    form.Show();
                }
            }
            catch (Exception ex)
            {
                Status(TypeStatus.Error, ex.Message);
            }
        }
        public bool ExistsFormInTabpage(Form form)
        {
            try
            {
                foreach (TabPage tp in tbMain2.TabPages)
                {
                    if (tp.Name == form.Name)
                    {
                        return true;
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                Status(TypeStatus.Error, ex.Message);
                return false;
            }
        }
        public bool AddNewTabPage(Form form)
        {
            try
            {
                if (ExistsFormInTabpage(form))
                {
                    return false;
                }
                TabPage tpage = new TabPage();
                tpage.Name = form.Name;
                tpage.Text = form.Text;
                tpage.BorderStyle = BorderStyle.None;
                tpage.BackColor = Color.Transparent;
                tbMain2.TabPages.Add(tpage);
                tbMain2.SelectedTab = tpage;
                tbMain2.Visible = tbMain2.TabPages.Count > 0;
                return true;
            }
            catch (Exception ex)
            {
                Status(TypeStatus.Error, ex.Message);
                return false;
            }
        }

        private void frmMain_MdiChildActivate(object sender, EventArgs e)
        {
            try
            {
                var form = this.ActiveMdiChild;
                if (form == null)
                {
                    return;
                }

                foreach (TabPage tab in tbMain2.TabPages)
                {
                    if (tab.Name == form.Name)
                    {
                        tbMain2.SelectedTab = tab;
                    }
                }
            }
            catch (Exception ex)
            {
                Status(TypeStatus.Error, ex.Message);
            }
        }

        private void tsNhanvien_Click(object sender, EventArgs e)
        {
            
            try
            {
                frmQLNV nv = new frmQLNV(this);
                CreateForm(nv);
            }
            catch (Exception ex)
            {
                Status(TypeStatus.Error, ex.Message);
            }
            
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void tsNhacungcap_Click(object sender, EventArgs e)
        {
            try
            {
                frmQLNCC ncc = new frmQLNCC(this);
                CreateForm(ncc);
            }
            catch (Exception ex)
            {
                Status(TypeStatus.Error, ex.Message);
            }
        }

        private void tsLoaithuoc_Click(object sender, EventArgs e)
        {
            try
            {
                frmQLLoaiThuoc lthuoc = new frmQLLoaiThuoc(this);
                CreateForm(lthuoc);
            }
            catch (Exception ex)
            {
                Status(TypeStatus.Error, ex.Message);
            }
        }

        private void tsThuoc_Click(object sender, EventArgs e)
        {
            try
            {
                frmQLThuoc qLT = new frmQLThuoc(this);
                CreateForm(qLT);
            }
            catch (Exception ex)
            {
                Status(TypeStatus.Error, ex.Message);
            }
        }

        private void tsBaocaothongkebanhang_Click(object sender, EventArgs e)
        {
            try
            {
                frmThongkebanhang thongke= new frmThongkebanhang(this);
                CreateForm(thongke);
            }
            catch (Exception ex)
            {
                Status(TypeStatus.Error, ex.Message);
            }
        }

        private void tsbBaocaonhapthuoc_Click(object sender, EventArgs e)
        {
            try
            {
                frmThongkenhapthuoc thongke = new frmThongkenhapthuoc(this);
                CreateForm(thongke);
            }
            catch (Exception ex)
            {
                Status(TypeStatus.Error, ex.Message);
            }
        }

        private void tsNhapthuoc_Click(object sender, EventArgs e)
        {
            try
            {
                frmNhapthuoc thongke = new frmNhapthuoc(this);
                CreateForm(thongke);
            }
            catch (Exception ex)
            {
                Status(TypeStatus.Error, ex.Message);
            }
        }

        private void tsBanthuoc_Click(object sender, EventArgs e)
        {
            try
            {
                frmBanThuoc banth = new frmBanThuoc(this);
                CreateForm(banth);
            }
            catch (Exception ex)
            {
                Status(TypeStatus.Error, ex.Message);
            }
        }

        private void tsTaikhoan_Click(object sender, EventArgs e)
        {
            try
            {
                frmTaikhoan TKhoan = new frmTaikhoan(this); 
                CreateForm(TKhoan);
            }
            catch (Exception ex)
            {
                Status(TypeStatus.Error, ex.Message);
            }
        }

        private void tspDangxuat_Click(object sender, EventArgs e)
        {
            var dlResult = MessageBox.Show("Bạn có muốn đăng xuất không ?", "Đăng Xuất", MessageBoxButtons.YesNo);
            if (dlResult == DialogResult.Yes)
            {
                frmLogin lg = new frmLogin();
                lg.Show();
                this.Hide();
            }
            try
            {
                
            }
            catch (Exception ex)
            {
                Status(TypeStatus.Error, ex.Message);
            }
        }

        private void tsThongtinthuoc_Click(object sender, EventArgs e)
        {

        }
    }
}