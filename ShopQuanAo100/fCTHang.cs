using FontAwesome.Sharp;
using ShopQuanAo100.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopQuanAo100
{
    public partial class fCTHang : Form
    {
        DataTable tblH;
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        public fCTHang()
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {

            ResetValues();
            btnBoQua.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtMaCTHang.Enabled = false;
            ActivateButton(sender, RGBColors.color1);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoQua.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValues();
            txtMaCTHang.Enabled = true;
            txtMaCTHang.Focus();
            txtTen.Enabled = true;
            txtChatLieu.Enabled = true;
            txtKieuDang.Enabled = true;
            txtGhiChu.Enabled = true;
            txtSoLuong.Enabled = true;
            txtDonGiaNhap.Enabled = true;
            txtDonGiaBan.Enabled = true;
            ActivateButton(sender, RGBColors.color4);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            string sql;
            if (tblH.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaCTHang.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá bản ghi này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE tblCT_Hang WHERE idCTHang=N'" + txtMaCTHang.Text + "'";
                DataProvider.Instance.ExecuteQuery(sql);
                LoadDataGridView();
                ResetValues();
            }
            ActivateButton(sender, RGBColors.color2);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            string sql;
            if (tblH.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaCTHang.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaCTHang.Focus();
                return;
            }
            if (txtTen.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTen.Focus();
                return;
            }
            if (txtChatLieu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập chất liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtChatLieu.Focus();
                return;
            }


            sql = "UPDATE tblCT_Hang SET Ten=N'" + txtTen.Text.Trim().ToString() +
                "',Size=N'" + txtSize.Text.Trim().ToString() +
                 "',KieuDang=N'" + txtKieuDang.Text.Trim().ToString() +
                "',ChatLieu=N'" + txtChatLieu.Text.Trim().ToString() +
                  "',GhiChu=N'" + txtGhiChu.Text.Trim().ToString() +
                      "',Soluong=N'" + txtSoLuong.Text.Trim().ToString() +
                "',DongiaNhap=N'" + txtDonGiaNhap.Text.Trim().ToString() +
                  "',DongiaBan=N'" + txtDonGiaBan.Text.Trim().ToString() +
              /*  ",Anh=N'" + txtAnh.Text + */ "' WHERE idCTHang=N'" + txtMaCTHang.Text + "'";

            //sql = "UPDATE tblKhachHang SET TenKhach=N'" + txtTenKhach.Text.Trim().ToString() + "',DiaChi=N'" +
            //       txtDiaChiKH.Text.Trim().ToString() + "',DienThoai='" + mtbSDTKhach.Text.ToString() + "',NgaySinh=N'" + dateTimeSNKH.Value.ToString() + "' WHERE idKhachHang=N'" + txtMaKhach.Text + "'";
            DataProvider.Instance.ExecuteQuery(sql);
            LoadDataGridView();
            ResetValues();
            btnBoQua.Enabled = false;
            ActivateButton(sender, RGBColors.color3);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            string idCTHang = txtMaCTHang.Text.Trim();
            string TenHang = txtTen.Text.Trim();
            string KieuDang = txtKieuDang.Text.Trim();
            string ChatLieu = txtChatLieu.Text.Trim();
            string GhiChu = txtGhiChu.Text.Trim();
            string Size = txtSize.Text.Trim();
            byte[] Anh = ImmagetoByteArray(picAnh.Image);
            string soluong = txtSoLuong.Text.Trim();
            string dongianhap = txtDonGiaNhap.Text.Trim();
            string dongiaban = txtDonGiaBan.Text.Trim();

            if (txtMaCTHang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaCTHang.Focus();
                return;
            }
            if (txtTen.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTen.Focus();
                return;
            }
            if (txtKieuDang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập kiểu dáng của hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtKieuDang.Focus();
                return;
            }
            if (txtChatLieu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập chất liệu hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtChatLieu.Focus();
                return;
            }

            if (txtSize.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn size hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSize.Focus();
                return;
            }
            if (txtSoLuong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaCTHang.Focus();
                return;
            }
            if (txtDonGiaNhap.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTen.Focus();
                return;
            }
            if (txtDonGiaBan.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập kiểu dáng của hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtKieuDang.Focus();
                return;
            }
            if (picAnh.Image == null)
            {
                MessageBox.Show("Bạn phải chọn ảnh cho hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtKieuDang.Focus();
                return;
            }


            string sql;
            try
            {
                sql = "SELECT idcthang FROM tblCT_Hang WHERE idcthang=N'" + txtMaCTHang.Text.Trim() + "'";
                if (DAO_CTHang.CheckKey(sql))
                {
                    MessageBox.Show("Mã hàng này đã tồn tại, bạn phải chọn mã hàng khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMaCTHang.Focus();
                    return;
                }

                SqlConnection conn = DataProvider.getConnection();
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO tblCT_Hang VALUES  ( @idcthang ,@Ten ,@Size , @KieuDang , @ChatLieu ,@GhiChu, @Anh,@soluong,@dongianhap,@dongiaban)", conn);





                cmd.Parameters.Add("@idcthang", idCTHang);
                cmd.Parameters.Add("@Ten", TenHang);
                cmd.Parameters.Add("@Size", Size);
                cmd.Parameters.Add("@KieuDang", KieuDang);
                cmd.Parameters.Add("@ChatLieu", ChatLieu);
                cmd.Parameters.Add("@GhiChu", GhiChu);
                cmd.Parameters.Add("@Anh", Anh);

                cmd.Parameters.Add("@soluong", soluong);
                cmd.Parameters.Add("@dongianhap", dongianhap);
                cmd.Parameters.Add("@dongiaban", dongiaban);
                cmd.ExecuteNonQuery();
                conn.Close();




                DataProvider.Instance.ExecuteQuery(sql);
                LoadDataGridView();
                //ResetValues();
                btnXoa.Enabled = true;
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnBoQua.Enabled = false;
                btnLuu.Enabled = false;
                txtTen.Enabled = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Exception");
            }
            ActivateButton(sender, RGBColors.color4);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

            string sql;
            if ((txtMaCTHang.Text == "") && (txtTen.Text == "") && (txtSize.Text == "") && (txtChatLieu.Text == "") && (txtKieuDang.Text == "") && (txtGhiChu.Text == ""))
            {
                MessageBox.Show("Bạn hãy nhập điều kiện tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "SELECT * from tblCT_Hang WHERE  1=1";
            if (txtMaCTHang.Text != "")
                sql += "  And idCTHang LIKE N'%" + txtMaCTHang.Text + "%'";
            if (txtTen.Text != "")
                sql += " AND Ten LIKE N'%" + txtTen.Text + "%'";
            if (txtSize.Text != "")
                sql += " AND Size LIKE N'%" + txtSize.Text + "%'";
            if (txtKieuDang.Text != "")
                sql += " AND KieuDang LIKE N'%" + txtKieuDang.Text + "%'";
            if (txtChatLieu.Text != "")
                sql += " AND ChatLieu LIKE N'%" + txtChatLieu.Text + "%'";
            if (txtGhiChu.Text != "")
                sql += " AND GhiChu LIKE N'%" + txtGhiChu.Text + "%'";


            tblH = DAO_CTHang.GetDataToTable(sql);
           // dgvHang.DataSource = DataProvider.Instance.ExecuteQuery(sql);
            if (tblH.Rows.Count == 0)
                MessageBox.Show("Không có bản ghi thoả mãn điều kiện tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Có " + tblH.Rows.Count + "  bản ghi thoả mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvHang.DataSource = tblH;
            ResetValues();
            ActivateButton(sender, RGBColors.color5);
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {

            string sql;
            sql = "SELECT * FROM tblCT_Hang";
            tblH = DAO_CTHang.GetDataToTable(sql);
            dgvHang.DataSource = tblH;
            ActivateButton(sender, RGBColors.color6);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color7);
        }

        private void dgvHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
            dgvHang.Columns[5].HeaderText = "Ghi Chú";
            dgvHang.Columns[6].HeaderText = "Ảnh";
            dgvHang.Columns[7].HeaderText = "Số Lượng";
            dgvHang.Columns[8].HeaderText = "Đơn giá nhập";
            dgvHang.Columns[9].HeaderText = "Đơn giá bán";
            dgvHang.Columns[0].Width = 80;
            dgvHang.Columns[1].Width = 100;
            dgvHang.Columns[2].Width = 80;
            dgvHang.Columns[3].Width = 80;
            dgvHang.Columns[4].Width = 100;
            dgvHang.Columns[5].Width = 100;
            dgvHang.Columns[6].Width = 100;
            dgvHang.Columns[7].Width = 100;
            dgvHang.Columns[8].Width = 100;
            dgvHang.Columns[9].Width = 100;

            dgvHang.AllowUserToAddRows = false;
            dgvHang.EditMode = DataGridViewEditMode.EditProgrammatically;


        }

        private void fCTHang_Load(object sender, EventArgs e)
        {
            txtMaCTHang.Enabled = false;
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
            //   txtGhiChu.Enabled = false;
            LoadDataGridView();
            ResetValues();
        }


        private void ResetValues()
        {
            txtMaCTHang.Text = "";
            txtTen.Text = "";
            // cboMaChatLieu.Text = "";
            txtSize.Text = "";
            txtKieuDang.Text = "";
            txtChatLieu.Text = "";
            txtGhiChu.Text = "";
            txtSoLuong.Text = "";
            txtDonGiaNhap.Text = "";
            txtDonGiaBan.Text = "";
            picAnh.Image = null;

        }
        private void picAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                picAnh.Image = Image.FromFile(open.FileName);
                this.Text = open.FileName;
            }
        }

        Image ByteArrayToImage(byte[] b)
        {
            MemoryStream m = new MemoryStream(b);
            return Image.FromStream(m);
        }



        byte[] ImmagetoByteArray(Image img)
        {
            MemoryStream m = new MemoryStream();
            img.Save(m, System.Drawing.Imaging.ImageFormat.Jpeg);
            return m.ToArray();
        }

        private void dgvHang_Click(object sender, EventArgs e)
        {
            string idSize;
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
            txtKieuDang.Text = dgvHang.CurrentRow.Cells["KieuDang"].Value.ToString();
            txtChatLieu.Text = dgvHang.CurrentRow.Cells["ChatLieu"].Value.ToString();
            txtSize.Text = dgvHang.CurrentRow.Cells["Size"].Value.ToString();
            txtGhiChu.Text = dgvHang.CurrentRow.Cells["GhiChu"].Value.ToString();


            byte[] Anh = (byte[])dgvHang.CurrentRow.Cells["Anh"].Value;
            picAnh.Image = ByteArrayToImage(Anh);

            txtSoLuong.Text = dgvHang.CurrentRow.Cells["soluong"].Value.ToString();
            txtDonGiaNhap.Text = dgvHang.CurrentRow.Cells["dongianhap"].Value.ToString();
            txtDonGiaBan.Text = dgvHang.CurrentRow.Cells["dongiaban"].Value.ToString();


            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnBoQua.Enabled = true;
        }
    }
}
