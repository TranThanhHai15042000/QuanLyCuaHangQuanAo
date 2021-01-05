using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Microsoft.Office.Interop.Excel;
using ShopQuanAo100.DAO;
using COMExcel = Microsoft.Office.Interop.Excel;

namespace ShopQuanAo100
{
    public partial class fBill : Form
    {
        DataTable tblCTHDB;

        public static string thanhtoan = "";//nut Tính tiền chuyển tạm thời cho form TT
        public static string IDhoadon = "";
        public static string HDmasp = "";
        public static string HDtensp = "";
        public static string HDdongia = "";
        public static string HDsl = "";
        public static string HDloai = "";
        //  public static string HDthanhtoan = "";
        public static string HDdonvi = "";
        public static string SDT = "";
        public static string TenKH = "";


        public fBill()
        {
            InitializeComponent();


        }

        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT a.idCTHang, b.Ten, a.SoLuong, b.DonGiaBan, a.GiamGia,a.ThanhTien FROM tblCT_HoaDon AS a, tblCT_Hang AS b WHERE a.idHoaDon = N'" + txtMaHoaDon.Text + "' AND a.idCTHang=b.idCTHang";
            tblCTHDB = DataProvider.Instance.ExecuteQuery(sql);
            dgvHoaDon.DataSource = tblCTHDB;
            dgvHoaDon.Columns[0].HeaderText = "Mã hàng";
            dgvHoaDon.Columns[1].HeaderText = "Tên hàng";
            dgvHoaDon.Columns[2].HeaderText = "Số lượng";
            dgvHoaDon.Columns[3].HeaderText = "Đơn giá";
            dgvHoaDon.Columns[4].HeaderText = "Giảm giá %";
            dgvHoaDon.Columns[5].HeaderText = "Thành tiền";
            dgvHoaDon.Columns[0].Width = 80;
            dgvHoaDon.Columns[1].Width = 130;
            dgvHoaDon.Columns[2].Width = 100;
            dgvHoaDon.Columns[3].Width = 100;
            dgvHoaDon.Columns[4].Width = 100;
            dgvHoaDon.Columns[5].Width = 160;
            dgvHoaDon.AllowUserToAddRows = false;
            dgvHoaDon.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        public void clearsp()
        {
            txtTenSP.Text = "";
            txtsoluongsp.Text = "";
            txtDonGiaSP.Text = "";
            txtgiamphantramsp.Text = "";
            txtThanhTien.Text = "";
            txtchatlieu.Text = "";
            txtSize.Text = "";

            cbbMaSP.Text = "";
            cbbSDTKH.Text = "";


        }
        public void huyhd()
        {
            txtTenKH.Clear();
            cbbSDTKH.Text = "";
            txtTenSP.Clear();
            cbbMaSP.Text = "";
            txtsoluongsp.Clear();
            txtDonGiaSP.Clear();
            txtgiamphantramsp.Clear();
            txtThanhTien.Clear();
            //cbbSize.SelectedItem = null;
            //cbbSize.Text = null;
            txtSize.Text = "";
            txtchatlieu.Text = "";
            txtTongTien.Clear();
            txtgiamtientong.Clear();
            txtgiamphantramtong.Clear();
            txtthanhtoan.Clear();
            txtcongtientong.Clear();
            txtcongphantramtong.Clear();
            btnthanhtoan.Enabled = true;
            btnthem.Enabled = true;
            btnxoa.Enabled = true;
            cbbMaNhanVien.Enabled = true;
            cbbSDTKH.Enabled = true;
            DataTable DT = (DataTable)dgvHoaDon.DataSource;
            if (DT != null)
                DT.Clear();

            dgvHoaDon.Refresh();
            dgvHoaDon.Enabled = true;
        }

