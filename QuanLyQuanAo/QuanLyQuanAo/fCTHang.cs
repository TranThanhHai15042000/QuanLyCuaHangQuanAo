using QuanLyQuanAo.DAO;
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
    public partial class fCTHang : MetroFramework.Forms.MetroForm
    {
        //BUS_TIEPNHANHOCSINH bustiepnhanhocsinh = new BUS_TIEPNHANHOCSINH();
        // int temp;
        DataTable tblH; //Bảng hàng
        public fCTHang()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            //txtMaCTHang.Text = "";
            //txtTen.Text = "";
            //cbbSize.Text = "";
            //txtKieuDang.Text = "";
            //txtChatLieu.Text = "";
            //txtAnh.Text = "";
   
        }

        private void fCTHang_Load(object sender, EventArgs e)
        {
            
                string sql;
                sql = "SELECT * from tblChatLieu";
                txtMaCTHang.Enabled = false;
                btnLuu.Enabled = false;
                btnBoQua.Enabled = false;
                LoadDataGridView();
            //Functions.FillCombo(sql, cboMaChatLieu, "MaChatLieu", "TenChatLieu");
            //boMaChatLieu.SelectedIndex = -1;
                ResetValues();
            
        }
        private void ResetValues()
        {
            txtMaCTHang.Text = "";
            txtTen.Text = "";
            // cboMaChatLieu.Text = "";
            cbbSize.Text = "";
            txtKieuDang.Text = "0";
            txtChatLieu.Text = "0";
            txtAnh.Text = "";
            pic.Image = null;
          
        }
        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT * from tblCT_Hang";
            tblH = DataProvider.Instance.ExecuteQuery(sql);
            dgvHang.DataSource = tblH;
            dgvHang.Columns[0].HeaderText = "Mã hàng";
            dgvHang.Columns[1].HeaderText = "Tên hàng";
            dgvHang.Columns[2].HeaderText = "Size";
            dgvHang.Columns[3].HeaderText = "Kiểu Dáng";
            dgvHang.Columns[4].HeaderText = "Chất Liệu";
            dgvHang.Columns[5].HeaderText = "Ảnh";
            dgvHang.Columns[0].Width = 80;
            dgvHang.Columns[1].Width = 140;
            dgvHang.Columns[2].Width = 80;
            dgvHang.Columns[3].Width = 80;
            dgvHang.Columns[4].Width = 100;
            dgvHang.Columns[5].Width = 100;
        
            dgvHang.AllowUserToAddRows = false;
            dgvHang.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dgvHang_Click(object sender, EventArgs e)
        {
            string MaChatLieu;
            string sql;
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaCTHang.Focus();
                return;
            }
            if (tblH.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaCTHang.Text = dgvHang.CurrentRow.Cells["idCTHang"].Value.ToString();
            txtTen.Text = dgvHang.CurrentRow.Cells["Ten"].Value.ToString();
            cbbSize.Text = dgvHang.CurrentRow.Cells["Size"].Value.ToString();
            txtKieuDang.Text = dgvHang.CurrentRow.Cells["KieuDang"].Value.ToString();
            txtChatLieu.Text = dgvHang.CurrentRow.Cells["ChatLieu"].Value.ToString();
            txtChatLieu.Text = dgvHang.CurrentRow.Cells["Anh"].Value.ToString();
        //    sql = "SELECT TenChatLieu FROM tblChatLieu WHERE MaChatLieu=N'" + MaChatLieu + "'";
            //  cboMaChatLieu.Text = Functions.GetFieldValues(sql);
            //   txtSoLuong.Text = dgvHang.CurrentRow.Cells["SoLuong"].Value.ToString();
            //   txtDonGiaNhap.Text = dgvHang.CurrentRow.Cells["DonGiaNhap"].Value.ToString();
            //     txtDonGiaBan.Text = dgvHang.CurrentRow.Cells["DonGiaBan"].Value.ToString();
            //   txtChatLieu.Text = dgvHang.CurrentRow.Cells["ChatLieu"].Value.ToString();
         //   sql = "SELECT Anh FROM tblHang WHERE MaHang=N'" + txtMaCTHang.Text + "'";
            //txtAnh.Text = Functions.GetFieldValues(sql );
            //picAnh.Image = Image.FromFile(txtAnh.Text);
            //sql = "SELECT Ghichu FROM tblHang WHERE MaHang = N'" + txtMaHang.Text + "'";
            //txtGhichu.Text = Functions.GetFieldValues(sql);
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnBoQua.Enabled = true;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

        }
    }
}

