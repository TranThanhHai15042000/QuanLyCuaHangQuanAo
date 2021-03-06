﻿using FontAwesome.Sharp;
using ShopQuanAo100.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopQuanAo100
{
    public partial class fKhachHang : Form
    {

        DataTable tblKH; //Bảng khách hàng

        private IconButton currentBtn;
        private Panel leftBorderBtn;
        public fKhachHang()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 90);
        }
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Current Child Form Icon

            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
            public static Color color7 = Color.FromArgb(140, 212, 122);
        }
        private void dgvKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thêm thông tin khách hàng", "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnBoQua.Enabled = true;
                btnLuu.Enabled = true;
                btnThem.Enabled = false;
                ResetValues();
                txtMaKhach.Enabled = true;
                txtMaKhach.Focus();
            }
            ActivateButton(sender, RGBColors.color7);
        }


        private void ResetValues()
        {
            txtMaKhach.Text = "";
            txtTenKhach.Text = "";
            txtDiaChiKH.Text = "";
            mtbSDTKhach.Text = "";

        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblKH.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaKhach.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                if (MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    sql = "DELETE tblKhachHang WHERE idKhachHang=N'" + txtMaKhach.Text + "'";
                    DataProvider.Instance.ExecuteQuery(sql);
                    LoadDataGridView();
                    ResetValues();
                }
            }

            catch (Exception)
            {
                MessageBox.Show("Xóa thất bại", "Thông báo");
            }
            ActivateButton(sender, RGBColors.color6);
        }

        private void LoadDataGridView()
        {
            // getdata();
            string sql;
            sql = "SELECT * from tblKhachHang";
            tblKH = DataProvider.Instance.ExecuteQuery(sql);
            dgvKhachHang.DataSource = tblKH; //Hiển thị vào dataGridView
            dgvKhachHang.Columns[0].HeaderText = "Mã Khách";
            dgvKhachHang.Columns[1].HeaderText = "Tên khách";
            dgvKhachHang.Columns[2].HeaderText = "Địa chỉ";
            dgvKhachHang.Columns[3].HeaderText = "Điện thoại";
            dgvKhachHang.Columns[4].HeaderText = "Ngày sinh";
       
            dgvKhachHang.Columns[0].Width = 130;
            dgvKhachHang.Columns[1].Width = 130;
            dgvKhachHang.Columns[2].Width = 200;
            dgvKhachHang.Columns[3].Width = 150;
            dgvKhachHang.Columns[4].Width = 300;
            dgvKhachHang.AllowUserToAddRows = false;        // Không cho người dùng thêm dữ liệu trực tiếp
            dgvKhachHang.EditMode = DataGridViewEditMode.EditProgrammatically;      //Không cho sửa dữ liệu trực tiếp
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblKH.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaKhach.Text == "")
            {
                MessageBox.Show("Bạn phải chọn bản ghi cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenKhach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên khách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenKhach.Focus();
                return;
            }
            if (txtDiaChiKH.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDiaChiKH.Focus();
                return;
            }
            if (mtbSDTKhach.Text == "(  )    -")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mtbSDTKhach.Focus();
                return;
            }
            if (dateTimeSNKH.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mtbSDTKhach.Focus();
                return;
            }
            try
            {
                sql = "UPDATE tblKhachHang SET TenKhach=N'" + txtTenKhach.Text.Trim().ToString() + "',DiaChi=N'" +
                txtDiaChiKH.Text.Trim().ToString() + "',DienThoai='" + mtbSDTKhach.Text.ToString() + "',NgaySinh=N'" + dateTimeSNKH.Value.ToString() + "' WHERE idKhachHang=N'" + txtMaKhach.Text + "'";
                DataProvider.Instance.ExecuteQuery(sql);
                LoadDataGridView();
                ResetValues();
                btnBoQua.Enabled = false;

            }
            catch (Exception)
            {
                MessageBox.Show("Sửa thất bại", "Thông báo");
            }
            ActivateButton(sender, RGBColors.color5);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMaKhach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã khách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaKhach.Focus();
                return;
            }
            if (txtTenKhach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên khách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenKhach.Focus();
                return;
            }
            if (txtDiaChiKH.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDiaChiKH.Focus();
                return;
            }
            if (mtbSDTKhach.Text == "(   )    -") // mặc định của trường masktextNumber
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mtbSDTKhach.Focus();
                return;
            }

            try
            {
                //Kiểm tra tồn tại mã khách 
                sql = "SELECT iDKhachHang FROM tblKhachHang WHERE iDKhachHang=N'" + txtMaKhach.Text.Trim() + "'";
                if (DAO_KhachHang.CheckKey(sql))
                {
                    MessageBox.Show("Mã khách này đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMaKhach.Focus();
                    return;
                }

                //Chèn thêm
                sql = "INSERT INTO dbo.tblKhachHang VALUES (N'" + txtMaKhach.Text.Trim() +
                            "',N'" + txtTenKhach.Text.Trim() + "',N'" + txtDiaChiKH.Text.Trim() + "','" + mtbSDTKhach.Text + "',N'" + dateTimeSNKH.Value.ToString() + "')";
                //Functions.RunSQL(sql);

                DataProvider.Instance.ExecuteQuery(sql);
                LoadDataGridView();
                ResetValues();

                btnXoa.Enabled = true;
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnBoQua.Enabled = false;
                btnLuu.Enabled = false;
                txtMaKhach.Enabled = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm thất bại", "Thông báo");
            }
            ActivateButton(sender, RGBColors.color4);
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            string sql;
            sql = "SELECT * FROM tblKhachHang";
            tblKH = DAO_CTHang.GetDataToTable(sql);
            dgvKhachHang.DataSource = tblKH;
            ActivateButton(sender, RGBColors.color3);
        }

        private void btnBoQua_Click_1(object sender, EventArgs e)
        {
            ResetValues();
            btnBoQua.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtMaKhach.Enabled = false;
            ActivateButton(sender, RGBColors.color2);
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            
                this.Close();
            
            ActivateButton(sender, RGBColors.color1);
        }

        private void btnChuanTen_Click(object sender, EventArgs e)
        {
            if (txtTenKhach.Text == "")
            {
                MessageBox.Show("Bạn phải nhập tên khách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenKhach.Focus();
                return;
            }
            else

            {
                string newname = txtTenKhach.Text.Trim().ToLower();
                string kq = newname[0].ToString().ToUpper();
                for (int i = 1; i < newname.Length; i++)
                {

                    if (newname[i] != ' ')
                    {
                        if (newname[i - 1] == ' ')
                        {
                            kq = kq;
                        }
                        else kq = kq + newname[i];
                    }
                    if (newname[i] == ' ')
                    {
                        kq = kq + ' ' + newname[i + 1].ToString().ToUpper();
                    }
                    //else  kq = kq + newname[i];
                }
                txtTenKhach.Text = kq;
            }


        }

        private void dgvKhachHang_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaKhach.Focus();
                return;
            }
            // trường hợp k có dữ liệu trong dgv khách hàng 
            if (tblKH.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaKhach.Text = dgvKhachHang.CurrentRow.Cells["idKhachHang"].Value.ToString();
            txtTenKhach.Text = dgvKhachHang.CurrentRow.Cells["TenKhach"].Value.ToString();
            txtDiaChiKH.Text = dgvKhachHang.CurrentRow.Cells["DiaChi"].Value.ToString();
            mtbSDTKhach.Text = dgvKhachHang.CurrentRow.Cells["DienThoai"].Value.ToString();
            dateTimeSNKH.Text = dgvKhachHang.CurrentRow.Cells["NgaySinh"].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnBoQua.Enabled = true;
        }

        private void fKhachHang_Load(object sender, EventArgs e)
        {
            txtMaKhach.Enabled = false;
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
            LoadDataGridView();
        }

        private void txtTimKH_TextChanged(object sender, EventArgs e)
        {
             if (cbbFind.Text == "Mã khách")
            {
                string qr1 = (" SELECT * FROM tblKhachHang WHERE idKhachHang like '%" + txtTimKH.Text.Trim() + "%' ");
                dgvKhachHang.DataSource = DataProvider.Instance.ExecuteQuery(qr1);

            }
            else if (cbbFind.Text == "Tên khách")
            {
                string qr2 = (" SELECT*FROM tblKhachHang WHERE TenKhach like '%" + txtTimKH.Text.Trim() + "%' ");
                dgvKhachHang.DataSource = DataProvider.Instance.ExecuteQuery(qr2);
            }
            else if (cbbFind.Text == "Số điện thoại")
            {
                string qr3 = (" SELECT * FROM tblKhachHang WHERE DienThoai like '%" + txtTimKH.Text.Trim() + "%' ");
                dgvKhachHang.DataSource = DataProvider.Instance.ExecuteQuery(qr3);

            }
            else if (cbbFind.Text == "Ngày Sinh")
            {
                string qr4 = (" SELECT*FROM tblKhachHang WHERE NgaySinh like '%" + txtTimKH.Text.Trim() + "%' ");
                dgvKhachHang.DataSource = DataProvider.Instance.ExecuteQuery(qr4);
            }
            else
            {
                string qr5 = (" SELECT*FROM tblKhachHang WHERE DiaChi like '%" + txtTimKH.Text.Trim() + "%' ");
                dgvKhachHang.DataSource = DataProvider.Instance.ExecuteQuery(qr5);
            }
        }

        private void txtTenKhach_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            if (txtTenKhach.Text == "")
            {
                MessageBox.Show("Bạn phải nhập tên khách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenKhach.Focus();
                return;
            }
            else

            {
                string newname = txtTenKhach.Text.Trim().ToLower();
                string kq = newname[0].ToString().ToUpper();
                for (int i = 1; i < newname.Length; i++)
                {

                    if (newname[i] != ' ')
                    {
                        if (newname[i - 1] == ' ')
                        {
                            kq = kq;
                        }
                        else kq = kq + newname[i];
                    }
                    if (newname[i] == ' ')
                    {
                        kq = kq + ' ' + newname[i + 1].ToString().ToUpper();
                    }
                    //else  kq = kq + newname[i];
                }
                txtTenKhach.Text = kq;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
