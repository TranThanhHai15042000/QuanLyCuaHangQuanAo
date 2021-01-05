using FontAwesome.Sharp;
using ShopQuanAo100.DAO;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
//using COMExcel = Microsoft.Office.Interop.Excel;

namespace ShopQuanAo100
{
    public partial class fCTHangNKHo : Form
    {
        DataTable tblH;
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        public fCTHangNKHo()
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
            ActivateButton(sender, RGBColors.color4);
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
            cbbChatLieu.Enabled = true;
            cbbSize.Enabled = true;
            txtKieuDang.Enabled = true;
            txtGhiChu.Enabled = true;
            txtSoLuong.Enabled = true;
            txtDonGiaNhap.Enabled = true;
            txtDonGiaBan.Enabled = true;
            ActivateButton(sender, RGBColors.color4);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            try
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
                ActivateButton(sender, RGBColors.color4);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message);
            }
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
            if (cbbChatLieu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập chất liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbbChatLieu.Focus();
                return;
            }

            try
            {

                sql = "UPDATE tblCT_Hang SET Ten=N'" + txtTen.Text.Trim().ToString() +
                    "',idSize=N'" + cbbSize.SelectedValue.ToString() +
                     "',KieuDang=N'" + txtKieuDang.Text.Trim().ToString() +
                    "',idChatLieu=N'" + cbbChatLieu.SelectedValue.ToString() +
                      "',GhiChu=N'" + txtGhiChu.Text.Trim().ToString() +
                          "',Soluong=N'" + txtSoLuong.Text.Trim().ToString() +
                    "',DongiaNhap=N'" + txtDonGiaNhap.Text.Trim().ToString() +
                      "',DongiaBan=N'" + txtDonGiaBan.Text.Trim().ToString() +
                   /* ",Anh=N'" +ImmagetoByteArray(picAnh.Image)+ */"' WHERE idCTHang=N'" + txtMaCTHang.Text + "'";

                //sql = "UPDATE tblKhachHang SET TenKhach=N'" + txtTenKhach.Text.Trim().ToString() + "',DiaChi=N'" +
                //       txtDiaChiKH.Text.Trim().ToString() + "',DienThoai='" + mtbSDTKhach.Text.ToString() + "',NgaySinh=N'" + dateTimeSNKH.Value.ToString() + "' WHERE idKhachHang=N'" + txtMaKhach.Text + "'";
                DataProvider.Instance.ExecuteQuery(sql);
                LoadDataGridView();
                ResetValues();
                btnBoQua.Enabled = false;
                ActivateButton(sender, RGBColors.color4);

            }
            catch (Exception ex )
            {
                MessageBox.Show("Lỗi" + ex.Message);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            string idCTHang = txtMaCTHang.Text.Trim();
            string TenHang = txtTen.Text.Trim();
            string KieuDang = txtKieuDang.Text.Trim();


            string ChatLieu = cbbChatLieu.SelectedValue.ToString();
            string Size = cbbSize.SelectedValue.ToString();


            string GhiChu = txtGhiChu.Text.Trim();
           
            byte[] Anh = ImmagetoByteArray(picAnh.Image);
            string soluong = txtSoLuong.Text.Trim();
            string dongianhap = txtDonGiaNhap.Text.Trim();
            string dongiaban = txtDonGiaBan.Text.Trim();
            string ngaynhap = dtbNgayNhap.Value.ToString();
          //  string day = g

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
            if (cbbChatLieu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập chất liệu hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbbChatLieu.Focus();
                return;
            }

            if (cbbSize.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn size hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbbSize.Focus();
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
                 sql = "INSERT INTO tblCT_Hang VALUES  ( @idcthang ,@Ten ,@idSize , @KieuDang , @idChatLieu ,@GhiChu, @Anh,@soluong,@dongianhap,@dongiaban,@ngaynhap)";
                SqlCommand cmd = new SqlCommand(sql, conn);





                cmd.Parameters.Add("@idcthang", idCTHang);
                cmd.Parameters.Add("@Ten", TenHang);
                cmd.Parameters.Add("@idSize", Size);
                cmd.Parameters.Add("@KieuDang", KieuDang);
                cmd.Parameters.Add("@idChatLieu", ChatLieu);
                cmd.Parameters.Add("@GhiChu", GhiChu);
                cmd.Parameters.Add("@Anh", Anh);

                cmd.Parameters.Add("@soluong", soluong);
                cmd.Parameters.Add("@dongianhap", dongianhap);
                cmd.Parameters.Add("@dongiaban", dongiaban);
                cmd.Parameters.Add("@ngaynhap", ngaynhap);
                cmd.ExecuteNonQuery();
                conn.Close();




              //  DataProvider.Instance.ExecuteQuery(sql);
                LoadDataGridView();
                ResetValues();
                btnXoa.Enabled = true;
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnBoQua.Enabled = false;
                btnLuu.Enabled = false;
                txtMaCTHang.Enabled = false;
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during update: " + ex.Message);
            }
            ActivateButton(sender, RGBColors.color4);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

            string sql;
            if ((txtMaCTHang.Text == "") && (txtTen.Text == "") && (cbbSize.Text == "") && (cbbChatLieu.Text == "") && (txtKieuDang.Text == "") && (txtGhiChu.Text == ""))
            {
                MessageBox.Show("Bạn hãy nhập điều kiện tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "SELECT * from tblCT_Hang WHERE  1=1";
            if (txtMaCTHang.Text != "")
                sql += "  And idCTHang LIKE N'%" + txtMaCTHang.Text + "%'";
            if (txtTen.Text != "")
                sql += " AND Ten LIKE N'%" + txtTen.Text + "%'";
            if (cbbSize.Text != "")
                sql += " AND idSize LIKE N'%" + cbbSize.SelectedValue.ToString() + "%'";
            if (txtKieuDang.Text != "")
                sql += " AND KieuDang LIKE N'%" + txtKieuDang.Text + "%'";
            if (cbbChatLieu.Text != "")
                sql += " AND idChatLieu LIKE N'%" + cbbChatLieu.SelectedValue.ToString() + "%'";
            if (txtGhiChu.Text != "")
                sql += " AND GhiChu LIKE N'%" + txtGhiChu.Text + "%'";
            

            tblH = DAO_CTHang.GetDataToTable(sql);
           // dgvHang.DataSource = DataProvider.Instance.ExecuteQuery(sql);
            if (tblH.Rows.Count == 0)
                MessageBox.Show("Không có bản ghi thoả mãn điều kiện tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Có " + tblH.Rows.Count + "  bản ghi thoả mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvHang.DataSource = tblH;
            ResetValues();
            ActivateButton(sender, RGBColors.color4);
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {

            LoadDataGridView();
            ActivateButton(sender, RGBColors.color4);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            ActivateButton(sender, RGBColors.color4);
        }

        private void dgvHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT ct.idCTHang, ct.ten, s.Ten,ct.kieudang,cl.tenChatLieu,ct.anh,ct.Soluong,ct.DonGiaNhap,ct.DonGiaBan,ct.ghichu FROM dbo.tblChatLieu cl JOIN dbo.tblCT_Hang ct ON ct.idChatLieu = cl.idChatLieu JOIN dbo.tblSize s ON s.idSize = ct.idSize WHERE (MONTH(GETDATE()) = MONTH(ct.NgayNhap)) ";
            tblH = DataProvider.Instance.ExecuteQuery(sql); 
            tblH = DataProvider.Instance.ExecuteQuery(sql);
            dgvHang.DataSource = tblH;
            dgvHang.Columns[0].HeaderText = "Mã hàng";
            dgvHang.Columns[1].HeaderText = "Tên hàng";
            dgvHang.Columns[2].HeaderText = "Size";
            dgvHang.Columns[3].HeaderText = "Kiểu Dáng";
            dgvHang.Columns[4].HeaderText = "Chất Liệu";
          
            dgvHang.Columns[5].HeaderText = "Ảnh";
            dgvHang.Columns[6].HeaderText = "Số Lượng";
            dgvHang.Columns[7].HeaderText = "Đơn giá nhập";
            dgvHang.Columns[8].HeaderText = "Đơn giá bán";
            dgvHang.Columns[9].HeaderText = "Ghi chú";
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
         

            // lấy dữ liệu size
            DataTable size = DAO_Bill.GetData("SELECT idSize, Ten FROM tblSize");
            cbbSize.DataSource = size;
            cbbSize.DisplayMember = "Ten";
            cbbSize.ValueMember = "idSize";

            // lấy dữ liệu chất liệu
            DataTable chatlieu = DAO_Bill.GetData("SELECT idChatLieu, tenChatLieu FROM tblChatlieu");
            cbbChatLieu.DataSource = chatlieu;
            cbbChatLieu.DisplayMember = "tenChatLieu";
            cbbChatLieu.ValueMember = "idChatLieu";

       

            LoadDataGridView();

            ResetValues();
        }


        private void ResetValues()
        {
            txtMaCTHang.Text = "";
            txtTen.Text = "";
            // cboMaChatLieu.Text = "";
            cbbSize.Text = "";
            txtKieuDang.Text = "";
            cbbChatLieu.Text = "";
            txtGhiChu.Text = "";
            txtSoLuong.Text = "";
            txtDonGiaNhap.Text = "";
            txtDonGiaBan.Text = "";
            picAnh.Image = null;

        }
      
        Image ByteArrayToImage(byte[] b)
        {
            MemoryStream m = new MemoryStream(b);
            return Image.FromStream(m);
        }



        byte[] ImmagetoByteArray(Image img)
        {
            MemoryStream m = new MemoryStream();
            if (picAnh.Image!=null)
            {
              
                img.Save(m, System.Drawing.Imaging.ImageFormat.Jpeg);
                
            }
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
            cbbChatLieu.Text = dgvHang.CurrentRow.Cells["TenChatLieu"].Value.ToString();
            cbbSize.Text = dgvHang.CurrentRow.Cells["Ten1"].Value.ToString();
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

        private void picAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                picAnh.Image = Image.FromFile(open.FileName);
                this.Text = open.FileName;
            }
        }
     

        private void iconButton1_Click(object sender, EventArgs e)
        {
            //COMExcel.Application exApp = new COMExcel.Application();
            //COMExcel.Workbook exBook; //Trong 1 chương trình Excel có nhiều Workbook
            //COMExcel.Worksheet exSheet; //Trong 1 Workbook có nhiều Worksheet
            //COMExcel.Range exRange;
            //string sql;
            //int hang = 0, cot = 0;
            //DataTable tblThongtinHD, tblThongtinHang;
            //exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
            //exSheet = exBook.Worksheets[1];
            //// Định dạng chung
            //exRange = exSheet.Cells[1, 1];
            //exRange.Range["A1:Z300"].Font.Name = "Times new roman"; //Font chữ
            //exRange.Range["A1:B3"].Font.Size = 10;
            //exRange.Range["A1:B3"].Font.Bold = true;
            //exRange.Range["A1:B3"].Font.ColorIndex = 5; //Màu xanh da trời
            //exRange.Range["A1:A1"].ColumnWidth = 7;
            //exRange.Range["B1:B1"].ColumnWidth = 15;
            //exRange.Range["A1:B1"].MergeCells = true;
            //exRange.Range["A1:B1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            //exRange.Range["A1:B1"].Value = "THE MR.SIMPLE SYTLE.";
            //exRange.Range["A2:B2"].MergeCells = true;
            //exRange.Range["A2:B2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            //exRange.Range["A2:B2"].Value = "27 - LÝ TỰ TRONG - QUẬN 1 - TPHCM";
            //exRange.Range["A3:B3"].MergeCells = true;
            //exRange.Range["A3:B3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            //exRange.Range["A3:B3"].Value = "Điện thoại: (+84)987644753";
            //exRange.Range["C2:E2"].Font.Size = 16;
            //exRange.Range["C2:E2"].Font.Bold = true;
            //exRange.Range["C2:E2"].Font.ColorIndex = 3; //Màu đỏ
            //exRange.Range["C2:E2"].MergeCells = true;
            //exRange.Range["C2:E2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            //exRange.Range["C2:E2"].Value = "HÓA ĐƠN BÁN";
            //// Biểu diễn thông tin chung của nhân viên
            //sql = "SELECT idnhanvien, tennv,dienthoai FROM dbo.tblNhanVien  ";
            //tblThongtinHD = DAO_Bill.GetDataToTable(sql);
            //exRange.Range["B6:C9"].Font.Size = 12;
            //exRange.Range["B6:B6"].Value = "Mã nhân viên:";
            //exRange.Range["C6:E6"].MergeCells = true;
            //exRange.Range["C6:E6"].Value = tblThongtinHD.Rows[0][1].ToString();
            //exRange.Range["B7:B7"].Value = "Tên nhân viên:";
            //exRange.Range["C7:E7"].MergeCells = true;
            //exRange.Range["C7:E7"].Value = tblThongtinHD.Rows[0][3].ToString();
            //exRange.Range["B8:B8"].Value = "Điện thoại:";
            //exRange.Range["C8:E8"].MergeCells = true;
            //exRange.Range["C8:E8"].Value = tblThongtinHD.Rows[0][4].ToString();
           
            ////Lấy thông tin các mặt hàng
            //sql = "SELECT * from tblCT_Hang";
            //tblThongtinHang = DAO_Bill.GetDataToTable(sql);
            ////Tạo dòng tiêu đề bảng
            //exRange.Range["A11:F11"].Font.Bold = true;
            //exRange.Range["A11:F11"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            //exRange.Range["C11:F11"].ColumnWidth = 12;
            //exRange.Range["A11:A11"].Value = "STT";
            //exRange.Range["B11:B11"].Value = "Mã hàng";
            //exRange.Range["C11:C11"].Value = "Tên hàng";
            //exRange.Range["D11:D11"].Value = "Size";
            //exRange.Range["E11:E11"].Value = "Số lượng";
            //exRange.Range["F11:F11"].Value = "Đơn giá";
            //exRange.Range["G11:G11"].Value = "Đơn giá bán";
            //exRange.Range["H11:H11"].Value = "Thành tiền";
            //exRange.Range["I11:I11"].Value = "Kiểu dáng";
            //exRange.Range["K11:K11"].Value = "Chất liệu";
           
          

           
            //for (hang = 0; hang < tblThongtinHang.Rows.Count; hang++)
            //{
            //    //Điền số thứ tự vào cột 1 từ dòng 12
            //    exSheet.Cells[1][hang + 12] = hang + 1;
            //    for (cot = 0; cot < tblThongtinHang.Columns.Count; cot++)
            //    //Điền thông tin hàng từ cột thứ 2, dòng 12
            //    {
            //        exSheet.Cells[cot + 2][hang + 12] = tblThongtinHang.Rows[hang][cot].ToString();
            //        if (cot == 3) exSheet.Cells[cot + 2][hang + 12] = tblThongtinHang.Rows[hang][cot].ToString() + "%";
            //    }
            //}
            //exRange = exSheet.Cells[cot][hang + 14];
            //exRange.Font.Bold = true;
            //exRange.Value2 = "Tổng tiền:";
            //exRange = exSheet.Cells[cot + 1][hang + 14];
            //exRange.Font.Bold = true;
            //exRange.Value2 = tblThongtinHD.Rows[0][2].ToString();
            //exRange = exSheet.Cells[1][hang + 15]; //Ô A1 
            //exRange.Range["A1:F1"].MergeCells = true;
            //exRange.Range["A1:F1"].Font.Bold = true;
            //exRange.Range["A1:F1"].Font.Italic = true;
            //exRange.Range["A1:F1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignRight;
            //exRange.Range["A1:F1"].Value = "Bằng chữ: " + DAO_Bill.ChuyenSoSangChu(double.Parse(tblThongtinHD.Rows[0][2].ToString()));
            //exRange = exSheet.Cells[4][hang + 17]; //Ô A1 
            //exRange.Range["A1:C1"].MergeCells = true;
            //exRange.Range["A1:C1"].Font.Italic = true;
            //exRange.Range["A1:C1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            //DateTime d = Convert.ToDateTime(tblThongtinHD.Rows[0][1]);
            //exRange.Range["A1:C1"].Value = "TPHCM, ngày " + d.Day + " tháng " + d.Month + " năm " + d.Year;
            //exRange.Range["A2:C2"].MergeCells = true;
            //exRange.Range["A2:C2"].Font.Italic = true;
            //exRange.Range["A2:C2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            //exRange.Range["A2:C2"].Value = "Nhân viên bán hàng";
            //exRange.Range["A6:C6"].MergeCells = true;
            //exRange.Range["A6:C6"].Font.Italic = true;
            //exRange.Range["A6:C6"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            //exRange.Range["A6:C6"].Value = tblThongtinHD.Rows[0][6];
            //exSheet.Name = "Hóa đơn nhập";
            //exApp.Visible = true;
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            // creating new WorkBook within Excel application  
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            // creating new Excelsheet in workbook  
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            // see the excel sheet behind the program  
            app.Visible = true;
            // get the reference of first sheet. By default its name is Sheet1.  
            // store its reference to worksheet  
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            // changing the name of active sheet  
            worksheet.Name = "Exported from gridview";
            // storing header part in Excel  
            for (int i = 1; i < dgvHang.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dgvHang.Columns[i - 1].HeaderText;
            }
            // storing Each row and column value to excel sheet  
            for (int i = 0; i < dgvHang.Rows.Count; i++)
            {
                for (int j = 0; j < dgvHang.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dgvHang.Rows[i].Cells[j].Value.ToString();
                }
            }
        }

        string imglogoloc = "";
        private void button1_Click(object sender, EventArgs e)
        {
         

            try
            {
                byte[] img = null;
                FileStream fs = new FileStream(imglogoloc, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                img = br.ReadBytes((int)fs.Length);
                string sql = "update tblCT_Hang set anh = @anh where ID = " + txtMaCTHang.Text;
                using (var cmd = new SqlCommand("sql"))
                {
                    cmd.Connection = DataProvider.getConnection(); 
                    cmd.Parameters.AddWithValue("@logo", img);
                    DataProvider.getConnection().Open();
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Đã lưu");
                    }
                    else
                    {
                        MessageBox.Show("Lưu không thành công!");
                    }
                    DataProvider.getConnection().Close();
                }
            }
            catch (Exception ex)
            {
                DataProvider.getConnection().Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void txtTen_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtDonGiaNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtDonGiaBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
