using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanAo
{
    public partial class fCTHang : Form
    {
        //BUS_TIEPNHANHOCSINH bustiepnhanhocsinh = new BUS_TIEPNHANHOCSINH();
       // int temp;
        public fCTHang()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            txtMaCTHang.Text = "";
            txtTen.Text = "";
            cbbSize.Text = "";
            txtKieuDang.Text = "";
            txtChatLieu.Text = "";
            txtAnh.Text = "";
            txtGhichu.Text = "";
        }

        private void fCTHang_Load(object sender, EventArgs e)
        {
            
        }
    }
}