        public static string CreateKey(string tiento)
        {
            string key = tiento;
            string[] partsDay;
            partsDay = DateTime.Now.ToShortDateString().Split('/');
            //Ví dụ 07/08/2009
            string d = String.Format("{0}{1}{2}", partsDay[0], partsDay[1], partsDay[2]);
            key = key + d;
            string[] partsTime;
            partsTime = DateTime.Now.ToLongTimeString().Split(':');
            //Ví dụ 7:08:03 PM hoặc 7:08:03 AM
            if (partsTime[2].Substring(3, 2) == "PM")
                partsTime[0] = DAO_Bill.ConvertTimeTo24(partsTime[0]);
            if (partsTime[2].Substring(3, 2) == "AM")
                if (partsTime[0].Length == 1)
                    partsTime[0] = "0" + partsTime[0];
            //Xóa ký tự trắng và PM hoặc AM
            partsTime[2] = partsTime[2].Remove(2, 3);
            string t;
            t = String.Format("_{0}{1}{2}", partsTime[0], partsTime[1], partsTime[2]);
            key = key + t;
            return key;
        }
        private void btnthanhtoan_Click(object sender, EventArgs e)
        {
            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook; //Trong 1 chương trình Excel có nhiều Workbook
            COMExcel.Worksheet exSheet; //Trong 1 Workbook có nhiều Worksheet
            COMExcel.Range exRange;
            string sql;
            int hang = 0, cot = 0;
            DataTable tblThongtinHD, tblThongtinHang;
            exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
            exSheet = exBook.Worksheets[1];
            // Định dạng chung
            exRange = exSheet.Cells[1, 1];
            exRange.Range["A1:Z300"].Font.Name = "Times new roman"; //Font chữ
            exRange.Range["A1:B3"].Font.Size = 10;
            exRange.Range["A1:B3"].Font.Bold = true;
            exRange.Range["A1:B3"].Font.ColorIndex = 5; //Màu xanh da trời
            exRange.Range["A1:A1"].ColumnWidth = 7;
            exRange.Range["B1:B1"].ColumnWidth = 15;
            exRange.Range["A1:B1"].MergeCells = true;
            exRange.Range["A1:B1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A1:B1"].Value = "THE MR.SIMPLE SYTLE.";
            exRange.Range["A2:B2"].MergeCells = true;
            exRange.Range["A2:B2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:B2"].Value = "27 - LÝ TỰ TRONG - QUẬN 1 - TPHCM";
            exRange.Range["A3:B3"].MergeCells = true;
            exRange.Range["A3:B3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A3:B3"].Value = "Điện thoại: (+84)987644753";
            exRange.Range["C2:E2"].Font.Size = 16;
            exRange.Range["C2:E2"].Font.Bold = true;
            exRange.Range["C2:E2"].Font.ColorIndex = 3; //Màu đỏ
            exRange.Range["C2:E2"].MergeCells = true;
            exRange.Range["C2:E2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C2:E2"].Value = "HÓA ĐƠN BÁN";
            // Biểu diễn thông tin chung của hóa đơn bán
            sql = "SELECT a.idHoadon, a.NgayBan, a.TongTien, b.TenKhach, b.DiaChi, b.DienThoai, c.TenNV FROM tblHoadon AS a, tblKhachHang AS b, tblNhanVien AS c WHERE a.idHoaDon = N'" + txtMaHoaDon.Text + "' AND a.idKhachHang = b.idKhachHang AND a.idNhanVien = c.idNhanVien";
            tblThongtinHD = DAO_Bill.GetDataToTable(sql);
            exRange.Range["B6:C9"].Font.Size = 12;
            exRange.Range["B6:B6"].Value = "Mã hóa đơn:";
            exRange.Range["C6:E6"].MergeCells = true;
            exRange.Range["C6:E6"].Value = tblThongtinHD.Rows[0][1].ToString();
            exRange.Range["B7:B7"].Value = "Khách hàng:";
            exRange.Range["C7:E7"].MergeCells = true;
            exRange.Range["C7:E7"].Value = tblThongtinHD.Rows[0][3].ToString();
            exRange.Range["B8:B8"].Value = "Địa chỉ:";
            exRange.Range["C8:E8"].MergeCells = true;
            exRange.Range["C8:E8"].Value = tblThongtinHD.Rows[0][4].ToString();
            exRange.Range["B9:B9"].Value = "Điện thoại:";
            exRange.Range["C9:E9"].MergeCells = true;
            exRange.Range["C9:E9"].Value = tblThongtinHD.Rows[0][5].ToString();
            //Lấy thông tin các mặt hàng
            sql = "SELECT b.Ten, a.SoLuong, b.DonGiaBan, a.GiamGia, a.ThanhTien " +
                  "FROM tblCT_HoaDon AS a , tblCT_Hang AS b WHERE a.idHoaDon = N'" +
                  txtMaHoaDon.Text + "' AND a.idCTHang = b.idCTHang";
            tblThongtinHang = DAO_Bill.GetDataToTable(sql);
            //Tạo dòng tiêu đề bảng
            exRange.Range["A11:F11"].Font.Bold = true;
            exRange.Range["A11:F11"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C11:F11"].ColumnWidth = 12;
            exRange.Range["A11:A11"].Value = "STT";
            exRange.Range["B11:B11"].Value = "Tên hàng";
            exRange.Range["C11:C11"].Value = "Số lượng";
            exRange.Range["D11:D11"].Value = "Đơn giá";
            exRange.Range["E11:E11"].Value = "Giảm giá";
            exRange.Range["F11:F11"].Value = "Thành tiền";
            for (hang = 0; hang < tblThongtinHang.Rows.Count; hang++)
            {
                //Điền số thứ tự vào cột 1 từ dòng 12
                exSheet.Cells[1][hang + 12] = hang + 1;
                for (cot = 0; cot < tblThongtinHang.Columns.Count; cot++)
                //Điền thông tin hàng từ cột thứ 2, dòng 12
                {
                    exSheet.Cells[cot + 2][hang + 12] = tblThongtinHang.Rows[hang][cot].ToString();
                    if (cot == 3) exSheet.Cells[cot + 2][hang + 12] = tblThongtinHang.Rows[hang][cot].ToString() + "%";
                }
            }
            exRange = exSheet.Cells[cot][hang + 14];
            exRange.Font.Bold = true;
            exRange.Value2 = "Tổng tiền:";
            exRange = exSheet.Cells[cot + 1][hang + 14];
            exRange.Font.Bold = true;
            exRange.Value2 = tblThongtinHD.Rows[0][2].ToString();
            exRange = exSheet.Cells[1][hang + 15]; //Ô A1 
            exRange.Range["A1:F1"].MergeCells = true;
            exRange.Range["A1:F1"].Font.Bold = true;
            exRange.Range["A1:F1"].Font.Italic = true;
            exRange.Range["A1:F1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignRight;
            exRange.Range["A1:F1"].Value = "Bằng chữ: " + DAO_Bill.ChuyenSoSangChu(double.Parse(tblThongtinHD.Rows[0][2].ToString()));
            exRange = exSheet.Cells[4][hang + 17]; //Ô A1 
            exRange.Range["A1:C1"].MergeCells = true;
            exRange.Range["A1:C1"].Font.Italic = true;
            exRange.Range["A1:C1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            DateTime d = Convert.ToDateTime(tblThongtinHD.Rows[0][1]);
            exRange.Range["A1:C1"].Value = "TPHCM, ngày " + d.Day + " tháng " + d.Month + " năm " + d.Year;
            exRange.Range["A2:C2"].MergeCells = true;
            exRange.Range["A2:C2"].Font.Italic = true;
            exRange.Range["A2:C2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:C2"].Value = "Nhân viên bán hàng";
            exRange.Range["A6:C6"].MergeCells = true;
            exRange.Range["A6:C6"].Font.Italic = true;
            exRange.Range["A6:C6"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A6:C6"].Value = tblThongtinHD.Rows[0][6];
            exSheet.Name = "Hóa đơn nhập";
            exApp.Visible = true;


         




        }
        //void PrintMyExcelFile()
        //{
        //   // Excel.Application excelApp = new Excel.Application();
        //    COMExcel.Application excelApp = new COMExcel.Application();
        //    // Open the Workbook:
        //    OpenFileDialog open = new OpenFileDialog();
        //    if (open.ShowDialog() == DialogResult.OK)
        //    {
        //        //  txtFile = open.FileName;
        //        btnPrint.Text = open.FileName;
        //    }
        //    COMExcel.Workbook wb = excelApp.Workbooks.Open(btnPrint.Text
        //      ,
        //        Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
        //        Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
        //        Type.Missing, Type.Missing, Type.Missing, Type.Missing);

        //    // Get the first worksheet.
        //    // (Excel uses base 1 indexing, not base 0.)
        //    COMExcel.Worksheet ws = (COMExcel.Worksheet)wb.Worksheets[1];

        //    // Print out 1 copy to the default printer:
        //    ws.PrintOut(
        //        Type.Missing, Type.Missing, Type.Missing, Type.Missing,
        //        Type.Missing, Type.Missing, Type.Missing, Type.Missing);

        //    // Cleanup:
        //    GC.Collect();
        //    GC.WaitForPendingFinalizers();

        //    Marshal.FinalReleaseComObject(ws);

        //    wb.Close(false, Type.Missing, Type.Missing);
        //    Marshal.FinalReleaseComObject(wb);

        //    excelApp.Quit();
        //    Marshal.FinalReleaseComObject(excelApp);
        //}
        private void HDThuong(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //ListBox listBoxHD1 = new ListBox();
            //foreach (DataGridViewRow item in dgvHoaDon.Rows)
            //{
            //    listBoxHD1.Items.Add(item.Cells[3].Value.ToString() + '/' + item.Cells[5].Value.ToString() + '/' + item.Cells[7].Value.ToString());
            //}
            ////--------------------------------------------//

            //int total = 0;
            ////float cash = float.Parse(txtTienKhachDua.Text);
            //float change = 0f;

            ////this prints the reciept
            //string _tenShop = "Mr.Simple";
            //string _diaChi = "26 - Lý Tự Trọng - Quận 1 - TP.HCM";
            //string _SDT = "0987644753";
            //string _LoiChao = "Xin cảm ơn!";
            //Graphics graphic = e.Graphics;
            //Font font = new Font("Courier New", 12); //must use a mono spaced font as the spaces need to line up
            //float fontHeight = font.GetHeight();

            //int startX = 10;
            //int startY = 10;
            //int offset = 40;

            //graphic.DrawString(_tenShop, new Font("Courier New", 18), new SolidBrush(Color.Black), startX, startY);

            //graphic.DrawString(_diaChi, font, new SolidBrush(Color.Black), startX, 40);

            //graphic.DrawString(_SDT, font, new SolidBrush(Color.Black), startX, 60);
            //offset = offset + 50;
            //string top = "Sản phẩm".PadRight(21) + "SL".PadRight(10) + "Giá".PadRight(10);
            //graphic.DrawString(top, font, new SolidBrush(Color.Black), startX, startY + offset);
            //offset = offset + (int)fontHeight; //make the spacing consistent
            //graphic.DrawString("------------------------------------", font, new SolidBrush(Color.Black), startX, startY + offset);
            //offset = offset + (int)fontHeight + 5; //make the spacing consistent


            //float totalprice = 0f;

            //foreach (string item in listBoxHD1.Items)
            //{
            //    var items = item.Split('/');
            //    string Ltensp = items[0].ToString();
            //    int Lsoluongsp = int.Parse(items[1].ToString());
            //    float Lgiasp = float.Parse(items[2].ToString());
            //    //    MessageBox.Show(productPrice.ToString());
            //    //create the string to print on the reciept
            //    //  string productDescription = item;
            //    //string productTotal = item.Substring(item.Length - 6, 6);
            //    float productTotal = float.Parse(dgvHoaDon.Rows[0].Cells[8].Value.ToString());
            //    //   float productPrice = float.Parse(item.Substring(item.Length - 5, 5));

            //    //totalprice += productPrice;
            //    totalprice = productTotal;

            //    string ten = Ltensp;
            //    string dongia = Lgiasp.ToString();
            //    string slsp = Lsoluongsp.ToString();
            //    graphic.DrawString(ten, font, new SolidBrush(Color.Black), startX, startY + offset);
            //    graphic.DrawString(slsp, font, new SolidBrush(Color.Black), 230, startY + offset);
            //    graphic.DrawString(dongia, font, new SolidBrush(Color.Black), 320, startY + offset);
            //    offset = offset + (int)fontHeight + 5; //make the spacing consistent
            //}
            ////  change = float.Parse(txtTienThoiLai.Text);
            ////when we have drawn all of the items add the total
            //offset = offset + 20; //make some room so that the total stands out.

            //graphic.DrawString("Tổng cộng ".PadRight(30) + totalprice.ToString("###,###"), new Font("Courier New", 12, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offset);

            //offset = offset + 30; //make some room so that the total stands out.
            ////graphic.DrawString("Tiền khách đưa ".PadRight(30) + cash.ToString("###,###"), font, new SolidBrush(Color.Black), startX, startY + offset);
            ////offset = offset + 15;
            ////graphic.DrawString("Tiền thối lại ".PadRight(30) + change.ToString("###,###"), font, new SolidBrush(Color.Black), startX, startY + offset);
            ////offset = offset + 30; //make some room so that the total stands out.
            //graphic.DrawString(_LoiChao, font, new SolidBrush(Color.Black), startX, startY + offset);
            //offset = offset + 15;
        }
        private void fBill_Load(object sender, EventArgs e)
        {
            string sql;
            try
            {

                // tạo ngẫu nhiên khóa chính
                CreateKey();

                // lấy dữ liệu nhân viên
                DataTable nv = DAO_Bill.GetData("SELECT idNhanVien, TenNV FROM tblNhanVien WHERE USERS!= 'ADMIN'");
                cbbMaNhanVien.DataSource = nv;
                cbbMaNhanVien.DisplayMember = "TenNV";
                cbbMaNhanVien.ValueMember = "idNhanVien";

                //lấy dữ liệu hàng
                DataTable hang = DAO_Bill.GetData("SELECT ct.idCTHang, ct.ten, s.Ten,ct.kieudang,cl.tenChatLieu,ct.ghichu,ct.anh,ct.Soluong,ct.DonGiaNhap,ct.DonGiaBan FROM dbo.tblChatLieu cl JOIN dbo.tblCT_Hang ct ON ct.idChatLieu = cl.idChatLieu JOIN dbo.tblSize s ON s.idSize = ct.idSize WHERE (MONTH(GETDATE()) = MONTH(ct.NgayNhap))");
                cbbMaSP.DataSource = hang;
                cbbMaSP.DisplayMember = "idCTHang";
                cbbMaSP.ValueMember = "idCTHang";

                // lấy dữ liệu Khách hàng
                LoadDataKh();

                LoadDataGridView();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            clearsp();




        }
        private void LoadDataKh()
        {
            DataTable kh = DAO_Bill.GetData("SELECT idKhachHang, dienthoai FROM tblKhachHang");
            cbbSDTKH.DataSource = kh;
            cbbSDTKH.DisplayMember = "dienthoai";
            cbbSDTKH.ValueMember = "idKhachHang";

        }

        private void LoadInfoHoaDon()
        {
            string str;
            str = "SELECT NgayBan FROM tblHoaDon WHERE idHoaDon = N'" + txtMaHoaDon.Text + "'";
            dtpNgayBan.Text = DAO_Bill.ConvertDateTime(DAO_Bill.SimpleRead(str));
            str = "SELECT nv.TenNV FROM tblHoaDon hd JOIN dbo.tblNhanVien nv ON nv.iDNhanVien = hd.iDNhanVien WHERE idHoaDon = '" + txtMaHoaDon.Text + "'";
            cbbMaNhanVien.Text = DAO_Bill.SimpleRead(str);
            str = " SELECT kh.DienThoai FROM dbo.tblHoaDon hd JOIN dbo.tblKhachHang kh ON kh.iDKhachHang = hd.iDKhachHang WHERE hd.idHoaDon = '" + txtMaHoaDon.Text + "'";
            cbbSDTKH.Text = DAO_Bill.SimpleRead(str);
            str = "SELECT TongTien FROM tblHoaDon WHERE idHoaDon = N'" + txtMaHoaDon.Text + "'";
            txtTongTien.Text = DAO_Bill.SimpleRead(str);
            txtthanhtoan.Text = DAO_Bill.SimpleRead(str);
            lblBangChu.Text = "Bằng chữ: " + DAO_Bill.ChuyenSoSangChu(double.Parse(txtTongTien.Text));
        }
        private void CreateKey()
        {
            txtMaHoaDon.Text = DAO_Bill.CreateKey("HDB");
        }




        private void btnthem_Click(object sender, EventArgs e)
        {

            string sql;
            double sl, SLcon, tong, Tongmoi;


            sql = "SELECT idHoaDon FROM tblHoaDon WHERE idHoaDon=N'" + txtMaHoaDon.Text + "'";
            if (!DAO_Bill.CheckKey(sql))
            {
                // Mã hóa đơn chưa có, tiến hành lưu các thông tin chung
                // Mã HDBan được sinh tự động do đó không có trường hợp trùng khóa
                if (dtpNgayBan.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập ngày bán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dtpNgayBan.Focus();
                    return;
                }
                if (cbbMaNhanVien.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbbMaNhanVien.Focus();
                    return;
                }
                if (cbbSDTKH.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbbSDTKH.Focus();
                    return;
                }
                try
                {
                    sql = "INSERT INTO tblHoaDon(idHoadon, NgayBan, TongTien,idNhanVien, idKhachHang) VALUES (N'" + txtMaHoaDon.Text.Trim() + "','" +
                     dtpNgayBan.Value.ToString() + "',N'" + txtTongTien.Text + "',N'" +
                     cbbMaNhanVien.SelectedValue + "','" + cbbSDTKH.SelectedValue + "')";
                    DataProvider.Instance.ExecuteQuery(sql);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
                cbbMaNhanVien.Enabled = false;
                cbbSDTKH.Enabled = false;
            }



            // Lưu thông tin của các mặt hàng
            if (cbbMaSP.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbbMaSP.Focus();
                return;
            }
            if ((txtsoluongsp.Text.Trim().Length == 0) || (txtsoluongsp.Text == "0"))
            {
                MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtsoluongsp.Text = "";
                txtsoluongsp.Focus();
                return;
            }
            if (txtgiamphantramsp.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập giảm giá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtgiamphantramsp.Focus();
                return;
            }
            sql = "SELECT idCTHang FROM tblCT_HoaDon WHERE idCTHang=N'" + cbbMaSP.SelectedValue + "' AND idHoaDon = N'" + txtMaHoaDon.Text.Trim() + "'";
            if (DAO_Bill.CheckKey(sql))
            {
                MessageBox.Show("Mã hàng này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearsp();
                cbbMaSP.Focus();
                return;
            }
            // Kiểm tra xem số lượng hàng trong kho còn đủ để cung cấp không?
            sl = Convert.ToDouble(DAO_Bill.SimpleRead("SELECT SoLuong FROM tblCT_Hang WHERE idCTHang = N'" + cbbMaSP.SelectedValue + "'"));
            if (Convert.ToDouble(txtsoluongsp.Text) > sl)
            {
                MessageBox.Show("Số lượng mặt hàng này chỉ còn " + sl, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtsoluongsp.Text = "";
                txtsoluongsp.Focus();
                return;
            }
            try
            {
                sql = "INSERT INTO tblCT_HoaDon(SoLuong,DonGia,GiamGia,ThanhTien, idCTHang,idHoaDon) VALUES( " + txtsoluongsp.Text + "," + txtDonGiaSP.Text + "," + txtgiamphantramsp.Text + "," + txtThanhTien.Text + ", N'" + cbbMaSP.SelectedValue + "',N'" + txtMaHoaDon.Text.Trim() + "')";
                DataProvider.Instance.ExecuteQuery(sql);
                LoadDataGridView();
                // Cập nhật lại số lượng của mặt hàng vào bảng tblHang
                SLcon = sl - Convert.ToDouble(txtsoluongsp.Text);
                sql = "UPDATE tblCT_Hang SET SoLuong =" + SLcon + " WHERE idCTHang= N'" + cbbMaSP.SelectedValue + "'";
                DataProvider.Instance.ExecuteQuery(sql);
                // Cập nhật lại tổng tiền cho hóa đơn bán
                tong = Convert.ToDouble(DAO_Bill.SimpleRead("SELECT TongTien FROM tblHoaDon WHERE idHoaDon = N'" + txtMaHoaDon.Text + "'"));
                Tongmoi = tong + Convert.ToDouble(txtThanhTien.Text);
                sql = "UPDATE tblHoadon SET TongTien =" + Tongmoi + " WHERE idHoaDon = N'" + txtMaHoaDon.Text + "'";
                DataProvider.Instance.ExecuteQuery(sql);
                txtTongTien.Text = Tongmoi.ToString();
                txtthanhtoan.Text = Tongmoi.ToString();
                lblBangChu.Text = "Bằng chữ: " + DAO_Bill.ChuyenSoSangChu(Tongmoi);
                clearsp();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }




            //btnXoa.Enabled = true;
            //btnThem.Enabled = true;
            //btnInHoaDon.Enabled = true;


            //bool found = false;
            //if (dgvHoaDon.Rows.Count > 0)
            //{
            //    foreach (DataGridViewRow row in dgvHoaDon.Rows)
            //    {
            //        if (Convert.ToString(row.Cells[0].Value) == cbbMaSP.Text)
            //        {
            //            //neu them san pham giong nhau se cộng dồn số lượng và tiền vào ô
            //            row.Cells[2].Value = (int.Parse(txtsoluongsp.Text) + Convert.ToInt16(row.Cells[2].Value.ToString()));
            //            row.Cells[4].Value = (double.Parse(txtThanhTien.Text) + Convert.ToDouble(row.Cells[4].Value.ToString()));
            //            found = true;
            //            /////////////////////
            //        }
            //    }
            //    if (!found)
            //    {
            //        dgvHoaDon.Rows.Add(cbbMaSP.Text, txtTenSP.Text, txtsoluongsp.Text, txtDonGiaSP.Text, txtThanhTien.Text, txtChatLieu.Text, txtSize.Text, txtgiamphantramsp.Text);
            //    }
            //}
            //else
            //{
            //    dgvHoaDon.Rows.Add(cbbMaSP.Text, txtTenSP.Text, txtsoluongsp.Text, txtDonGiaSP.Text, txtThanhTien.Text, txtChatLieu.Text, txtSize.Text, txtgiamphantramsp.Text);
            //}

            //double sum = 0;
            //for (int i = 0; i < dgvHoaDon.Rows.Count; ++i)
            //{
            //    sum += Convert.ToDouble(dgvHoaDon.Rows[i].Cells[4].Value);
            //}
            //txtTongTien.Text = sum.ToString("###,###");
            ////------------------- update sql -----------------//
            //string sql = "update tblCT_Hang set soluong=soluong - '" + txtsoluongsp.Text + "' where idCTHang ='" + cbbMaSP.Text + "' ";
            //DataProvider.Instance.ExecuteQuery(sql);

            //clearsp();
        }

        private void cbbTenSp_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (cbbMaSP.Text == "")
            {
                txtTenSP.Text = "";
                txtDonGiaSP.Text = "";
                txtsoluongsp.Text = "";
            }
            // Khi chọn MÃ hàng tự động hiện ra
            try
            {
                str = "SELECT Ten FROM tblCT_Hang WHERE idCTHang =N'" + cbbMaSP.SelectedValue.ToString() + "'";
                txtTenSP.Text = DAO_Bill.SimpleRead(str);
                str = "SELECT DonGiaBan FROM tblCT_Hang WHERE idCTHang =N'" + cbbMaSP.SelectedValue.ToString() + "'";
                txtDonGiaSP.Text = DAO_Bill.SimpleRead(str);

                //str = "select soluong from tblCT_Hang where (tensp= N'" + cbbMaSP.Text + "') ";
                //DAO_Bill.CheckSL(str,checkslsp);

                str = "SELECT SoLuong FROM tblCT_Hang WHERE idCTHang = N'" + cbbMaSP.SelectedValue.ToString() + "'";
                txtsoluongsp.Text = DAO_Bill.SimpleRead(str);


                str = "SELECT s.Ten FROM tblCT_Hang ct JOIN dbo.tblSize s ON s.idSize = ct.idSize WHERE idCTHang = N'" + cbbMaSP.SelectedValue.ToString() + "'";
                txtSize.Text = DAO_Bill.SimpleRead(str);
                str = "SELECT  cl.tenChatLieu FROM dbo.tblChatLieu cl JOIN dbo.tblCT_Hang ct ON ct.idChatLieu = cl.idChatLieu WHERE ct.idCTHang = N'" + cbbMaSP.SelectedValue.ToString() + "'";
                txtchatlieu.Text = DAO_Bill.SimpleRead(str);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }


            //str = "SELECT idChatLieu FROM tblCT_Hang WHERE idCTHang = N'" + cbbChatLieu.SelectedValue.ToString() + "'";
            //cbbChatLieu.Text = DAO_Bill.SimpleRead(str);
            //str = "SELECT idSize FROM tblCT_Hang WHERE idCTHang = N'" + cbbSize.SelectedValue.ToString() + "'";
            //cbbSize.Text = DAO_Bill.SimpleRead(str);

            // thành tiền
            double giamgiaTextbox = 0;
            double slsp = 0;
            double dongiasp = 0;
            double thanhtiensp;
            double thanhtiensp2;
            if (txtsoluongsp.Text != "")
            {
                slsp = double.Parse(txtsoluongsp.Text);
            }
            if (txtDonGiaSP.Text != "")
            {
                dongiasp = double.Parse(txtDonGiaSP.Text);
            }

            thanhtiensp = slsp * dongiasp;
            //tien giam gia cua san pham
            if (txtgiamphantramsp.Text != "")
            {
                giamgiaTextbox = double.Parse(txtgiamphantramsp.Text);
            }

            double giamgiasp = (giamgiaTextbox * thanhtiensp) / 100;
            //tien san pham = (so luong * don gia ) - giam gia
            thanhtiensp2 = thanhtiensp - giamgiasp;

            txtThanhTien.Text = thanhtiensp2.ToString("###,###");
        }


        double checkslsp;//kiem tra so luong san pham nao do trong ton kho

        private void txtsoluongsp_TextChanged_1(object sender, EventArgs e)
        {
            #region
            //string str = "SELECT SoLuong FROM tblCT_Hang WHERE idCTHang = N'" + cbbMaSP.SelectedValue.ToString() + "'";
            //checkslsp = Convert.ToDouble(DAO_Bill.SimpleRead(str));
            //if (string.IsNullOrWhiteSpace(txtsoluongsp.Text))
            //{

            //}
            //else if (string.IsNullOrWhiteSpace(txtDonGiaSP.Text))
            //{

            //}
            //else if (string.IsNullOrWhiteSpace(txtgiamphantramsp.Text))
            //{

            //}
            //else
            //{
            //    int slspHienTai = Convert.ToInt32(txtsoluongsp.Text);
            //    if (slspHienTai > checkslsp)
            //    {
            //        txtsoluongsp.Text = checkslsp.ToString();
            //    }
            //    else
            //    {

            //double giamgiaTextbox;
            //double slsp;
            //double dongiasp;
            //double thanhtiensp;
            //double thanhtiensp2;


            //dongiasp = double.Parse(txtDonGiaSP.Text);
            //thanhtiensp = slsp * dongiasp;

            ////tien giam gia cua san pham
            //giamgiaTextbox = double.Parse(txtgiamphantramsp.Text);
            //double giamgiasp = (giamgiaTextbox * thanhtiensp) / 100;
            ////tien san pham = (so luong * don gia ) - giam gia
            //thanhtiensp2 = thanhtiensp - giamgiasp;


            //txttiensp.Text = thanhtiensp2.ToString("###,###");
            #endregion

            double tt, sl, dg, gg;
            if (txtsoluongsp.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txtsoluongsp.Text);
            if (txtgiamphantramsp.Text == "")
                gg = 0;
            else
                gg = Convert.ToDouble(txtgiamphantramsp.Text);
            if (txtDonGiaSP.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(txtDonGiaSP.Text);
            tt = sl * dg - sl * dg * gg / 100;
            txtThanhTien.Text = tt.ToString();
            //    }
        }
        private void txtsoluongsp_TextChanged(object sender, EventArgs e)
        {



            //}

        }

        private void btnhuyHD_Click(object sender, EventArgs e)
        {
            huyhd();
            CreateKey();
        }



        private void cbbSDT_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtTenKH_TextChanged(object sender, EventArgs e)
        {



        }

        private void cbbSDTKH_TextChanged_1(object sender, EventArgs e)
        {
            string str;
            if (cbbSDTKH.Text == "")
            {
                txtTenKH.Text = "";
            }
            //Khi chọn SDT Tên khách tự động hiện ra
            try
            {
                str = "SELECT TenKhach FROM tblKhachHang WHERE idKhachHang =N'" + cbbSDTKH.SelectedValue.ToString() + "'";
                txtTenKH.Text = DAO_Bill.SimpleRead(str);



                // Khi chọn sdT ten khach  tự động hiện ra
                str = "SELECT idKhachHang FROM tblKhachHang WHERE idKhachHang =N'" + cbbSDTKH.SelectedValue.ToString() + "'";
                txtMaKhach.Text = DAO_Bill.SimpleRead(str);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }




            //// Khi chọn sdT ma khach  tự động hiện ra
            //str = "SELECT idKhachHang FROM tblKhachHang WHERE DienThoai =N'" + cbbSDTKH.SelectedValue.ToString() + "'";
            //txtMaKhach.Text = DAO_Bill.SimpleRead(str);

        }



        private void txtgiamphantramsp_TextChanged(object sender, EventArgs e)
        {
            double tt, sl, dg, gg;
            if (txtsoluongsp.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txtsoluongsp.Text);
            if (txtgiamphantramsp.Text == "")
                gg = 0;
            else
                gg = Convert.ToDouble(txtgiamphantramsp.Text);
            if (txtDonGiaSP.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(txtDonGiaSP.Text);
            tt = sl * dg - sl * dg * gg / 100;
            txtThanhTien.Text = tt.ToString();
        }


        string maspedit;
        int slspedit;
        private void btnsua_Click(object sender, EventArgs e)
        {
            //string sql; //Lưu câu lệnh sql
            //if (tblCTHDB.Rows.Count == 0)
            //{
            //    MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return;
            //}
            //if (cbbMaSP.Text == "") //nếu chưa chọn bản ghi nào
            //{
            //    MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return;
            //}
            //if (txtTenSP.Text.Trim().Length == 0) //nếu chưa nhập tên chất liệu
            //{
            //    MessageBox.Show("Bạn chưa nhập tên chất liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return;
            //}
            //sql = "UPDATE tblChatLieu SET TenChatLieu=N'" +
            //    txtTenSP.Text.ToString() +
            //    "' WHERE MaChatLieu=N'" + txtMaChatLieu.Text + "'";
            //Class.Functions.RunSQL(sql);
            //LoadDataGridView();
            //ResetValue();

            //btnBoQua.Enabled = false;
        }



        private void dgvHoaDon_DoubleClick(object sender, EventArgs e)
        {
            string MaHangxoa, sql;
            Double ThanhTienxoa, SoLuongxoa, sl, slcon, tong, tongmoi;
            if (tblCTHDB.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                if ((MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    //Xóa hàng và cập nhật lại số lượng hàng 
                    MaHangxoa = dgvHoaDon.CurrentRow.Cells["idCTHang"].Value.ToString();
                    SoLuongxoa = Convert.ToDouble(dgvHoaDon.CurrentRow.Cells["SoLuong"].Value.ToString());
                    ThanhTienxoa = Convert.ToDouble(dgvHoaDon.CurrentRow.Cells["ThanhTien"].Value.ToString());
                    sql = "DELETE tblCT_Hoadon WHERE idHoaDon=N'" + txtMaHoaDon.Text + "' AND idCTHang = N'" + MaHangxoa + "'";
                    DataProvider.Instance.ExecuteQuery(sql);
                    LoadDataGridView();
                    // Cập nhật lại số lượng cho các mặt hàng
                    sl = Convert.ToDouble(DAO_Bill.SimpleRead("SELECT SoLuong FROM tblCT_Hang WHERE idCTHang = N'" + MaHangxoa + "'"));
                    slcon = sl + SoLuongxoa;
                    sql = "UPDATE tblCT_Hang SET SoLuong =" + slcon + " WHERE idCTHang= N'" + MaHangxoa + "'";
                    DataProvider.Instance.ExecuteQuery(sql);
                    // Cập nhật lại tổng tiền cho hóa đơn bán
                    tong = Convert.ToDouble(DAO_Bill.SimpleRead("SELECT TongTien FROM tblHoadon WHERE idhoadon = N'" + txtMaHoaDon.Text + "'"));
                    tongmoi = tong - ThanhTienxoa;
                    sql = "UPDATE tblHoadon SET TongTien =" + tongmoi + " WHERE idhoadon = N'" + txtMaHoaDon.Text + "'";
                    DataProvider.Instance.ExecuteQuery(sql);
                    txtTongTien.Text = tongmoi.ToString();
                    txtthanhtoan.Text = tongmoi.ToString();
                    lblBangChu.Text = "Bằng chữ: " + DAO_Bill.ChuyenSoSangChu(tongmoi);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void cbbMaHoaDon_DropDownClosed(object sender, EventArgs e)
        {

        }

        private void cbbMaHoaDon_DropDown(object sender, EventArgs e)
        {
            DataTable kh = DAO_Bill.GetData("SELECT idHoaDon FROM tblHoaDon");
            cbbMaHoaDon.DataSource = kh;
            cbbMaHoaDon.DisplayMember = "idHoaDon";
            cbbMaHoaDon.ValueMember = "idHoaDon";

            cbbMaHoaDon.SelectedIndex = -1;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cbbMaHoaDon.Text == "")
            {
                MessageBox.Show("Bạn phải chọn một mã hóa đơn để tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbbMaHoaDon.Focus();
                return;
            }
            txtMaHoaDon.Text = cbbMaHoaDon.Text;
            LoadInfoHoaDon();
            LoadDataGridView();
            //btnxoa.Enabled = false;
            btnthem.Enabled = false;
            dgvHoaDon.Enabled = false;
            //btnthanhtoan.Enabled = false;
            cbbMaHoaDon.SelectedIndex = -1;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            double sl, slcon, slxoa;
            try
            {

                if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string sql = "SELECT idCTHang,SoLuong FROM tblCT_HoaDon WHERE idHoadon = N'" + txtMaHoaDon.Text + "'";
                    DataTable tblHang = DAO_Bill.GetDataToTable(sql);
                    for (int hang = 0; hang <= tblHang.Rows.Count - 1; hang++)
                    {
                        // Cập nhật lại số lượng cho các mặt hàng
                        sl = Convert.ToDouble(DAO_Bill.SimpleRead("SELECT SoLuong FROM tblCT_Hang WHERE idCTHang = N'" + tblHang.Rows[hang][0].ToString() + "'"));
                        slxoa = Convert.ToDouble(tblHang.Rows[hang][1].ToString());
                        slcon = sl + slxoa;
                        sql = "UPDATE tblCT_Hang SET SoLuong =" + slcon + " WHERE idCTHang= N'" + tblHang.Rows[hang][0].ToString() + "'";
                        DataProvider.Instance.ExecuteQuery(sql);
                    }

                    //Xóa chi tiết hóa đơn
                    sql = "DELETE tblCT_HoaDon WHERE idHoadon=N'" + txtMaHoaDon.Text + "'";
                    DataProvider.Instance.ExecuteQuery(sql);

                    //Xóa hóa đơn
                    sql = "DELETE tblHoaDon WHERE idHoadon=N'" + txtMaHoaDon.Text + "'";
                    DataProvider.Instance.ExecuteQuery(sql);
                    clearsp();
                    LoadDataGridView();
                    //btnxoa.Enabled = false;
                    btnthanhtoan.Enabled = false;
                    txtTongTien.Text = "";
                    lblBangChu.Text = "";
                    txtthanhtoan.Text = "";
                }
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            huyhd();
            CreateKey();
        }

        private void dtpNgayBan_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnThemKhach_Click(object sender, EventArgs e)
        {
            fAddKH f = new fAddKH();
            //  this.Hide();
           // this.Dispose();
            f.ShowDialog();
        }

        private void cbbMaNhanVien_DropDown(object sender, EventArgs e)
        {
            this.cbbMaNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //PrintMyExcelFile();
        }

        private void cbbSDTKH_TabStopChanged(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {
         
        }

        private void cbbSDTKH_Click(object sender, EventArgs e)
        {
            LoadDataKh();
        }
    }
}
