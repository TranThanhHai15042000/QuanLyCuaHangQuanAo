﻿using FontAwesome.Sharp;
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
//using COMExcel = Microsoft.Office.Interop.Excel;



namespace ShopQuanAo100
{
    public partial class fCTHangTonKho : Form
    {
        DataTable tblH;
        //public fCTHangTonKho()
        //{
        //    InitializeComponent();
        //}


        private IconButton currentBtn;
        private Panel leftBorderBtn;
        public fCTHangTonKho()
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
            }
                catch(Exception )
            {
                MessageBox.Show( "Lỗi");
            }    
            ActivateButton(sender, RGBColors.color5);
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
                     // "',GhiChu=N'" + txtGhiChu.Text.Trim().ToString() +
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
                ActivateButton(sender, RGBColors.color4);

            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string idCTHang = txtMaCTHang.Text.Trim();
            string TenHang = txtTen.Text.Trim();
            string KieuDang = txtKieuDang.Text.Trim();


            string ChatLieu = cbbChatLieu.SelectedValue.ToString();
            string Size = cbbSize.SelectedValue.ToString();


         //   string GhiChu = txtGhiChu.Text.Trim();

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
            //    cmd.Parameters.Add("@GhiChu", GhiChu);
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
               // btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnBoQua.Enabled = false;
                btnLuu.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during update: " + ex.Message);
            }
            ActivateButton(sender, RGBColors.color4);
        }

        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT ct.idCTHang, ct.ten, s.Ten,ct.kieudang,cl.tenChatLieu,ct.anh,ct.Soluong,ct.DonGiaNhap,ct.DonGiaBan,ct.ghichu FROM dbo.tblChatLieu cl JOIN dbo.tblCT_Hang ct ON ct.idChatLieu = cl.idChatLieu JOIN dbo.tblSize s ON s.idSize = ct.idSize WHERE (MONTH(GETDATE()) != MONTH(ct.NgayNhap))";
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


        private void ResetValues()
        {
            txtMaCTHang.Text = "";
            txtTen.Text = "";
            // cboMaChatLieu.Text = "";
            cbbSize.Text  = "";
            txtKieuDang.Text = "";
            cbbChatLieu.Text = "";
            txtSoLuong.Text = "";
            txtDonGiaNhap.Text = "";
            txtDonGiaBan.Text = "";
            picAnh.Image = null;

        }
        private void fCTHangTonKho_Load(object sender, EventArgs e)
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

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string sql;
            if ((txtMaCTHang.Text == "") && (txtTen.Text == "") && (cbbSize.Text == "") && (cbbChatLieu.Text == "") && (txtKieuDang.Text == "") )
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
          
            ActivateButton(sender, RGBColors.color5);
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnBoQua.Enabled = false;
          //  btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtMaCTHang.Enabled = false;
            ActivateButton(sender, RGBColors.color5);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            // creating Excel Application  
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
            // save the application  
            //  workbook.SaveAs("C:\\Users\\lionel\\Desktop\\Test\\output.xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            // Exit from the application  
            //  app.Quit(); 
        }

        private void dgvHang_Click(object sender, EventArgs e)
        {
            string idSize;
            string sql;
           
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
           // txtGhiChu.Text = dgvHang.CurrentRow.Cells["GhiChu"].Value.ToString();


            byte[] Anh = (byte[])dgvHang.CurrentRow.Cells["Anh"].Value;
            picAnh.Image = ByteArrayToImage(Anh);

            txtSoLuong.Text = dgvHang.CurrentRow.Cells["soluong"].Value.ToString();
            txtDonGiaNhap.Text = dgvHang.CurrentRow.Cells["dongianhap"].Value.ToString();
            txtDonGiaBan.Text = dgvHang.CurrentRow.Cells["dongiaban"].Value.ToString();


            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnBoQua.Enabled = true;
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

        string imgloc = "";
        private void btnButtonChooseIMG_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    imgloc = dlg.FileName.ToString();
                    picAnh.ImageLocation = imgloc;
                }
            }
            catch (Exception ex)
            {
                DataProvider.getConnection().Close();
                MessageBox.Show("Error during insert: " + ex.Message);
            }
        }

        private void btnDeleteIMG_Click(object sender, EventArgs e)
        {
            try
            {
                using (var cmd = new SqlCommand("update tblCT_Hang set Anh=null where idCTHang=@idCTHang"))
                {
                    cmd.Connection = DataProvider.getConnection();
                    cmd.Parameters.AddWithValue("@idCTHang", txtMaCTHang.Text);
                    DataProvider.getConnection().Open();
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Đã xóa");
                        ResetValues();
                        LoadDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("Không thành công!");
                    }
                    DataProvider.getConnection().Close();
                }
            }
            catch (Exception ex)
            {
                DataProvider.getConnection().Close();
                MessageBox.Show("Error during insert: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // creating Excel Application  
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
                worksheet.Cells[1, i+3] = dgvHang.Columns[i - 1].HeaderText;
            }
            // storing Each row and column value to excel sheet  
            for (int i = 0; i < dgvHang.Rows.Count; i++)
            {
                for (int j = 0; j < dgvHang.Columns.Count; j++)
                {
                    worksheet.Cells[i + 5, j + 1] = dgvHang.Rows[i].Cells[j].Value.ToString();
                }
            }
            // save the application  
            //  workbook.SaveAs("C:\\Users\\lionel\\Desktop\\Test\\output.xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            // Exit from the application  
            //  app.Quit();
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

        private void txtTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDonGiaNhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDonGiaBan_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtKieuDang_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaCTHang_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbbChatLieu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
