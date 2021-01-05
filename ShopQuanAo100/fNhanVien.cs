using FontAwesome.Sharp;
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
    public partial class fNhanVien : Form
    {

        DataTable tblNV;
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        public fNhanVien()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 90);
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
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
        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void iconButton4_Click(object sender, EventArgs e)
        {

            ResetValues();
            btnBoQua.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtMaNV.Enabled = false;
            ActivateButton(sender, RGBColors.color6);
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMaNV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaNV.Focus();
                return;
            }
            if (txtTenNV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenNV.Focus();
                return;
            }
            if (txtDiaChiNV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDiaChiNV.Focus();
                return;
            }
            if (mtbSDTNV.Text == "(   )    -") // mặc định của trường masktextNumber
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mtbSDTNV.Focus();
                return;
            }
            if (rdbNam.Checked == false && rdbNu.Checked == false)
            {
                MessageBox.Show("Bạn chưa chọn giới tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTk.Text == "") // mặc định của trường masktextNumber
            {
                MessageBox.Show("Bạn phải nhập tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTk.Focus();
                return;
            }
            if (txtMK.Text == "") { 
                MessageBox.Show("Bạn phải nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMK.Focus();
                return;
            }
            try
            {
                //Kiểm tra tồn tại mã khách 
                sql = "SELECT iDNhanVien FROM tblNhanVien WHERE iDNhanVien=N'" + txtMaNV.Text.Trim() + "'";
                if (DAO_KhachHang.CheckKey(sql))
                {
                    MessageBox.Show("Mã khách này đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMaNV.Focus();
                    return;
                }

                sql = "SELECT Users FROM tblNhanVien WHERE iDNhanVien=N'" + txtTk.Text.Trim() + "'";
                if (DAO_KhachHang.CheckKey(sql))
                {
                    MessageBox.Show("Tài khoản nhân viên này đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMaNV.Focus();
                    return;
                }
                string strGioiTinh = rdbGioiTinh();

                //Chèn thêm
                sql = "INSERT INTO dbo.tblNhanVien ( iDNhanVien ,TenNV , GioiTinh ,DiaChi ,  DienThoai ,NgaySinh ,Users,pass ) VALUES (N'" + txtMaNV.Text.Trim() + "',N'" + txtTenNV.Text.Trim() + "',N'" + strGioiTinh + "',N'" + txtDiaChiNV.Text.Trim() + "','" + mtbSDTNV.Text + "',N'" + datetimeNV.Value.ToString() + "','"+ txtTk.Text+ "','"+txtMK.Text+"')";
                //Functions.RunSQL(sql);

                DataProvider.Instance.ExecuteQuery(sql);
                LoadDataGridView();
                ResetValues();

                btnXoa.Enabled = true;
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnBoQua.Enabled = false;
                btnLuu.Enabled = false;
                txtMaNV.Enabled = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm thất bại", "Thông báo");
            }
            ActivateButton(sender, RGBColors.color5);
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

            string sql;
            if (tblNV.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaNV.Text == "")
            {
                MessageBox.Show("Bạn phải chọn bản ghi cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenNV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên khách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenNV.Focus();
                return;
            }
            if (txtDiaChiNV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDiaChiNV.Focus();
                return;
            }
            if (mtbSDTNV.Text == "(  )    -")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mtbSDTNV.Focus();
                return;
            }
            if (datetimeNV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                datetimeNV.Focus();
                return;
            }
            try
            {

                sql = "SELECT Users FROM tblNhanVien WHERE iDNhanVien=N'" + txtTk.Text.Trim() + "'";
                if (DAO_KhachHang.CheckKey(sql))
                {
                    MessageBox.Show("Tài khoản nhân viên này đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMaNV.Focus();
                    return;
                }
                sql = "UPDATE tblNhanVien SET TenNV=N'" + txtTenNV.Text.Trim().ToString() + "',GioiTinh=N'" +
                rdbGioiTinh() + "',DiaChi=N'" + txtDiaChiNV.Text.Trim().ToString() + "',DienThoai='" + mtbSDTNV.Text.ToString() + "',NgaySinh=N'" + datetimeNV.Value.ToString() + "',Users= '"+txtTk.Text+ "',pass='"+txtMK.Text +"' WHERE idNhanVien=N'" + txtMaNV.Text + "'";
                DataProvider.Instance.ExecuteQuery(sql);
                LoadDataGridView();
                ResetValues();
                btnBoQua.Enabled = false;

            }
            catch (Exception)
            {
                MessageBox.Show("Sửa thất bại", "Thông báo");
            }
            ActivateButton(sender, RGBColors.color4);
        }

        private string rdbGioiTinh()
        {
            string str = "";
            if (rdbNam.Checked == true)
            {
                str = "Nam";
            }
            if (rdbNu.Checked == true)
            {
                str = "Nữ";
            }
            return str;
        }



        private void iconButton5_Click(object sender, EventArgs e)
        {

          
                this.Close();
    
            ActivateButton(sender, RGBColors.color3);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblNV.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaNV.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                if (MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    sql = "DELETE tblNhanVien WHERE idNhanVien=N'" + txtMaNV.Text + "'";
                    DataProvider.Instance.ExecuteQuery(sql);
                    LoadDataGridView();
                    ResetValues();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Xóa thất bại", "Thông báo");
            }
            ActivateButton(sender, RGBColors.color2);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thêm thông tin nhân viên", "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnBoQua.Enabled = true;
                btnLuu.Enabled = true;
                btnThem.Enabled = false;
                txtTk.Text = "";
                txtMK.Text = "";
                ResetValues();
                txtMaNV.Enabled = true;
                txtMaNV.Focus();
            }
            ActivateButton(sender, RGBColors.color1);
        }

        private void ResetValues()
        {
            txtMaNV.Text = "";
            txtTenNV.Text = "";
            txtDiaChiNV.Text = "";
            mtbSDTNV.Text = "";
        }
        private void fNhanVien_Load(object sender, EventArgs e)
        {
            txtMaNV.Enabled = false;
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
            LoadDataGridView();
        }
        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT * FROM dbo.tblNhanVien EXCEPT SELECT* FROM dbo.tblNhanVien WHERE Users = 'admin'";
            tblNV = DataProvider.Instance.ExecuteQuery(sql);
            dgvNhanVien.DataSource = tblNV; //Hiển thị vào dataGridView
            dgvNhanVien.Columns[0].HeaderText = "ID";
            dgvNhanVien.Columns[1].HeaderText = "Tên Nhân viên";
            dgvNhanVien.Columns[2].HeaderText = "Giới tính";
            dgvNhanVien.Columns[3].HeaderText = "Địa chỉ";
            dgvNhanVien.Columns[4].HeaderText = "Điện thoại";
            dgvNhanVien.Columns[5].HeaderText = "Ngày sinh";
            dgvNhanVien.Columns[0].Width = 20;
            dgvNhanVien.Columns[1].Width = 130;
            dgvNhanVien.Columns[2].Width = 70;
            dgvNhanVien.Columns[3].Width = 200;
            dgvNhanVien.Columns[4].Width = 150;
            dgvNhanVien.Columns[5].Width = 300;
            dgvNhanVien.AllowUserToAddRows = false;                 // Không cho người dùng thêm dữ liệu trực tiếp
            dgvNhanVien.EditMode = DataGridViewEditMode.EditProgrammatically;   //Không cho sửa dữ liệu trực tiếp
        }

        private void dgvNhanVien_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaNV.Focus();
                return;
            }
            if (tblNV.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaNV.Text = dgvNhanVien.CurrentRow.Cells["idNhanVien"].Value.ToString();
            txtTenNV.Text = dgvNhanVien.CurrentRow.Cells["TenNV"].Value.ToString();
            if (dgvNhanVien.CurrentRow.Cells["GioiTinh"].Value.ToString() == "Nam") rdbNam.Checked = true;
            else rdbNu.Checked = true;
            txtDiaChiNV.Text = dgvNhanVien.CurrentRow.Cells["DiaChi"].Value.ToString();
            mtbSDTNV.Text = dgvNhanVien.CurrentRow.Cells["DienThoai"].Value.ToString();
            datetimeNV.Text = dgvNhanVien.CurrentRow.Cells["NgaySinh"].Value.ToString();
            txtTk.Text = dgvNhanVien.CurrentRow.Cells["Users"].Value.ToString();
            txtMK.Text = dgvNhanVien.CurrentRow.Cells["pass"].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void txtTenNV_TextChanged(object sender, EventArgs e)
        {
            //e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

       

        private void txtTenNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void btnChuanTen_Click(object sender, EventArgs e)
        {

           
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            string sql;
            sql = "SELECT * FROM tblNhanVien";
            tblNV = DAO_CTHang.GetDataToTable(sql);
            dgvNhanVien.DataSource = tblNV;
            ActivateButton(sender, RGBColors.color3);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnBoQua.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtMaNV.Enabled = false;
        }

        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {

        }

        private void mtbSDTNV_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnChuanTen_Click_1(object sender, EventArgs e)
        {
            if (txtTenNV.Text == "")
            {
                MessageBox.Show("Bạn phải nhập tên khách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenNV.Focus();
                return;
            }
            {
                string newname = txtTenNV.Text.Trim().ToLower();
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
                txtTenNV.Text = kq;
            }
        }

        private void txtTenNV_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtTimNV_TextChanged_1(object sender, EventArgs e)
        {
            if (cbbFind.Text == "Mã nhân viên")
            {
                string qr1 = (" SELECT * FROM tblNhanVien WHERE idNhanVien like '%" + txtTimNV.Text.Trim() + "%' ");
                dgvNhanVien.DataSource = DataProvider.Instance.ExecuteQuery(qr1);

            }
            else if (cbbFind.Text == "Tên nhân viên")
            {
                string qr2 = (" SELECT*FROM tblNhanVien WHERE TenNV like '%" + txtTimNV.Text.Trim() + "%' ");
                dgvNhanVien.DataSource = DataProvider.Instance.ExecuteQuery(qr2);
            }
            else if (cbbFind.Text == "Số điện thoại")
            {
                string qr3 = (" SELECT * FROM tblNhanVien WHERE DienThoai like '%" + txtTimNV.Text.Trim() + "%' ");
                dgvNhanVien.DataSource = DataProvider.Instance.ExecuteQuery(qr3);

            }
            else if (cbbFind.Text == "Ngày sinh")
            {
                string qr4 = (" SELECT*FROM tblNhanVien WHERE NgaySinh like '%" + txtTimNV.Text.Trim() + "%' ");
                dgvNhanVien.DataSource = DataProvider.Instance.ExecuteQuery(qr4);
            }
            else if (cbbFind.Text == "Địa chỉ")
            {
                string qr5 = (" SELECT*FROM tblNhanVien WHERE DiaChi like '%" + txtTimNV.Text.Trim() + "%' ");
                dgvNhanVien.DataSource = DataProvider.Instance.ExecuteQuery(qr5);
            }
        }
    }
 }

