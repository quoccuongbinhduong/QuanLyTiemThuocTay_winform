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
    public partial class frmQLThuoc : Form
    {
        public frmQLThuoc()
        {
            InitializeComponent();
        }

        frmMain m;
        public frmQLThuoc(frmMain m)
        {
            InitializeComponent();
            this.m = m;
        }
    }
}
